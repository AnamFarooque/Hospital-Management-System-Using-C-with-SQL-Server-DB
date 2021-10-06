using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HospitalManagement.SupportingClasses;
using System.IO;
using System.Drawing.Imaging;

namespace HospitalManagement
{
    public partial class PatientRegistration : Form
    {
        private static PatientRegistration _instance;

        private string _patientImagePath{get; set;}

        private string UserName;
        private string UserID;

        public PatientRegistration(string UserName,string UserID)
        {
            InitializeComponent();
            _instance = this;
            Gender.SelectedIndex = 0;
            BloodGroup.SelectedIndex = 0;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_UserName.Text = UserName;
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

        private static PatientRegistration GetInstance()
        {
            return _instance;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                DialogResult result = MessageBox.Show("Do you want to Finish Regitration?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Handler.PateintInfo_Insert(int.Parse(txt_PatientID.Text.ToString()), LastName.Text.ToString(), MiddleName.Text.ToString(), FirstName.Text.ToString(), FirstName.Text.ToString() + " " + MiddleName.Text.ToString() + " " + " " + LastName.Text.ToString(), Email.Text.ToString(), int.Parse(PhoneNo.Text.ToString()), Convert.ToDateTime(txt_DateTimePicker.Text.ToString()), int.Parse(Age.Text.ToString()), BloodGroup.Text.ToString(), StreetAddress.Text.ToString(), City.Text.ToString(), State.Text.ToString(), Country.Text.ToString(), _patientImagePath);
                    RefreshForm();
                    MessageBox.Show("Patient Form has been successfully Submitted", "Submitted Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private bool ValidateData()
        {
            string msg = "";
            //chck for empty fields
            if (txt_PatientID.TextLength == 0 || txt_PatientID.Text.ToString() == "" || txt_PatientID.Text.ToString() == null)
            {
                msg += "\n - Patient ID";
            }
            if (FirstName.TextLength == 0 || FirstName.Text.ToString() == "" || FirstName.Text.ToString() == null)
            {
                msg += "\n - First Name";
            }
            if (LastName.TextLength == 0 || LastName.Text.ToString() == "" || LastName.Text.ToString() == null)
            {
                msg += "\n - Last Name";
            }
            if (MiddleName.TextLength == 0 || MiddleName.Text.ToString() == "" || MiddleName.Text.ToString() == null)
            {
                msg += "\n - Middle Name";
            }
            if (PhoneNo.TextLength == 0 || PhoneNo.Text.ToString() == "" || PhoneNo.Text.ToString() == null)
            {
                msg += "\n - Phone No";
            }
            if (StreetAddress.TextLength == 0 || StreetAddress.Text.ToString() == "" || StreetAddress.Text.ToString() == null)
            {
                msg += "\n - Street Address";
            }
            if (City.TextLength == 0 || City.Text.ToString() == "" || City.Text.ToString() == null)
            {
                msg += "\n - City";
            }
            if (State.TextLength == 0 || State.Text.ToString() == "" || State.Text.ToString() == null)
            {
                msg += "\n - State";
            }
            if (Gender.SelectedIndex == 0 )
            {
                msg += "\n - Gender";
            }
            if (BloodGroup.SelectedIndex == 0)
            {
                msg += "\n - Blood Group";
            }
            if (Email.TextLength == 0 || Email.Text.ToString() == "" )
            {
                msg += "\n - Email";
            }
            if (PhoneNo.TextLength == 0 || PhoneNo.Text.ToString() == "")
            {
                msg += "\n - Phone No";
            }

            if (msg != "")
            {
                String Errormsg = "Patient form must have following fields filled properly: \n";
                Errormsg += msg;
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            if (!(ValidateEmail(Email.Text)))
            {
                String Errormsg = "Patient form must have following fields filled properly: \n";
                Errormsg += "\n - Email is not valid";
                MessageBox.Show(Errormsg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!(Validatephone(PhoneNo.Text)))
            {
                String Errormsg = "Patient form must have following fields filled properly: \n";
                Errormsg += "\n - Phone no is not valid";
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

        public bool Validatephone(string no)
        {
            Regex expr = new Regex(@"^[0-9]{11}$/");
            if (expr.IsMatch(no))
            {
                return true;
            }
            else return false;
        }

   
        private void UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // display image in picture box  
                Image _image = new Bitmap(open.FileName);
                //System.IO.File.Copy(open.FileName, open.FileName.Split('.')[0] + "_Copy." + open.FileName.Split('.')[1]);

                //this is an example, you give it the name you want
                string imagename = open.SafeFileName;
                string root = Directory.GetCurrentDirectory();
                string subdir = @"\\PatientFolder\";
                // If directory does not exist, create it. 
                if (!Directory.Exists(root+subdir))
                {
                    Directory.CreateDirectory(root+subdir);
                }
                _patientImagePath = root + subdir + imagename;

                _image.Save(_patientImagePath);
                Patient_pictureBox.Image = _image.GetThumbnailImage(146, 180, null, new IntPtr());
                open.RestoreDirectory = true;
            }
        }


        public void RefreshForm() {
            FirstName.Text = "";
            LastName.Text = "";
            MiddleName.Text = "";
            Email.Text = "";
            PhoneNo.Text = "";
            StreetAddress.Text = "";
            City.Text = "";
            Country.Text = "";
            State.Text = "";
            txt_DateTimePicker.Value = DateTime.Today;
            Gender.SelectedValue = "Select";
            BloodGroup.SelectedValue = "Select";
            _patientImagePath = "";
        }

        private void CaptureMyScreen()
        {

            try
            {

                //Creating a new Bitmap object
                this.WindowState = FormWindowState.Maximized;
                Bitmap captureBitmap = new Bitmap(1185, 775, PixelFormat.Format32bppArgb);

                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);

                //Creating a Rectangle object which will  

                //capture our Current Screen

                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

                //Creating a New Graphics Object

                Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                //Copying Image from The Screen

                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
  
                
                // If directory does not exist, create it. 
                // Displays a SaveFileDialog so the user can save the Image
                // assigned to Button2.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs =
                        (System.IO.FileStream)saveFileDialog1.OpenFile();
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.
                    captureBitmap.Save(fs, ImageFormat.Jpeg);
                    fs.Close();
                    //Displaying the Successfull Result

                    MessageBox.Show("Screen Captured");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Capture_Click(object sender, EventArgs e)
        {
            CaptureMyScreen();
        }
        //Class Ends
    }
}


