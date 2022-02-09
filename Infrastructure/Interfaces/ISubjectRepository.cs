using System.Collections.Generic;

using backend.Domain.entities;
using backend.Domain.ResponseModels.Subjects;
using planner_web_api.Domain.entities;


using System.Threading.Tasks;

namespace planner_web_api.Infrastructure.Interfaces
{
    public interface ISubjectRepository
    {
        Task<List<GetSubjectsResponseModel>> GetSubjects(Project project);
        Task<Subject> InsertSubject(Subject subject);
        Task Delete(int SubjectId);
        Task<Subject> GetSubject(int SubjectId);
    }
}