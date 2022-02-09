using System.Collections.Generic;

using backend.Domain.entities;
using backend.Domain.ResponseModels.Subjects;

using System.Threading.Tasks;

namespace backend.Application.UseCases.Subjects
{
    public interface ISubjectManagement
    {
        Task<List<GetSubjectsResponseModel>> GetSubjects(int projectId);
        Task<Subject> InsertSubject(Subject subject);
        Task<Subject> GetSubject(int subjectId);
        Task DeleteSubject(int subjectId);
    }
}