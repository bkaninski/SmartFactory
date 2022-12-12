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
    public class CareerConfiguration : IEntityTypeConfiguration<Career>
    {
        public void Configure(EntityTypeBuilder<Career> builder)
        {
            builder.HasData(CreateCareers());
        }

        private List<Career> CreateCareers()
        {
            var leaves = new List<Career>()
            {
                 new Career()
                {

                    Id=1,
                    PositionId=3,
                    DataOpen = new DateTime(2022,12,3),
                    DaysActive = 30,
                     Title = "Електротехник",
                    Description = "1. Извършва подготвителни операции и монтаж на различни електрически инсталации. Следи за изправността, профилактиката и ремонта на електрическите мрежи, машини и съоръжения в сградите на работодателя.\r\nТрудови задачи и задължения, характеризиращи описанието на длъжността:\r\n2. Извършва монтаж и свързване на различни електрически табла;\r\n3. Извършва монтаж на елементите на електрообзавеждането или електро задвижването на производствени схеми;\r\n4. Следи за изправността на електрическите мрежи ,машини и съоръжения и определя необходимостта от ремонт.\r\n5. Прави профилактични проверка на техническото състояние на електрическите мрежи, машини и съоръжения.\r\n6. Извършва необходимият ремонт на електрическите мрежи, машини и съоръжения и отстранява технически повреди;\r\n7. Следи за правното прилагане на правилата за заземителните и гръмоотводните инсталации.\r\n8. Следи за изправността на измервателната техника .\r\n9. При необходимост изпълнява и други задачи, възложени във връзка с изпълнение на длъжността.",
                    Qualifications = " Завършено висше/ средно образование с профил електротехника, електроенергетика и електрообзавеждане или автоматизация\r\n∙ Минимум 2 години опит по специалността в производствено предприятие"

                },



            };




            return leaves;
        }
    }
}
