using System.Threading.Tasks;

using planner_web_api.Application.Interfaces;

using planner_web_api.Infrastructure.Interfaces;

using planner_web_api.Domain.entities;
using backend.Domain.entities;


namespace backend.Application.UseCases.Subjects.InsertNewSubject
{
    public class InsertNewSubject : IInsertNewSubject
    {
        public ISubjectRepository _subjectRepository;
        public IProjectRepository _projectRepository;

        private readonly ISubjectService _subjectService;

        public InsertNewSubject(ISubjectRepository subjectRepository, ISubjectService subjectService, IProjectRepository projectRepository){
            this._subjectRepository = subjectRepository;
            this._subjectService = subjectService;
            this._projectRepository = projectRepository;
        }

        public async Task<InsertNewSubjectRequestModel> InsertSubject(InsertNewSubjectRequestModel subjectRequestModel)
        {
            Project project = await _projectRepository.GetProject(subjectRequestModel.ProjectId);

            if (project == null)
                return null;

            Subject subject = BuildSubjectEntity(project, subjectRequestModel);

            subject = await _subjectRepository.InsertSubject(subject);

            return BuildSubjectRequesModel(subject);
        }

        private Subject BuildSubjectEntity(Project project, InsertNewSubjectRequestModel subject)
        {
            return new Subject{
                SubjectId = 0,
                project = project,
                Name = subject.Name
            };
        }

        private InsertNewSubjectRequestModel BuildSubjectRequesModel(Subject subject)
        {
            return new InsertNewSubjectRequestModel{
                SubjectId = subject.SubjectId,
                ProjectId = subject.project.Id,
                Name = subject.Name
            };
        }
    }
}