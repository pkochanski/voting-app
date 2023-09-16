using MediatR;

namespace VotingApp.Backend.Application.Queries;

public interface IQuery<out T>:IRequest<T>
{
    
}