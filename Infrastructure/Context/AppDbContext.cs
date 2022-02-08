
using Microsoft.EntityFrameworkCore;
using planner_web_api.Domain.entities;

namespace planner_web_api.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Project> Project { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}   