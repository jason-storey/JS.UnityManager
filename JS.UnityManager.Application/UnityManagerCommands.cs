using System.Diagnostics;
using DarkerSmile.UnityManagement;

namespace JS.UnityManager.App
{
    public class UnityManagerCommands : IUnityManagerCommands
    {
        private readonly IView _form;
        private readonly ProjectLauncher _launcher;

        public UnityManagerCommands(IView form, ProjectLauncher launcher)
        {
            _form = form;
            _launcher = launcher;
        }
        public void LaunchVersion(UnityVersion version)
        {
            Process.Start(version.ExecutablePath);
        }

        public void OpenVersionFolder(UnityVersion version)
        {
            Process.Start(version.InstallPath);
        }

        public void MinimizeApp()
        {
            _form.Hide();
        }

        public void OpenProject(UnityProject project)
        {
            _launcher.OpenProjectInMatchingVersion(project);
        }

        public bool IsVersionInstalled(UnityProject proj)
        {
            return _launcher.CorrectVersionInstalled(proj);
        }

        public void OpenProjectFolder(UnityProject project)
        {
            _launcher.OpenProjectFolder(project);
        }

        public void ViewReleaseNotes(UnityVersion version)
        {
            Process.Start(version.ReleaseUrl);
        }

        public void TryInstallUnityVersionFor(UnityProject project)
        {
            
            _launcher.InstallVersion(project.Version);
        }
    }
}