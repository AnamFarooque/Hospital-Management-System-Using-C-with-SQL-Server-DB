using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.SupportingClasses;
using System.IO;
using System;
using IronOcr;

namespace HospitalManagement
{
    public partial class PatientSearch : Form
    {
        private static PatientSearch _instance;
        public string UserID;
        public string UserName;

        public PatientSearch(string UserName, string UserID)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_PopUp.Text = UserName;
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

        private void Dashboard_Click(object sender, MouseEventArgs e)
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
        public static PatientSearch GetInstance()
        {
            return _instance;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           


        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (txtbox_Search.Text == "" || txtbox_Search.Text == null)
            {

                MessageBox.Show("Please insert Patient ID or Name", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Regex regex_string = new Regex(@"^[a-zA-Z]+$");
            Regex regex_int = new Regex(@"^[0-9]+$");

            if (regex_string.IsMatch(txtbox_Search.Text))
            {
                try
                {
                    DataTable dt = Handler.GetPateintbyPatientName(txtbox_Search.Text);
                    PatientRecord Frm_PatientRecord = new PatientRecord(UserID, UserName, dt.Rows[0]);
                    this.Hide();
                    Frm_PatientRecord.Show();

                }
                catch (Exception ex) { }
            }
            if (regex_int.IsMatch(txtbox_Search.Text))
            {
                try
                {
                    DataTable dt = Handler.GetPateintbyPatientID(int.Parse(txtbox_Search.Text));
                    PatientRecord Frm_PatientRecord = new PatientRecord(UserID, UserName, dt.Rows[0]);
                    this.Hide();
                    Frm_PatientRecord.Show();

                }
                catch (Exception ex) { }


            }
        }

        private void bn_ImageBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *jpeg;|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // display image in picture box  
                Image _image = new Bitmap(open.FileName);
                var Ocr = new AutoOcr();
                var Result = Ocr.Read(_image);
                //MessageBox.Show(Result.Text);
                List<string> list = Result.ToString().Split(' ').ToList();
                DataTable dt_patient = Handler.GetPatientsList(UserID);

                foreach (DataRow dr in dt_patient.Rows) {
                    string PatientName = dr["FirstName"].ToString();
                    var resultList = list.Contains(PatientName);
                    var mySearch = list.FindAll(delegate(string s) { return list.Contains(PatientName); });

                    MessageBox.Show(string.Join(",", mySearch.ToString()));
                    MessageBox.Show(string.Join(",", resultList.ToString()));

                }

                

            }
        }
    }
}
