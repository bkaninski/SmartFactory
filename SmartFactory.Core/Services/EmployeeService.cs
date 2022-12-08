using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
using SmartFactory.Infrastructure.Data;
using SmartFactory.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Services
{
    public class EmployeeService :IEmployeeService
    {
        private readonly IRepository repo;

        public EmployeeService(IRepository _repo)
        {
            repo = _repo;
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

        public async Task<IEnumerable<PositionModel>> AllPositions()
        {
            return await repo.AllReadonly<Position>()
                .OrderBy(p => p.Title)
                .Select(p => new PositionModel()
                {
                    Id = p.Id,  
                    Title = p.Title
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllPositionsNames()
        {
            return await repo.AllReadonly<Position>()
                .Select(p => p.Title)
                .Distinct()
                .ToListAsync();
        }

        public async Task<int> Create(string userId, EmployeeAddModel model)
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

            
            await repo.AddAsync(employee);
            await repo.SaveChangesAsync();

            return employee.Id;
        }

        public async Task<string> CreateUser(string email)
        {
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

        public async Task Edit(int employeeId, EmployeeEditModel model)
        {
            var employee = await repo.GetByIdAsync<Employee>(employeeId);

            employee.Address = model.Address;
            employee.PositionId = model.PositionId;
            employee.Salary = model.Salary;

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

        public async Task<int> GetEmployeePositionId(int employeeId)
        {
            var result = await repo.AllReadonly<Employee>()
                .Where(e => e.Id == employeeId)
                .Select(e => e.PositionId)
                .FirstAsync();
            return result.Value;
                
        }

        public async Task<bool> PositionExists(int positionId)
        {
            return await repo.AllReadonly<Position>()
                .AnyAsync(p => p.Id == positionId);
        }
    }
}
