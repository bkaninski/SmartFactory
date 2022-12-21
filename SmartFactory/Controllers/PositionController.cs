using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Constans;
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

        [Authorize(Roles = "factoryManager")]
        [HttpGet]
        public async Task<IActionResult> AddPosition()
        {
            var model = new PositionQueryModel();
            
            return View(model);
        }

        [Authorize(Roles = "factoryManager")]
        [HttpPost]
        public async Task<IActionResult> AddPosition(PositionQueryModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if ((await positionService.PositionExistsByTitle(model.Title))==true)
            {
                ModelState.AddModelError(nameof(model.Title), "Длъжността вече съществува!");
                return View(model);
            }

            int id = await positionService.Create(model);

            return RedirectToAction(nameof(Details), new { id });
        }

        [Authorize(Roles = "factoryManager")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await positionService.PositionExistsById(id)) == false)
            {
                TempData[MessageConstant.ErrorMessage] = "Няма длъжност с такъв идентификатор!";
                return RedirectToAction(nameof(All));
            }

            var position = await positionService.PositionDetailsById(id);

            var model = new PositionEditModel()
            {
                Id = position.Id,
                Title = position.Title,
                Description = position.Description
               
            };

            return View(model);
        }

        [Authorize(Roles = "factoryManager")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, PositionEditModel model)
        {
            if ((await positionService.PositionExistsById(model.Id)) == false)
            {
                ModelState.AddModelError("", "Длъжността не съществува!");

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await positionService.Edit(model.Id, model);

            return RedirectToAction(nameof(Details), new { model.Id });

        }

        public async Task<IActionResult> Details(int id)
        {
            if ((await positionService.PositionExistsById(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }
            var model = await positionService.PositionDetailsById(id);

            return View(model);
        }
    }
}
