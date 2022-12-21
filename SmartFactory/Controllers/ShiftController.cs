using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Constans;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Shift;
using SmartFactory.Core.Services;
using SmartFactory.Infrastructure.Data;

namespace SmartFactory.Controllers
{
    [Authorize]
    public class ShiftController : Controller
    {
        private readonly IShiftService shiftService;
        private readonly IEmployeeService employeeService;

        public ShiftController(
            IShiftService _shiftService,
            IEmployeeService _employeeService)
        {
            shiftService = _shiftService;
            employeeService = _employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Calendar()
        {
            int? month = null;
            var models = await shiftService.AllShifts(month);

       

            return View(models);
        }

        [HttpGet]
        public async Task<IActionResult> CalendarNext()
        {
            int month = 1;
            var models = await shiftService.AllShifts(month);



            return View(models);
        }
        [HttpGet]
        public async Task<IActionResult> CalendarPrevious()
        {
            int month = -1;

            var models = await shiftService.AllShifts(month);



            return View(models);
        }

        [Authorize(Roles = "factoryManager,Manager")]
        [HttpGet]
        public async Task<IActionResult> AddShift()
        {
            var model = new ShiftAddModel()
            {

                Electrician = await employeeService.AllElectrical(),
                OperatorPackaging = await employeeService.AllOperatorPack(),
                OperatorPreparation = await employeeService.AllOperatorPre()
            };


            return View(model);
        }

        [Authorize(Roles = "factoryManager,Manager")]
        [HttpPost]
        public async Task<IActionResult> AddShift(ShiftAddModel model)
        {
            if (model.Date < DateTime.Now)
            {
                ModelState.AddModelError("", "Не може да добавите смяна със задна дата!");
                TempData[MessageConstant.ErrorMessage] = "Не може да добавите смяна със задна дата!";
                return RedirectToAction(nameof(Calendar));
            }
            if (model.Date == DateTime.Now)
            {
                ModelState.AddModelError("", "Не може да добавите днешна смяна!");
                TempData[MessageConstant.ErrorMessage] = "Не може да добавите днешна смяна!";
                return RedirectToAction(nameof(Calendar));
            }

            if (await shiftService.ShiftExistByDateAndType(model.Date, model.TypeOfShift.ToString()))
            {
                ModelState.AddModelError("", "Вече има такава смяна");
                TempData[MessageConstant.ErrorMessage] = "Вече има такава смяна";
                return RedirectToAction(nameof(Calendar));
            }

            if ((await employeeService.Exists(model.ElectricianId)) == false || (await employeeService.Exists(model.OperatorPackagingId)) == false
                || (await employeeService.Exists(model.OperatorPreparationId)) == false)
            {
                ModelState.AddModelError(nameof(model.ElectricianId), "Невалиден служител");

            }
            if (await shiftService.InWorkToday(model.ElectricianId, model.Date))
            {
                ModelState.AddModelError("","Електротехника вече е на смяна в този ден!");
                TempData[MessageConstant.ErrorMessage] = "Електротехника вече е на смяна в този ден!";
            }
            if (await shiftService.InWorkToday(model.OperatorPackagingId, model.Date))
            {
                ModelState.AddModelError("", "Оператор пакетиране вече е на смяна в този ден!");
                TempData[MessageConstant.ErrorMessage] = "Оператор пакетиране вече е на смяна в този ден!";

            }
            if (await shiftService.InWorkToday(model.OperatorPreparationId, model.Date))
            {
                ModelState.AddModelError("", "Оператор подготовка вече е на смяна в този ден!");
                TempData[MessageConstant.ErrorMessage] = "Оператор подготовка вече е на смяна в този ден!";
            }

         
            if (!ModelState.IsValid)
            {
                model.Electrician = await employeeService.AllElectrical();
                model.OperatorPackaging = await employeeService.AllOperatorPack();
                model.OperatorPreparation = await employeeService.AllOperatorPre();
                return View(model);
            }

            await shiftService.Create(model);

            TempData[MessageConstant.SuccessMessage] = "Смяната е добавена";
            return RedirectToAction(nameof(Calendar));
        }

        [Authorize(Roles = "factoryManager,Manager")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await shiftService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(Calendar));
            }

            var shift = await shiftService.ShiftDetailsById(id);



            shift.Electrician = await employeeService.AllElectrical();
            shift.OperatorPackaging = await employeeService.AllOperatorPack();
            shift.OperatorPreparation = await employeeService.AllOperatorPre();

            return View(shift);
        }

        [Authorize(Roles = "factoryManager,Manager")]
        [HttpPost]
        public async Task<IActionResult> Edit(ShiftEditModel model)
        {
            if ((await shiftService.Exists(model.Id)) == false)
            {
                ModelState.AddModelError("", "Смяната не съществува!");
                TempData[MessageConstant.ErrorMessage] = "Смяната не съществува!";

                model.Electrician = await employeeService.AllElectrical();
                model.OperatorPackaging = await employeeService.AllOperatorPack();
                model.OperatorPreparation = await employeeService.AllOperatorPre();

                return View(model);
            }

            if ((await employeeService.Exists(model.ElectricianId)) == false || (await employeeService.Exists(model.OperatorPackagingId)) == false
                || (await employeeService.Exists(model.OperatorPreparationId)) == false)
            {
                ModelState.AddModelError(nameof(model.ElectricianId), "Невалиден служител");
                TempData[MessageConstant.ErrorMessage] = "Невалиден служител";

                model.Electrician = await employeeService.AllElectrical();
                model.OperatorPackaging = await employeeService.AllOperatorPack();
                model.OperatorPreparation = await employeeService.AllOperatorPre();

                return View(model);

            }

            if (model.Date<DateTime.Now)
            {
                ModelState.AddModelError("", "Не може да промените приключила смяна!");
                TempData[MessageConstant.ErrorMessage] = "Не може да промените приключила смяна!";
                return RedirectToAction(nameof(Calendar));
            }
            if (model.Date== DateTime.Now)
            {
                ModelState.AddModelError("", "Не може да промените днешната смяна!");
                TempData[MessageConstant.ErrorMessage] = "Не може да промените днешната смяна!";
                return RedirectToAction(nameof(Calendar));
            }

            if (ModelState.IsValid == false)
            {
                model.Electrician = await employeeService.AllElectrical();
                model.OperatorPackaging = await employeeService.AllOperatorPack();
                model.OperatorPreparation = await employeeService.AllOperatorPre();

                return View(model);
            }

            await shiftService.Edit(model.Id, model);

            return RedirectToAction(nameof(Calendar));

        }
    }
}
