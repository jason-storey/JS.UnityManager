using System.Collections.Generic;

namespace DarkerSmile.UnityManagement
{
    public interface IProjectFinder
    {
        IEnumerable<UnityProject> SearchForProjects();
    }
}