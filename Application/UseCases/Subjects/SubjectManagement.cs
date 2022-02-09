using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using planner_web_api.Application.Interfaces;

using planner_web_api.Infrastructure.Interfaces;

using backend.Domain.entities;
using backend.Domain.ResponseModels.Subjects;


namespace backend.Application.UseCases.Subjects
{
   
    public class SubjectManagement : ISubjectManagement
    {

        public ISubjectRepository _subjectRepository;
        private readonly ISubjectService _subjectService;

        public SubjectManagement(ISubjectRepository subjectRepository, ISubjectService subjectService){
            this._subjectRepository = subjectRepository;
            this._subjectService = subjectService;
        }

        public async Task<List<GetSubjectsResponseModel>> GetSubjects(int projectId)
        {
          
            return await _subjectService.GetSubjects(projectId);
        }

      
        public async Task<Subject> GetSubject(int subjectId)
        {
            return await _subjectRepository.GetSubject(subjectId);
        }

        public async Task DeleteSubject(int subjectId)
        {
            await _subjectRepository.Delete(subjectId);
        }

    }
}