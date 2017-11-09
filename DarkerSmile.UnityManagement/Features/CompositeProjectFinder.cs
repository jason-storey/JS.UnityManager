using System.Collections.Generic;

namespace DarkerSmile.UnityManagement
{
    public class CompositeProjectFinder : List<IProjectFinder>, IProjectFinder
    {
        public IEnumerable<UnityProject> SearchForProjects()
        {
            var _projects = new List<UnityProject>();
            foreach (var finder in this)
                _projects.AddRange(finder.SearchForProjects());
            return _projects;
        }
    }
}