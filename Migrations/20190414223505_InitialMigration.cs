using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_JFink_Final2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distances",
                columns: table => new
                {
                    distanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    driverDistance = table.Column<double>(nullable: false),
                    threeWoodDistance = table.Column<double>(nullable: false),
                    fiveWoodDistance = table.Column<double>(nullable: false),
                    fourIronDistance = table.Column<double>(nullable: false),
                    fiveIronDistance = table.Column<double>(nullable: false),
                    sixIronDistance = table.Column<double>(nullable: false),
                    sevenIronDistance = table.Column<double>(nullable: false),
                    eightIronDistance = table.Column<double>(nullable: false),
                    nineIronDistance = table.Column<double>(nullable: false),
                    pitchingWedgeDistance = table.Column<double>(nullable: false),
                    attackWedgeDistance = table.Column<double>(nullable: false),
                    sandWedgeDistance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distances", x => x.distanceId);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    scoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    numEagles = table.Column<int>(nullable: false),
                    numBirdies = table.Column<int>(nullable: false),
                    numPars = table.Column<int>(nullable: false),
                    numBogeys = table.Column<int>(nullable: false),
                    numDoubleBogeys = table.Column<int>(nullable: false),
                    totalPutts = table.Column<int>(nullable: false),
                    totalScore = table.Column<int>(nullable: false),
                    frontNineScore = table.Column<int>(nullable: false),
                    backNineScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.scoreId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Handicap = table.Column<double>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    myDistancedistanceId = table.Column<int>(nullable: true),
                    myScoresscoreId = table.Column<int>(nullable: true),
                    LeagueManagerMemberID = table.Column<int>(nullable: true),
                    LeagueManagerID = table.Column<int>(nullable: true),
                    NumOfTeams = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_Members_Members_LeagueManagerMemberID",
                        column: x => x.LeagueManagerMemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_Distances_myDistancedistanceId",
                        column: x => x.myDistancedistanceId,
                        principalTable: "Distances",
                        principalColumn: "distanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_Scores_myScoresscoreId",
                        column: x => x.myScoresscoreId,
                        principalTable: "Scores",
                        principalColumn: "scoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_LeagueManagerMemberID",
                table: "Members",
                column: "LeagueManagerMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_myDistancedistanceId",
                table: "Members",
                column: "myDistancedistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_myScoresscoreId",
                table: "Members",
                column: "myScoresscoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Distances");

            migrationBuilder.DropTable(
                name: "Scores");
        }
    }
}
