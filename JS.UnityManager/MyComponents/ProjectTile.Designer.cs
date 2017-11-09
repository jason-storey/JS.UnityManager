namespace JS.UnityManager
{
    partial class ProjectTile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectTile));
            this.lblTitle = new JS.UnityManager.PassLabel();
            this.lblDays = new JS.UnityManager.PassLabel();
            this.installedBox1 = new JS.UnityManager.PassPictureBox();
            this.lblVersion = new JS.UnityManager.PassLabel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.notInstalledPictureBox1 = new JS.UnityManager.PassPictureBox();
            this.contextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploreDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeUnityVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.installedBox1)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notInstalledPictureBox1)).BeginInit();
            this.contextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.CausesValidation = false;
            this.lblTitle.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(11, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 22);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label1";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.CausesValidation = false;
            this.lblDays.ForeColor = System.Drawing.Color.Black;
            this.lblDays.Location = new System.Drawing.Point(12, 29);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(35, 13);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "label1";
            // 
            // installedBox1
            // 
            this.installedBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.installedBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("installedBox1.BackgroundImage")));
            this.installedBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.installedBox1.Location = new System.Drawing.Point(255, 3);
            this.installedBox1.Name = "installedBox1";
            this.installedBox1.Size = new System.Drawing.Size(14, 13);
            this.installedBox1.TabIndex = 5;
            this.installedBox1.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(193, 4);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(55, 13);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "2017.3.5c";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblDays);
            this.headerPanel.Location = new System.Drawing.Point(1, 1);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(273, 73);
            this.headerPanel.TabIndex = 7;
            this.headerPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseClick);
            this.headerPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDoubleClick);
            this.headerPanel.MouseEnter += new System.EventHandler(this.headerPanel_MouseEnter);
            this.headerPanel.MouseLeave += new System.EventHandler(this.headerPanel_MouseLeave);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.notInstalledPictureBox1);
            this.pnl_Bottom.Controls.Add(this.lblVersion);
            this.pnl_Bottom.Controls.Add(this.installedBox1);
            this.pnl_Bottom.Location = new System.Drawing.Point(1, 57);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(273, 17);
            this.pnl_Bottom.TabIndex = 8;
            // 
            // notInstalledPictureBox1
            // 
            this.notInstalledPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notInstalledPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notInstalledPictureBox1.BackgroundImage")));
            this.notInstalledPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notInstalledPictureBox1.Location = new System.Drawing.Point(255, 3);
            this.notInstalledPictureBox1.Name = "notInstalledPictureBox1";
            this.notInstalledPictureBox1.Size = new System.Drawing.Size(14, 13);
            this.notInstalledPictureBox1.TabIndex = 7;
            this.notInstalledPictureBox1.TabStop = false;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.exploreDirectoryToolStripMenuItem,
            this.upgradeUnityVersionToolStripMenuItem});
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(192, 70);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // exploreDirectoryToolStripMenuItem
            // 
            this.exploreDirectoryToolStripMenuItem.Name = "exploreDirectoryToolStripMenuItem";
            this.exploreDirectoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exploreDirectoryToolStripMenuItem.Text = "Explore Directory";
            this.exploreDirectoryToolStripMenuItem.Click += new System.EventHandler(this.exploreDirectoryToolStripMenuItem_Click);
            // 
            // upgradeUnityVersionToolStripMenuItem
            // 
            this.upgradeUnityVersionToolStripMenuItem.Name = "upgradeUnityVersionToolStripMenuItem";
            this.upgradeUnityVersionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.upgradeUnityVersionToolStripMenuItem.Text = "Upgrade Unity Version";
            // 
            // ProjectTile
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.headerPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ProjectTile";
            this.Size = new System.Drawing.Size(275, 75);
            ((System.ComponentModel.ISupportInitialize)(this.installedBox1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notInstalledPictureBox1)).EndInit();
            this.contextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PassLabel lblTitle;
        private PassLabel lblDays;
        private PassPictureBox installedBox1;
        private PassLabel lblVersion;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel pnl_Bottom;
        private PassPictureBox notInstalledPictureBox1;
        private MetroFramework.Controls.MetroContextMenu contextMenu1;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploreDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradeUnityVersionToolStripMenuItem;
    }
}
