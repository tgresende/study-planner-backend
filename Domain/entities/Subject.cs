using planner_web_api.Domain.entities;

namespace backend.Domain.entities
{
    public class Subject
    {
        public int SubjectId {get; set;}

        public string Name {get; set;}

        public Project project {get; set;}

    }
}