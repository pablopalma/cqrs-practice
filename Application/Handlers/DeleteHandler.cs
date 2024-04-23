using CQRS.Practice.Infrastructure;
using CQRS.Practice.Infrastructure.Commands;
using MediatR;

namespace CQRS.Practice.Application.Handlers
{
    public class DeleteHandler : IRequestHandler<DeleteTaskCommand, bool>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            var taskItem = await _dbContext.TaskItems.FindAsync([request.id],
                                                                cancellationToken);
            if (taskItem == null)
                return false;

            _dbContext.TaskItems.Remove(taskItem);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
