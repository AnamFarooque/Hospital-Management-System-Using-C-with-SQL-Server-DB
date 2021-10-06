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
    public partial class PatientSurgicalProcedure : Form
    {
        private static PatientSurgicalProcedure _instance;
        public string UserID;
        public string UserName;
        public string PatientName;
        public int PatientID{get; set;}
        
        public PatientSurgicalProcedure(string UserID, string UserName, int PatientID,string PatientName)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_PopUp.Text = UserName;
            this.PatientID = PatientID;
            LoadDoctorData();

            lblPatientName.Text = PatientName.ToString();
        }
        private static PatientSurgicalProcedure GetInstance()
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

        private void Assign_Click(object sender, EventArgs e)
        {
            if (comboBox_Doctor.SelectedIndex == 0)
            {
                String Errormsg = "For Appointment you must select a Doctor \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (procedureName_txt.Text=="")
            {
                String Errormsg = "For Appointment you must insert a Surgical Procedure Name \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Handler.PatientProcedureAssign(PatientID,int.Parse(comboBox_Doctor.SelectedValue.ToString()),procedureName_txt.Text.ToString(), dateTimePicker_Appointment.Value, " Procedure Registration ", 01);
            MessageBox.Show("Assignment Confirmed Successfully", "Appointment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshControls();
            return;
        }

        public void RefreshControls()
        {
            procedureName_txt.Text = "";
            comboBox_Doctor.SelectedIndex = 0;
        }

    }
}
