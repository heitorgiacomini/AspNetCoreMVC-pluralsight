using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreEmpty.Migrations
{
    public partial class NotesAddedOnPie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Pie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 1,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 2,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 3,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 4,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 5,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 6,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 7,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 8,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 9,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 10,
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pie",
                keyColumn: "PieId",
                keyValue: 11,
                column: "Notes",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Pie");
        }
    }
}
