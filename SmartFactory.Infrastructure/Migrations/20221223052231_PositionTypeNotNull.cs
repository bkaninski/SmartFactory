using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFactory.Infrastructure.Migrations
{
    public partial class PositionTypeNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PositionType",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 3,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "66774e50-dbd0-48de-807a-a6eeb8f34c80", "AQAAAAEAACcQAAAAEHClbbgctQFjHifnWanC1RN3c5Zjdqrba+L88bEiIvkkqgf3lQTIafCScVuvYikxkg==", "5b824979-26b7-40f1-809d-88c0bac317b4" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "fbdd05c0-90c0-46e7-8762-33d7c167805c", "AQAAAAEAACcQAAAAEC1qJU9Y9vPbESbCEVQ4RIctb9l2odSga48xQZk6KLK9sjFdT/lPU6FXv4JnqVxAsQ==", "987d830f-5989-4694-a502-21b8dd960f3a" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "1beddf79-a198-4174-9ca9-0fb28a25af37", "AQAAAAEAACcQAAAAEJ7cEYZjspiSiUKALAtabTqwyWgQz4MuAYwP1s5+tbJTjRGm4t3KoM7BBdHQ78WXFg==", "efe526a3-6a7c-4c65-a824-02fa72d1b4a2" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "0734feaa-efda-4105-9189-872462ecf4ca", "AQAAAAEAACcQAAAAEBQQfVzUGxnO5ChZnIOg9nxktok6Rdw0TfaMh5eC5h63CcFkd1Kh6RffhvmNi4Xf3g==", "4cefb68c-8d53-49f0-8903-b08c4a772ee5" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "fca71d16-57a6-4cef-bac9-8c0a0515ae88", "AQAAAAEAACcQAAAAEDS1pw/YSmphTQRm8pngIBKS3ZI7TUayEvqKwEZBmc5lRZbF76Kd7lS9JWiGUpZ3ew==", "93c0cd28-e99c-427c-9aec-17135c22fc73" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "270f21c3-02db-4fd5-b6bb-5b03eec58a4f", "AQAAAAEAACcQAAAAEAt6YSVPAhlC+/jn6I4z+rvlb4MWtVXizNRbK20KJqbZPMwhmex1WLgwLjOy1M60HA==", "9acc92f2-929b-4996-b6d5-dad5cbcdf10e" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "d37dc1cd-0625-4751-b63e-b49338943262", "AQAAAAEAACcQAAAAEE2qgmHBCc9x1aiQtMuegsnAoo4uCKcnKVAJpgWaI9uZ5QbqEDh8uDeMM+et/xXvZQ==", "8a59a02e-c99e-4f6e-8ed0-3a81d4b9fe0b" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "25481391-218d-4008-b3c0-9ff197f1bfc6", "AQAAAAEAACcQAAAAEIWljLjKeKFgp+qzsMW29iaVP1nBbE5DqklkCn1rX/yNijIghtCfMsW8lmeOBjnGcQ==", "5ffdbe69-bd11-4c21-8bfe-d3366d9c0c5f" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "9bd9bd80-ebf8-4278-8c41-da344869f298", "AQAAAAEAACcQAAAAEABTddQXo6MHUQTu/ljDvieSBXeGQfRBvbVYb2V6RzurZQp1gNXu5DI/wieYQIYVOg==", "da76ab53-0dcf-4716-b509-b299b84ca269" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PositionType",
                table: "Positions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c36e67e-1170-455e-8581-c0e5638e9ca3", "AQAAAAEAACcQAAAAENSyhuf2OmzNcJJwyozMHs9BSKiZ/lc5y6R57pTLOgDnPKZIsnGIcicoUdTAznkL9Q==", "9369e810-003e-43f6-bdce-a4e8c9f33dd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce069347-9b2c-4aaa-9a92-455120c7e83b", "AQAAAAEAACcQAAAAEBtfJhgUYh0zdezNitb1ANNgbyZdflREIuopuqFVFeVPuUXqgE+hed3WT8zjezKX8Q==", "081e31ab-3ad2-448b-984e-eabaf3fe8b3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0af1ea51-03c7-4b9f-9dd4-535ed852942b", "AQAAAAEAACcQAAAAENWVO6eOiScjwsuIba+pcbOHrZVF5Trkr/c2FV4XB7iR8ZDCO1YE0bPK0uUlEDTFkw==", "1fcaa19c-2e48-4add-9f45-4c184bcd3661" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "274ceba5-5755-49fc-847d-f4ab9c79ce91", "AQAAAAEAACcQAAAAEPa0KI6G+sTG5sLl8ePZTJUAEmF+jVeb/lj+NavN3N028NYt00vCHzFeIAMpieSOCQ==", "d2b4fc06-3a78-4270-82fd-a0b91e072254" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "973c17d3-5064-4311-9941-8cfc32e30d05", "AQAAAAEAACcQAAAAED2Sstx7CHnjDqXBwRNR4ljDIXmGnG5noueG8eCVFraG8wcnguroNNfm3nE+frtVww==", "5dc84768-6d06-4417-a3c8-4fac57f77197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67b467de-5b90-4367-b863-460bf09f125c", "AQAAAAEAACcQAAAAEHFenQWgXmO/cgDiaZQK7pgscsUPvk8dDAvyddvmhbLkJvWpGPkxBvdQJ04jkKXA2A==", "43fe17ec-1b7f-440c-be7d-ed48e3fa2011" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02df4620-aa69-4b86-adef-6607f2976d82", "AQAAAAEAACcQAAAAEOdV8JkCG5PHHZVJEJOzNDhGBYe0ruUsj5Di36Ronp8CxNZRa6kLi+eHnXUDoYc+GA==", "76731577-5d1e-4157-9527-efc9f4dd117f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0cebea5-060f-4fe2-b277-cf02a771caf1", "AQAAAAEAACcQAAAAEDXWpduTM8l+vEfXTV2mck30m1QKbc4/QB2DRXvtXdcURbPfoojzJauFrM3OFZYuYg==", "a8913614-b486-4774-94ff-35a4fd398d7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "573218a9-92c8-4170-88ba-d801f7344ce6", "AQAAAAEAACcQAAAAEPskH0YkNBnk4jlxBJPfruutPntZBe5q6f9laoBkCEEfRCPjwTFBU2j41Bxu9USrTw==", "672060ee-6fae-4fe3-8a80-981213d5951f" });
        }
    }
}
