using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogNest.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "203f864c-6a4a-4584-a2cc-d302caa7990f", "203f864c-6a4a-4584-a2cc-d302caa7990f", "Admin", "Admin" },
                    { "c40acc69-73bf-4be7-b47d-d6c83c591986", "c40acc69-73bf-4be7-b47d-d6c83c591986", "User", "User" },
                    { "e73de0dc-0eb3-43a8-9529-48769cc74910", "e73de0dc-0eb3-43a8-9529-48769cc74910", "SuperAdmin", "SuperAdmin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "149081ed-9659-4c49-b222-bbbafd920060",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "746e113a-09be-4c1a-9874-1f681d91bc86", "AQAAAAIAAYagAAAAELjXevok0lNIZr86LxbPV9PDen2Jte7X4ghi/rWH3DxdS0b9tYrryw9h9R9vyWxouw==", "c182d8e6-2dec-4a94-ae88-7e659d131e63" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "203f864c-6a4a-4584-a2cc-d302caa7990f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c40acc69-73bf-4be7-b47d-d6c83c591986");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e73de0dc-0eb3-43a8-9529-48769cc74910");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "149081ed-9659-4c49-b222-bbbafd920060",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01dc85c2-518a-436d-b45a-8f814994bc5b", "AQAAAAIAAYagAAAAEL8CiYORUl+/LrTzeDmXp2trD6mcPBU1baaL8Q6/iWkHiUrgUp6xbls0K7cAqHbWqg==", "fcc40b47-ab79-422d-8697-2aaacd197b51" });
        }
    }
}
