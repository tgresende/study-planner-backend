using System.Collections.Generic;
using planner_web_api.Domain.entities;

namespace planner_web_api.Application.ViewModels
{
    public class ProjectViewModel
    {
        public IEnumerable<Project> Projects {get; set;}

    }
}