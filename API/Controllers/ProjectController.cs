using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Threading.Tasks;

using planner_web_api.Application.ViewModels;
using planner_web_api.Application.InputModels;
using planner_web_api.Application.Interfaces;


namespace planner_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
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

       

        
    }
}