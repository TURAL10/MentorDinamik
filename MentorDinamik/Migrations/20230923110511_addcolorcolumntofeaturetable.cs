using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorDinamik.Migrations
{
    public partial class addcolorcolumntofeaturetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Features");
        }
    }
}
