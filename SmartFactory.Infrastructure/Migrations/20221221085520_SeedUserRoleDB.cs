using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFactory.Infrastructure.Migrations
{
    public partial class SeedUserRoleDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a9eb5bf-c65b-4f8d-9d5c-da3d6537683d", "9e2681ea-93fb-448c-8840-e1e982c2573a", "Manager", "Manager" },
                    { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "8c2e01b5-a78d-4187-ba52-357c52228e99", "Operator", "Operator" },
                    { "71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d", "0070bc5f-05e0-4169-bd52-6096e85c0ffe", "Electrical", "Electrical" },
                    { "7eef1923-b5cf-41b5-9ca7-acd1107446a2", "fa2ca1a5-e9d4-4d07-899b-2e8537663382", "factoryManager", "factoryManager" }
                });

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d", "25cb202d-9873-432c-b049-f9184c3ce525" },
                    { "71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d", "58434ec1-2216-4b26-869e-94db0c1f7d09" },
                    { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "64a268d0-e995-41a0-a640-f9defb7f6f85" },
                    { "0a9eb5bf-c65b-4f8d-9d5c-da3d6537683d", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "7e07d5d6-f082-454c-91c4-4c101a91aee0" },
                    { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b" },
                    { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "c77fc444-d5a0-45c2-a576-667a021b6d1f" },
                    { "7eef1923-b5cf-41b5-9ca7-acd1107446a2", "dea12856-c198-4129-b3f3-b893d8395082" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d", "25cb202d-9873-432c-b049-f9184c3ce525" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d", "58434ec1-2216-4b26-869e-94db0c1f7d09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "64a268d0-e995-41a0-a640-f9defb7f6f85" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a9eb5bf-c65b-4f8d-9d5c-da3d6537683d", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "7e07d5d6-f082-454c-91c4-4c101a91aee0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32d1dbb3-e785-47a1-ab5a-982603422fbd", "c77fc444-d5a0-45c2-a576-667a021b6d1f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7eef1923-b5cf-41b5-9ca7-acd1107446a2", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a9eb5bf-c65b-4f8d-9d5c-da3d6537683d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32d1dbb3-e785-47a1-ab5a-982603422fbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eef1923-b5cf-41b5-9ca7-acd1107446a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f4b164b-71da-45f9-8c56-41b5219a45de", "AQAAAAEAACcQAAAAEE8CUxl6BBdsmnaJWYdl181re0OR/AFFEh+pm6L52Tutw/BOMz9ZzYHMJBtetZcUOg==", "0ae3d4cf-4aee-4ea7-9cce-79ca8286b0ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "466387c1-8bf2-4b56-af5c-56b29592618e", "AQAAAAEAACcQAAAAEKu92/ncM1PR3FnQvasIkVcCa7dCQez5/E7n7aZJuZ1iPv1qzF/rRJTrqtCSvECV1w==", "24d7ad61-80d0-4606-a02d-f4e3ca90d44f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86f98fd2-b001-4628-8821-8e2c850517a7", "AQAAAAEAACcQAAAAEOkJM4IDV90+/Qed+E0oRtdS4HR9VKPTy6EwaCAFZDonHnDsYeahXRZPZ9ytJIJ3dA==", "1de4e619-dbc3-4a57-b1db-f6990cfe2109" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "512d96d7-7c88-490f-b589-985365f017e9", "AQAAAAEAACcQAAAAEDyc3YvBFRI7EvRFGfrCY7Kl4lSGBwashnl0TUwb0U/GXtLtg+ZRwwh26t7xj9LEFA==", "a38b8a87-a51c-489b-9bdb-3de2d35b23f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31585798-04ff-495f-b86d-465cc3abd71d", "AQAAAAEAACcQAAAAEA8QKVoktT5nSprvnEMgsDN/ZK7Z2m65IqkVbo8En25GYcKTTUpAlKqGMF/mUOPQuA==", "3d0bb8b9-2be2-4f2a-80db-bad137c9865c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f7b11f5-bdda-4a67-bb04-e4db682a597e", "AQAAAAEAACcQAAAAEMrj9JmG82+5wnGpifBSTmG/REysG/VDtxY/i0duF9Zjl+E8Dmc7j3RfwSlOLkiKlQ==", "6c361fbe-4ae3-4898-875c-810cc747c2e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65fc8975-8885-41c9-b2e4-97158d992175", "AQAAAAEAACcQAAAAEMQYAwC8/xZc2ClpbCxgiS825FxRrgMw8p7QlZvXrPhj79B55eJ9V1BwJKREiP2pNg==", "f80025f8-f587-4288-a47a-33b004963cc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6041ac7f-6a6f-434d-a0f9-12f3b7d73642", "AQAAAAEAACcQAAAAEB4eaiDo+lo9PjDfKLakHDbThqw91cQvwqhX+/uevR72P0zhydPw0kQw/Tx3PpH9fg==", "6fecf333-54d2-4344-9112-9039f3740bd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "009eec0b-721a-4653-b365-f52becce6edb", "AQAAAAEAACcQAAAAEJke8vi0JBkm25uJGBc+zLyM3BCEsw8tNJkOtH9pBLsiRG5qA5PZWbjDlvmHDJyM8Q==", "e5a52845-f928-49e0-bf3c-aeeeed467619" });
        }
    }
}
