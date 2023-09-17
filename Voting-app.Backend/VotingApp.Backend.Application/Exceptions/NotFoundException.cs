namespace VotingApp.Backend.Application.Exceptions;

public class NotFoundException:ApplicationException
{
    protected NotFoundException(string message) : base("Not found", message)
    {
    }
}