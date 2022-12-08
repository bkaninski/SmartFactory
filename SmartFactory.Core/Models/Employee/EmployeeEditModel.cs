using SmartFactory.Core.Models.Position;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartFactory.Core.Models.Employee
{
    public class EmployeeEditModel
    {
        public int Id { get; set; }

        [Display(Name = "Име")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Възраст")]
        public int Age { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Длъжност")]
        public int PositionId { get; set; }

        [Display(Name = "Заплата")]
        public decimal Salary { get; set; }

        public IEnumerable<PositionModel> Positions { get; set; } = new List<PositionModel>();
    }
}
