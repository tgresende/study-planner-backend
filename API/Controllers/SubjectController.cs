using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using backend.Application.UseCases.Subjects;

using backend.Domain.ResponseModels.Subjects;
using backend.Domain.entities;


namespace planner_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private ISubjectManagement _manageSubject;


        public SubjectController(ISubjectManagement manageSubject)
        {
            this._manageSubject = manageSubject;
        }

        [HttpGet("{projectId:int}")]        
        public async Task<IActionResult> GetSubjects(int projectId)
        {
            List<GetSubjectsResponseModel> subjects = await _manageSubject.GetSubjects(projectId);
            return Ok(subjects);
        }

        [HttpPost]
        public async Task<ActionResult<Subject>> InsertSubject([FromBody] Subject subject)
        {
            var newSubject = await _manageSubject.InsertSubject(subject);
            return newSubject;
        }

        [HttpDelete("{subjectId:int}")]        
        public async Task<IActionResult> DeleteProject(int subjectId)
        {
            await _manageSubject.DeleteSubject(subjectId);
            return Ok("Deletado");
        }

       

        
    }
}