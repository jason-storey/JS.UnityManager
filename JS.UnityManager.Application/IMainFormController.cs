using System.Collections.Generic;

namespace JS.UnityManager.App
{
    public interface IMainFormController
    {
        void LoadRecentProjects();
    }

    public interface IMainFormView
    {
        void SetController(IMainFormController ctrl);
        IList<UnityProject> RecentProjects { set; }
    }

}