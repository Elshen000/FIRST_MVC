﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FIRST_MVC.Migrations
{
    public partial class AddIsDeactiveColumnToProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeactive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeactive",
                table: "Products");
        }
    }
}
