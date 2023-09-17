namespace VotingApp.Backend.Application.Exceptions;

public class VoterAlreadyVotedException:BadRequestException
{
    public VoterAlreadyVotedException(int voterId) : base($"Voter with id {voterId} already voted.")
    {
    }
}