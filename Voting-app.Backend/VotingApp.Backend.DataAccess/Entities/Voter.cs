using System.ComponentModel.DataAnnotations.Schema;

namespace VotingApp.Backend.DataAccess.Entities;

public class Voter:BaseEntity
{
    public string Name { get; set; }
    [ForeignKey("Vote")]
    public int? VoteId { get; set; }
    public Vote? Vote { get; set; }
}