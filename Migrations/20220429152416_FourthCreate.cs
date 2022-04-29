using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDemo.Migrations
{
    public partial class FourthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Question1 = table.Column<string>(type: "TEXT", nullable: false),
                    Question2 = table.Column<string>(type: "TEXT", nullable: false),
                    Question3 = table.Column<string>(type: "TEXT", nullable: false),
                    Question4 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quiz");
        }
    }
}
