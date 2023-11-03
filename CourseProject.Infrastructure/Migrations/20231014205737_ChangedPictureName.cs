using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPictureName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Users",
                newName: "ProfilePicture");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "Users",
                newName: "Image");
        }
    }
}
