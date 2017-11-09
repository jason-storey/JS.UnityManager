using System.Collections.Generic;
using System.Linq;

namespace DarkerSmile.UnityManagement
{
    public class UnityProjectRepository : IUnityProjectRepository
    {
        private readonly List<UnityProject> _projects = new List<UnityProject>();

        public IEnumerable<UnityProject> GetProjects() => _projects;

        public IEnumerable<UnityProject> GetProjectsForVersion(string version)
        {
            return _projects.Where(x => x.Version == version);
        }

        public void AddProject(UnityProject project)
        {
            if (!_projects.Contains(project))
                _projects.Add(project);
        }

        public void Save()
        {
        }
    }
}