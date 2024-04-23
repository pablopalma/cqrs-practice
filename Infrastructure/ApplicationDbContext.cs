using CQRS.Practice.Domain;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Practice.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; } 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
