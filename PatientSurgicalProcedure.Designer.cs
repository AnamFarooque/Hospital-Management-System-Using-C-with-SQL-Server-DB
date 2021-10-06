namespace HospitalManagement
{
    partial class PatientSurgicalProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientSurgicalProcedure));
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateTimePicker_Appointment = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_Doctor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.procedureName_txt = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelPatientRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_PopUp = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelPatientRegister.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(280, 20);
            this.lblServerStatus.Text = "ePatient Management System Version 1.0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServerStatus,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(130, 611);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(561, 25);
            this.statusStrip1.TabIndex = 17;
            // 
            // dateTimePicker_Appointment
            // 
            this.dateTimePicker_Appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Appointment.Location = new System.Drawing.Point(45, 21);
            this.dateTimePicker_Appointment.Name = "dateTimePicker_Appointment";
            this.dateTimePicker_Appointment.Size = new System.Drawing.Size(296, 24);
            this.dateTimePicker_Appointment.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker_Appointment);
            this.groupBox3.Location = new System.Drawing.Point(43, 291);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 65);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Date";
            // 
            // comboBox_Doctor
            // 
            this.comboBox_Doctor.FormattingEnabled = true;
            this.comboBox_Doctor.Location = new System.Drawing.Point(44, 21);
            this.comboBox_Doctor.Name = "comboBox_Doctor";
            this.comboBox_Doctor.Size = new System.Drawing.Size(297, 24);
            this.comboBox_Doctor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Doctor);
            this.groupBox2.Location = new System.Drawing.Point(43, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 67);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Doctor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.procedureName_txt);
            this.groupBox1.Location = new System.Drawing.Point(43, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 65);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Surgical Procedure Name";
            // 
            // procedureName_txt
            // 
            this.procedureName_txt.Location = new System.Drawing.Point(44, 26);
            this.procedureName_txt.Name = "procedureName_txt";
            this.procedureName_txt.Size = new System.Drawing.Size(297, 22);
            this.procedureName_txt.TabIndex = 0;
            // 
            // flowLayoutPanelPatientRegister
            // 
            this.flowLayoutPanelPatientRegister.AutoScroll = true;
            this.flowLayoutPanelPatientRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelPatientRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelPatientRegister.Controls.Add(this.groupBox4);
            this.flowLayoutPanelPatientRegister.Controls.Add(this.groupBox1);
            this.flowLayoutPanelPatientRegister.Controls.Add(this.groupBox2);
            this.flowLayoutPanelPatientRegister.Controls.Add(this.groupBox3);
            this.flowLayoutPanelPatientRegister.Controls.Add(this.Book);
            this.flowLayoutPanelPatientRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPatientRegister.Location = new System.Drawing.Point(130, 109);
            this.flowLayoutPanelPatientRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.flowLayoutPanelPatientRegister.Name = "flowLayoutPanelPatientRegister";
            this.flowLayoutPanelPatientRegister.Padding = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.flowLayoutPanelPatientRegister.Size = new System.Drawing.Size(561, 527);
            this.flowLayoutPanelPatientRegister.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPatientName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(43, 40);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 65);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Patient";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(149, 24);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(63, 17);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "MyName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Patient Name: ";
            // 
            // Book
            // 
            this.Book.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Book.AutoSize = true;
            this.Book.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Book.Image = global::HospitalManagement.Properties.Resources.Assign1;
            this.Book.Location = new System.Drawing.Point(100, 386);
            this.Book.Margin = new System.Windows.Forms.Padding(60, 15, 3, 3);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(263, 102);
            this.Book.TabIndex = 24;
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Assign_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(4, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(460, 41);
            this.label10.TabIndex = 15;
            this.label10.Text = "Patient Surgical Procedure Assign";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(130, 57);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(561, 52);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "ePatient App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_PopUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(399, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 57);
            this.panel1.TabIndex = 16;
            // 
            // btn_PopUp
            // 
            this.btn_PopUp.BackColor = System.Drawing.Color.White;
            this.btn_PopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PopUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PopUp.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_PopUp.Image = global::HospitalManagement.Properties.Resources._employee___Copy1;
            this.btn_PopUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PopUp.Location = new System.Drawing.Point(0, 0);
            this.btn_PopUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PopUp.Name = "btn_PopUp";
            this.btn_PopUp.Size = new System.Drawing.Size(162, 44);
            this.btn_PopUp.TabIndex = 15;
            this.btn_PopUp.Text = "Admin Panel";
            this.btn_PopUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PopUp.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(130, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(561, 57);
            this.panelHeader.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 636);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "Appointment";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(3, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 79);
            this.button4.TabIndex = 2;
            this.button4.Text = "Search";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "Info";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PatientSurgicalProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 636);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanelPatientRegister);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PatientSurgicalProcedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientSurgicalProcedure";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanelPatientRegister.ResumeLayout(false);
            this.flowLayoutPanelPatientRegister.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PopUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lblServerStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Appointment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_Doctor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPatientRegister;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox procedureName_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label label4;
    }
}