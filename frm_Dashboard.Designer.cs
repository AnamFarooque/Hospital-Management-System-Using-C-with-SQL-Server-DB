namespace CMSWinApp
{
    partial class frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panelMainCenter = new System.Windows.Forms.Panel();
            this.panelMainCenterCenter = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTiles = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMainCenterBottom = new System.Windows.Forms.Panel();
            this.panelBootmLeft = new System.Windows.Forms.Panel();
            this.panelExitRightBottom = new System.Windows.Forms.Panel();
            this.btn_Tile_MonitoringForAgent = new System.Windows.Forms.Button();
            this.btn_Tile_PersonalView = new System.Windows.Forms.Button();
            this.btn_Tile_Review = new System.Windows.Forms.Button();
            this.btn_Tile_AuditReports = new System.Windows.Forms.Button();
            this.btn_Tile_AllowMonitoringWithOutSales = new System.Windows.Forms.Button();
            this.btn_Tile_DeleteMonitoring = new System.Windows.Forms.Button();
            this.btn_Tile_MonitoringInterval = new System.Windows.Forms.Button();
            this.btn_Tile_ResendUnknownEmails = new System.Windows.Forms.Button();
            this.btn_Tile_Reports = new System.Windows.Forms.Button();
            this.btn_Tile_AgentSession = new System.Windows.Forms.Button();
            this.btn_Tile_DiscardMonitoring = new System.Windows.Forms.Button();
            this.btn_Tile_GATMonitoring = new System.Windows.Forms.Button();
            this.btn_Tile_ReviewGATMonitoring = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_PopUp = new System.Windows.Forms.Button();
//            this.newsTicker1 = new CMSWinApp.NewsTicker();
  //          this.uC_UserProfile1 = new CMSWinApp.UC_UserProfile();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelMainCenter.SuspendLayout();
            this.panelMainCenterCenter.SuspendLayout();
            this.flowLayoutPanelTiles.SuspendLayout();
            this.panelMainCenterBottom.SuspendLayout();
            this.panelBootmLeft.SuspendLayout();
            this.panelExitRightBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.label10);
//            this.panelHeader.Controls.Add(this.uC_UserProfile1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1142, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_PopUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(725, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 60);
            this.panel1.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(36, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 54);
            this.label10.TabIndex = 14;
            this.label10.Text = "Dashboard";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panelMainCenter);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1142, 600);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 60);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1142, 622);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServerStatus,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1142, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(92, 17);
            this.lblServerStatus.Text = "CMS Version 4.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // panelMainCenter
            // 
            this.panelMainCenter.AutoScroll = true;
            this.panelMainCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMainCenter.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainCenter.Controls.Add(this.panelMainCenterCenter);
            this.panelMainCenter.Controls.Add(this.panelMainCenterBottom);
            this.panelMainCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainCenter.Location = new System.Drawing.Point(0, 0);
            this.panelMainCenter.Name = "panelMainCenter";
            this.panelMainCenter.Size = new System.Drawing.Size(1142, 600);
            this.panelMainCenter.TabIndex = 3;
            // 
            // panelMainCenterCenter
            // 
            this.panelMainCenterCenter.Controls.Add(this.flowLayoutPanelTiles);
            this.panelMainCenterCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainCenterCenter.Location = new System.Drawing.Point(0, 0);
            this.panelMainCenterCenter.Name = "panelMainCenterCenter";
            this.panelMainCenterCenter.Size = new System.Drawing.Size(1142, 539);
            this.panelMainCenterCenter.TabIndex = 1;
            // 
            // flowLayoutPanelTiles
            // 
            this.flowLayoutPanelTiles.AutoScroll = true;
            this.flowLayoutPanelTiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_MonitoringForAgent);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_PersonalView);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_Review);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_AuditReports);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_AllowMonitoringWithOutSales);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_DeleteMonitoring);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_MonitoringInterval);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_ResendUnknownEmails);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_Reports);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_AgentSession);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_DiscardMonitoring);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_GATMonitoring);
            this.flowLayoutPanelTiles.Controls.Add(this.btn_Tile_ReviewGATMonitoring);
            this.flowLayoutPanelTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTiles.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTiles.Name = "flowLayoutPanelTiles";
            this.flowLayoutPanelTiles.Padding = new System.Windows.Forms.Padding(30);
            this.flowLayoutPanelTiles.Size = new System.Drawing.Size(1142, 539);
            this.flowLayoutPanelTiles.TabIndex = 2;
            // 
            // panelMainCenterBottom
            // 
            this.panelMainCenterBottom.BackColor = System.Drawing.Color.White;
            this.panelMainCenterBottom.Controls.Add(this.panelBootmLeft);
            this.panelMainCenterBottom.Controls.Add(this.panelExitRightBottom);
            this.panelMainCenterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainCenterBottom.Location = new System.Drawing.Point(0, 539);
            this.panelMainCenterBottom.Name = "panelMainCenterBottom";
            this.panelMainCenterBottom.Size = new System.Drawing.Size(1142, 61);
            this.panelMainCenterBottom.TabIndex = 0;
            // 
            // panelBootmLeft
            // 
