using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidJournal.Data.Migrations
{
    public partial class ModifiedSymptomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CovidEntry_Symptoms_SymptomsId",
                table: "CovidEntry");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropIndex(
                name: "IX_CovidEntry_SymptomsId",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "SymptomsId",
                table: "CovidEntry");

            migrationBuilder.AddColumn<bool>(
                name: "Breathlessness",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Chest_Pressure",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Chills",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cough",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Diarrhea",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Fatigue",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Fever",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Headache",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Lack_of_Smell",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Lack_of_Taste",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Nausea",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Pale_Blue_Skin",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sore_Throat",
                table: "CovidEntry",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Breathlessness",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Chest_Pressure",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Chills",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Cough",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Diarrhea",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Fatigue",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Fever",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Headache",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Lack_of_Smell",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Lack_of_Taste",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Nausea",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Pale_Blue_Skin",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "Sore_Throat",
                table: "CovidEntry");

            migrationBuilder.AddColumn<int>(
                name: "SymptomsId",
                table: "CovidEntry",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    SymptomsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Breathlessness = table.Column<bool>(type: "bit", nullable: false),
                    Chest_Pressure = table.Column<bool>(type: "bit", nullable: false),
                    Chills = table.Column<bool>(type: "bit", nullable: false),
                    Cough = table.Column<bool>(type: "bit", nullable: false),
                    Diarrhea = table.Column<bool>(type: "bit", nullable: false),
                    Fatigue = table.Column<bool>(type: "bit", nullable: false),
                    Fever = table.Column<bool>(type: "bit", nullable: false),
                    Headache = table.Column<bool>(type: "bit", nullable: false),
                    Lack_of_Smell = table.Column<bool>(type: "bit", nullable: false),
                    Lack_of_Taste = table.Column<bool>(type: "bit", nullable: false),
                    Nausea = table.Column<bool>(type: "bit", nullable: false),
                    Pale_Blue_Skin = table.Column<bool>(type: "bit", nullable: false),
                    Sore_Throat = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.SymptomsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CovidEntry_SymptomsId",
                table: "CovidEntry",
                column: "SymptomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CovidEntry_Symptoms_SymptomsId",
                table: "CovidEntry",
                column: "SymptomsId",
                principalTable: "Symptoms",
                principalColumn: "SymptomsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
