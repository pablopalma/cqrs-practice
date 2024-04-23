using CQRS.Practice.Application.DTOs;
using CQRS.Practice.Domain;
using CQRS.Practice.Infrastructure;
using CQRS.Practice.Infrastructure.Commands;
using MediatR;

namespace CQRS.Practice.Application.Handlers
{
    public class CreateHandler : IRequestHandler<CreateTaskCommand, TaskItemDto>
    {

        private readonly ApplicationDbContext _dbContext;

        public CreateHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TaskItemDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskItemDto = new TaskItem
            {
                Title = request.title,
                Description = request.description,
            };

            _dbContext.TaskItems.Add(taskItemDto);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return new TaskItemDto
            {
                Id = taskItemDto.Id,
                Title = taskItemDto.Title,
                Description = taskItemDto.Description,
                IsCompleted = taskItemDto.IsCompleted
            };
        }
    }
}
