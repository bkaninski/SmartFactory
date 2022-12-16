using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Models.Shift
{
    public class ShiftQueryModel
    {
        public int Id { get; set; }

       
        public DateTime Date { get; set; }

       
        public string TypeOfShift { get; set; }

        
        public string Electrician { get; set; }

       
        public string OperatorPreparation { get; set; }

      
        public string OperatorPackaging { get; set; }

       
    }
}
