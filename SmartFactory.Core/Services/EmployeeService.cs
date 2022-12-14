using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Infrastructure.Data;
using SmartFactory.Infrastructure.Data.Common;

namespace SmartFactory.Core.Services
{
    public class EmployeeService :IEmployeeService
    {
        private readonly IRepository repo;
        private readonly UserManager<IdentityUser> userManager;

        public EmployeeService(
            IRepository _repo,
            UserManager<IdentityUser> _userManager)
        {
            repo = _repo;
            userManager = _userManager;
        }

        public async Task<EmployeeQueryModel> All(string? position = null, string? searchTerm = null, EmployeeSorting sorting = EmployeeSorting.Длъжност)
        {
            var result = new EmployeeQueryModel();

            var employes = repo.AllReadonly<Employee>();

            if (string.IsNullOrEmpty(position)==false)
            {
                employes = employes
                    .Where(e => e.Position.Title == position);
            }

            if (string.IsNullOrEmpty(searchTerm)==false)
            {
                searchTerm = $"%{ searchTerm.ToLower()}%";
                employes = employes
                    .Where(e => EF.Functions.Like(e.FirstName.ToLower(), searchTerm) ||
                    EF.Functions.Like(e.LastName.ToLower(), searchTerm) ||
                    EF.Functions.Like(e.Address.ToLower(), searchTerm));
            }

            employes = sorting switch
            {
                EmployeeSorting.Възраст => employes
                            .OrderBy(e => e.Age),
                EmployeeSorting.Длъжност => employes
                            .OrderBy(e => e.Position),
                EmployeeSorting.Заплата => employes
                            .OrderBy(e => e.Salary),
                _ => employes.OrderBy(e => e.FirstName)
            };

            result.Employees = await employes
                .Where(e=>e.IsQuits!=true)
                .Select(e => new EmployeeServiceModel()
                {
                    Id=e.Id,
                    FirstName= e.FirstName,
                    LastName=e.LastName,
                    Age= e.Age,
                    Address=e.Address,
                    Salary=e.Salary,
                    Position= e.Position.Title
                })
                .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<ElectricalModel>> AllElectrical()
        {
            return await repo.AllReadonly<Employee>()
                .Where(e=>e.PositionId==3)
                .Where(e=>e.IsQuits==false)
               .OrderBy(e => e.Id)
               .Select(e => new ElectricalModel()
               {
                   Id = e.Id,
                   FirstName = e.FirstName,
                   LastName = e.LastName
               })
               .ToListAsync();
        }

        public async Task<IEnumerable<OperatorPackModel>> AllOperatorPack()
        {
            return await repo.AllReadonly<Employee>()
            .Where(e => e.PositionId == 5)
            .Where(e => e.IsQuits==false)
           .OrderBy(e => e.Id)
           .Select(e => new OperatorPackModel()
           {
               Id = e.Id,
               FirstName = e.FirstName,
               LastName = e.LastName
           })
           .ToListAsync();
        }

        public async Task<IEnumerable<OperatorPreModel>> AllOperatorPre()
        {
            return await repo.AllReadonly<Employee>()
           .Where(e => e.PositionId == 4)
           .Where(e => e.IsQuits == false)
          .OrderBy(e => e.Id)
          .Select(e => new OperatorPreModel()
          {
              Id = e.Id,
              FirstName = e.FirstName,
              LastName = e.LastName
          })
          .ToListAsync();
        }

        public async Task<int> Create(string userId, EmployeeAddModel model, int positionType)
        {
            var employee = new Employee()
            {
                UserId= userId,
                FirstName= model.FirstName,
                LastName= model.LastName,
                Age= model.Age,
                Address=model.Address,
                PositionId=model.PositionId,
                Salary=model.Salary
            };

            await UpdateUser(userId, positionType);
            await repo.AddAsync(employee);
            await repo.SaveChangesAsync();

            return employee.Id;
        }

        public async Task<string> CreateUser(string email)
        {
            if (await userManager.FindByEmailAsync(email)!=null)
            {
                throw new Exception("Вече има такъв потребител");
            }

            var user = new IdentityUser()
            {
                UserName = email,
                NormalizedUserName = email,
                Email = email,
                NormalizedEmail = email
            };
            user.PasswordHash =
                new PasswordHasher<IdentityUser>().HashPassword(user, "1234");

            await repo.AddAsync(user);
            await repo.SaveChangesAsync();

            return user.Id;
        }

        public async Task Edit(int employeeId, EmployeeEditModel model, int positionType)
        {
            var employee = await repo.GetByIdAsync<Employee>(employeeId);

            employee.Age = model.Age;
            employee.Address = model.Address;
            employee.PositionId = model.PositionId;
            employee.Salary = model.Salary;

            string userId = employee.UserId;


            await UpdateUser(userId, positionType);

            await repo.SaveChangesAsync();
        }

        public async Task<EmployeeDetailsModel> EmployeeDetailsById(int id)
        {
            return await repo.AllReadonly<Employee>()
                 .Where(e => e.Id == id)
                 .Select(e => new EmployeeDetailsModel()
                 {
                     Id=e.Id,
                     FirstName=e.FirstName,
                     LastName=e.LastName,
                     Address=e.Address,
                     Age=e.Age,
                     Position=e.Position.Title,
                     Salary=e.Salary,

                 })
                 .FirstAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Employee>()
                .AnyAsync(e => e.Id == id);
        }

        public async Task<int> GetEmployeeId(string userId)
        {
            return  await repo.AllReadonly<Employee>()
                 .Where(e => e.UserId == userId)
                 .Select(e => e.Id)
                 .FirstAsync();
           
        }

        public async Task<int> GetEmployeePositionId(int employeeId)
        {
            var result = await repo.AllReadonly<Employee>()
                .Where(e => e.Id == employeeId)
                .Select(e => e.PositionId)
                .FirstAsync();
            return result.Value;
                
        }

        public async Task UpdateUser(string userId, int positionType)
        {
            var user = await userManager.FindByIdAsync(userId);


            if (positionType == 0)
            {
               await userManager.AddToRoleAsync(user, "factoryManager");
            }
            else if (positionType == 1)
            {
                await userManager.AddToRoleAsync(user, "Manager");

            }
            else if (positionType == 2)
            {
                await userManager.AddToRoleAsync(user, "Electrical");

            }
            else if (positionType == 3)
            {
                await userManager.AddToRoleAsync(user, "Operator");
            }
        }

     
    }
}
