using MediatR;

namespace VotingApp.Backend.Application.Queries;

public interface IQueryHandler<in T,TR>:IRequestHandler<T,TR> where T:IQuery<TR>
{
    
}