using System;
using System.Windows.Forms;
using JS.UnityManager.App;

namespace JS.UnityManager
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new MainForm();
            var ctrl = new MainFormControllerImpl(view, new UnityProjectRepositoryTestData());
            Application.Run(view);
        }
    }
}