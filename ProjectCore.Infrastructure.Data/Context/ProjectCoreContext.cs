using Microsoft.EntityFrameworkCore;
using ProjectCore.Infrastructure.Data.Context.Mapping;

namespace ProjectCore.Infrastructure.Data.Context
{
    public class ProjectCoreContext : DbContext
    {
        public ProjectCoreContext(DbContextOptions<ProjectCoreContext> options) : base(options)
        {                    
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
