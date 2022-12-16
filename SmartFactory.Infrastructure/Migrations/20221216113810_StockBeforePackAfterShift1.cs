using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFactory.Infrastructure.Migrations
{
    public partial class StockBeforePackAfterShift1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockAfterShift",
                table: "Productions",
                newName: "StockBeforePackingAfterShift");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d745d10a-7492-4865-89a9-965e9cf7ce1e", "AQAAAAEAACcQAAAAEAThc5K8zihk2iGEozrAvmaaVlgsa8as0jvJTr2XfJD+fp4FYToR4homDvnwerOvIw==", "28363eb4-379b-4719-99a7-b548a91f5303" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cb202d-9873-432c-b049-f9184c3ce525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e560f06-fdfb-4f74-b949-520a74aa22c9", "AQAAAAEAACcQAAAAEPPQCalVEJbwgSlkMSQ9xrcJ4uRJiGt4InYorzm8Ub4FWAKNEX01kT9AauPD23wSRg==", "c06a650a-a750-453e-8047-b1d29667579d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58434ec1-2216-4b26-869e-94db0c1f7d09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c070813-23d4-456d-b368-b277d7839468", "AQAAAAEAACcQAAAAEHQ6kikR42L8ICKW05l1FDDCzAkuDB1VcqPZMKjdED+44zZkcWkvqx75gZseLrCF/w==", "2bf3e0e0-37b8-4bce-8d81-be23ec81eddb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a268d0-e995-41a0-a640-f9defb7f6f85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e20aa8cd-23c6-4107-a52b-cd02d2938986", "AQAAAAEAACcQAAAAEAm4Lt92BUjFAtnjUL3B3jJvf0WAkMSphtgH+Jo9IJvay9xJwJHlgBLSh4yTSV46bw==", "962d3069-d454-4b6b-acf0-c5b5e07555fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73257cc1-87f3-4d92-bd78-567a98bd6827", "AQAAAAEAACcQAAAAELpuur7hKC6yKyW6CGKxvWCNqjOgumDqPiMv9dKdzl2ySKn+N63KODcrHTtuoxBYXw==", "d92fadaa-11c4-45db-9e6e-8029781216b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f1c3c61-b623-4f49-8101-c3047734162d", "AQAAAAEAACcQAAAAEMIBuxJi4qt/iVvaPbQHGmAOF8I6TemA5Xgytjt2lnGhccDaGd62qLTq4I3lioxH1w==", "6f15560a-329a-4370-8026-bec5e4034912" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5effd064-6624-4e5d-99f9-6716d35f155d", "AQAAAAEAACcQAAAAEPAPYy7UCJSv9wREBHSixExe/N3VcXUYrPKHfYqS6buxrUPug4gouLk0vRiSD1W6Vg==", "49240ded-a2bf-470d-a7c6-d1df54cc9831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f8a2025-1862-4569-9299-907ec6332527", "AQAAAAEAACcQAAAAEFCH9HN0AO7e1GO79WgQxWBP7KTy5/tThkuR/iRjJ0Jgpinj4wUdOFD1pKYyb9ed8A==", "8c31b710-254f-46c8-a710-91e955348bb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67d4f84c-9a4c-4eb5-821f-0f019db820fd", "AQAAAAEAACcQAAAAEND9g7aCSPaD2o77jNM/SOhtyMrhIY/h6fyRoysSsAUnArC1yRFQzOgxWOSWKfqObw==", "479be9ea-a4f0-4931-b2ee-3801e8ebfcd8" });
        }
    }
}
