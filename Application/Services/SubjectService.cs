using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using planner_web_api.Application.Interfaces;

using planner_web_api.Infrastructure.Interfaces;

using planner_web_api.Domain.entities;
using backend.Domain.ResponseModels.Subjects;
    
namespace planner_web_api.Application.Services
{
   
    public class SubjectService : ISubjectService
    {

        private readonly ISubjectRepository _subjectRepository;
        private readonly IProjectRepository _projectRepository;

        public SubjectService(ISubjectRepository subjectRepository, IProjectRepository projectRepository){
            _subjectRepository = subjectRepository;
            _projectRepository = projectRepository;
        }

        public async Task<List<GetSubjectsResponseModel>> GetSubjects(int projectId)
        {
            Project project = await _projectRepository.GetProject(projectId);
            return await _subjectRepository.GetSubjects(project);
        }

    }
}