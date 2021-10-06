using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.SupportingClasses;

namespace HospitalManagement
{
    public partial class PatientAppointment : Form
    {
        private static PatientAppointment _instance;
        public string UserID;
        public string UserName;

        public PatientAppointment(string UserName, string UserID)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_PopUp.Text = UserName;
            LoadPatientData();
            LoadDoctorData();
          
        }

        public PatientAppointment(string UserName, string UserID,int PatientID,string PatientName)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_PopUp.Text = UserName;

            LoadPatientData(PatientID, PatientName);
            LoadDoctorData();

        }

        private void LoadPatientData(int PatientID, string PatientName)
        {
            DataRow dr;

            DataTable dt = Handler.GetPatientsList(UserID);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, " ", " ", " ", "Select Patient" };
            dt.Rows.InsertAt(dr, 0);
            //dr.ItemArray = new object[] { PatientID, " ", " ", " ", PatientName};
            //dt.Rows.InsertAt(dr, dt.);

            comboBox_patient.ValueMember = "PatientID";
            comboBox_patient.DisplayMember = "FullName";
            comboBox_patient.DataSource = dt;
            comboBox_patient.SelectedValue = PatientID;
            comboBox_patient.Enabled = false;
            comboBox_patient.AllowDrop = false;
        }

        private static PatientAppointment GetInstance()
        {
            return _instance;
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard presentObj = Dashboard.GetInstance();

            if (presentObj != null && !presentObj.IsDisposed)
            {
                this.Hide();
                presentObj.Show();
                presentObj.BringToFront();
            }
            else
            {
                Dashboard frmDashboard = new Dashboard();
                frmDashboard.Show();
            }

        }

       

        private void LoadPatientData() {
            //Get Patient Info
          //  string userID = UserSession.UserID;
            DataRow dr;  

            DataTable dt = Handler.GetPatientsList(UserID);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, " ", " ", " ", "--Select Patient--" };           
            dt.Rows.InsertAt(dr, 0);

            comboBox_patient.ValueMember = "PatientID";
            comboBox_patient.DisplayMember = "FullName";
            comboBox_patient.DataSource = dt;
            comboBox_patient.SelectedItem = 0;
         
        }

        private void LoadDoctorData()
        {
            //Get Patient Info
            //  string userID = UserSession.UserID;
            DataRow dr;

            DataTable dt = Handler.GetDoctorsList(UserID);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, " ", " ", "--Select Doctor--" };
            dt.Rows.InsertAt(dr, 0);

            comboBox_Doctor.ValueMember = "EmpID";          
            comboBox_Doctor.DisplayMember = "userName";           
            comboBox_Doctor.DataSource = dt;
            comboBox_Doctor.SelectedIndex = 0;
        }

     

        private void BookNow_Click(object sender, EventArgs e)
        {
            if (comboBox_Doctor.SelectedIndex == 0)
            {
                String Errormsg = "For Appointment you must select a Doctor \n";              
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (comboBox_patient.SelectedIndex == 0)
            {
                String Errormsg = "For Appointment you must select a Patient \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Handler.PatientAppointment(int.Parse(comboBox_patient.SelectedValue.ToString()),int.Parse(comboBox_Doctor.SelectedValue.ToString()),dateTimePicker_Appointment.Value," Appointment Registeration ", 01);
            MessageBox.Show("Appointment Confirmed Successfully", "Appointment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EnableControls();
            return;

        }
      
 

    public void  EnableControls(){
    comboBox_Doctor.SelectedIndex = 0;
    comboBox_patient.SelectedIndex = 0;
    }

    private void PatientAppointment_FormClosing(object sender, FormClosingEventArgs e)
    {
        _instance = null;
        e.Cancel = false;
    }

    }
}
