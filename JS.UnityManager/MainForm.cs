using System.Windows.Forms;
using MetroFramework.Forms;

namespace JS.UnityManager
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Visible = true;
        }

        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}