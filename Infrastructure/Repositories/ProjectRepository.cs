using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using planner_web_api.Infrastructure.Interfaces;
using planner_web_api.Infrastructure.Context;

using planner_web_api.Domain.entities;

namespace planner_web_api.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
     {
        public AppDbContext context;

        public ProjectRepository(AppDbContext context){
            this.context = context;
        }

        public async Task<IEnumerable<Project>> GetProjects() 
        {
            return await context.Project.ToListAsync();
        }

        public async Task<Project> InsertProject(Project project) 
        {
            context.Project.Add(project);
            await context.SaveChangesAsync();
            return project;
        }

        public async Task<Project> GetProject(int projectId) 
        {
            Project project = await this.context.Project.FirstOrDefaultAsync( project => project.Id == projectId);

            return project;
        }

        public async Task Delete(Project project) 
        {
            this.context.Project.Remove(project);
            context.SaveChanges();
        }
    }
}