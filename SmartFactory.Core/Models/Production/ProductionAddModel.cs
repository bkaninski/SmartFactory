using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Core.Models.Shift;
using SmartFactory.Core.Models.Employee;

namespace SmartFactory.Core.Models.Production
{
    public class ProductionAddModel
    {
        [Required]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Смяна")]
        public TypeOfShift TypeOfShift { get; set; }

        [Required]
        [Display(Name = "Производство станция подготовка")]
        public int ProductionPreparation { get; set; }

        [Display(Name = "Буфер преди пакетиране")]
        public int StockBeforePacking { get; set; }

        [Display(Name = "Буфер в края на смяната")]
        public int AfterShiftBufer { get; set; }

        [Required]
        [Display(Name = "Производство станция пакетиране")]
        public int ProcuctionPackaging { get; set; }

        [Display(Name = "Коментар")]
        public string? Coment { get; set; }

        [Display(Name = "Подробно описание")]

        public string? ComentDetails { get; set; }

    }
}
