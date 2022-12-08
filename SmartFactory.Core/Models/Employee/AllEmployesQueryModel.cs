using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Models.Employee
{
    public class AllEmployesQueryModel
    {
        public string? Position { get; set; }
        public string? SearchTerm { get; set; }
        public EmployeeSorting  Sorting { get; set; }

        public IEnumerable<string> Positions { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<EmployeeServiceModel> Employees { get; set; } = Enumerable.Empty<EmployeeServiceModel>();
    }
}
