using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFactory.Infrastructure.Migrations
{
    public partial class AddComentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InWork",
                table: "Shifts");

            migrationBuilder.AddColumn<string>(
                name: "ComentDetails",
                table: "Productions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8124aea5-d0c2-4eb0-ba00-71307957e261", "AQAAAAEAACcQAAAAENPHu2EdwKYuqqbnTEnNw/OGuHcY8/Ga3H+PRwGj7ZX80mWj3r7AcvT1YxZjZUDkow==", "a31a6600-f067-422a-9bf7-bc9ef79c77e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e40cb07-e8ea-4bb1-855f-6e2287ca5296", "AQAAAAEAACcQAAAAEGu7iBSFL06+WJmwQRx4AYCY4XMGCV4i6a8HtxM0F1730LhXu+AtyHUrvOPg6gNSyg==", "08e58f79-5133-4c08-8aba-d9c6b9d9c2c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce26ed11-a6ab-4360-8dea-40f9faf9d3e8", "AQAAAAEAACcQAAAAEK3ZcYsjuIxnkQr6gJ1AFGPuklZYX/x+UnpPTFA+u81AS5bFAnj0EYGn+68bxvzs8A==", "59216a95-055b-40a8-88b6-77bc25fe31c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "732f6043-30a3-4620-9c14-7c5c79dcacc0", "AQAAAAEAACcQAAAAEKcfo3N0QwrJ0fRRESYg7eQxO0cgzowdZVxcQwz1dDMWjn9oSwm27B/WiCqgLYzZ+Q==", "1ea383db-1313-4dbc-a9d1-cb4b5398cc0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac2957e7-162f-47b5-b29a-647579fd1f7f", "AQAAAAEAACcQAAAAEHmLj4e0F83XAuXdywplKwS8A7/GW4IDpw9Z6m5ithTr5XqMCmVahXf8yAjUqv2S+g==", "fbaffdfa-c4b4-4cb3-9c11-ab9fe2bcbacb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15eab5a1-ae01-410d-8bf5-71351d6abbaf", "AQAAAAEAACcQAAAAEKkWMOgo4uLPf6kJrXTZBH8hpr449sOlVG68COpeCWvnP+3pgomUIAEdWY7iM4e+zg==", "345b114e-fd03-4b8c-92d5-4f77e622c2bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8231e3b5-c1fd-4376-8795-86d3354ef882", "AQAAAAEAACcQAAAAECo8B7K3dya6hz+NLwbA5ElR5MJFJ7Bq0kGxWq6CNSCE9KHrZ4FI5kt9eOAqAxt4Vg==", "63c2de2f-c599-4d82-a590-e5b42616c5c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a55881cb-fb97-4b16-9d36-1dfc50c902de", "AQAAAAEAACcQAAAAEGH7yAuz/61QGS5tTj/QqAxzHVct76CIuES+ZbyTYJx5ymGNlelUigH3kRcT4nm8Cw==", "ebfa31f8-80c7-4eca-b497-c30d842c2c7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ac7bb76-37e2-43d5-b329-22f2a495349e", "AQAAAAEAACcQAAAAEGHSVlsG6LmhDSwtEQSOtAJ2n8dLlrhDRVTgW0CuoBj+DXo4TP4aYGfSKaLLfI0/yw==", "a493848e-b6c7-4dfd-a0d7-8eff959a7d66" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComentDetails",
                table: "Productions");

            migrationBuilder.AddColumn<bool>(
                name: "InWork",
                table: "Shifts",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }
    }
}
