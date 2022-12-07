using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFactory.Infrastructure.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockBeforePacking",
                table: "Productions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "67905730-9c1f-43fb-bf6b-e8dfd5abfd83", 0, "1cfb59f3-82ba-4ec7-9cb2-4e397172a2dd", "operatorleave@mail.com", false, false, null, "operatorleave@mail.com", "operatorleave@mail.com", "AQAAAAEAACcQAAAAEJJVfvSDtJ9TPL+1RnWz2USqF2hYaxoYM8TMUo31bzfcxhuuOZznczs538Lrm8Vzsw==", null, false, "0f5e17e7-3b5e-4556-a9fa-b5b21dae4aea", false, "operatorleave@mail.com" },
                    { "25cb202d-9873-432c-b049-f9184c3ce525", 0, "a089ef1c-da3d-44bf-a2c3-f1d56a204d66", "electrician1@mail.com", false, false, null, "electrician1@mail.com", "electrician1@mail.com", "AQAAAAEAACcQAAAAEEiBVRXMChFwmrrSDQDTN3tcPAVCTsn2bL0n+lLrrFBUJO3CcZct7XShDJaxQGXOxQ==", null, false, "d242d809-a767-498d-afe8-5978eb9948f9", false, "electrician1@mail.com" },
                    { "58434ec1-2216-4b26-869e-94db0c1f7d09", 0, "95bfa28b-58ea-4fb3-a6a4-64db3891e345", "electrician2@mail.com", false, false, null, "electrician2@mail.com", "electrician2@mail.com", "AQAAAAEAACcQAAAAEGmxCUOv0nfNohDbB4/HJ2LYZoqTwh3k6ZRScOVT7fUZwaGZtuvQhwmET67V1yYx/g==", null, false, "f5792614-b93a-4659-a0d0-dd139f3c8f7a", false, "electrician2@mail.com" },
                    { "64a268d0-e995-41a0-a640-f9defb7f6f85", 0, "959856fa-c55d-4815-a72a-060642c563c3", "operator1@mail.com", false, false, null, "operator1@mail.com", "operator1@mail.com", "AQAAAAEAACcQAAAAEBe1atsTyceeYQSEp/ATvh6Q9dVqa+Wz1WqAE/w1N+wi4NiuUWdtoiEXwGwZo9hsnQ==", null, false, "054c0210-762e-429f-b2a8-3757ef784e9d", false, "operator1@mail.com" },
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "6073f4d8-f95c-45e4-b983-68ec582da1a8", "supervisor@mail.com", false, false, null, "supervisor@mail.com", "supervisor@mail.com", "AQAAAAEAACcQAAAAED8bqHKxXEPCYWdILuLogBH01L58lbLNxuLcU/fAsGtFmVgqAkvK7npsPT/M+cpTMw==", null, false, "cec638c5-a192-47e8-96b8-513c99c91417", false, "supervisor@mail.com" },
                    { "7e07d5d6-f082-454c-91c4-4c101a91aee0", 0, "41452c8e-0222-43de-8f41-1fed50524ec7", "operator2@mail.com", false, false, null, "operator2@mail.com", "operator2@mail.com", "AQAAAAEAACcQAAAAEMcF2E8LRCN9Ec759I3vW1FTRRCJk2fI5GcKPEx/FYLRMkannEfR6lldGQQ65+f4ig==", null, false, "9ba5534d-dd5c-464c-b617-7eeeaffe2375", false, "operator2@mail.com" },
                    { "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b", 0, "bfcfd45b-1e09-47a4-a099-a4efeecc3074", "operator3@mail.com", false, false, null, "operator3@mail.com", "operator3@mail.com", "AQAAAAEAACcQAAAAEAhF7uZf1bTIt6qY7f5qjFttUGfDYtL+b63TmBdNr1wZvbF50zG735JSDkZFQ25HkA==", null, false, "199b43fa-38cb-4c88-9f43-7a1b4579b2e9", false, "operator3@mail.com" },
                    { "c77fc444-d5a0-45c2-a576-667a021b6d1f", 0, "1d326156-506b-4bfb-9b0a-be69e72bafb6", "operator4@mail.com", false, false, null, "operator4@mail.com", "operator4@mail.com", "AQAAAAEAACcQAAAAEPiwQDREAGKIME+laxU3lI5nJ9Py3ukMHdnnNEh6UsCi86u7F97SGqb5r70EXK1A1A==", null, false, "8675b9a4-1359-436b-a817-334e3dbc3532", false, "operator4@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "fdc2a709-72f1-4795-a3ab-38395f7a07d6", "factoryManager@mail.com", false, false, null, "factoryManager@mail.com", "factoryManager@mail.com", "AQAAAAEAACcQAAAAEDLYbDxdVJECAkAJmPlDadzBbPUJ4tBMCOAc9WLprVrb5JcPtCMpcs1xdCfdaPWh5A==", null, false, "95531834-d0e5-4c03-bdb7-17caf0d0885a", false, "factoryManager@mail.com" }
                });

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
                table: "Leaves",
                columns: new[] { "Id", "DateLeave", "LeaveEmployeeId", "Reason" },
                values: new object[] { 1, new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Пенсиониране по възраст" });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "Date", "ElectricianId", "InWork", "OperatorPackagingId", "OperatorPreparationId", "TypeOfShift" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, 7, 5, 0 },
                    { 2, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, 8, 6, 1 },
                    { 3, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, 7, 5, 0 },
                    { 4, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, 8, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Coment", "Date", "HasBeenReported", "ProcuctionPackaging", "ProductionPreparation", "ShiftId", "StockBeforePacking", "TypeOfShift" },
                values: new object[] { 1, "По време на сяната авария на пакетираща машина", new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 63, 87, 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Coment", "Date", "HasBeenReported", "ProcuctionPackaging", "ProductionPreparation", "ShiftId", "StockBeforePacking", "TypeOfShift" },
                values: new object[] { 2, "По време на сяната нямаше аварии!", new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 96, 82, 1, 24, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "StockBeforePacking",
                table: "Productions");
        }
    }
}
