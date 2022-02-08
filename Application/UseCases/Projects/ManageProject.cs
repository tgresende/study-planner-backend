using System;
using System.Threading.Tasks;

using planner_web_api.Infrastructure.Interfaces;
using planner_web_api.Domain.entities;


namespace backend.Application.UseCases.Projects
{

    public class ManageProject : IManageProjects
    {
        public IProjectRepository _projectrepository;

          public ManageProject(IProjectRepository projectRepository){
             this._projectrepository = projectRepository;
         }
        public async Task DeleteProject(int projectId)
        {
            Project project = await _projectrepository.GetProject(projectId);
            
            await _projectrepository.Delete(project);
        }
    }
}