using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Models.Position
{
    public class PositionModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

    }
}
