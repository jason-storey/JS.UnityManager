namespace DarkerSmile.UnityManagement
{
    public interface IProjectLauncher
    {
        bool CanOpen(UnityProject project);
        bool CorrectVersionInstalled(UnityProject project);
        UnityVersion FindNearestInstalledVersion(UnityVersion version);
        UnityVersion FindNearestVersion(UnityVersion version);
        void InstallVersion(string version);
        void InstallVersion(UnityVersion version);
        void OpenProjectFolder(UnityProject project);
        void OpenProjectInMatchingVersion(UnityProject project);
        void OpenProjectInVersion(UnityProject project, UnityVersion version);
        void OpenUnityVersion(UnityVersion version);
    }
}