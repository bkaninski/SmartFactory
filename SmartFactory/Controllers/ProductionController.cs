using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Contracts;

namespace SmartFactory.Controllers
{
    [Authorize]
    public class ProductionController : Controller
    {
        private readonly IProductionService productionService;

        public ProductionController(IProductionService _productionService)
        {
            productionService = _productionService;
        }

        public async Task<IActionResult> LastWeekProduction()
        {
            var model = await productionService.LastWeekProduction();

            return View(model);
        }

        public IActionResult CurrentShift()
        {
            return View();
        }
    }
}
