using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingApp.Backend.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKey_Voter_Vote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Voters_VoterId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_VoterId",
                table: "Votes");

            migrationBuilder.CreateIndex(
                name: "IX_Voters_VoteId",
                table: "Voters",
                column: "VoteId",
                unique: true,
                filter: "[VoteId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Votes_VoteId",
                table: "Voters",
                column: "VoteId",
                principalTable: "Votes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Votes_VoteId",
                table: "Voters");

            migrationBuilder.DropIndex(
                name: "IX_Voters_VoteId",
                table: "Voters");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoterId",
                table: "Votes",
                column: "VoterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Voters_VoterId",
                table: "Votes",
                column: "VoterId",
                principalTable: "Voters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
