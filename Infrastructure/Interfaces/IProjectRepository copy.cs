using System.Collections.Generic;
using backend.Domain.entities;
using System.Threading.Tasks;

namespace planner_web_api.Infrastructure.Interfaces
{
    public interface ISubjectRepository
    {
        Task<IEnumerable<Subject>> GetSubjects();
        Task<Subject> InsertSubject(Subject subject);
        Task Delete(Subject subject);
        Task<Subject> GetSubject(int SubjectId);

    }
}