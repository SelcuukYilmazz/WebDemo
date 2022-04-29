using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDemo.Migrations
{
    public partial class SixthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Choice1_1",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice1_2",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice1_3",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice1_4",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice2_1",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice2_2",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice2_3",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice2_4",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice3_1",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice3_2",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice3_3",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice3_4",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice4_1",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice4_2",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice4_3",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Choice4_4",
                table: "Quiz",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Choice1_1",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice1_2",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice1_3",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice1_4",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice2_1",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice2_2",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice2_3",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice2_4",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice3_1",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice3_2",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice3_3",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice3_4",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice4_1",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice4_2",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice4_3",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Choice4_4",
                table: "Quiz");
        }
    }
}
