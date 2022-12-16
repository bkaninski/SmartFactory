using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartFactory.Core.Models.Production
{
    public class ProductionViewModel
    {
        public DateTime Date { get; set; }

        public TypeOfShift TypeOfShift { get; set; }

        public int? ShiftId { get; set; }
        public int ProductionPreparation { get; set; }

        public string Electrical { get; set; }

        public string OperatorPreparation { get; set; }
        public string OperatorPackaging { get; set; }

        public int StockBeforePacking { get; set; }
        public int AfterShiftBufer { get; set; }

        public int ProcuctionPackaging { get; set; }

        public string? Coment { get; set; }

        public string? ComentDetails { get; set; }

    }
}
