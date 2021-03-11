using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidJournal.Data.Migrations
{
    public partial class CustomTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CovidEntry_CovidUser_CovidUserUserId",
                table: "CovidEntry");

            migrationBuilder.DropTable(
                name: "CovidUser");

            migrationBuilder.DropIndex(
                name: "IX_CovidEntry_CovidUserUserId",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "CovidUserUserId",
                table: "CovidEntry");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "CovidEntry",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CovidEntry_ApplicationUserId",
                table: "CovidEntry",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CovidEntry_AspNetUsers_ApplicationUserId",
                table: "CovidEntry",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CovidEntry_AspNetUsers_ApplicationUserId",
                table: "CovidEntry");

            migrationBuilder.DropIndex(
                name: "IX_CovidEntry_ApplicationUserId",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "CovidEntry");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "CovidUserUserId",
                table: "CovidEntry",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CovidUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidUser", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CovidEntry_CovidUserUserId",
                table: "CovidEntry",
                column: "CovidUserUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CovidEntry_CovidUser_CovidUserUserId",
                table: "CovidEntry",
                column: "CovidUserUserId",
                principalTable: "CovidUser",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
