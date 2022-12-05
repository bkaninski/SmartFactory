using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Infrastructure.Data
{
    public class Leave
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int LeaveEmployeeId { get; set; }

        [ForeignKey(nameof(LeaveEmployeeId))]
        public Employee LeaveEmployee { get; set; } = null!;

        public DateTime DateLeave { get; set; }

        [Required]
        public string Reason { get; set; } = null!;
    }
}
