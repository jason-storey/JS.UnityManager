using System;
using System.Collections.Generic;
using System.IO;

namespace DarkerSmile.UnityManagement
{
    public class UnityVersionFinder
    {
        public IEnumerable<UnityVersion> SearchInDirectory(string directory)
        {
            if (!Directory.Exists(directory))
                throw new ArgumentOutOfRangeException(nameof(directory), directory, "No Directory Found");

            var subddirectories = Directory.GetDirectories(directory);
            for (int i = 0, length = subddirectories.Length; i < length; i++)
            {
                var subdirectory = subddirectories[i];
                if (UnityVersion.HasUnityInstall(subdirectory))
                    yield return UnityVersion.FromInstallDirectory(subdirectory);
            }
        }
    }
}