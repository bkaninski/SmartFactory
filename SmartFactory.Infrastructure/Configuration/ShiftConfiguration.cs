using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFactory.Infrastructure.Data;

namespace SmartFactory.Infrastructure.Configuration
{
    public class ShiftConfiguration : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {
            builder.HasData(CreateShifts());
        }

        private List<Shift> CreateShifts()
        {
            var shifts = new List<Shift>()
            {
                 new Shift()
                {

                    Id=1,
                    Date=new DateTime(2022,12,6),
                    TypeOfShift=TypeOfShift.Early,
                    ElectricianId = 3,
                    OperatorPreparationId = 5,
                    OperatorPackagingId = 7,

                },

                  new Shift()
                {
                    Id=2,
                    Date=new DateTime(2022,12,6),
                    TypeOfShift=TypeOfShift.Late,
                    ElectricianId = 4,
                    OperatorPreparationId = 6,
                    OperatorPackagingId = 8,

                },


                new Shift()
                {
                    Id=3,
                    Date=new DateTime(2022,12,7),
                    TypeOfShift=TypeOfShift.Early,
                    ElectricianId = 3,
                    OperatorPreparationId = 5,
                    OperatorPackagingId = 7,

                },

                  new Shift()
                {
                    Id=4,
                    Date=new DateTime(2022,12,7),
                    TypeOfShift=TypeOfShift.Late,
                    ElectricianId = 4,
                    OperatorPreparationId = 6,
                    OperatorPackagingId = 8,

                },


            };




            return shifts;
        }
    }
}
