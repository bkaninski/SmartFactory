using Microsoft.AspNetCore.Identity;
using SmartFactory.Core.Models.Employee;
using SmartFactory.Core.Models.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Contracts
{
    public interface IEmployeeService
    {
        Task<IEnumerable<PositionModel>> AllPositions();

        Task<bool> PositionExists(int positionId);

        Task<string> CreateUser(string email);

        Task<int> Create(string userId,EmployeeAddModel model);

        Task<EmployeeQueryModel> All(
            string? position=null,
            string? searchTerm = null,
            EmployeeSorting sorting = EmployeeSorting.Длъжност);

        Task<IEnumerable<string>> AllPositionsNames();

        Task<EmployeeDetailsModel> EmployeeDetailsById(int id);

        Task<bool> Exists(int id);

        Task Edit(int employeeId,EmployeeEditModel model);

        Task<int> GetEmployeePositionId(int employeeId);

    }
}
