using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFactory.Infrastructure.Migrations
{
    public partial class StockBeforePackAfterShift11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockAfterShift",
                table: "Productions",
                newName: "AfterShiftBufer");

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "3f4b164b-71da-45f9-8c56-41b5219a45de", "AQAAAAEAACcQAAAAEE8CUxl6BBdsmnaJWYdl181re0OR/AFFEh+pm6L52Tutw/BOMz9ZzYHMJBtetZcUOg==", "0ae3d4cf-4aee-4ea7-9cce-79ca8286b0ee" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "466387c1-8bf2-4b56-af5c-56b29592618e", "AQAAAAEAACcQAAAAEKu92/ncM1PR3FnQvasIkVcCa7dCQez5/E7n7aZJuZ1iPv1qzF/rRJTrqtCSvECV1w==", "24d7ad61-80d0-4606-a02d-f4e3ca90d44f" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "86f98fd2-b001-4628-8821-8e2c850517a7", "AQAAAAEAACcQAAAAEOkJM4IDV90+/Qed+E0oRtdS4HR9VKPTy6EwaCAFZDonHnDsYeahXRZPZ9ytJIJ3dA==", "1de4e619-dbc3-4a57-b1db-f6990cfe2109" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "512d96d7-7c88-490f-b589-985365f017e9", "AQAAAAEAACcQAAAAEDyc3YvBFRI7EvRFGfrCY7Kl4lSGBwashnl0TUwb0U/GXtLtg+ZRwwh26t7xj9LEFA==", "a38b8a87-a51c-489b-9bdb-3de2d35b23f0" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "31585798-04ff-495f-b86d-465cc3abd71d", "AQAAAAEAACcQAAAAEA8QKVoktT5nSprvnEMgsDN/ZK7Z2m65IqkVbo8En25GYcKTTUpAlKqGMF/mUOPQuA==", "3d0bb8b9-2be2-4f2a-80db-bad137c9865c" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "7f7b11f5-bdda-4a67-bb04-e4db682a597e", "AQAAAAEAACcQAAAAEMrj9JmG82+5wnGpifBSTmG/REysG/VDtxY/i0duF9Zjl+E8Dmc7j3RfwSlOLkiKlQ==", "6c361fbe-4ae3-4898-875c-810cc747c2e1" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "65fc8975-8885-41c9-b2e4-97158d992175", "AQAAAAEAACcQAAAAEMQYAwC8/xZc2ClpbCxgiS825FxRrgMw8p7QlZvXrPhj79B55eJ9V1BwJKREiP2pNg==", "f80025f8-f587-4288-a47a-33b004963cc6" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "6041ac7f-6a6f-434d-a0f9-12f3b7d73642", "AQAAAAEAACcQAAAAEB4eaiDo+lo9PjDfKLakHDbThqw91cQvwqhX+/uevR72P0zhydPw0kQw/Tx3PpH9fg==", "6fecf333-54d2-4344-9112-9039f3740bd3" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "009eec0b-721a-4653-b365-f52becce6edb", "AQAAAAEAACcQAAAAEJke8vi0JBkm25uJGBc+zLyM3BCEsw8tNJkOtH9pBLsiRG5qA5PZWbjDlvmHDJyM8Q==", "e5a52845-f928-49e0-bf3c-aeeeed467619" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AfterShiftBufer",
                table: "Productions",
                newName: "StockAfterShift");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b86a5a82-ba6d-417a-a215-4853e110cd78", "AQAAAAEAACcQAAAAEFeK/LvTqErsXT1xeWLH/U0zfSn+vugQJv56aM9wL/0qLQPONbobQ9zRVdS0wcnTCw==", "3c94deab-6ab3-404e-a95d-7a4077cc3730" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d920a19b-6e53-4fac-8fc1-df92593ec3ea", "AQAAAAEAACcQAAAAEMCXvMMK61Egeihgiyrt3jzU/YwSP5htJMgGMsL4Mp5GGUA+JGf3veyGtG27yUzxWA==", "6bc9c410-5403-4a1b-ae91-edeca1a5be92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d15e33cc-92f0-4660-afc0-cba998dce383", "AQAAAAEAACcQAAAAENCYRXCTQqsmU+5juxZFiFjERog8DoXtFDLhqlfEuX5GDDJC3bz5Sc0k/bGSHxKXEg==", "757f4a72-3e54-4757-a487-e3a6b7f35c42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "533fd5a9-e4de-46d0-964e-315686a82f9e", "AQAAAAEAACcQAAAAENHj3sUT1qF4XMDxs5JQKHO9QIvptoLKX28pFdKqParexjtVPvRo9ScyaAPq+rD66g==", "f000c7c0-c6b1-4a4d-9811-c71bd536995e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c568e2e-4470-4700-965a-47a3ee1a4d65", "AQAAAAEAACcQAAAAEMPw0hkoYszaNcZqHRO1O+2VI8fr4g9dAQZFXzevHlfzso0tKSSDMxF6R9H6iSzWuQ==", "2605af5b-ab87-48ed-8aab-5d4a3d906326" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd220a37-0f93-475a-89c1-74ab95a3a924", "AQAAAAEAACcQAAAAEPQgEv9mKQHxNTyyKstRY4bb/fSagJYaAulSLJfqPUa/+E1YhKlnfk/zJAp7zspeVw==", "c80fc814-7359-4087-a8dc-5a434af05b5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55823389-9482-4186-86ff-3996cabdfe59", "AQAAAAEAACcQAAAAEF4T/g2/Va1D1/NkdkMr+kRuXAUtD6+TXg3virFGldulVSzFm336Vw5Tq+FXjCkqNg==", "9195fd87-2271-46e7-b710-6756d8cf3413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c60fdbf-db6c-4274-ab9e-02ba3ae8ca81", "AQAAAAEAACcQAAAAEEWcMeERgEfOGHOPlOtPz80cbgvH/b/iLk6Cg8CBDJo738oYTO/jcUB3GNJdLBFVGQ==", "ca14ed94-0f54-4c74-be38-82694edfe0d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d86405e2-5a39-4b67-9452-3a2b7652c4c3", "AQAAAAEAACcQAAAAEA9OtmBoekseMN82lJgmz3oR+1DLIraHeInKZN8rMsvU4pNHewcf77s2EQr46hjWBw==", "49c185e5-1755-4aa2-ac1a-70903091ddbc" });
        }
    }
}
