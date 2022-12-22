using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Infrastructure.Configuration
{
    public class ProductionConfiguration : IEntityTypeConfiguration<Production>
    {
        public void Configure(EntityTypeBuilder<Production> builder)
        {
            //builder.HasData(CreateProductions());
        }

        private List<Production> CreateProductions()
        {
            var productions = new List<Production>()
            {
                new Production()
                {
                   Id=1,
                   Date=new DateTime(2022,12,6),
                   TypeOfShift = TypeOfShift.Early,
                   ShiftId=1,
                   ProductionPreparation=87,
                   StockBeforePacking = 0,
                   ProcuctionPackaging=63,
                   Coment = "По време на сяната авария на пакетираща машина",
                   HasBeenReported=true,
                },

                new Production()
                {
                   Id=2,
                   Date=new DateTime(2022,12,6),
                   TypeOfShift = TypeOfShift.Late,
                   ShiftId=1,
                   ProductionPreparation=82,
                   StockBeforePacking = 24,
                   ProcuctionPackaging=96,
                   Coment = "По време на сяната нямаше аварии!",
                   HasBeenReported=true,
                },



            };




            return productions;
        }
    }
}
