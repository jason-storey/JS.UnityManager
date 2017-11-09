using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DarkerSmile.UnityManagement;
using JS.UnityManager.App;
using MetroFramework;
using MetroFramework.Forms;

namespace JS.UnityManager
{
    public partial class MainForm : MetroForm, IMainFormView
    {
        private IUnityManagerCommands _commands;

        public MainForm()
        {
            InitializeComponent();

            notifyIcon.Visible = true;
            notifyIcon.ContextMenu = BuildContextMenu();
            SetStyleToProjectMode();
            panelVersionActions.BackColor = MetroColors.Green;
        }

        private ContextMenu BuildContextMenu()
        {
            var menu = new ContextMenu();
            var projects = new MenuItem("Projects");
            projects.Click += Click_ProjectMenu;
            menu.MenuItems.Add(projects);
            var versions = new MenuItem("Versions");
            versions.Click += Click_VersionsMenu;
            menu.MenuItems.Add(versions);
            return menu;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                HideApp();
        }


        public void HideApp()
        {
            Hide();
        }

        public void ShowApp()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }


        public void SetController(IMainFormController ctrl)
        {
            _ctrl = ctrl;
            _commands = _ctrl.CreateCommands();
            _ctrl.LoadRecentProjects();
            _ctrl.LoadUnityVersions();
        }

        public IList<UnityProject> RecentProjects
        {
            get => _recentProjects;
            set
            {
                _recentProjects = value;
                RebuildRecent();
            }
        }

        public IList<UnityVersion> Versions
        {
            get => _versions;
            set
            {
                _versions = value;
                RebuildVersions();
            }
        }

        private void RebuildVersions()
        {
            versionFlowPanel.Controls.Clear();
            foreach (var v in _versions)
                versionFlowPanel.Controls.Add(CreateVersionsControl(v));
        }

        private Control CreateVersionsControl(UnityVersion unityVersion) => new UnityVersionTile(unityVersion,
            _commands);

        private void RebuildRecent()
        {
            projectFlowPanel.Controls.Clear();

            foreach (var p in _recentProjects)
                projectFlowPanel.Controls.Add(CreateControl(p));
        }

        private UserControl CreateControl(UnityProject p) => new ProjectTile(p, metroStyleManager,
            _ctrl.CreateCommands());


        private IMainFormController _ctrl;
        private IList<UnityProject> _recentProjects;

        private IList<UnityVersion> _versions;


        private void SetStyleToProjectMode()
        {
            metroStyleManager.Style = MetroColorStyle.Blue;
            Style = MetroColorStyle.Blue;
            Text = "Projects";
            Refresh();
        }

        private void SetStyleToUnityVersionMode()
        {
            metroStyleManager.Style = MetroColorStyle.Green;
            Style = MetroColorStyle.Green;
            Text = "Versions";
            Refresh();
        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0) SetStyleToProjectMode();
            else SetStyleToUnityVersionMode();
        }


        private void Click_ProjectMenu(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            ShowApp();
        }

        private void Click_VersionsMenu(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 1;
            ShowApp();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowApp();
        }
    }
}