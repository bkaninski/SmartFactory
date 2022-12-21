using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Constans;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Production;
using SmartFactory.Extensions;

namespace SmartFactory.Controllers
{
    [Authorize]
    public class ProductionController : Controller
    {
        private readonly IProductionService productionService;
        private readonly IShiftService shiftService;
        private readonly IEmployeeService employeeService;

        public ProductionController(
            IProductionService _productionService,
            IShiftService _shiftService,
            IEmployeeService _employeeService)
        {
            productionService = _productionService;
            shiftService = _shiftService;
           employeeService = _employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> LastWeekProduction()
        {
            var model = await productionService.LastWeekProduction();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CurrentShift()
        {

            int? shiftInWork = await shiftService.ShiftInWorkId();
            if (shiftInWork == 0)
            {
                TempData[MessageConstant.ErrorMessage] = "Няма смяна";

                return RedirectToAction(nameof(LastWeekProduction));
            }

            var stockBeforePack = await productionService.StockBeforePack();
            var model =await productionService.View(shiftInWork.Value);
            model.StockBeforePacking = stockBeforePack;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CurrentShift(ProductionViewModel model)
        {
            int? shiftInWork = await shiftService.ShiftInWorkId();

            if (shiftInWork == null )
            {
                TempData[MessageConstant.ErrorMessage]= "Няма смяна!";
                return RedirectToAction(nameof(LastWeekProduction));
            }

            if (User.IsInRole("Electrical"))
            {
                await productionService.Create(model);

                TempData[MessageConstant.SuccessMessage] = "Смяната е рапортувана";
                return RedirectToAction(nameof(LastWeekProduction));
            }
            else
            {
                TempData[MessageConstant.SuccessMessage] = "Нямате право да рапортувате смянатa, потърсете дежурния електротехник!";

                 return RedirectToAction(nameof(Index),"Home");
            }
           
        }


        [HttpGet]
        public async Task<IActionResult> AddProduction()
        {

            int? shiftInWork = await shiftService.ShiftInWorkId();
            if (shiftInWork == 0)
            {
                TempData[MessageConstant.ErrorMessage] = "Няма смяна";

                return RedirectToAction(nameof(LastWeekProduction));
            }

            var stockBeforePack = await productionService.StockBeforePack();
            var model = await productionService.View(shiftInWork.Value);
            model.StockBeforePacking = stockBeforePack;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduction(ProductionViewModel model)
        {
            int? shiftInWork = await shiftService.ShiftInWorkId();
            
            if (shiftInWork == null)
            {
                TempData[MessageConstant.ErrorMessage] = "Няма смяна!";
                return RedirectToAction(nameof(LastWeekProduction));
            }
            
            var shift = await shiftService.ShiftInWork((int)shiftInWork);

            var employeeId = await employeeService.GetEmployeeId(User.Id());

            if (employeeId==shift.OperatorPreparationId||employeeId==shift.OperatorPackagingId)
            {
               
                await productionService.AddProduction(model);

                TempData[MessageConstant.SuccessMessage] = "Продукцията е записана";
                return RedirectToAction(nameof(LastWeekProduction));
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = "Нямате право да запишете продукцията, потърсете дежурния оператор!";

                return RedirectToAction(nameof(Index), "Home");
            }

        }
    }
}
