using System.Collections.Generic;

using backend.Domain.ResponseModels.Subjects;

using System.Threading.Tasks;

namespace planner_web_api.Application.Interfaces
{
    public interface ISubjectService
    {
        Task<List<GetSubjectsResponseModel>> GetSubjects(int projectId);
    }
}