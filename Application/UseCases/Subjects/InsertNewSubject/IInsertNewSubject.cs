using System.Collections.Generic;

using backend.Domain.entities;
using backend.Domain.ResponseModels.Subjects;

using System.Threading.Tasks;

namespace backend.Application.UseCases.Subjects.InsertNewSubject
{
    public interface IInsertNewSubject
    {
        Task<InsertNewSubjectRequestModel> InsertSubject(InsertNewSubjectRequestModel subject);
    }
}