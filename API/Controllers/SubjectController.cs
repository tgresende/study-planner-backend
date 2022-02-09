using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using backend.Application.UseCases.Subjects;
using backend.Application.UseCases.Subjects.InsertNewSubject;


using backend.Domain.ResponseModels.Subjects;
using backend.Domain.entities;


namespace planner_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private ISubjectManagement _manageSubject;
        private IInsertNewSubject _insertSubject;

        public SubjectController(ISubjectManagement manageSubject, IInsertNewSubject insertSubject)
        {
            this._manageSubject = manageSubject;
            this._insertSubject = insertSubject;
        }

        [HttpGet("{projectId:int}")]        
        public async Task<IActionResult> GetSubjects(int projectId)
        {
            List<GetSubjectsResponseModel> subjects = await _manageSubject.GetSubjects(projectId);
            return Ok(subjects);
        }

        [HttpPost]
        public async Task<ActionResult<InsertNewSubjectRequestModel>> InsertSubject([FromBody] InsertNewSubjectRequestModel subject)
        {
            var newSubject = await _insertSubject.InsertSubject(subject);

            if (newSubject != null)
                return Ok(newSubject);
            
            return BadRequest();
        }

        [HttpDelete("{subjectId:int}")]        
        public async Task<IActionResult> DeleteProject(int subjectId)
        {
            await _manageSubject.DeleteSubject(subjectId);
            return Ok("Deletado");
        }

       

        
    }
}