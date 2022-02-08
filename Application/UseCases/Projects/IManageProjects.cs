using System.Threading.Tasks;

namespace backend.Application.UseCases.Projects
{
    public interface IManageProjects
    {
        Task DeleteProject(int projectId);

    }
}