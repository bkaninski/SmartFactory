using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Core.Models.Position
{
    public class PositionAddModel
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name ="Наименование")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(5000, MinimumLength =5)]
        [Display(Name = "Описание")]
        public string Description { get; set; } = null!;
    }
}
