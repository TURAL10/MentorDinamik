using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorDinamik.Migrations
{
    public partial class addcoursetrainertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Courses_CourseId",
                table: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_CourseId",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Trainers");

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreinerId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TrainerId",
                table: "Courses",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Trainers_TrainerId",
                table: "Courses",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Trainers_TrainerId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TrainerId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TreinerId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Trainers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_CourseId",
                table: "Trainers",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Courses_CourseId",
                table: "Trainers",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
