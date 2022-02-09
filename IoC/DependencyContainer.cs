using Microsoft.Extensions.DependencyInjection;

using planner_web_api.Application.Services;
using planner_web_api.Application.Interfaces;

using planner_web_api.Infrastructure.Interfaces;
using planner_web_api.Infrastructure.Repositories;

using backend.Application.UseCases.Projects;
using backend.Application.UseCases.Subjects;

namespace planner_web_api.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services){
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IManageProjects, ManageProject>();

            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<ISubjectManagement, SubjectManagement>();

        }
    }
}