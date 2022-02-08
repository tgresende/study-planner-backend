
using Microsoft.EntityFrameworkCore;
using planner_web_api.Domain.entities;
using backend.Domain.entities;


namespace planner_web_api.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Project> Project { get; set; }
        public DbSet<Subject> Subject { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Subject>()
                .HasOne(e => e.project)
                .WithMany(e => e.Subjects)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}   