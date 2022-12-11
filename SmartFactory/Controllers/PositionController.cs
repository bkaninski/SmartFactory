using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
using SmartFactory.Core.Services;

namespace SmartFactory.Controllers
{
    [Authorize]
    public class PositionController : Controller
    {

        private readonly IPositionService positionService;

        public PositionController(IPositionService _positionService)
        {
            positionService = _positionService;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await positionService.AllPositions();

            var positions = new PositionAllModel();
            positions.Positions = model;

            return View(positions);
        }

        [HttpGet]
        public async Task<IActionResult> AddPosition()
        {
            var model = new PositionAddModel();
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPosition(PositionAddModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            int id = await positionService.Create(model);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new EmployeeEditModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EmployeeEditModel model)
        {
            return RedirectToAction(nameof(Details), new { id });

        }

        public async Task<IActionResult> Details(int id)
        {
            var model = new PositionDetailsModel();

            return View(model);
        }
    }
}
