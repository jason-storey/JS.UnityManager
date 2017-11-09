using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DarkerSmile.UnityManagement
{
    public class DirectoryProjectFinder : IProjectFinder
    {
        private readonly List<string> _directories = new List<string>();

        public DirectoryProjectFinder AddSearchDirectory(string directoryPath)
        {
            _directories.Add(directoryPath);
            return this;
        }

        public IEnumerable<UnityProject> SearchForProjects()
        {
            foreach (var directory in _directories)
            foreach (var unityProject in GetProjectsInDirectory(directory))
                yield return unityProject;
        }


        private IEnumerable<UnityProject> GetProjectsInDirectory(string path)
        {
            var subdirectories = Directory.GetDirectories(path);

            foreach (var subdirectory in subdirectories)
                if (IsAProjectFolder(subdirectory))
                    yield return UnityProject.CreateFromDirectory(subdirectory);
        }

        private bool IsAProjectFolder(string path)
        {
            var subdirectories = Directory.GetDirectories(path);
            return subdirectories.Contains(Path.Combine(path, "Assets")) &&
                   subdirectories.Contains(Path.Combine(path, "Library")) &&
                   subdirectories.Contains(Path.Combine(path, "ProjectSettings"));
        }
    }
}