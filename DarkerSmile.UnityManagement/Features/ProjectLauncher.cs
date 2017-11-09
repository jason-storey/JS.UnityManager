using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace DarkerSmile.UnityManagement
{
    public class ProjectLauncher : IProjectLauncher
    {
        private readonly UnityVersionController _controller;

        public ProjectLauncher(IUnityVersionRepository versions)
        {
            _controller = new UnityVersionController();
            _versions = versions;
        }

        private UnityVersion GetVersionForProject(UnityProject project)
        {
            if (project == null) throw new NoProjectProvided();
            return _versions.GetVersions().FirstOrDefault(x => x.Version == project.Version);
        }

        public bool CorrectVersionInstalled(UnityProject project) => GetVersionForProject(project) != null;

        public void InstallVersion(UnityVersion version)
        {
            if (version == null) throw new NoUnityVersionProvided();
            _controller.DownloadAndRun(version.ReleaseUrl);
        }

        public void InstallVersion(string version)
        {
            if (version == null) throw new NoUnityVersionProvided();
            _controller.DownloadAndRun(UnityVersion.FromVersionNumber(version).ReleaseUrl);
        }

        public bool CanOpen(UnityProject project) => CorrectVersionInstalled(project);

        public void OpenUnityVersion(UnityVersion version)
        {
            Process.Start(version.ExecutablePath);
        }

        public void OpenProjectInVersion(UnityProject project, UnityVersion version)
        {
            _controller.Launch(version, project);
        }

        public void OpenProjectInMatchingVersion(UnityProject project)
        {
            var version = GetVersionForProject(project);
            if (version == null)
                throw new VersionNotInstalled(project.Version, $"{project.ProjectName} ({project.Version})");
            OpenProjectInVersion(project, version);
        }

        private readonly IUnityVersionRepository _versions;

        public void OpenProjectFolder(UnityProject project)
        {
            Process.Start(project.Path);
        }


        public static UnityVersion FindNearestMatchingVersion(UnityVersion version,
            IEnumerable<UnityVersion> comparableversions)
        {
            var unityVersions = comparableversions as UnityVersion[] ?? comparableversions.ToArray();
            var versionNumber = FindNearestVersion(version.Version,
                unityVersions.Select(x => x.Version).ToList());
            var versions = unityVersions.ToList();

            var vers = versions.FirstOrDefault(x => x.Version == versionNumber);

            return vers;
        }

        public UnityVersion FindNearestVersion(UnityVersion version)
        {
            if (version.ComparableVersion.Contains("2017"))
                return FindNearestMatchingVersion(version,
                    _versions.GetVersions().Where(x => x.Version.Contains("2017")));
            return FindNearestMatchingVersion(version, _versions.GetVersions().Where(x => !x.Version.Contains("2017")));
        }

        public UnityVersion FindNearestInstalledVersion(UnityVersion version)
        {
            if (version.ComparableVersion.Contains("2017"))
                return FindNearestMatchingVersion(version,
                    _versions.GetVersions().Where(x => x.Version.Contains("2017") && x.Installed));
            return FindNearestMatchingVersion(version,
                _versions.GetVersions().Where(x => !x.Version.Contains("2017") && x.Installed));
        }


        public static string FindNearestVersion(string version, List<string> allAvailable)
        {
            if (version.Contains("2017"))
                return FindNearestVersionFromSimilarVersions(version, allAvailable.Where(x => x.Contains("2017")));
            return FindNearestVersionFromSimilarVersions(version, allAvailable.Where(x => !x.Contains("2017")));
        }

        private static string FindNearestVersionFromSimilarVersions(string version, IEnumerable<string> allAvailable)
        {
            var stripped = new Dictionary<string, string>();
            var enumerable = allAvailable as string[] ?? allAvailable.ToArray();

            foreach (var t in enumerable)
                stripped.Add(new Regex("[a-zA-z]").Replace(t, "."), t);

            var comparableVersion = new Regex("[a-zA-z]").Replace(version, ".");
            if (!stripped.ContainsKey(comparableVersion))
                stripped.Add(comparableVersion, version);

            var comparables = stripped.Keys.OrderBy(x => x).ToList();
            var actualIndex = comparables.IndexOf(comparableVersion);

            if (actualIndex < stripped.Count) return stripped[comparables[actualIndex + 1]];
            return null;
        }
    }
}