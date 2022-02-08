using System.ComponentModel.DataAnnotations;

namespace planner_web_api.Domain.entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}