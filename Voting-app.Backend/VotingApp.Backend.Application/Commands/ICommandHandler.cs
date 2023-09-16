using MediatR;

namespace VotingApp.Backend.Application.Commands;

public interface ICommandHandler<in T, TResponse>:IRequestHandler<T,TResponse> where T:ICommand<TResponse>
{
    
}