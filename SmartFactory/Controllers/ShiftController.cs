using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public async Task<IActionResult> AddShift(ShiftAddModel model)
        {
            if ((await employeeService.Exists(model.ElectricianId)) == false || (await employeeService.Exists(model.OperatorPackagingId)) == false
                || (await employeeService.Exists(model.OperatorPreparationId)) == false)
            {
                ModelState.AddModelError(nameof(model.ElectricianId), "Невалиден служител");

            }

            if (!ModelState.IsValid)
            {
                model.Electrician = await employeeService.AllElectrical();
                model.OperatorPackaging = await employeeService.AllOperatorPack();
                model.OperatorPreparation = await employeeService.AllOperatorPre();
                return View(model);
            }

           await shiftService.Create(model);

            return RedirectToAction(nameof(Calendar));
        }

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

        [HttpPost]
        public async Task<IActionResult> Edit(ShiftEditModel model)
        {
            if ((await shiftService.Exists(model.Id)) == false)
            {
                ModelState.AddModelError("", "Смяната не съществува!");

                model.Electrician = await employeeService.AllElectrical();
                model.OperatorPackaging = await employeeService.AllOperatorPack();
                model.OperatorPreparation = await employeeService.AllOperatorPre();

                return View(model);
            }

            if ((await employeeService.Exists(model.ElectricianId)) == false || (await employeeService.Exists(model.OperatorPackagingId)) == false
                || (await employeeService.Exists(model.OperatorPreparationId)) == false)
            {
                ModelState.AddModelError(nameof(model.ElectricianId), "Невалиден служител");
                model.Electrician = await employeeService.AllElectrical();
                model.OperatorPackaging = await employeeService.AllOperatorPack();
                model.OperatorPreparation = await employeeService.AllOperatorPre();

                return View(model);

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
