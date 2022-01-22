using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlamningDatabas.Migrations
{
    public partial class RemovedUnusedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ErrandId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ErrandId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
