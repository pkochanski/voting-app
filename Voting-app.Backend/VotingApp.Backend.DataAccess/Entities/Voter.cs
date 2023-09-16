namespace VotingApp.Backend.DataAccess.Entities;

public class Voter:BaseEntity
{
    public string Name { get; set; }
    public int? VoteId { get; set; }
    public Vote? Vote { get; set; }
}