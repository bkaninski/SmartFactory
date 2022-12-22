using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Infrastructure.Data;
using SmartFactory.Core.Models.Position;

namespace SmartFactory.Core.Models.Employee
{
    public class EmployeeAddModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Електронна поща")]
        public string Email { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [StringLength(50,MinimumLength =2)]
        [Display(Name = "Име")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50,MinimumLength =2)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = null!;

        [Required]
        [Display(Name = "Години")]
        public int Age { get; set; }

        [Required]
        [StringLength(150,MinimumLength =10)]
        [Display(Name = "Адрес")]
        public string Address { get; set; } = null!;

        [Display(Name ="Длъжност")]
        public int PositionId { get; set; }

        public IEnumerable<PositionModel> Positions { get; set; } = new List<PositionModel>();

        [Required]
        [Display(Name = "Заплата")]
        [Range(820.00,20000.00,ErrorMessage ="Заплатата трябва да бъде положително число по-голямо от {1} лева")]
        public decimal Salary { get; set; }
    }
}
