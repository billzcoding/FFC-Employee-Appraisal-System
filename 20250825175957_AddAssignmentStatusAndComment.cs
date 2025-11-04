using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppraisalAppV1.Migrations
{
    /// <inheritdoc />
    public partial class AddAssignmentStatusAndComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReviewerComment",
                table: "AppraisalAssignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AppraisalAssignments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewerComment",
                table: "AppraisalAssignments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AppraisalAssignments");
        }
    }
}
