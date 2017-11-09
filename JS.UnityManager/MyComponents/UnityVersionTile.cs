using System.Drawing;
using System.Windows.Forms;
using DarkerSmile.UnityManagement;
using JS.UnityManager.App;
using MetroFramework;

namespace JS.UnityManager
{
    public partial class UnityVersionTile : UserControl
    {
        private UnityVersion unityVersion;
        private readonly IUnityManagerCommands _commands;


        public UnityVersionTile(UnityVersion unityVersion, IUnityManagerCommands commands)
        {
            InitializeComponent();
            this.unityVersion = unityVersion;
            _commands = commands;
            label1.Text = unityVersion.Version;
            var col = unityVersion.Installed ? MetroColors.Green : MetroColors.Red;
            panel1.BackColor = col;
            VisuallyDeSelect();
            MouseEnter += (o, args) => VisuallySelect();
            MouseLeave += (sender, args) => VisuallyDeSelect();
        }

        private void UnityVersionTile_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                metroContextMenu1.Show(this, new Point(this.Width-metroContextMenu1.Width,0));
            }
        }

      
        private void UnityVersionTile_Leave(object sender, System.EventArgs e)
        {
            metroContextMenu1.Hide();
            VisuallyDeSelect();
        }

        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _commands.LaunchVersion(this.unityVersion);
   
        }

        private void openFolderToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _commands.OpenVersionFolder(this.unityVersion);
   
        }

        private void UnityVersionTile_Load(object sender, System.EventArgs e)
        {

        }

        private void UnityVersionTile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _commands.LaunchVersion(this.unityVersion);
        
        }

        void VisuallySelect()
        {
            var col = unityVersion.Installed ? MetroColors.Green : MetroColors.Red;
            BorderStyle = BorderStyle.FixedSingle;
            panel1.BackColor = MetroColors.Green;
            BackColor = col;

            label1.ForeColor = Color.White;
        }

        void VisuallyDeSelect()
        {
            var col = unityVersion.Installed ? MetroColors.Green : MetroColors.Red;
            BorderStyle = BorderStyle.None;
            label1.ForeColor = Color.Black;
            BorderStyle = BorderStyle.FixedSingle;
            panel1.BackColor = col;
            BackColor = Color.White;
            
        }

        private void UnityVersionTile_Enter(object sender, System.EventArgs e)
        {
            VisuallySelect();
        }

        private void viewReleaseNotesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _commands.ViewReleaseNotes(unityVersion);
        }
    }
}