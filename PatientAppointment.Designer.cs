namespace HospitalManagement
{
    partial class PatientAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAppointment));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPatientRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_patient = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Doctor = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Appointment = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.Book = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_PopUp = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanelPatientRegister.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 554);
            this.flowLayoutPanel1.TabIndex = 11;
            //this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(691, 57);
            this.panelHeader.TabIndex = 9;
           // this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
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
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_PopUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(529, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 57);
            this.panel1.TabIndex = 16;
          //  this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(130, 57);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(561, 52);
            this.flowLayoutPanel2.TabIndex = 8;
          //  this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
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
            this.label10.Size = new System.Drawing.Size(293, 41);
            this.label10.TabIndex = 15;
            this.label10.Text = "Patient Appointment";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           // this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // flowLayoutPanelPatientRegister
            // 
            this.flowLayoutPanelPatientRegister.AutoScroll = true;
            this.flowLayoutPanelPatientRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelPatientRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelPatientRegister.Controls.Add(this.groupBox1);
            this.flowLayoutPanelPatientRegister.Controls.Add(this.groupBox2);
            this.flowLayoutPanelPatientRegister.Controls.Add(this.groupBox3);
            this.flowLayoutPanelPatientRegister.Controls.Add(this.Book);
            this.flowLayoutPanelPatientRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPatientRegister.Location = new System.Drawing.Point(130, 109);
            this.flowLayoutPanelPatientRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.flowLayoutPanelPatientRegister.Name = "flowLayoutPanelPatientRegister";
            this.flowLayoutPanelPatientRegister.Padding = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.flowLayoutPanelPatientRegister.Size = new System.Drawing.Size(561, 502);
            this.flowLayoutPanelPatientRegister.TabIndex = 10;
           // this.flowLayoutPanelPatientRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelPatientRegister_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_patient);
            this.groupBox1.Location = new System.Drawing.Point(43, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 65);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Patient";
         //   this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox_patient
            // 
            this.comboBox_patient.FormattingEnabled = true;
            this.comboBox_patient.Location = new System.Drawing.Point(45, 20);
            this.comboBox_patient.Name = "comboBox_patient";
            this.comboBox_patient.Size = new System.Drawing.Size(297, 24);
            this.comboBox_patient.TabIndex = 1;
          //  this.comboBox_patient.SelectedIndexChanged += new System.EventHandler(this.comboBox_patient_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Doctor);
            this.groupBox2.Location = new System.Drawing.Point(43, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 67);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Doctor";
          //  this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox_Doctor
            // 
            this.comboBox_Doctor.FormattingEnabled = true;
            this.comboBox_Doctor.Location = new System.Drawing.Point(44, 21);
            this.comboBox_Doctor.Name = "comboBox_Doctor";
            this.comboBox_Doctor.Size = new System.Drawing.Size(297, 24);
            this.comboBox_Doctor.TabIndex = 0;
         //   this.comboBox_Doctor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Doctor_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker_Appointment);
            this.groupBox3.Location = new System.Drawing.Point(43, 208);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 65);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Date";
           // this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dateTimePicker_Appointment
            // 
            this.dateTimePicker_Appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Appointment.Location = new System.Drawing.Point(45, 21);
            this.dateTimePicker_Appointment.Name = "dateTimePicker_Appointment";
            this.dateTimePicker_Appointment.Size = new System.Drawing.Size(296, 24);
            this.dateTimePicker_Appointment.TabIndex = 27;
        //    this.dateTimePicker_Appointment.ValueChanged += new System.EventHandler(this.dateTimePicker_Appointment_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServerStatus,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 611);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(691, 25);
            this.statusStrip1.TabIndex = 12;
           // this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(280, 20);
            this.lblServerStatus.Text = "ePatient Management System Version 1.0";
          //  this.lblServerStatus.Click += new System.EventHandler(this.lblServerStatus_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
          //  this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // Book
            // 
            this.Book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Book.AutoSize = true;
            this.Book.Image = global::HospitalManagement.Properties.Resources.booking;
            this.Book.Location = new System.Drawing.Point(100, 303);
            this.Book.Margin = new System.Windows.Forms.Padding(60, 15, 3, 3);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(226, 90);
            this.Book.TabIndex = 24;
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.BookNow_Click);
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
            this.button1.Click += new System.EventHandler(this.Dashboard_Click);
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
            //this.button3.Click += new System.EventHandler(this.button3_Click);
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
          //  this.button4.Click += new System.EventHandler(this.button4_Click);
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
           // this.button2.Click += new System.EventHandler(this.button2_Click);
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
           // this.btn_PopUp.Click += new System.EventHandler(this.btn_PopUp_Click);
            // 
            // PatientAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 636);
            this.Controls.Add(this.flowLayoutPanelPatientRegister);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelHeader);
            this.Name = "PatientAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientAppointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientAppointment_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanelPatientRegister.ResumeLayout(false);
            this.flowLayoutPanelPatientRegister.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_PopUp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPatientRegister;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServerStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_Doctor;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.ComboBox comboBox_patient;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Appointment;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}