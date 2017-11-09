using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace DarkerSmile.UnityManagement
{
    [Serializable]
    public class UnityVersion
    {
        private string _versionType;

        public static UnityVersion FromInstallDirectory(string directory)
        {
            var uninstallexecutable = Path.Combine(directory, "Editor", "Uninstall.exe");
            var version = GetUnityVersionFromPath(uninstallexecutable);
            var comparableVersion = new Regex("[a-zA-z]").Replace(version, ".");

            if (!File.Exists(uninstallexecutable))
                throw new InvalidUnityInstallDirectory();

            return new UnityVersion
            {
                InstallPath = directory,
                ExecutablePath = Path.Combine(directory, "Editor", "Unity.exe"),
                UninstallExecutablePath = uninstallexecutable,
                Version = version,
                ComparableVersion = comparableVersion,
                ReleaseUrl = GetReleaseUrlFromVersion(version),
                Installed = true
            };
        }

        public static UnityVersion FromVersionNumber(string version)
        {
            var comparableVersion = new Regex("[a-zA-z]").Replace(version, ".");

            return new UnityVersion
            {
                Version = version,
                ComparableVersion = comparableVersion,
                ReleaseUrl = GetReleaseUrlFromVersion(version),
                Installed = false
            };
        }

        //Properties
        public string ComparableVersion;

        public bool Installed { get; set; }
        public string Version { get; set; }

        public string VersionType => _versionType ?? (_versionType = GetVersionType(Version));

        public string InstallPath { get; set; }

        public string UninstallExecutablePath { get; set; }
        public string ExecutablePath { get; set; }

        public string ReleaseUrl { get; private set; }

        //Internal

        public static bool HasUnityInstall(string directoryPath)
        {
            var executable = Path.Combine(directoryPath, "Editor", "Unity.exe");
            return File.Exists(executable);
        }

        private static string GetUnityVersionFromPath(string path)
        {
            var fvi = FileVersionInfo.GetVersionInfo(path);
            return fvi.ProductName.Replace("(64-bit)", "").Replace("Unity", "").Trim();
        }

        private static string GetReleaseUrlFromVersion(string version)
        {
            var url = "";
            if (version.Contains("f"))
            {
                version = Regex.Replace(version, @"f.", "", RegexOptions.IgnoreCase);
                return "https://unity3d.com/unity/whats-new/unity-" + version;
            }
            if (version.Contains("p"))
                return "https://unity3d.com/unity/qa/patch-releases/" + version;
            if (version.Contains("b"))
                return "https://unity3d.com/unity/beta/unity" + version;
            return url;
        }

        private string GetVersionType(string version)
        {
            if (version.Contains("f"))
                return "Archived";
            if (version.Contains("p"))
                return "Patch";

            return version.Contains("b") ? "Beta" : "Unknown";
        }

        public void SetInstalledAt(string directory)
        {
            var executable = Path.Combine(directory, "Editor", "Unity.exe");
            var version = GetUnityVersionFromPath(executable);
            if (!File.Exists(executable))
                throw new InvalidUnityInstallDirectory();
            InstallPath = directory;
            ExecutablePath = executable;
            UninstallExecutablePath = Path.Combine(directory, "Editor", "Uninstall.exe");
            Version = version;
            ReleaseUrl = GetReleaseUrlFromVersion(version);
            Installed = true;
        }
    }
}