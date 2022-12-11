using SmartFactory.Core.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Models.Position
{
    public class PositionAllModel
    {
        public IEnumerable<PositionModel> Positions { get; set; } = new List<PositionModel>();

    }
}
