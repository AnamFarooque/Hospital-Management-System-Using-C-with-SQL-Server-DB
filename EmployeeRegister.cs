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
using System.Text.RegularExpressions;

namespace HospitalManagement
{
    public partial class EmployeeRegister : Form
    {
        private static EmployeeRegister _instance;
        public string UserID;
        public string UserName;

        public EmployeeRegister(string UserName, string UserID)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_UserName.Text = UserName;
            LoadData();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ValidateData()) { 
                 DialogResult result = MessageBox.Show("Do you want to Submit Form?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes)
                 {
                     Handler.EmployeeInfo_Insert(txt_FirstName.Text.ToString(), txt_LastName.Text.ToString(), txt_FirstName.Text.ToString()+" "+txt_LastName.Text.ToString(), txt_UserID.Text.ToString(),
                         txt_Password.Text.ToString(), txt_Email.Text.ToString(),DateTime.Now,Cmbbx_Designation.SelectedValue.ToString(),Cmbbox_Department.SelectedValue.ToString());
                     RefreshForm();
                     MessageBox.Show("Employee Form has been successfully Submitted", "Submitted Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
            }
        }

        private void RefreshForm()
        {
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_UserID.Text = "";
            txt_Email.Text = "";
            txt_Password.Text = "";
            txt_ConfirmPassword.Text = "";
            Cmbbox_Department.SelectedIndex=0;
            Cmbbx_Designation.SelectedIndex = 0;
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

        public static EmployeeRegister GetInstance()
        {
            return _instance;
        }

        public void LoadData() {
            DataRow dr;
            DataRow dr2;
            //Departement
            DataTable dt_Dept= Handler.Department_Select();
            dr = dt_Dept.NewRow();
            dr.ItemArray = new object[] { 0, "Select" };
            dt_Dept.Rows.InsertAt(dr, 0);

            Cmbbox_Department.ValueMember = "DeptID";
            Cmbbox_Department.DisplayMember = "DeptName";
            Cmbbox_Department.DataSource = dt_Dept;
            Cmbbox_Department.SelectedIndex = 0;

            DataTable dt_Desg = Handler.Designations_Select();
            dr2 = dt_Desg.NewRow();
            dr2.ItemArray = new object[] { 0, "Select" };
            dt_Desg.Rows.InsertAt(dr2, 0);

            Cmbbx_Designation.ValueMember = "DesignationID";
            Cmbbx_Designation.DisplayMember = "DesignationName";
            Cmbbx_Designation.DataSource = dt_Desg;
            Cmbbx_Designation.SelectedIndex = 0;
        
        }

        private bool ValidateData()
        {
            string msg = "";
            //chck for empty fields
            //if (txt_EmpID.Text.Length == 0 || txt_EmpID.Text.ToString() == "" || txt_EmpID.Text.ToString() == null)
            //{
            //    msg += "\n - EmpID";
            //}
            if (txt_FirstName.TextLength == 0 || txt_FirstName.Text.ToString() == "" || txt_FirstName.Text.ToString() == null)
            {
                msg += "\n - FirstName";
            }
            if (txt_LastName.TextLength == 0 || txt_LastName.Text.ToString() == "" || txt_LastName.Text.ToString() == null)
            {
                msg += "\n - LastName";
            }
            if (txt_Email.TextLength == 0 || txt_Email.Text.ToString() == "" || txt_Email.Text.ToString() == null)
            {
                msg += "\n - MiddleName";
            }
          
            if (txt_Password.TextLength == 0 || txt_Password.Text.ToString() == "" || txt_Password.Text.ToString() == null)
            {
                msg += "\n - Password";
            }
            if (txt_ConfirmPassword.TextLength == 0 || txt_ConfirmPassword.Text.ToString() == "" || txt_ConfirmPassword.Text.ToString() == null)
            {
                msg += "\n - Confirm Password";
            }
            if (Cmbbox_Department.SelectedIndex == 0)
            {
                msg += "\n - Department";
            }
            if (Cmbbx_Designation.SelectedIndex == 0)
            {
                msg += "\n - Designation";
            }
            if (msg != "")
            {
                String Errormsg = "Employee form must have following fields filled properly: \n";
                Errormsg += msg;
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            if (!(ValidateEmail(txt_Email.Text)))
            {
                String Errormsg = "Employee form must have following fields filled properly: \n";
                Errormsg += "\n - Email is not valid";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!(txt_Password.Text.ToString() == txt_ConfirmPassword.Text.ToString())) {
                String Errormsg = "Employee form must have following fields filled properly: \n";
                Errormsg += "\n - Confirm Password must match Password";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!(Validatepassword(txt_Password.Text)))
            {
                String Errormsg = "Password field must be filled properly: \n";
                //Errormsg += "\n - Password is not valid \n";
                Errormsg += "\n - Password must be between 4 and 8 digits long and include at least one numeric digit. \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return true;

        }

        public bool ValidateEmail(string email)
        {
            //System.Text.RegularExpressions.Regex expr;
            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (expr.IsMatch(email))
            {
                return true;
            }
            else return false;
        }

        public bool Validatepassword(string password)
        {
            Regex expr = new Regex(@"^(?=.*\d).{4,8}$");
            if (expr.IsMatch(password))
            {
                return true;
            }
            else return false;
        }

        private void EmployeeRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshForm();
            _instance = null;

        }
    }
}