//            this.panelBootmLeft.Controls.Add(this.newsTicker1);
            this.panelBootmLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBootmLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBootmLeft.Name = "panelBootmLeft";
            this.panelBootmLeft.Padding = new System.Windows.Forms.Padding(20);
            this.panelBootmLeft.Size = new System.Drawing.Size(1015, 61);
            this.panelBootmLeft.TabIndex = 2;
            // 
            // panelExitRightBottom
            // 
            this.panelExitRightBottom.Controls.Add(this.btn_Exit);
            this.panelExitRightBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExitRightBottom.Location = new System.Drawing.Point(1015, 0);
            this.panelExitRightBottom.Name = "panelExitRightBottom";
            this.panelExitRightBottom.Size = new System.Drawing.Size(127, 61);
            this.panelExitRightBottom.TabIndex = 1;
            // 
            // btn_Tile_MonitoringForAgent
            // 
            this.btn_Tile_MonitoringForAgent.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_MonitoringForAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_MonitoringForAgent.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_MonitoringForAgent.Image")));
            this.btn_Tile_MonitoringForAgent.Location = new System.Drawing.Point(33, 33);
            this.btn_Tile_MonitoringForAgent.Name = "btn_Tile_MonitoringForAgent";
            this.btn_Tile_MonitoringForAgent.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_MonitoringForAgent.TabIndex = 16;
            this.btn_Tile_MonitoringForAgent.UseVisualStyleBackColor = false;
            this.btn_Tile_MonitoringForAgent.Click += new System.EventHandler(this.btn_Tile_MonitoringForAgent_Click);
            // 
            // btn_Tile_PersonalView
            // 
            this.btn_Tile_PersonalView.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_PersonalView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_PersonalView.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_PersonalView.Image")));
            this.btn_Tile_PersonalView.Location = new System.Drawing.Point(411, 33);
            this.btn_Tile_PersonalView.Name = "btn_Tile_PersonalView";
            this.btn_Tile_PersonalView.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_PersonalView.TabIndex = 20;
            this.btn_Tile_PersonalView.UseVisualStyleBackColor = false;
            this.btn_Tile_PersonalView.Click += new System.EventHandler(this.btn_Tile_PersonalView_Click);
            // 
            // btn_Tile_Review
            // 
            this.btn_Tile_Review.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_Review.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_Review.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_Review.Image")));
            this.btn_Tile_Review.Location = new System.Drawing.Point(33, 184);
            this.btn_Tile_Review.Name = "btn_Tile_Review";
            this.btn_Tile_Review.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_Review.TabIndex = 21;
            this.btn_Tile_Review.UseVisualStyleBackColor = false;
            this.btn_Tile_Review.Click += new System.EventHandler(this.btn_Tile_Review_Click);
            // 
            // btn_Tile_AuditReports
            // 
            this.btn_Tile_AuditReports.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_AuditReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_AuditReports.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_AuditReports.Image")));
            this.btn_Tile_AuditReports.Location = new System.Drawing.Point(411, 184);
            this.btn_Tile_AuditReports.Name = "btn_Tile_AuditReports";
            this.btn_Tile_AuditReports.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_AuditReports.TabIndex = 14;
            this.btn_Tile_AuditReports.UseVisualStyleBackColor = false;
            this.btn_Tile_AuditReports.Click += new System.EventHandler(this.btn_Tile_AuditReports_Click);
            // 
            // btn_Tile_AllowMonitoringWithOutSales
            // 
            this.btn_Tile_AllowMonitoringWithOutSales.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_AllowMonitoringWithOutSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_AllowMonitoringWithOutSales.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_AllowMonitoringWithOutSales.Image")));
            this.btn_Tile_AllowMonitoringWithOutSales.Location = new System.Drawing.Point(33, 335);
            this.btn_Tile_AllowMonitoringWithOutSales.Name = "btn_Tile_AllowMonitoringWithOutSales";
            this.btn_Tile_AllowMonitoringWithOutSales.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_AllowMonitoringWithOutSales.TabIndex = 13;
            this.btn_Tile_AllowMonitoringWithOutSales.UseVisualStyleBackColor = false;
            this.btn_Tile_AllowMonitoringWithOutSales.Click += new System.EventHandler(this.btn_Tile_AllowMonitoringWithOutSales_Click);
            // 
            // btn_Tile_DeleteMonitoring
            // 
            this.btn_Tile_DeleteMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_DeleteMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_DeleteMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_DeleteMonitoring.Image")));
            this.btn_Tile_DeleteMonitoring.Location = new System.Drawing.Point(411, 335);
            this.btn_Tile_DeleteMonitoring.Name = "btn_Tile_DeleteMonitoring";
            this.btn_Tile_DeleteMonitoring.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_DeleteMonitoring.TabIndex = 15;
            this.btn_Tile_DeleteMonitoring.UseVisualStyleBackColor = false;
            this.btn_Tile_DeleteMonitoring.Click += new System.EventHandler(this.btn_Tile_DeleteMonitoring_Click);
            // 
            // btn_Tile_MonitoringInterval
            // 
            this.btn_Tile_MonitoringInterval.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_MonitoringInterval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_MonitoringInterval.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_MonitoringInterval.Image")));
            this.btn_Tile_MonitoringInterval.Location = new System.Drawing.Point(33, 486);
            this.btn_Tile_MonitoringInterval.Name = "btn_Tile_MonitoringInterval";
            this.btn_Tile_MonitoringInterval.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_MonitoringInterval.TabIndex = 18;
            this.btn_Tile_MonitoringInterval.UseVisualStyleBackColor = false;
            this.btn_Tile_MonitoringInterval.Click += new System.EventHandler(this.btn_Tile_MonitoringInterval_Click);
            // 
            // btn_Tile_ResendUnknownEmails
            // 
            this.btn_Tile_ResendUnknownEmails.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_ResendUnknownEmails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_ResendUnknownEmails.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_ResendUnknownEmails.Image")));
            this.btn_Tile_ResendUnknownEmails.Location = new System.Drawing.Point(411, 486);
            this.btn_Tile_ResendUnknownEmails.Name = "btn_Tile_ResendUnknownEmails";
            this.btn_Tile_ResendUnknownEmails.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_ResendUnknownEmails.TabIndex = 19;
            this.btn_Tile_ResendUnknownEmails.UseVisualStyleBackColor = false;
            this.btn_Tile_ResendUnknownEmails.Click += new System.EventHandler(this.btn_Tile_ResendUnknownEmails_Click);
            // 
            // btn_Tile_Reports
            // 
            this.btn_Tile_Reports.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_Reports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tile_Reports.BackgroundImage")));
            this.btn_Tile_Reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_Reports.Location = new System.Drawing.Point(33, 637);
            this.btn_Tile_Reports.Name = "btn_Tile_Reports";
            this.btn_Tile_Reports.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_Reports.TabIndex = 23;
            this.btn_Tile_Reports.UseVisualStyleBackColor = false;
            this.btn_Tile_Reports.Click += new System.EventHandler(this.btn_Tile_Reports_Click);
            // 
            // btn_Tile_AgentSession
            // 
            this.btn_Tile_AgentSession.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_AgentSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_AgentSession.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_AgentSession.Image")));
            this.btn_Tile_AgentSession.Location = new System.Drawing.Point(411, 637);
            this.btn_Tile_AgentSession.Name = "btn_Tile_AgentSession";
            this.btn_Tile_AgentSession.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_AgentSession.TabIndex = 24;
            this.btn_Tile_AgentSession.UseVisualStyleBackColor = false;
            this.btn_Tile_AgentSession.Click += new System.EventHandler(this.btn_Tile_AgentSession_Click);
            // 
            // btn_Tile_DiscardMonitoring
            // 
            this.btn_Tile_DiscardMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_DiscardMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_DiscardMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_DiscardMonitoring.Image")));
            this.btn_Tile_DiscardMonitoring.Location = new System.Drawing.Point(33, 788);
            this.btn_Tile_DiscardMonitoring.Name = "btn_Tile_DiscardMonitoring";
            this.btn_Tile_DiscardMonitoring.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_DiscardMonitoring.TabIndex = 25;
            this.btn_Tile_DiscardMonitoring.UseVisualStyleBackColor = false;
            this.btn_Tile_DiscardMonitoring.Click += new System.EventHandler(this.btn_Tile_DiscardMonitoring_Click);
            // 
            // btn_Tile_GATMonitoring
            // 
            this.btn_Tile_GATMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_GATMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tile_GATMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tile_GATMonitoring.Image")));
            this.btn_Tile_GATMonitoring.Location = new System.Drawing.Point(411, 788);
            this.btn_Tile_GATMonitoring.Name = "btn_Tile_GATMonitoring";
            this.btn_Tile_GATMonitoring.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_GATMonitoring.TabIndex = 27;
            this.btn_Tile_GATMonitoring.UseVisualStyleBackColor = false;
            this.btn_Tile_GATMonitoring.Click += new System.EventHandler(this.btn_Tile_GATMonitoring_Click);
            // 
            // btn_Tile_ReviewGATMonitoring
            // 
            this.btn_Tile_ReviewGATMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tile_ReviewGATMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.btn_Tile_ReviewGATMonitoring.Image = global::CMSWinApp.Properties.Resources.GATMonitoringReview;
            this.btn_Tile_ReviewGATMonitoring.Location = new System.Drawing.Point(33, 939);
            this.btn_Tile_ReviewGATMonitoring.Name = "btn_Tile_ReviewGATMonitoring";
            this.btn_Tile_ReviewGATMonitoring.Size = new System.Drawing.Size(372, 145);
            this.btn_Tile_ReviewGATMonitoring.TabIndex = 28;
            this.btn_Tile_ReviewGATMonitoring.UseVisualStyleBackColor = false;
            this.btn_Tile_ReviewGATMonitoring.Click += new System.EventHandler(this.btn_Tile_ReviewGATMonitoring_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
//            this.btn_Exit.BackgroundImage = global::CMSWinApp.Properties.Resources.Exit;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(4, 7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 43);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_PopUp
            // 
            this.btn_PopUp.BackColor = System.Drawing.Color.White;
            this.btn_PopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PopUp.ForeColor = System.Drawing.Color.Red;
//            this.btn_PopUp.Image = global::CMSWinApp.Properties.Resources.bell;
            this.btn_PopUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PopUp.Location = new System.Drawing.Point(41, 9);
            this.btn_PopUp.Name = "btn_PopUp";
            this.btn_PopUp.Size = new System.Drawing.Size(67, 42);
            this.btn_PopUp.TabIndex = 15;
            this.btn_PopUp.Text = "0";
            this.btn_PopUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PopUp.UseVisualStyleBackColor = false;
            this.btn_PopUp.Click += new System.EventHandler(this.btn_PopUp_Click);
            // 
            // newsTicker1
            // 
///            this.newsTicker1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.newsTicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.newsTicker1.Location = new System.Drawing.Point(20, 20);
//            this.newsTicker1.Name = "newsTicker1";
//            this.newsTicker1.Size = new System.Drawing.Size(975, 21);
//            this.newsTicker1.TabIndex = 0;
//            this.newsTicker1.Text = "newsTicker1";
            // 
            // uC_UserProfile1
            // 
            //this.uC_UserProfile1.AutoSize = true;
            //this.uC_UserProfile1.BackColor = System.Drawing.Color.Transparent;
            //this.uC_UserProfile1.Dock = System.Windows.Forms.DockStyle.Right;
            //this.uC_UserProfile1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.uC_UserProfile1.Location = new System.Drawing.Point(925, 0);
            //this.uC_UserProfile1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            //this.uC_UserProfile1.Name = "uC_UserProfile1";
            //this.uC_UserProfile1.Size = new System.Drawing.Size(217, 60);
            //this.uC_UserProfile1.TabIndex = 0;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 682);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Dashboard";
            this.Text = "...::Version : Beta 1.0.0.0:::...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Dashboard_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMainCenter.ResumeLayout(false);
            this.panelMainCenterCenter.ResumeLayout(false);
            this.flowLayoutPanelTiles.ResumeLayout(false);
            this.panelMainCenterBottom.ResumeLayout(false);
            this.panelBootmLeft.ResumeLayout(false);
            this.panelExitRightBottom.ResumeLayout(false);
            this.panelExitRightBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panelMainCenter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServerStatus;
      //  private UC_UserProfile uC_UserProfile1;
        private System.Windows.Forms.Panel panelMainCenterCenter;
        private System.Windows.Forms.Panel panelMainCenterBottom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTiles;
        private System.Windows.Forms.Button btn_Tile_AllowMonitoringWithOutSales;
        private System.Windows.Forms.Button btn_Tile_AuditReports;
        private System.Windows.Forms.Button btn_Tile_DeleteMonitoring;
        private System.Windows.Forms.Button btn_Tile_MonitoringForAgent;
        private System.Windows.Forms.Button btn_Tile_MonitoringInterval;
        private System.Windows.Forms.Button btn_Tile_ResendUnknownEmails;
        private System.Windows.Forms.Button btn_Tile_PersonalView;
        private System.Windows.Forms.Button btn_Tile_Review;
        private System.Windows.Forms.Panel panelExitRightBottom;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panelBootmLeft;
        private NewsTicker newsTicker1;
        private System.Windows.Forms.Button btn_Tile_Reports;
        private System.Windows.Forms.Button btn_Tile_AgentSession;
        private System.Windows.Forms.Button btn_Tile_DiscardMonitoring;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_PopUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btn_Tile_GATMonitoring;
        private System.Windows.Forms.Button btn_Tile_ReviewGATMonitoring;
    }
}

