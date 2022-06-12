using Microsoft.EntityFrameworkCore.Migrations;

namespace homeeduTest.Migrations
{
    public partial class addCourseCardsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_courseDetails",
                table: "courseDetails");

            migrationBuilder.RenameTable(
                name: "courseDetails",
                newName: "CourseDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseDetails",
                table: "CourseDetails",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CourseCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    CardTitle = table.Column<string>(nullable: true),
                    CardDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseDetails",
                table: "CourseDetails");

            migrationBuilder.RenameTable(
                name: "CourseDetails",
                newName: "courseDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courseDetails",
                table: "courseDetails",
                column: "Id");
        }
    }
}
