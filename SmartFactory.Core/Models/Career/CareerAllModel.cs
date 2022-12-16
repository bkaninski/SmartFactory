using SmartFactory.Core.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Models.Position
{
    public class CareerAllModel
    {
       public int Id { get; set; }

       
        public string Position { get; set; }

        public string DateOpen { get; set; }

        public string DateClose { get; set; }

       
    }
}
