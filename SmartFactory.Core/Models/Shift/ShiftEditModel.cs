using SmartFactory.Core.Models.Employee;
using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartFactory.Core.Models.Shift
{
    public class ShiftEditModel
    {
        public int Id { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "Смяна")]
        public TypeOfShift TypeOfShift { get; set; }

        [Display(Name = "Електротехник")]
        public int ElectricianId { get; set; }
        public IEnumerable<ElectricalModel> Electrician { get; set; } = new List<ElectricalModel>();

        [Display(Name = "Оператор Подготовка")]
        public int OperatorPreparationId { get; set; }

        public IEnumerable<OperatorPreModel> OperatorPreparation { get; set; } = new List<OperatorPreModel>();

        [Display(Name = "Оператор Пакетиране")]
        public int OperatorPackagingId { get; set; }

        public IEnumerable<OperatorPackModel> OperatorPackaging { get; set; } = new List<OperatorPackModel>();
    }
}
