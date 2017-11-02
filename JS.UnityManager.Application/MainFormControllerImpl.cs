using System;
using System.Linq;

namespace JS.UnityManager.App
{
    public class MainFormControllerImpl : IMainFormController
    {
        private readonly IMainFormView _view;
        private readonly IUnityProjectRepository _projects;

        public MainFormControllerImpl(IMainFormView view,IUnityProjectRepository projects)
        {
            _view = view;
            _projects = projects;
            _view.SetController(this);
        }

        public void LoadRecentProjects()
        {
            _view.RecentProjects = _projects.GetAll().Where(x => (DateTime.Now - x.LastModified).Days < InTheLastXDays).ToList();
        }


        private int InTheLastXDays = 5;
    }
}
