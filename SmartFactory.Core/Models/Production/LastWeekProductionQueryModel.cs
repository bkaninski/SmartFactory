using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Models.Production
{
    public class LastWeekProductionQueryModel
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public TypeOfShift TypeOfShift { get; set; }

        public int ProductionPreparation { get; set; }

        public int StockBeforePacking { get; set; }

        public int ProductionPackaging { get; set; }

        public int StockBeforePackingAfter { get; set; }

        public string? Coment { get; set; }
    }
}
