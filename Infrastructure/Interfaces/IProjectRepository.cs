using System.Collections.Generic;
using planner_web_api.Domain.entities;
using System.Threading.Tasks;

namespace planner_web_api.Infrastructure.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetProjects();

        Task<Project> InsertProject(Project proj);

    }
}