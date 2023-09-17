namespace VotingApp.Backend.Application.Exceptions;

public class VoterNotFoundException:NotFoundException
{
    public VoterNotFoundException(int voterId) : base($"Voter with id {voterId} not found.")
    {
    }
}