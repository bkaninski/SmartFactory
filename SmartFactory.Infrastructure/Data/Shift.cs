using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Infrastructure.Data
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TypeOfShift TypeOfShift { get; set; }

        [Required]
        public int ElectricianId { get; set; }

        [ForeignKey(nameof(ElectricianId))]
        public Employee Electrician { get; set; } = null!;

        [Required]
        public int OperatorPreparationId { get; set; }

        [ForeignKey(nameof(OperatorPreparationId))]
        public Employee OperatorPreparation { get; set; } = null!;

        [Required]
        public int OperatorPackagingId { get; set; }

        [ForeignKey(nameof(OperatorPackagingId))]
        public Employee OperatorPackaging { get; set; } = null!;

        public bool InWork { get; set; } = false;
    }
}
