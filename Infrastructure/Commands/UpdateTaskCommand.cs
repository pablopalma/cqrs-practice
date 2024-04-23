using CQRS.Practice.Application.DTOs;
using MediatR;

namespace CQRS.Practice.Infrastructure.Commands
{
    public record UpdateTaskCommand(int id, string title, string description, bool isCompleted)
        : IRequest<TaskItemDto>;
}
