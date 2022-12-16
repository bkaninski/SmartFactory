using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Position;
using SmartFactory.Core.Services;

namespace SmartFactory.Controllers
{
    public class CareerController : Controller
    {

        private readonly ICareerService careerService;

        public CareerController(ICareerService _careerService)
        {
            careerService = _careerService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var models = await careerService.AllCareer();

           

            return View(models);
        }
    }
}
