using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppraisalAppV1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Appraisals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppraiseeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppraisalYear = table.Column<int>(type: "int", nullable: true),
                    PeriodCoveredFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainTrainingAssignment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingPlanned = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobKnowledge = table.Column<double>(type: "float", nullable: true),
                    QualityOfWork = table.Column<double>(type: "float", nullable: true),
                    Creativity = table.Column<double>(type: "float", nullable: true),
                    Initiative = table.Column<double>(type: "float", nullable: true),
                    SelfDevelopment = table.Column<double>(type: "float", nullable: true),
                    OrganizingWork = table.Column<double>(type: "float", nullable: true),
                    QuantityOfWork = table.Column<double>(type: "float", nullable: true),
                    AnalyticalAbility = table.Column<double>(type: "float", nullable: true),
                    Dependability = table.Column<double>(type: "float", nullable: true),
                    RelationshipSenior = table.Column<double>(type: "float", nullable: true),
                    WorkingUnderPressure = table.Column<double>(type: "float", nullable: true),
                    Communication = table.Column<double>(type: "float", nullable: true),
                    RelationshipJunior = table.Column<double>(type: "float", nullable: true),
                    SafetyConsciousness = table.Column<double>(type: "float", nullable: true),
                    Leadership = table.Column<double>(type: "float", nullable: true),
                    NewIdeas = table.Column<double>(type: "float", nullable: true),
                    Judgement = table.Column<double>(type: "float", nullable: true),
                    CompanyPhilosophy = table.Column<double>(type: "float", nullable: true),
                    ProblemAnalysis = table.Column<double>(type: "float", nullable: true),
                    CumulativeWeightage = table.Column<double>(type: "float", nullable: true),
                    Ranking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachmentFilePaths = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAppraiseeNumber = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appraisals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appraisals_Employees_EmployeeAppraiseeNumber",
                        column: x => x.EmployeeAppraiseeNumber,
                        principalTable: "Employees",
                        principalColumn: "AppraiseeNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_EmployeeAppraiseeNumber",
                table: "Appraisals",
                column: "EmployeeAppraiseeNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appraisals");
        }
    }
}
