using planner_web_api.Application.ViewModels;
using planner_web_api.Application.InputModels;
using System.Threading.Tasks;

namespace planner_web_api.Application.Interfaces
{
    public interface IProjectService
    {
        Task<ProjectViewModel> GetProjects();
        Task<ProjectInputModel> InsertProject(ProjectInputModel model);


    }
}