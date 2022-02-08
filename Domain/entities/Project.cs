using System.Collections.Generic;

using backend.Domain.entities;

namespace planner_web_api.Domain.entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}