using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JS.UnityManager.App;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace JS.UnityManager
{
    public partial class MainForm : MetroForm,IMainFormView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                notifyIcon.Visible = true;
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }


        public void SetController(IMainFormController ctrl)
        {
            _ctrl = ctrl;
            _ctrl.LoadRecentProjects();
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

        private void RebuildRecent()
        {
            flowLayoutPanel1.Controls.Clear();
            
            for (int i = 0; i < _recentProjects.Count; i++)
            {

                var p = _recentProjects[i];
                flowLayoutPanel1.Controls.Add(CreateControl(p));
          
            }

          
        }

        private UserControl CreateControl(UnityProject p)
        {
            return new ProjectTile(p, metroStyleManager);
        }

        ListViewItem CreateLVI(UnityProject proj)
        {
            var lvp = new ListViewItem(proj.Name);
            lvp.SubItems.Add(proj.LastModified.ToShortDateString());
            return lvp;
        }

        private int xSpace = 5;
        private int tileWidth = 175;
        private int tileHeight = 100;


        private IMainFormController _ctrl;
        private IList<UnityProject> _recentProjects;

       


        private int viewIndex;
        List<View> _views = new List<View>
        {
            View.Details,View.LargeIcon,View.SmallIcon,View.List,View.Tile
        };


        void SetStyleToProjectMode()
        {
            metroStyleManager.Style = MetroColorStyle.Blue;
            this.Style = MetroColorStyle.Blue;
            this.Refresh();
        }

        void SetStyleToUnityVersionMode()
        {
            metroStyleManager.Style = MetroColorStyle.Green;
             this.Style = MetroColorStyle.Green;
            this.Refresh();

        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0) SetStyleToProjectMode();
            else SetStyleToUnityVersionMode();
        }
    }
}