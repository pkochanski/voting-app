using MediatR;

namespace VotingApp.Backend.Application.Commands;

public interface ICommand<out T>:IRequest<T>
{
    
}