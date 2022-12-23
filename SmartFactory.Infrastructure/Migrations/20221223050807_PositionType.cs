using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFactory.Infrastructure.Migrations
{
    public partial class PositionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 9);

            //migrationBuilder.DeleteData(
            //    table: "Productions",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Productions",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Shifts",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Shifts",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Shifts",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 6);

            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 8);

            //migrationBuilder.DeleteData(
            //    table: "Positions",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Positions",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Shifts",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 5);

            //migrationBuilder.DeleteData(
            //    table: "Employees",
            //    keyColumn: "Id",
            //    keyValue: 7);

            //migrationBuilder.DeleteData(
            //    table: "Positions",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Positions",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "Positions",
            //    keyColumn: "Id",
            //    keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "PositionType",
                table: "Positions",
                type: "int",
                nullable: true);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "9c36e67e-1170-455e-8581-c0e5638e9ca3", "AQAAAAEAACcQAAAAENSyhuf2OmzNcJJwyozMHs9BSKiZ/lc5y6R57pTLOgDnPKZIsnGIcicoUdTAznkL9Q==", "9369e810-003e-43f6-bdce-a4e8c9f33dd5" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "ce069347-9b2c-4aaa-9a92-455120c7e83b", "AQAAAAEAACcQAAAAEBtfJhgUYh0zdezNitb1ANNgbyZdflREIuopuqFVFeVPuUXqgE+hed3WT8zjezKX8Q==", "081e31ab-3ad2-448b-984e-eabaf3fe8b3b" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "0af1ea51-03c7-4b9f-9dd4-535ed852942b", "AQAAAAEAACcQAAAAENWVO6eOiScjwsuIba+pcbOHrZVF5Trkr/c2FV4XB7iR8ZDCO1YE0bPK0uUlEDTFkw==", "1fcaa19c-2e48-4add-9f45-4c184bcd3661" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "274ceba5-5755-49fc-847d-f4ab9c79ce91", "AQAAAAEAACcQAAAAEPa0KI6G+sTG5sLl8ePZTJUAEmF+jVeb/lj+NavN3N028NYt00vCHzFeIAMpieSOCQ==", "d2b4fc06-3a78-4270-82fd-a0b91e072254" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "973c17d3-5064-4311-9941-8cfc32e30d05", "AQAAAAEAACcQAAAAED2Sstx7CHnjDqXBwRNR4ljDIXmGnG5noueG8eCVFraG8wcnguroNNfm3nE+frtVww==", "5dc84768-6d06-4417-a3c8-4fac57f77197" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "67b467de-5b90-4367-b863-460bf09f125c", "AQAAAAEAACcQAAAAEHFenQWgXmO/cgDiaZQK7pgscsUPvk8dDAvyddvmhbLkJvWpGPkxBvdQJ04jkKXA2A==", "43fe17ec-1b7f-440c-be7d-ed48e3fa2011" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "02df4620-aa69-4b86-adef-6607f2976d82", "AQAAAAEAACcQAAAAEOdV8JkCG5PHHZVJEJOzNDhGBYe0ruUsj5Di36Ronp8CxNZRa6kLi+eHnXUDoYc+GA==", "76731577-5d1e-4157-9527-efc9f4dd117f" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "e0cebea5-060f-4fe2-b277-cf02a771caf1", "AQAAAAEAACcQAAAAEDXWpduTM8l+vEfXTV2mck30m1QKbc4/QB2DRXvtXdcURbPfoojzJauFrM3OFZYuYg==", "a8913614-b486-4774-94ff-35a4fd398d7c" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "573218a9-92c8-4170-88ba-d801f7344ce6", "AQAAAAEAACcQAAAAEPskH0YkNBnk4jlxBJPfruutPntZBe5q6f9laoBkCEEfRCPjwTFBU2j41Bxu9USrTw==", "672060ee-6fae-4fe3-8a80-981213d5951f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionType",
                table: "Positions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "594ba88a-4820-42c7-a79d-2fd2c0ef8fc5", "AQAAAAEAACcQAAAAECQ0NBw/7Yv9/lgMdwziubfdZeSBq/rYDOrwB4iGyw6XK3wJpO/hkaVStLByPtr/PQ==", "4edb0018-c24e-45a9-b494-38301eecfb3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c6711d9-a9ad-497e-a691-6b5f22a22a8f", "AQAAAAEAACcQAAAAEO8zRb9SUqUoAxMnpAqQeXQNCWHuEODZh9mEOHAqsnaNEjpnlvdFlTGA0OEg1k1VYw==", "37436c12-9786-4612-b482-a19e40cf6314" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddbdfda1-00b4-4272-b346-a8f46670b429", "AQAAAAEAACcQAAAAEAXAOcF6HLkjQLM4/YiAqZetqszxEQaGowN4o/0DODYhiQlQomTU1TOQMf2b752u7w==", "481b33e0-e545-40fe-a50c-6be6e20e5522" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7906f5e5-9abd-43f4-bede-edcb03d9ad59", "AQAAAAEAACcQAAAAEIqOsPoLCJz9dyMYmG/xeYCSix0f+J1ItYcAK8AkDYu6F+4JgQwUSWLOHNNI5KwGZg==", "7147baf5-16ea-44d4-bce5-8b96791dc722" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a034d3-6930-42e9-a3a9-6c271b1ee4b3", "AQAAAAEAACcQAAAAEBe6lcqh7xQUup6LU5SKYHpY9AMDPq4IF0ojMfChqv//znHlIMENNSnxQwHrew0l5Q==", "f9eb2b3c-da84-469a-881d-38b8875be0fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cfeec7e-6740-4334-b90c-e3c8669ea934", "AQAAAAEAACcQAAAAEJM+Sas8v9I58KcqvNlIQGVXtu1Pzlj6hqv44KonS1/nnruPOeROXT+YqA5pUE7+7Q==", "a0f98e7e-6899-482c-b54b-426971184777" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f4dcecc-993c-41af-9d72-239acb44d1cc", "AQAAAAEAACcQAAAAEM63hw/J2FN+0AYhb40/nYwJsjdDdQtVdDr7GYTtl4V/Fbp/e0LPqVkBjBfsIzsmLg==", "50ead8ca-9017-40fd-9de6-0250c8fa387c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed5c69ed-1fe3-4536-abd4-474eab16e0b5", "AQAAAAEAACcQAAAAEJtLgrkGywsav5mVJAZfNaq58paQL6rFUo/BugsU7tafbp9Vu+hggDAFIjKDibjGEw==", "e83e9313-c81a-46df-8f7d-81232bde25f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "729a2ef9-a882-4154-b856-00e0d0f2bbc8", "AQAAAAEAACcQAAAAEAunztqqbvAllvsSrcdlaKWT51B9p2aWJ7UPZzcugTEF3ItoxaQAg5qD+ESuhjphBw==", "7420d16c-af12-4e64-8ba5-6bf86162671b" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "1. Ръководи цялостната дейност на търговското дружество/ клона на дружеството, съобразно изискванията на Търговския закон, разработената стратегия и правилата на добрата търговска практика.\r\nТрудови задачи и задължения, характеризиращи съдържанието на длъжността:\r\n2.Разработва бизнес план за дейността на дружеството/ клона на дружеството.\r\n3.Осигурява изпълнение на бизнес плана чрез най-добрия наличен технологичен, технически и кадрови ресурс.\r\n4.Отговаря на техническата и противопожарна безопасност в предприятието, както и за осигуряването на здравословни и безопасни условия на труд.\r\n5. Назначава и освобождава персонала в дружеството/ клона на търговското дружество\r\n6.Решава всички ръководни въпроси по дейността на дружеството/ клона на търговското дружество.", "Управител на фабриката" },
                    { 2, "Координиране на цялостната организация на производствения процес – спазване на технологията на производство и работата на оборудването\r\nУчастие в изготвяне на производствени програми и последващ контрол\r\nАнализиране на разходите в съответствие с технологичните норми и отговорност за спазване на стандартите за качество\r\nРазработване на предложения за усъвършенстване на технологичното равнище на производството\r\nУчастие в обучението и повишаване квалификацията на работниците и служителите при усвояване на нови техника или технологии", "Ръководител производство" },
                    { 3, "1. Извършва подготвителни операции и монтаж на различни електрически инсталации. Следи за изправността, профилактиката и ремонта на електрическите мрежи, машини и съоръжения в сградите на работодателя.\r\nТрудови задачи и задължения, характеризиращи описанието на длъжността:\r\n2. Извършва монтаж и свързване на различни електрически табла;\r\n3. Извършва монтаж на елементите на електрообзавеждането или електро задвижването на производствени схеми;\r\n4. Следи за изправността на електрическите мрежи ,машини и съоръжения и определя необходимостта от ремонт.\r\n5. Прави профилактични проверка на техническото състояние на електрическите мрежи, машини и съоръжения.\r\n6. Извършва необходимият ремонт на електрическите мрежи, машини и съоръжения и отстранява технически повреди;\r\n7. Следи за правното прилагане на правилата за заземителните и гръмоотводните инсталации.\r\n8. Следи за изправността на измервателната техника .\r\n9. При необходимост изпълнява и други задачи, възложени във връзка с изпълнение на длъжността.", "Електротехник" },
                    { 4, "Подготвя и контролира машините на производствената линия, следи за качеството на произвеждания продукт и спазва разходните норми за материали\r\nУчаства в текущата поддръжка на машините и отговаря за правилната им експлоатация\r\nГрижи се за почистването на машините и сортиране на отпадъците, според наличните процедури.", "Оператор подготовка" },
                    { 5, "• Обслужваш и подпомагаш чрез ръчни операции работата на линията - товаро-разтоварни и преносни дейности;\r\n• Работиш с палетна количка и пренасяш кашони/касетки;\r\n• Контролираш и спазваш всички параметри на производствения процес, съгласно стандартите на съответното работно място;\r\n• Контролираш качеството на продукцията (входяща и изходяща) съгласно стандартите за съответното работно място;\r\n• При необходимост изпълняваш и други задачи, свързани с трудовия процес;\r\n• Извършваш почистване на работното място и съораженията, съгласно Инструкциите.", "Оператор пакетиране" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "FirstName", "IsQuits", "LastName", "PositionId", "Salary", "UserId" },
                values: new object[,]
                {
                    { 1, "ул. Гео Милев 13, София, България", 51, "Петър", false, "Петров", 1, 10000.0m, "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "кв. Дружба 1 бл. 12 , вх. А, ап. 13, Плевен, България", 42, "Ангел", false, "Ангелов", 2, 4762.20m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "кв. Дружба 3 бл. 22 , вх. Б, ап. 7, Плевен, България", 48, "Иван", false, "Иванов", 3, 2357.80m, "25cb202d-9873-432c-b049-f9184c3ce525" },
                    { 4, "ул. Търговска 11, Червен бряг, България", 34, "Димитър", false, "Димитров", 3, 2027.34m, "58434ec1-2216-4b26-869e-94db0c1f7d09" },
                    { 5, "ул. Божурица 4, Плевен, България", 37, "Валери", false, "Атанасов", 4, 1628.54m, "64a268d0-e995-41a0-a640-f9defb7f6f85" },
                    { 6, "ул. Янко Сакъзов 24, Плевен, България", 23, "Христо", false, "Христов", 4, 1243.00m, "7e07d5d6-f082-454c-91c4-4c101a91aee0" },
                    { 7, "ул. Шипка 14, Плевен, България", 35, "Цветомир", false, "Цветанов", 5, 1480.00m, "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b" },
                    { 8, "ул. Осогово 2, Плевен, България", 26, "Антон", false, "Антонов", 5, 1343.00m, "c77fc444-d5a0-45c2-a576-667a021b6d1f" },
                    { 9, "ул. Шипка 2, Плевен, България", 63, "Надежда", false, "Георгиева", 5, 2362.93m, "67905730-9c1f-43fb-bf6b-e8dfd5abfd83" }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "Date", "ElectricianId", "OperatorPackagingId", "OperatorPreparationId", "TypeOfShift" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, 5, 0 },
                    { 2, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 8, 6, 1 },
                    { 3, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, 5, 0 },
                    { 4, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 8, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "AfterShiftBufer", "Coment", "ComentDetails", "Date", "HasBeenReported", "ProcuctionPackaging", "ProductionPreparation", "ShiftId", "StockBeforePacking", "TypeOfShift" },
                values: new object[] { 1, 0, "По време на сяната авария на пакетираща машина", null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 63, 87, 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "AfterShiftBufer", "Coment", "ComentDetails", "Date", "HasBeenReported", "ProcuctionPackaging", "ProductionPreparation", "ShiftId", "StockBeforePacking", "TypeOfShift" },
                values: new object[] { 2, 0, "По време на сяната нямаше аварии!", null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 96, 82, 1, 24, 1 });
        }
    }
}
