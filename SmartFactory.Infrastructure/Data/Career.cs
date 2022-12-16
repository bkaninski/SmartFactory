using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Infrastructure.Data
{
    public class Career
    {
        [Key]
        public int Id { get; set; }

        public int? PositionId { get; set; }

        [ForeignKey(nameof(PositionId))]
        public Position? Position { get; set; } = null!;

        [Required]
        public DateTime DataOpen { get; set; }

        [Required]
        public int DaysActive { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(5000)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(5000)]
        public string Qualifications { get; set; } = null!;

    }
}
