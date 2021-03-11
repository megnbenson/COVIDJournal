using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidJournal.Data.Migrations
{
    public partial class ModifiedSymptomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

           
        }
    }
}
