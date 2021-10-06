using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Dashboard : Form
    {
        private static Dashboard _instance;

        public string UserID;
        public string UserName;
        public int designationID;
        public Dashboard(string _UserID, string _UserName,int designationID)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = _UserID;
            this.UserName = _UserName;
            btn_UserName.Text = _UserName;
            this.designationID = designationID;
            switch (designationID) { 
                case 1:
                    btn_Tile_PatientRegistration.Visible = true;
                    btn_Tile_PatientSearch.Visible = true;
                    btn_Tile_Appointment.Visible = true;
                    btn_Tile_PatientQueue.Visible = true;                   
                    btn_Tile_PatientVisit.Visible = true;
                    btn_Tile_LabQueue.Visible = true;
                    btn_Tile_Billing.Visible = true;
                    break;
                case 2:
                    btn_Tile_PatientRegistration.Visible = true;
                    btn_Tile_PatientSearch.Visible = true;
                    btn_Tile_Appointment.Visible = true;
                    btn_Tile_PatientQueue.Visible = true;
                    btn_Tile_PatientVisit.Visible = true;
                    btn_Tile_LabQueue.Visible = true;
                    //btn_Tile_Billing.Visible = true;
                    break;
                case 3:
                   // btn_Tile_PatientRegistration.Visible = true;
                    btn_Tile_PatientSearch.Visible = true;
                    btn_Tile_Appointment.Visible = true;
                    btn_Tile_PatientQueue.Visible = true;
                    btn_Tile_PatientVisit.Visible = true;
                    btn_Tile_LabQueue.Visible = true;
                    //btn_Tile_Billing.Visible = true;
                    break;
                case 4:
                    btn_Tile_PatientRegistration.Visible = true;
                    btn_Tile_PatientSearch.Visible = true;
                    btn_Tile_Appointment.Visible = true;
                    btn_Tile_PatientQueue.Visible = true;
                    btn_Tile_PatientVisit.Visible = true;
                    btn_Tile_LabQueue.Visible = true;
                   // btn_Tile_Billing.Visible = true;
                    break;
                case 5:
                    btn_Tile_Billing.Visible = true;
                    break;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
            _instance = this;          
        }


        private void btn_Tile_PatientRegistration_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PatientRegistration frm_PatientRegistration = new PatientRegistration(UserName,UserID);
            frm_PatientRegistration.Show();
        }

        private void btn_Tile_PatientSearch_Click(object sender, EventArgs e)
        {
           // this.Hide();
            PatientSearch frm_PatientSearch = new PatientSearch(UserName, UserID);
            frm_PatientSearch.Show();
        }

       

        private void btn_Tile_Appointment_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PatientAppointment frm_PatientAppointment = new PatientAppointment(UserName, UserID);
            frm_PatientAppointment.Show();
        }

        private void btn_Tile_PatientQueue_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PatientQueue frm_PatientQueue = new PatientQueue(UserName, UserID);
            frm_PatientQueue.Show();

        }

        private void btn_Tile_PatientVisit_Click(object sender, EventArgs e)
        {
           // this.Hide();
          //  PatientRecord frm_PatientRecord = new PatientRecord(UserName, UserID);
          //  frm_PatientRecord.Show();
           PatientSearch frm_PatientSearch = new PatientSearch(UserName, UserID);
           frm_PatientSearch.Show();

        }
        private void btn_Tile_LabQueue_Click(object sender, EventArgs e)
        {
            LabQueue frm_LabQueue = new LabQueue(UserName, UserID);
            frm_LabQueue.Show();
        }
     

        private void btn_Tile_Billing_Click(object sender, EventArgs e)
        {
            Billing Frm_Billing = new Billing(UserName,UserID);
            Frm_Billing.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
           Dashboard presentObj = Dashboard.GetInstance();

           if (presentObj != null && !presentObj.IsDisposed)
           {
               presentObj.BringToFront();
           }
           else
           {
               Dashboard frmDashboard = new Dashboard();
               frmDashboard.Show();
            }

        }

        public static Dashboard GetInstance()
        {
            return _instance;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit ?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes){
                //this.Close();
                Application.Exit();
            }
            
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit ?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
               // this.Close();
                Application.Exit();
            }

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            EmployeeRegister presentObj = EmployeeRegister.GetInstance();

            if (presentObj != null && !presentObj.IsDisposed)
            {
                presentObj.BringToFront();
            }
            else
            {
                EmployeeRegister frmEmployeeRegister = new EmployeeRegister(UserName,UserID);
                frmEmployeeRegister.Show();
            }
        }

        private void btn_Appointment_Click(object sender, EventArgs e)
        {

        }

        


      
    }
}
