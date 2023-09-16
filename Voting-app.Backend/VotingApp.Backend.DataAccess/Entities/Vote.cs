using System.ComponentModel.DataAnnotations.Schema;

namespace VotingApp.Backend.DataAccess.Entities;

public class Vote:BaseEntity
{
    public int CandidateId { get; set; }
    public Candidate Candidate { get; set; }
    [ForeignKey("Voter")]
    public int VoterId { get; set; }
    public Voter Voter { get; set; }
}