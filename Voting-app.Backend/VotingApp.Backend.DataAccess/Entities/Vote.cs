using System.ComponentModel.DataAnnotations.Schema;

namespace VotingApp.Backend.DataAccess.Entities;

public class Vote:BaseEntity
{
    public int CandidateId { get; set; }
    public Candidate Candidate { get; set; }
}