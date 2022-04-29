using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDemo.Migrations
{
    public partial class FifthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer1",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer2",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer3",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer4",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer1",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Answer2",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Answer3",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Answer4",
                table: "Quiz");
        }
    }
}
