using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Constans;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Production;

namespace SmartFactory.Controllers
{
    [Authorize]
    public class ProductionController : Controller
    {
        private readonly IProductionService productionService;
        private readonly IShiftService shiftService;

        public ProductionController(
            IProductionService _productionService,
            IShiftService _shiftService)
        {
            productionService = _productionService;
            shiftService = _shiftService;
        }

        public async Task<IActionResult> LastWeekProduction()
        {
            var model = await productionService.LastWeekProduction();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CurrentShift()
        {

            int? shiftInWork = await shiftService.ShiftInWork();
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
            int? shiftInWork = await shiftService.ShiftInWork();

            if (shiftInWork == null )
            {
                ModelState.AddModelError(nameof(model), "Няма смяна!");
                return RedirectToAction(nameof(LastWeekProduction));
            }

            
            await productionService.Create(model);

            TempData[MessageConstant.SuccessMessage] = "Смяната е рапортувана";
            return RedirectToAction(nameof(LastWeekProduction));
        }
    }
}
