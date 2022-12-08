using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Models.Employee
{
    public class EmployeeQueryModel
    {
        public int TotalEmployesCount { get; set; }

        public IEnumerable<EmployeeServiceModel> Employees { get; set; } = new List<EmployeeServiceModel>();
    }
}
