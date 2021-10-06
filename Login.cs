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
    public partial class Login : Form
    {
        //private cConfig configuration { get; set; }
        private string _userID;
        private string _password;
        private bool _isResendCredentials = false; 

        public Login()
        {
            InitializeComponent();
            int width = this.Width / 2;
            int height = this.Height / 2;
            pictureBox1.Location = new Point((width - 90), 25);
            lbl_Heading.Location = new Point((width - 180), (height - 110)); //212
            groupBox1.Location = new Point((width - 170), (height - 50));
            
        }

        private void btn_Login_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Hide();
            //Dashboard frm_dashboard = new Dashboard();
            //frm_dashboard.Show();
            _userID = txt_UserID.Text;
            _password  = txt_Password.Text;
            DisableControls();
            AuthorizeUser(_userID, _password);

        }

        void DisableControls()
        {
            Loader.Visible = true;
            txt_UserID.Enabled = false;
            txt_Password.Enabled = false;
            btn_Login.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
        }

        void EnableControls()
        {
            Loader.Visible = false;
            txt_UserID.Enabled = true;
            txt_Password.Enabled = true;
            txt_UserID.Text = "";
            txt_Password.Text = "";
            btn_Login.Enabled = true;
            txt_UserID.Focus(); 
        }

        protected void AuthorizeUser(string Username, string pass) {
          
            DataTable dt = Handler.GetUserInfo(Username, pass);
            if (dt != null && dt.Rows.Count >0)
            {
                UserSession userSession= new UserSession(dt);
                this.Hide();
                Dashboard frm_dashboard = new Dashboard(UserSession.UserID,UserSession.UserName,UserSession.designationID);
                frm_dashboard.Show();
            }
            else {
                MessageBox.Show("Invalid Credientials.", "Invalid Credientials", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                EnableControls();
            }

        
        }

    }
}
