using System;
using System.Linq;
using DarkerSmile.UnityManagement;

namespace JS.UnityManager.App
{
    public class MainFormControllerImpl : IMainFormController
    {
        private readonly IMainFormView _view;
        private readonly IUnityProjectRepository _projects;
        private readonly IUnityVersionRepository _versions;

        public MainFormControllerImpl(IMainFormView view,IUnityProjectRepository projects,IUnityVersionRepository versions)
        {
            _view = view;
            _projects = projects;
            _versions = versions;
            _view.SetController(this);
        }

        public void LoadRecentProjects()
        {
            _view.RecentProjects = _projects.GetProjects() .Where(x=>x.LastModified.HasValue).ToList();
        }

        public void LoadUnityVersions()
        {
            var lst =  _versions.GetInstalledVersions().ToList();
            _view.Versions = lst;
        }

        public IUnityManagerCommands CreateCommands()
        {
            return new UnityManagerCommands(_view, new ProjectLauncher(_versions));
        }

    }
}
