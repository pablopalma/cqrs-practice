using CQRS.Practice.Application.DTOs;
using CQRS.Practice.Infrastructure;
using CQRS.Practice.Infrastructure.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Practice.Application.Handlers
{
    public class GetAllTasksHandler : IRequestHandler<GetAllTasksQuery, IEnumerable<TaskItemDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAllTasksHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TaskItemDto>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            var tasks = await _dbContext.TaskItems.ToListAsync(cancellationToken);

            return tasks.Select(task => new TaskItemDto
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                IsCompleted = task.IsCompleted
            });
        }
    }
}
