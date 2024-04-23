using CQRS.Practice.Application.DTOs;
using MediatR;

namespace CQRS.Practice.Infrastructure.Commands
{
    public record CreateTaskCommand(string title, string description) 
        : IRequest<TaskItemDto>;
}
