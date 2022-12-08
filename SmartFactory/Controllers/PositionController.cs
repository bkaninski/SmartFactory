using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;

namespace SmartFactory.Controllers
{
    [Authorize]
    public class PositionController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = new PositionModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult AddPosition()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPosition(PositionModel model)
        {
            int id = 1;

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
