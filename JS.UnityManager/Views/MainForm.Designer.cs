namespace JS.UnityManager
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.projectFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panelVersionActions = new System.Windows.Forms.Panel();
            this.versionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unityVersionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Unity Manager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Recent Projects";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(623, 404);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.metroTabControl1_Selected);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.projectFlowPanel);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(615, 362);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "PROJECTS";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // projectFlowPanel
            // 
            this.projectFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectFlowPanel.AutoScroll = true;
            this.projectFlowPanel.BackColor = System.Drawing.Color.White;
            this.projectFlowPanel.Location = new System.Drawing.Point(21, 34);
            this.projectFlowPanel.Name = "projectFlowPanel";
            this.projectFlowPanel.Size = new System.Drawing.Size(591, 332);
            this.projectFlowPanel.TabIndex = 5;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.panelVersionActions);
            this.metroTabPage2.Controls.Add(this.versionFlowPanel);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(615, 362);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "UNITY VERSIONS";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(491, 308);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 51);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Install New Version";
            this.metroButton1.UseSelectable = true;
            // 
            // panelVersionActions
            // 
            this.panelVersionActions.Location = new System.Drawing.Point(3, 299);
            this.panelVersionActions.Name = "panelVersionActions";
            this.panelVersionActions.Size = new System.Drawing.Size(609, 2);
            this.panelVersionActions.TabIndex = 3;
            // 
            // versionFlowPanel
            // 
            this.versionFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionFlowPanel.AutoScroll = true;
            this.versionFlowPanel.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.versionFlowPanel.BackColor = System.Drawing.Color.White;
            this.versionFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.versionFlowPanel.Location = new System.Drawing.Point(3, 13);
            this.versionFlowPanel.Name = "versionFlowPanel";
            this.versionFlowPanel.Size = new System.Drawing.Size(609, 279);
            this.versionFlowPanel.TabIndex = 2;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.unityVersionsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.Click_ProjectMenu);
            // 
            // unityVersionsToolStripMenuItem
            // 
            this.unityVersionsToolStripMenuItem.Name = "unityVersionsToolStripMenuItem";
            this.unityVersionsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.unityVersionsToolStripMenuItem.Text = "Unity Versions";
            this.unityVersionsToolStripMenuItem.Click += new System.EventHandler(this.Click_VersionsMenu);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 492);
            this.Controls.Add(this.metroTabControl1);
            this.MinimumSize = new System.Drawing.Size(360, 345);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Unity Manager";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.FlowLayoutPanel projectFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel versionFlowPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unityVersionsToolStripMenuItem;
        private System.Windows.Forms.Panel panelVersionActions;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

