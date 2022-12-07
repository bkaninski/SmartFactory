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
    public class LeaveConfiguration : IEntityTypeConfiguration<Leave>
    {
        public void Configure(EntityTypeBuilder<Leave> builder)
        {
            builder.HasData(CreateLeaves());
        }

        private List<Leave> CreateLeaves()
        {
            var leaves = new List<Leave>()
            {
                 new Leave()
                {

                    Id=1,
                    LeaveEmployeeId=9,
                    DateLeave= new DateTime(2022,11,21),
                    Reason = "Пенсиониране по възраст"

                },



            };




            return leaves;
        }
    }
}
