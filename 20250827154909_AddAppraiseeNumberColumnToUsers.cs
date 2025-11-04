using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppraisalAppV1.Migrations
{
    /// <inheritdoc />
    public partial class AddAppraiseeNumberColumnToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
        name: "AppraiseeNumber",
        table: "Users",
        type: "nvarchar(450)",
        nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
