using System;
using System.Windows.Forms;
using DarkerSmile.UnityManagement;
using JS.UnityManager.App;

namespace JS.UnityManager
{
    internal static class EntryPoint
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new MainForm();

            var repo = new UnityProjectRepository();

            var finder = new RecentProjectFinder();
            foreach (var project in finder.SearchForProjects())
            {
                repo.AddProject(project);    
            }

            var versions = new UnityVersionRepository();
            var vfinder = new UnityVersionFinder();
            foreach (var v in vfinder.SearchInDirectory(@"C:\Program Files"))
            {
                versions.AddVersion(v);
            }


            var ctrl = new MainFormControllerImpl(view, repo,versions);
            Application.Run(view);
        }
    }
}