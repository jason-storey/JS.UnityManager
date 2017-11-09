using System.Collections.Generic;

namespace DarkerSmile.UnityManagement
{
    public interface IUnityProjectRepository
    {
        IEnumerable<UnityProject> GetProjects();
        IEnumerable<UnityProject> GetProjectsForVersion(string version);

        void AddProject(UnityProject project);


        void Save();
    }
}