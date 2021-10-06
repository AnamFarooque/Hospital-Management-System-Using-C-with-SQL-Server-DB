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
    public partial class PatientLabTest : Form
    {
        private static PatientLabTest _instance;
        public string UserID;
        public string UserName;
        private string UserName1;
        private string UserID1;
        private int p1;
        private string p2;
        public int PatientID { get; set; }
        public int EmpID { get; set; }

        public PatientLabTest(string UserID,string UserName,string PatientName,int PatientID)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_PopUp.Text = UserName;
            this.PatientID = PatientID;
            //this.EmpID = EmpID;

            LoadLabTestData();
            LoadDoctorData();
            lbl_PatientName.Text = PatientName.ToString();
        }

     

        private void Assign_Click(object sender, EventArgs e)
        {
           
            if (comboBox_LabTest.SelectedIndex == 0)
            {
                String Errormsg = "For Lab Test Assignment you must select a Test \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (comboBox_Doctor.SelectedIndex == 0)
            {
                String Errormsg = "For Lab Test Assignment you must select a Doctor \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Handler.PatientLabTest_Assign(PatientID, int.Parse(comboBox_Doctor.SelectedValue.ToString()), int.Parse(comboBox_LabTest.SelectedValue.ToString()), " Lab Test Registration ", 01);
            MessageBox.Show("Appointment Confirmed Successfully", "Appointment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshControls();
            return;
        }

        public void RefreshControls()
        {
            comboBox_LabTest.SelectedIndex = 0;
        }

        private static PatientLabTest GetInstance()
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

       


        private void LoadLabTestData()
        {
            //Get Patient Info
            //  string userID = UserSession.UserID;
            DataRow dr;

            DataTable dt = Handler.GetLabTestList();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0,"--Select Lab Test--" };
            dt.Rows.InsertAt(dr, 0);

            comboBox_LabTest.ValueMember = "TestID";
            comboBox_LabTest.DisplayMember = "TestName";
            comboBox_LabTest.DataSource = dt;
            comboBox_LabTest.SelectedItem = 0;

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

    }
}
