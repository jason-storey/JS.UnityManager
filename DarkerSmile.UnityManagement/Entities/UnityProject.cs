using System;
using System.IO;

namespace DarkerSmile.UnityManagement
{
    [Serializable]
    public class UnityProject
    {
        public string Version { get; set; }
        public string Path { get; set; }
        public DateTime? LastModified { get; set; }
        public string ProjectName { get; set; }


        public static UnityProject CreateFromDirectory(string projectPath)
        {
            var info = new DirectoryInfo(projectPath);
            var projectName = info.Name;
            var csprojFile = System.IO.Path.Combine(projectPath, projectName + ".csproj");

            if (File.Exists(csprojFile) == false)
                csprojFile = System.IO.Path.Combine(projectPath, projectName + ".Editor.csproj");

            var lastUpdated = GetLastUpdatedTime(csprojFile);

            var projectVersion = GetProjectVersion(projectPath);


            return new UnityProject
            {
                ProjectName = projectName,
                Version = projectVersion,
                Path = projectPath,
                LastModified = lastUpdated
            };
        }

        private static DateTime? GetLastUpdatedTime(string path)
        {
            if (!File.Exists(path)) return null;

            var modification = File.GetLastWriteTime(path);
            return modification;
        }

        private static string GetProjectVersion(string path)
        {
            var version = "";
            if (Directory.Exists(System.IO.Path.Combine(path, "ProjectSettings")))
            {
                var versionPath = System.IO.Path.Combine(path, "ProjectSettings", "ProjectVersion.txt");
                if (File.Exists(versionPath))
                {
                    var data = File.ReadAllLines(versionPath);

                    if (data != null && data.Length > 0)
                    {
                        var dd = data[0];
                        // check first line
                        if (dd.Contains("m_EditorVersion"))
                        {
                            var t = dd.Split(new[] {"m_EditorVersion: "}, StringSplitOptions.None);
                            if (t != null && t.Length > 0)
                                version = t[1].Trim();
                            else
                                throw new InvalidDataException("invalid version data:" + data);
                        }
                        else
                        {
                            throw new InvalidDataException("Cannot find m_EditorVersion:" + dd);
                        }
                    }
                    else
                    {
                        throw new InvalidDataException("invalid projectversion data:" + data);
                    }
                }
            }
            return version;
        }
    }
}