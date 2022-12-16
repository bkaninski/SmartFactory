using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Core.Models.Position;
using SmartFactory.Core.Models.Employee;

namespace SmartFactory.Core.Models.Shift
{
    public class ShiftAddModel
    {
        [Required]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Смяна")]
        public TypeOfShift TypeOfShift { get; set; }

        [Required]
        [Display(Name = "Електротехник")]
        public int ElectricianId { get; set; }
        public IEnumerable<ElectricalModel> Electrician { get; set; } = new List<ElectricalModel>();

        [Required]
        [Display(Name = "Оператор Подготовка")]
        public int OperatorPreparationId { get; set; }

        public IEnumerable<OperatorPreModel> OperatorPreparation { get; set; } = new List<OperatorPreModel>();

        [Required]
        [Display(Name = "Оператор Пакетиране")]
        public int OperatorPackagingId { get; set; }

        public IEnumerable<OperatorPackModel> OperatorPackaging { get; set; } = new List<OperatorPackModel>();
    }
}
