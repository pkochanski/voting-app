namespace VotingApp.Backend.DataAccess.Entities;

public class Candidate:BaseEntity
{
    public string Name { get; set; }
    public ICollection<Vote> Votes { get; set; } = new List<Vote>();
}