using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace DarkerSmile.UnityManagement
{
    public class RecentProjectFinder : IProjectFinder
    {
        public IEnumerable<UnityProject> FindRecentProjects()
        {
            var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            var key = hklm.OpenSubKey(@"SOFTWARE\Unity Technologies\Unity Editor 5.x");
            if (key == null)
                throw new ArgumentNullException("No Recent Projects Found");

            foreach (var valueName in key.GetValueNames())
                if (valueName.IndexOf("RecentlyUsedProjectPaths-") == 0)
                {
                    var projectPathBytes = (byte[]) key.GetValue(valueName);
                    var projectPath = Encoding.Default.GetString(projectPathBytes, 0, projectPathBytes.Length - 1);
                    yield return UnityProject.CreateFromDirectory(projectPath);
                }
        }


        public IEnumerable<UnityProject> SearchForProjects() => FindRecentProjects();
    }
}