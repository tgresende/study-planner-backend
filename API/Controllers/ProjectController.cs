using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using planner_web_api.Application.ViewModels;
using planner_web_api.Application.InputModels;
using planner_web_api.Application.Interfaces;
using backend.Application.UseCases.Projects;



namespace planner_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService projectService;
        private IManageProjects _manageProject;


        public ProjectController(IProjectService projectService, IManageProjects manageProject)
        {
            this.projectService = projectService;
            this._manageProject = manageProject;
        }

        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            ProjectViewModel model = await projectService.GetProjects();
            return Ok(model.Projects);
        }

        [HttpPost]
        public async Task<ActionResult<ProjectInputModel>> InsertProject([FromBody] ProjectInputModel project)
        {
            var newProject = await projectService.InsertProject(project);

            return newProject;
        }

        [HttpDelete("{projectId:int}")]        
        public async Task<IActionResult> DeleteProject(int projectId)
        {
            await _manageProject.DeleteProject(projectId);

            return Ok("Deletado");
        }

       

        
    }
}