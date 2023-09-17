using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingApp.Backend.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Voter_From_Vote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Voters_VoteId",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "VoterId",
                table: "Votes");

            migrationBuilder.CreateIndex(
                name: "IX_Voters_VoteId",
                table: "Voters",
                column: "VoteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Voters_VoteId",
                table: "Voters");

            migrationBuilder.AddColumn<int>(
                name: "VoterId",
                table: "Votes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Voters_VoteId",
                table: "Voters",
                column: "VoteId",
                unique: true,
                filter: "[VoteId] IS NOT NULL");
        }
    }
}
