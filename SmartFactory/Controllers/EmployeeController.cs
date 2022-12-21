using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;

namespace SmartFactory.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IPositionService positionService;

        public EmployeeController(
            IEmployeeService _employeeService,
            IPositionService _positionService)
        {
            employeeService = _employeeService;
            positionService = _positionService;
        }


        public async Task<IActionResult> All([FromQuery]AllEmployesQueryModel query)
        {
            var result = await employeeService.All(
                query.Position,
                query.SearchTerm,
                query.Sorting);

            query.Positions = await positionService.AllPositionsNames();
            query.Employees = result.Employees;

            return View(query);
        }

        [Authorize(Roles = "factoryManager")]
        [HttpGet]
        public async Task< IActionResult> AddEmployee()
        {
            var model = new EmployeeAddModel()
            {
               Positions = await positionService.AllPositions()
            };
          

            return View(model);
        }

        [Authorize(Roles = "factoryManager")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeAddModel model)
        {
            if (await positionService.PositionExistsById(model.PositionId)==false)
            {
                ModelState.AddModelError(nameof(model.PositionId), "Длъжността не съществува!");

            }
            try
            {
                string userId = await employeeService.CreateUser(model.Email);
                if (userId != null)
                {
                    model.UserId = userId;
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError(nameof(model.Email),ex.Message);
               
            }
           

            if (!ModelState.IsValid)
            {
                model.Positions = await positionService.AllPositions();
                return View(model);
            }

            int id = await employeeService.Create(model.UserId, model);

            return RedirectToAction(nameof(Details), new {id});
        }

        [Authorize(Roles = "factoryManager")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await employeeService.Exists(id))==false)
            {
                return RedirectToAction(nameof(All));
            }

            var employee = await employeeService.EmployeeDetailsById(id);

            var positionId = await employeeService.GetEmployeePositionId(id);

            var model = new EmployeeEditModel()
            {
                Id=employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Age = employee.Age,
                Address = employee.Address,
                PositionId = positionId,
                Salary = employee.Salary,
                Positions = await positionService.AllPositions()
            };

            return View(model);
        }

        [Authorize(Roles = "factoryManager")]
        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeEditModel model)
        {
            if ((await employeeService.Exists(model.Id))==false)
            {
                ModelState.AddModelError("", "Служителя не съществува!");

                model.Positions = await positionService.AllPositions();

                return View(model);
            }

            if ((await positionService.PositionExistsById(model.PositionId))==false)
            {
                ModelState.AddModelError(nameof(model.PositionId), "Длъжността не съществува!");
                model.Positions = await positionService.AllPositions();

                return View(model);
            }

            if (ModelState.IsValid==false)
            {
                model.Positions = await positionService.AllPositions();
                return View(model);
            }

            await employeeService.Edit(model.Id, model);

            return RedirectToAction(nameof(Details), new { model.Id });

        }

        public async Task<IActionResult> Details(int id)
        {
            if ((await employeeService.Exists(id))==false)
            {
                return RedirectToAction(nameof(All));
            }
            var model = await employeeService.EmployeeDetailsById(id);

            return View(model);
        }
    }
}
