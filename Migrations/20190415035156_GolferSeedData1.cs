using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_JFink_Final2.Migrations
{
    public partial class GolferSeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberID", "Discriminator", "Email", "FirstName", "LastName", "Password", "Username", "Age", "Gender", "Handicap", "LeagueManagerMemberID", "myDistancedistanceId", "myScoresscoreId" },
                values: new object[,]
                {
                    { 1, "Golfer", "dakrlonz@hotmail.com", "Justin", "Fink", "123", "Finklacon", 29, "Male", 18.8, null, null, null },
                    { 2, "Golfer", "@.com", "Kyle", "Marley", "123", "Marley", 33, "Male", 11.0, null, null, null },
                    { 3, "Golfer", "@.com", "Scott", "Smith", "123", "Smith", 24, "Male", 21.0, null, null, null },
                    { 4, "Golfer", "@.com", "Ramon", "Casias", "123", "Casias", 31, "Male", 25.8, null, null, null },
                    { 5, "Golfer", "@.com", "William", "Dietz", "123", "Dietz", 30, "Male", 1.8, null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 5);
        }
    }
}
