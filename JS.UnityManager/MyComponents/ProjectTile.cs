using System;
using System.Drawing;
using System.Windows.Forms;
using DarkerSmile.UnityManagement;
using JS.UnityManager.App;
using MetroFramework;
using MetroFramework.Components;

namespace JS.UnityManager
{
    public partial class ProjectTile : UserControl
    {
        private MetroStyleManager metroStyleManager;
        private readonly IUnityManagerCommands _commands;

        private UnityProject _project;
        public ProjectTile(UnityProject project, MetroStyleManager metroStyleManager, IUnityManagerCommands commands)
        {
            this.metroStyleManager = metroStyleManager;
            _commands = commands;
            _project = project;
            InitializeComponent();
            lblTitle.Text = project.ProjectName;
            lblDays.Text = project.LastModified.HasValue ? project.LastModified.Value.ToString("dd MMM yy") : "";
            lblVersion.Text = project.Version;

            if (!_commands.IsVersionInstalled(_project))
            {
                notInstalledPictureBox1.Visible = true;
                var item = new ToolStripMenuItem("Install Required Unity Version") {ForeColor = MetroColors.Red};
                item.Click += (sender, args) => _commands.TryInstallUnityVersionFor(_project);
                contextMenu1.Items.Add(item);
            }
            else
            {
                notInstalledPictureBox1.Visible = false;
                installedBox1.ForeColor = MetroColors.Green;
            }
           VisuallyDeSelect();
        }



        void VisuallySelect()
        {
            BackColor = MetroColors.Blue;
            headerPanel.BackColor = MetroColors.Blue;
            pnl_Bottom.BackColor = _commands.IsVersionInstalled(_project) ? MetroColors.Blue : MetroColors.Silver;
            //   pnl_Bottom.BackColor = MetroColors.White;
            lblTitle.ForeColor = MetroColors.White;
            lblDays.ForeColor = MetroColors.White;
            //  lblVersion.ForeColor = MetroColors.Black;
            
        }

        void VisuallyDeSelect()
        {
            
            BackColor = MetroColors.Blue;
            headerPanel.BackColor = MetroColors.White;
            pnl_Bottom.BackColor = _commands.IsVersionInstalled(_project) ? MetroColors.Blue : MetroColors.Silver;
            lblVersion.ForeColor = Color.Black;
            lblTitle.ForeColor = MetroColors.Black;
            lblDays.ForeColor = MetroColors.Black;
            lblVersion.ForeColor = MetroColors.White;
        }

        private void headerPanel_MouseEnter(object sender, EventArgs e)
        {
            VisuallySelect();
        }

        private void headerPanel_MouseLeave(object sender, EventArgs e)
        {

            VisuallyDeSelect();
        }

        private void headerPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _commands.OpenProject(_project);
           
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _commands.OpenProject(_project);
        }

        private void exploreDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _commands.OpenProjectFolder(_project);
        }

        private void headerPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenu1.Show(this, new Point(this.Width - contextMenu1.Width, 0));
            }
        }
    }
}
