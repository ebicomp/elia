using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EliaGroup.API.Migrations
{
    /// <inheritdoc />
    public partial class seedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17d35459-b5b8-4ac2-90c8-f3161035524d", 0, "17fce683-7bf2-4848-bf6b-5e867d39c918", "admin@elia.com", false, "admin", "McCartey", false, null, "ADMIN@ELIA.COM", null, "AQAAAAIAAYagAAAAEGeMgccFlsrqzoYPgtNYAnVY8levzy/dacWwnaipwe2sNU1uoBUPLLOkFVFFCNeiGA==", null, false, "0fb75ce8-48ba-4b71-a819-5b9e244a2aaa", false, "admin@bookstore.com" },
                    { "56fa0eef-e65b-49c3-8cca-080b27774a67", 0, "ec30126e-1006-439c-b89b-a4bbdfcb05a6", "user@elia.com", false, "user", "McCartey", false, null, "USER@ELIA.COM", null, "AQAAAAIAAYagAAAAEHnEblhtgiQye9xRDkpZpdkN9HwjPXEU24UOeHw18rnj8iIQmA4s3PQFTsgvU7un2A==", null, false, "c73200b5-a9b8-40f3-8246-6280892e8691", false, "user@Elia.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "575b0447-b092-4397-a528-22e400fd0718", "17d35459-b5b8-4ac2-90c8-f3161035524d" },
                    { "5b12f593-4697-4f2a-afad-9524f894cefd", "56fa0eef-e65b-49c3-8cca-080b27774a67" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "575b0447-b092-4397-a528-22e400fd0718", "17d35459-b5b8-4ac2-90c8-f3161035524d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b12f593-4697-4f2a-afad-9524f894cefd", "56fa0eef-e65b-49c3-8cca-080b27774a67" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17d35459-b5b8-4ac2-90c8-f3161035524d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56fa0eef-e65b-49c3-8cca-080b27774a67");
        }
    }
}
