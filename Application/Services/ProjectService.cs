using System;
using System.Threading.Tasks;

using planner_web_api.Application.Interfaces;
using planner_web_api.Application.ViewModels;
using planner_web_api.Application.InputModels;

using planner_web_api.Infrastructure.Interfaces;

using planner_web_api.Domain.entities;



namespace planner_web_api.Application.Services
{
   
    public class ProjectService : IProjectService
    {

         public IProjectRepository projectRepository;

         public ProjectService(IProjectRepository projectRepository){
             this.projectRepository = projectRepository;
         }

         public async Task<ProjectViewModel> GetProjects()
         {
             return new ProjectViewModel()
             {
                 Projects = await projectRepository.GetProjects()
             };
         }

         public async Task<ProjectInputModel> InsertProject(ProjectInputModel model)
         {

             Project newProject = new Project(){
                Name = model.Name,
                Id = model.Id,
             };
             
             newProject = await projectRepository.InsertProject(newProject);

             return new ProjectInputModel()
             {
                Name = newProject.Name,
                Id = newProject.Id,
             };
         }
    }
}