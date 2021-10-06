namespace HospitalManagement
{
    partial class PatientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegistration));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_UserName = new System.Windows.Forms.Button();
            this.flowLayoutPanelPatientRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.UploadImage = new System.Windows.Forms.Button();
            this.Patient_pictureBox = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.Capture = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_PatientID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StreetAddress = new System.Windows.Forms.TextBox();
            this.PhoneNo = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BloodGroup = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelPatientRegister.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patient_pictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 646);
            this.flowLayoutPanel1.TabIndex = 6;
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1167, 57);
            this.panelHeader.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "ePatient App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_UserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1005, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 57);
            this.panel1.TabIndex = 16;
            // 
            // btn_UserName
            // 
            this.btn_UserName.BackColor = System.Drawing.Color.White;
            this.btn_UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserName.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_UserName.Image = global::HospitalManagement.Properties.Resources._employee___Copy1;
            this.btn_UserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UserName.Location = new System.Drawing.Point(0, 0);
            this.btn_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UserName.Name = "btn_UserName";
            this.btn_UserName.Size = new System.Drawing.Size(162, 44);
            this.btn_UserName.TabIndex = 16;
            this.btn_UserName.Text = "Admin Panel";
            this.btn_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UserName.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelPatientRegister
            // 
            this.flowLayoutPanelPatientRegister.AutoScroll = true;
            this.flowLayoutPanelPatientRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelPatientRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelPatientRegister.Controls.Add(this.groupBox1);
            this.flowLayoutPanelPatientRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPatientRegister.Location = new System.Drawing.Point(130, 109);
            this.flowLayoutPanelPatientRegister.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelPatientRegister.Name = "flowLayoutPanelPatientRegister";
            this.flowLayoutPanelPatientRegister.Padding = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.flowLayoutPanelPatientRegister.Size = new System.Drawing.Size(1037, 594);
            this.flowLayoutPanelPatientRegister.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.UploadImage);
            this.groupBox1.Controls.Add(this.Patient_pictureBox);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.Capture);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Form";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label17.Location = new System.Drawing.Point(814, 240);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 19);
            this.label17.TabIndex = 13;
            this.label17.Text = "Uplaod Patient Image";
            // 
            // UploadImage
            // 
            this.UploadImage.BackColor = System.Drawing.Color.MistyRose;
            this.UploadImage.Location = new System.Drawing.Point(833, 274);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.Size = new System.Drawing.Size(106, 53);
            this.UploadImage.TabIndex = 12;
            this.UploadImage.Text = "Upload Image";
            this.UploadImage.UseVisualStyleBackColor = false;
            this.UploadImage.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // Patient_pictureBox
            // 
            this.Patient_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Patient_pictureBox.Location = new System.Drawing.Point(814, 51);
            this.Patient_pictureBox.Name = "Patient_pictureBox";
            this.Patient_pictureBox.Size = new System.Drawing.Size(146, 180);
            this.Patient_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Patient_pictureBox.TabIndex = 11;
            this.Patient_pictureBox.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(759, 448);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(96, 34);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Capture
            // 
            this.Capture.Location = new System.Drawing.Point(639, 448);
            this.Capture.Name = "Capture";
            this.Capture.Size = new System.Drawing.Size(96, 34);
            this.Capture.TabIndex = 9;
            this.Capture.Text = "Capture";
            this.Capture.UseVisualStyleBackColor = true;
            this.Capture.Click += new System.EventHandler(this.Capture_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_DateTimePicker);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txt_PatientID);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(314, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(479, 57);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // txt_DateTimePicker
            // 
            this.txt_DateTimePicker.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateTimePicker.Location = new System.Drawing.Point(266, 17);
            this.txt_DateTimePicker.Name = "txt_DateTimePicker";
            this.txt_DateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.txt_DateTimePicker.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(218, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "Date";
            // 
            // txt_PatientID
            // 
            this.txt_PatientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PatientID.Location = new System.Drawing.Point(120, 22);
            this.txt_PatientID.Name = "txt_PatientID";
            this.txt_PatientID.Size = new System.Drawing.Size(79, 20);
            this.txt_PatientID.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Patient ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.PhoneNo);
            this.groupBox4.Controls.Add(this.Email);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(32, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(761, 204);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Country);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.State);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.City);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.StreetAddress);
            this.groupBox5.Location = new System.Drawing.Point(6, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(742, 118);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Address";
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "Afghanistan",
            "Armenia",
            "Azerbaijan",
            "Bahrain",
            "Bangladesh",
            "Bhutan",
            "Brunei",
            "Cambodia",
            "China",
            "Cyprus",
            "East Timor",
            "Georgia",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Israel",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Lebanon",
            "Malaysia",
            "Maldives",
            "Mongolia",
            "Myanmar",
            "Nepal",
            "North Korea",
            "Oman",
            "Pakistan",
            "Philippines",
            "Qatar",
            "Saudi Arabia",
            "Singapore",
            "South Korea",
            "Sri Lanka",
            "State of Palestine",
            "Syria",
            "Tajikistan",
            "Thailand",
            "Turkey",
            "Turkmenistan",
            "United Arab Emirates",
            "Uzbekistan",
            "Vietnam",
            "Yemen"});
            this.Country.Location = new System.Drawing.Point(612, 68);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(121, 27);
            this.Country.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(547, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "Country";
            // 
            // State
            // 
            this.State.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.State.Location = new System.Drawing.Point(364, 76);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(170, 20);
            this.State.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(246, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "State/Province";
            // 
            // City
            // 
            this.City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.City.Location = new System.Drawing.Point(48, 77);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(170, 20);
            this.City.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Street Address";
            // 
            // StreetAddress
            // 
            this.StreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StreetAddress.Location = new System.Drawing.Point(122, 36);
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.Size = new System.Drawing.Size(611, 20);
            this.StreetAddress.TabIndex = 10;
            // 
            // PhoneNo
            // 
            this.PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNo.Location = new System.Drawing.Point(381, 23);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(170, 20);
            this.PhoneNo.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.Location = new System.Drawing.Point(66, 25);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(170, 20);
            this.Email.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phone No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BloodGroup);
            this.groupBox3.Controls.Add(this.Gender);
            this.groupBox3.Controls.Add(this.Age);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(761, 69);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Info";
            // 
            // BloodGroup
            // 
            this.BloodGroup.DisplayMember = "Select";
            this.BloodGroup.FormattingEnabled = true;
            this.BloodGroup.Items.AddRange(new object[] {
            "Select",
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.BloodGroup.Location = new System.Drawing.Point(618, 20);
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.Size = new System.Drawing.Size(121, 27);
            this.BloodGroup.TabIndex = 8;
            // 
            // Gender
            // 
            this.Gender.DisplayMember = "Select";
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Select",
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(315, 20);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 27);
            this.Gender.TabIndex = 7;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(66, 21);
            this.Age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(120, 27);
            this.Age.TabIndex = 6;
            this.Age.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Blood Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Age";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LastName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.MiddleName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FirstName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 58);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // LastName
            // 
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Location = new System.Drawing.Point(557, 25);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(182, 20);
            this.LastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last";
            // 
            // MiddleName
            // 
            this.MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiddleName.Location = new System.Drawing.Point(315, 27);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(182, 20);
            this.MiddleName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle";
            // 
            // FirstName
            // 
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstName.Location = new System.Drawing.Point(56, 27);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(170, 20);
            this.FirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "First";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(130, 57);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1037, 52);
            this.flowLayoutPanel2.TabIndex = 0;
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
            this.label10.Size = new System.Drawing.Size(275, 41);
            this.label10.TabIndex = 15;
            this.label10.Text = "Patient Registration";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServerStatus,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 703);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1167, 25);
            this.statusStrip1.TabIndex = 7;
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(280, 20);
            this.lblServerStatus.Text = "ePatient Management System Version 1.0";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 728);
            this.Controls.Add(this.flowLayoutPanelPatientRegister);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelHeader);
            this.Name = "PatientRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientRegistration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanelPatientRegister.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patient_pictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPatientRegister;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServerStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StreetAddress;
        private System.Windows.Forms.TextBox PhoneNo;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox BloodGroup;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_PatientID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker txt_DateTimePicker;
        private System.Windows.Forms.Label label16;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Capture;
        private System.Windows.Forms.PictureBox Patient_pictureBox;
        private System.Windows.Forms.Button UploadImage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_UserName;
    }
}