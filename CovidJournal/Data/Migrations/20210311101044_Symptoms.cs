using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidJournal.Data.Migrations
{
    public partial class Symptoms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SymptomsId",
                table: "CovidEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    SymptomsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Headache = table.Column<bool>(type: "bit", nullable: false),
                    Cough = table.Column<bool>(type: "bit", nullable: false),
                    Lack_of_Smell = table.Column<bool>(type: "bit", nullable: false),
                    Lack_of_Taste = table.Column<bool>(type: "bit", nullable: false),
                    Fever = table.Column<bool>(type: "bit", nullable: false),
                    Chills = table.Column<bool>(type: "bit", nullable: false),
                    Breathlessness = table.Column<bool>(type: "bit", nullable: false),
                    Fatigue = table.Column<bool>(type: "bit", nullable: false),
                    Sore_Throat = table.Column<bool>(type: "bit", nullable: false),
                    Nausea = table.Column<bool>(type: "bit", nullable: false),
                    Diarrhea = table.Column<bool>(type: "bit", nullable: false),
                    Chest_Pressure = table.Column<bool>(type: "bit", nullable: false),
                    Pale_Blue_Skin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.SymptomsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropColumn(
                name: "SymptomsId",
                table: "CovidEntry");
        }
    }
}
