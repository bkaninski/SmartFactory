using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Models.Shift;

namespace SmartFactory.Controllers
{
    [Authorize]
    public class ShiftController : Controller
    {
        public async Task<IActionResult> Calendar()
        {
            

            return View();
        }

        public async Task<IActionResult> AddShift()
        {
            var model = new AddShiftModel();

            return View();
        }
    }
}
