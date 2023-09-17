namespace VotingApp.Backend.Application.Queries.Voters.List.DTO;

public class VoterDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool HasVoted { get; set; }
}