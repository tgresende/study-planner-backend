namespace backend.Application.UseCases.Subjects.InsertNewSubject
{
    public class InsertNewSubjectRequestModel
    {
        public int SubjectId {get;set;}
        public string Name {get;set;}
        public int ProjectId {get;set;}
    }
}