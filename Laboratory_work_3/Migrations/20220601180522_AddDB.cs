using Microsoft.EntityFrameworkCore.Migrations;

namespace Laboratory_work_3.Migrations
{
    public partial class AddDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    ComputerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Processor = table.Column<int>(type: "INTEGER", nullable: false),
                    VideoCard = table.Column<int>(type: "INTEGER", nullable: false),
                    RamMemory = table.Column<int>(type: "INTEGER", nullable: false),
                    SSD = table.Column<int>(type: "INTEGER", nullable: false),
                    Cooling = table.Column<int>(type: "INTEGER", nullable: false),
                    Motherboard = table.Column<int>(type: "INTEGER", nullable: false),
                    PowerSupply = table.Column<int>(type: "INTEGER", nullable: false),
                    Body = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.ComputerId);
                });

            migrationBuilder.CreateTable(
                name: "Gamers",
                columns: table => new
                {
                    GamerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Satiety = table.Column<int>(type: "INTEGER", nullable: false),
                    Fatigue = table.Column<int>(type: "INTEGER", nullable: false),
                    Money = table.Column<int>(type: "INTEGER", nullable: false),
                    Day = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamers", x => x.GamerId);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Wages = table.Column<int>(type: "INTEGER", nullable: false),
                    Minqualifications = table.Column<double>(type: "REAL", nullable: false),
                    Experience = table.Column<int>(type: "INTEGER", nullable: false),
                    UpExperience = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Gamers");

            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
