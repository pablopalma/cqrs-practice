using MediatR;

namespace CQRS.Practice.Infrastructure.Commands
{
    public record DeleteTaskCommand(int id) : IRequest<bool>;
}
