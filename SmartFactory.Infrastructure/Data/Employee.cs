using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Infrastructure.Data
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; } = null!;

        public int? PositionId { get; set; }

        [ForeignKey(nameof(PositionId))]
        public Position? Position { get; set; } = null!;

        [Required]
        public decimal Salary { get; set; }

        public bool IsQuits { get; set; } = false;
    }
}
