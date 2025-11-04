using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppraisalAppV1.Migrations
{
    /// <inheritdoc />
    public partial class AddApprovalWorkflowFinalFixedAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AppraiseeNumber",
                table: "Appraisals",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ApprovalStatusId",
                table: "Appraisals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubmitterId",
                table: "Appraisals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApprovalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalStages = table.Column<int>(type: "int", nullable: false),
                    CurrentStage = table.Column<int>(type: "int", nullable: false),
                    CurrentActionerUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_AppraiseeNumber",
                table: "Appraisals",
                column: "AppraiseeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_ApprovalStatusId",
                table: "Appraisals",
                column: "ApprovalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_SubmitterId",
                table: "Appraisals",
                column: "SubmitterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appraisals_ApprovalStatus_ApprovalStatusId",
                table: "Appraisals",
                column: "ApprovalStatusId",
                principalTable: "ApprovalStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appraisals_Employees_AppraiseeNumber",
                table: "Appraisals",
                column: "AppraiseeNumber",
                principalTable: "Employees",
                principalColumn: "AppraiseeNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Appraisals_Users_SubmitterId",
                table: "Appraisals",
                column: "SubmitterId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appraisals_ApprovalStatus_ApprovalStatusId",
                table: "Appraisals");

            migrationBuilder.DropForeignKey(
                name: "FK_Appraisals_Employees_AppraiseeNumber",
                table: "Appraisals");

            migrationBuilder.DropForeignKey(
                name: "FK_Appraisals_Users_SubmitterId",
                table: "Appraisals");

            migrationBuilder.DropTable(
                name: "ApprovalStatus");

            migrationBuilder.DropIndex(
                name: "IX_Appraisals_AppraiseeNumber",
                table: "Appraisals");

            migrationBuilder.DropIndex(
                name: "IX_Appraisals_ApprovalStatusId",
                table: "Appraisals");

            migrationBuilder.DropIndex(
                name: "IX_Appraisals_SubmitterId",
                table: "Appraisals");

            migrationBuilder.DropColumn(
                name: "ApprovalStatusId",
                table: "Appraisals");

            migrationBuilder.DropColumn(
                name: "SubmitterId",
                table: "Appraisals");

            migrationBuilder.AlterColumn<string>(
                name: "AppraiseeNumber",
                table: "Appraisals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
