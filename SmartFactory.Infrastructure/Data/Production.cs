using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Infrastructure.Data
{
    public class Production
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TypeOfShift TypeOfShift { get; set; }

        public int? ShiftId { get; set; }

        [ForeignKey(nameof(ShiftId))]
        public Shift? Shift { get; set; }

        [Required]
        public int ProductionPreparation { get; set; }

        public int StockBeforePacking { get; set; }

        [Required]
        public int ProcuctionPackaging { get; set; }

        [Required]

        public int AfterShiftBufer { get; set; }

        public string? Coment { get; set; }
        public string? ComentDetails { get; set; }

        public bool HasBeenReported { get; set; } = false;
    }
}
