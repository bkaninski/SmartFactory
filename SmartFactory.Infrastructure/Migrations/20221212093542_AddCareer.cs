using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFactory.Infrastructure.Migrations
{
    public partial class AddCareer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    DataOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaysActive = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Careers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fa179ce-5674-420e-a94d-213db4029023", "AQAAAAEAACcQAAAAEEUbUd7BppMI2ZPzJlQBeuZobqRWQ3dWBjyTmmW44I26SJJ0MxOUbqJib83yhJJk4Q==", "cff4282a-ae46-4b88-b97a-2446fe3762a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f6ddc19-7414-4465-bd64-6bc64c3d4fe7", "AQAAAAEAACcQAAAAEEcBs1lLW1iF+n1BpVbvglNDkXsLWKLlSxgdcaLin2FpdIiQZsMDKab8LvJALnApsQ==", "cf61524d-64e5-464d-a718-c150017b7c8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab68c873-7692-4850-aa4f-34217c1bfc89", "AQAAAAEAACcQAAAAEKT1N2NbohOk3iURjW1rDNQ8Ux9nXG6eEaNfmLwCvdFI1cc49yQgGjS47r4/vXH/SQ==", "00681ad4-8c31-47b1-844a-25f5e1d4999d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "051b044e-daf5-4e3b-bded-7d8912e58768", "AQAAAAEAACcQAAAAEGc1AH8GFLI+D0eCUaYqXdhGKSns29x7FL4/utZzUngWrPyJBrDihPIlI1ld0p9/Uw==", "8292ff23-0d5f-40e7-8846-b991fa906370" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ae6e628-4bc2-4840-8c55-0a0522048c2f", "AQAAAAEAACcQAAAAEFPRUIVCJj6vEpEFWAQhcB6a05h8bNpzqfp+EQw4GBQA19xE35FGkpWEdXr+lCxRGw==", "2b068318-ab8d-47e0-9668-17884ac272c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d26684b3-19b1-4e59-9bf4-8d7c331e655d", "AQAAAAEAACcQAAAAENgKEA85drrHgQ/exigD/0TqQsfpr5Hwuc1ZG2tzoYLrgZPwA6YdLbDqNyV7QqWSAQ==", "203afb6c-1dbc-434d-af57-376824114dce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afa54c68-53f6-4d17-8880-fe9f927a12c0", "AQAAAAEAACcQAAAAELGhyBA27k73SaWLod011aKkQsC+siSA+cKftDB7o2Z0B6XJDjepuaQ4P5o3rliqzA==", "16dc90fd-5cc9-4fe1-ac97-0f03d19fe2cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa941bd5-7ca2-4d1b-ad71-5716ab7c0887", "AQAAAAEAACcQAAAAEPf9YvR8c3z45C9NdAkRyhhm6y3e56DKxuW/ejjC8MXM5G2c7DYtgladKxCaJMSQAA==", "00bbb176-c42e-4fdb-a27f-50c184af68f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d4695d4-16a7-4984-8250-3a9968caf003", "AQAAAAEAACcQAAAAEADQOXSDrBnmtG4O97oioBnce8JROOnLVBQgX2VWyK/WEgIf0/FHoD3WRxODtPxMUA==", "8e4bf594-9ed7-42fa-85d4-c90d57c6925d" });

            migrationBuilder.InsertData(
                table: "Careers",
                columns: new[] { "Id", "DataOpen", "DaysActive", "Description", "PositionId", "Qualifications", "Title" },
                values: new object[] { 1, new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "1. Извършва подготвителни операции и монтаж на различни електрически инсталации. Следи за изправността, профилактиката и ремонта на електрическите мрежи, машини и съоръжения в сградите на работодателя.\r\nТрудови задачи и задължения, характеризиращи описанието на длъжността:\r\n2. Извършва монтаж и свързване на различни електрически табла;\r\n3. Извършва монтаж на елементите на електрообзавеждането или електро задвижването на производствени схеми;\r\n4. Следи за изправността на електрическите мрежи ,машини и съоръжения и определя необходимостта от ремонт.\r\n5. Прави профилактични проверка на техническото състояние на електрическите мрежи, машини и съоръжения.\r\n6. Извършва необходимият ремонт на електрическите мрежи, машини и съоръжения и отстранява технически повреди;\r\n7. Следи за правното прилагане на правилата за заземителните и гръмоотводните инсталации.\r\n8. Следи за изправността на измервателната техника .\r\n9. При необходимост изпълнява и други задачи, възложени във връзка с изпълнение на длъжността.", 3, " Завършено висше/ средно образование с профил електротехника, електроенергетика и електрообзавеждане или автоматизация\r\n∙ Минимум 2 години опит по специалността в производствено предприятие", "Електротехник" });

            migrationBuilder.CreateIndex(
                name: "IX_Careers_PositionId",
                table: "Careers",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d051b546-e1b2-49b6-b9da-0d0d83b52ece", "AQAAAAEAACcQAAAAEHKkpNO/QqqLthBKSrmlINlPQzu0LAUlchznhiHjCPhU5m045QrzKa7zDNfgE3/S5Q==", "cd196bf3-d000-4d46-a4b2-10a39fcc606a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab06e0f7-3572-4113-8fad-15c51c391df2", "AQAAAAEAACcQAAAAEMlObOxz6Rwud0ySdnLtQeHDT3Om2XU1VB+gU872BtNAdshlkVEYpkZvLWu1Ugti+A==", "e168155b-be80-4863-b18f-4244912750ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbab96c7-5cda-49a3-bf17-70b0aeac45b4", "AQAAAAEAACcQAAAAEFVJXyF6lBIqbn1FCaE5jOp5c/55vwUzxigkGYxcswwt9Ox4ESUQey2bwfum4AVmoA==", "9b0ea831-c6a2-437b-b3a3-08d62591201f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee4eb4d2-a0c9-4a24-a516-29d1e925ead4", "AQAAAAEAACcQAAAAECPvOt4xO50cVj4vEdcaOV2tAjDiL5TZCM2ggiBASK0PonZqtskO+gReWSdn7pGvRA==", "f21af4d8-95d7-4127-a62e-444daf61b099" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7441ce9a-3b03-4aab-becd-7edad727c7c9", "AQAAAAEAACcQAAAAEAcbG4wCbwsLHiBeYts3VSYeuIsQtOYda19FxBfdb64V8BF1mkBr8cTB+79/MJ2ZYg==", "7dd409b1-03b6-4e5b-a6ae-7d835edff667" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3537f166-87c0-4127-bf60-e76331a2d1c1", "AQAAAAEAACcQAAAAEEcD3cz/P32Kz3yUQ4TEkRTpNvAClqTBr9sRy6ofBtoeYIl6EyggCjAmkAFxNFJtLw==", "d4b15b7e-eca8-4b56-a34b-decf40f8c4c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f6f30de-9193-4399-a191-ce2ed09777af", "AQAAAAEAACcQAAAAEKfpc3cQ2UTdSUVRH3/9iVIurCDf+auCj8i+0FG81+qbbWUphTGUkVF7QcOa7Ce0QA==", "3d946831-7b50-431d-aeab-f01338fa705d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89e96f92-3dfb-40fa-86cc-64f181cda54a", "AQAAAAEAACcQAAAAELCMHrSoSFUa7jmguER+yMp0nGMiw5nr99O7axKDhTq2nDC4aQE2cD+U7WzKSRpxOA==", "313d52cc-41ac-4570-b045-c28f964daa1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf822f91-3249-46f7-bedd-6fe02fbf098e", "AQAAAAEAACcQAAAAEFVbPE1Zhw3qI+0JW7JXNKa/EY1Sp4S+JZvAx/LSWR/ieb9FD8iwmOy+XLrzQipX4A==", "64f44e26-8b7a-490a-968d-f6481d912678" });
        }
    }
}
