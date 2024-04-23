using CQRS.Practice.Application.DTOs;
using CQRS.Practice.Infrastructure;
using CQRS.Practice.Infrastructure.Commands;
using MediatR;

namespace CQRS.Practice.Application.Handlers
{
    public class UpdateHandler : IRequestHandler<UpdateTaskCommand, TaskItemDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TaskItemDto> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskItem = await _dbContext.TaskItems.FindAsync([request.id],
                                                                cancellationToken);
            if (taskItem == null) 
                return null;

            taskItem.Id = request.id;
            taskItem.Description = request.description;
            taskItem.IsCompleted = request.isCompleted;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return new TaskItemDto
            {
                Id = request.id,
                Description = request.description
            };
        }
    }
}
