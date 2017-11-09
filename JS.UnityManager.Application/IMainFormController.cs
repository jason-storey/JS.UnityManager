using System.Collections.Generic;
using DarkerSmile.UnityManagement;

namespace JS.UnityManager.App
{
    public interface IMainFormController
    {
        void LoadRecentProjects();

        void LoadUnityVersions();

        IUnityManagerCommands CreateCommands();
    }

    public interface IMainFormView : IView
    {
        void SetController(IMainFormController ctrl);
        IList<UnityProject> RecentProjects { set; }

        IList<UnityVersion> Versions { set; }

    }

    public interface IUnityManagerCommands
    {
        void LaunchVersion(UnityVersion version);
        void OpenVersionFolder(UnityVersion version);

        void MinimizeApp();

        void OpenProject(UnityProject project);

        bool IsVersionInstalled(UnityProject proj);

        void OpenProjectFolder(UnityProject project);
        void ViewReleaseNotes(UnityVersion version);
        void TryInstallUnityVersionFor(UnityProject project);
    }


 

}