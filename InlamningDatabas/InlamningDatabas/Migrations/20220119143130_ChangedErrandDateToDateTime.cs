using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlamningDatabas.Migrations
{
    public partial class ChangedErrandDateToDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Todaysdate",
                table: "Errands");

            migrationBuilder.AddColumn<DateTime>(
                 name: "Todaysdate",
                table: "Errands",
                type: "datetime2",
                nullable: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "Todaysdate",
               table: "Errands");
            migrationBuilder.AddColumn<int>(
                 name: "Todaysdate",
                table: "Errands",
                type: "int",
                nullable: false);
        }
    }
}
