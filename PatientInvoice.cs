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
    public partial class PatientInvoice : Form
    {
        private static PatientInvoice _instance;
        public string UserID;
        public string UserName;
        public int _PatientID;
        public string _PatientName;

        public PatientInvoice(string UserName, string UserID,int PatientID,string PatientName)
        {
            InitializeComponent();
            _instance = this;
            LoadData();
            this._PatientID = PatientID;
            this._PatientName = PatientName;
        }

        private void LoadData() { 
        

        //GetPaymentType
            DataRow dr;

            DataTable dt = Handler.GetPaymentType();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Select Payment Type" };
            dt.Rows.InsertAt(dr, 0);

            comboBox_PaymentType.ValueMember = "PaymentTypeID";
            comboBox_PaymentType.DisplayMember = "PaymentTypeName";
            comboBox_PaymentType.DataSource = dt;
            comboBox_PaymentType.SelectedIndex = 0;
            comboBox_Status.SelectedIndex = 0;
        
        }

        private void PatientInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            _PatientName = null;
            _instance = null;
            e.Cancel = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox_PaymentType.SelectedIndex == 0)
            {
                String Errormsg = "You must select Payment Type \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (comboBox_Status.SelectedIndex == 0)
            {
                String Errormsg = "You must select Payment Status \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Amount.Text == "" || txt_Amount.Text == null)
            {
                String Errormsg = "You must insert an Amount \n";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
              Regex regex_int = new Regex(@"^[0-9]+$");
              if (!(regex_int.IsMatch(txt_Amount.Text)))
              {
                  String Errormsg = "You must insert an Amount properly \n";
                  MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }
             DialogResult result = MessageBox.Show("Do you want to Save Changes?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 Handler.PatientPayment_Insert(_PatientID, int.Parse(comboBox_PaymentType.SelectedValue.ToString()), " Patient Invoice ", int.Parse(txt_Amount.Text), comboBox_Status.SelectedItem.ToString());
                 MessageBox.Show("Invoice added Successfully", "Appointment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
             }
        }

        private static PatientInvoice GetInstance()
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

    }
}
