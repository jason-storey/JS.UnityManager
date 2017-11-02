using System;
using System.Drawing;
using System.Windows.Forms;
using JS.UnityManager.App;
using MetroFramework;
using MetroFramework.Components;

namespace JS.UnityManager
{
    public partial class ProjectTile : UserControl
    {
        private MetroStyleManager metroStyleManager;

  

        public ProjectTile(UnityProject project, MetroStyleManager metroStyleManager)
        {
            this.metroStyleManager = metroStyleManager;
            InitializeComponent();
            lblTitle.Text = project.Name;
            var days = (DateTime.Now - project.LastModified).Days;
            lblDays.Text = days <= 1 ? "Today" : days + " Days Ago";
            
            BackColor = MetroColors.Blue;

        }

        private void ProjectTile_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void ProjectTile_MouseLeave(object sender, EventArgs e)
        {
          
        }
    }
}
