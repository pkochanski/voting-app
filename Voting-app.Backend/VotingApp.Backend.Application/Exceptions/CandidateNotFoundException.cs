namespace VotingApp.Backend.Application.Exceptions;

public class CandidateNotFoundException:NotFoundException
{
    public CandidateNotFoundException(int candidateId) : base($"Candidate with id {candidateId} not found.")
    {
    }
}