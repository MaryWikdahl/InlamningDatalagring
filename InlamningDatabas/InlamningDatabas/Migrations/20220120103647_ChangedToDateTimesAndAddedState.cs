using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlamningDatabas.Migrations
{
    public partial class ChangedToDateTimesAndAddedState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Update",
                table: "Errands",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Todaysdate",
                table: "Errands",
                newName: "UpdatedTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Errands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Errands");

            migrationBuilder.RenameColumn(
                name: "UpdatedTime",
                table: "Errands",
                newName: "Todaysdate");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Errands",
                newName: "Update");
        }
    }
}
