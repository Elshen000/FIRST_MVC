using Microsoft.EntityFrameworkCore.Migrations;

namespace FIRST_MVC.Migrations
{
    public partial class AddSeedDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bios",
                columns: new[] { "Id", "Facebook", "Linkedin", "Logo" },
                values: new object[] { 1, "https://www.facebook.com/", "https://www.linkedin.com/feed/", "logo.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
