using CQRS.Practice.Application.DTOs;
using CQRS.Practice.Infrastructure;
using CQRS.Practice.Infrastructure.Queries;
using MediatR;

namespace CQRS.Practice.Application.Handlers
{
    public class GetByIdHandler : IRequestHandler<GetTaskByIdQuery, TaskItemDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetByIdHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TaskItemDto> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var taskItem = await _dbContext.TaskItems.FindAsync([request.id],
                                                             cancellationToken);
            if (taskItem == null)
                return null;

            return new TaskItemDto
            {
                Id = taskItem.Id,
                Title = taskItem.Title,
                Description = taskItem.Description,
                IsCompleted = taskItem.IsCompleted
            };
        }
    }
}
