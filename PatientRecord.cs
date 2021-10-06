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
using System.IO;

namespace HospitalManagement
{
    public partial class PatientRecord : Form
    {
        private static PatientRecord _instance;
        public string UserID;
        public string UserName;
        public DataRow Patient_dr;
        public int _PatientID{get; set;}
        public string _PatientName{get; set;}

        public PatientRecord(string UserName, string UserID, int PatientID)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_UserName.Text = UserName;
            this._PatientID = PatientID;
            PopulatePatientRecord(PatientID);
        }

        public PatientRecord(string UserName, string UserID, DataRow Patient_dr)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_UserName.Text = UserName;
            this.Patient_dr = Patient_dr;
            this._PatientID = int.Parse(Patient_dr["PatientID"].ToString());
            PopulatePatientRecord(int.Parse(Patient_dr["PatientID"].ToString()));
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

        public static PatientRecord GetInstance()
        {
            return _instance;
        }

        public void PopulatePatientRecord(int PatientID)
        {
            try
            {
                DataSet ds = Handler.GetPatientsRecord(PatientID);
                //  dataGridView_PatientInfo.DataSource = ds.Tables[0];
                // dataGridView2.DataSource = ds.Tables[1];

                DataTable PatientInfo_dt = ds.Tables[0];
                DataTable PatientAppointment_dt = ds.Tables[1];
                DataTable PatientTest_dt = ds.Tables[2];
                DataTable PatientProcedure_dt = ds.Tables[3];

               foreach (DataRow dr in PatientInfo_dt.Rows) {
                    this._PatientName = dr["PatientName"].ToString();
                }
                //1st Tab
                DataSet new_ds = FlipDataSet(ds); // Flip the DataSet
                DataView my_DataView = new_ds.Tables[0].DefaultView;
                this.dataGridView_PatientInfo.DataSource = my_DataView;

                string ImagePath = PatientInfo_dt.Rows[0]["ImagePath"].ToString();
                if (!(ImagePath == null) && !(ImagePath == ""))
                {
                    Image _image = Image.FromFile(@"" + ImagePath);
                    if (_image != null)
                    {
                        this.Patient_pictureBox.Image = _image.GetThumbnailImage(146, 180, null, new IntPtr());
                    }
                    else
                    {
                        this.Patient_pictureBox.Image = Properties.Resources.Noimage;
                    }
                }

                //Get Status
                DataTable dt_status = Handler.GetPatientStatus();

                // 2nd Tab

                dataGridView_Appointment.AutoGenerateColumns = false;
                dataGridView_Appointment.Rows.Clear();


                foreach (DataRow dr in PatientAppointment_dt.Rows)
                {
                   
                    int n = dataGridView_Appointment.Rows.Add();
                    dataGridView_Appointment.Rows[n].Cells[0].Value = dr["PatientID"].ToString();
                    dataGridView_Appointment.Rows[n].Cells[1].Value = dr["PatientName"].ToString();
                    dataGridView_Appointment.Rows[n].Cells[2].Value = dr["PhoneNo"].ToString();
                    dataGridView_Appointment.Rows[n].Cells[3].Value = dr["DoctorName"].ToString();
                    dataGridView_Appointment.Rows[n].Cells[4].Value = Convert.ToDateTime(dr["AppointmentDate"]).ToString("M/d/y");

                    foreach (DataRow dr2 in dt_status.Rows)
                    {

                        (dataGridView_Appointment.Rows[n].Cells[5] as DataGridViewComboBoxCell).Items.Add(dr2["StatusName"].ToString());
                    }

                    (dataGridView_Appointment.Rows[n].Cells[5] as DataGridViewComboBoxCell).Value = dr["Status"].ToString();

                    dataGridView_Appointment.Rows[n].Tag = dr;
                }

                dataGridView_PatientLabTest.AutoGenerateColumns = false;
                dataGridView_PatientLabTest.Rows.Clear();


                foreach (DataRow dr in PatientTest_dt.Rows)
                {
                    int n = dataGridView_PatientLabTest.Rows.Add();
                    dataGridView_PatientLabTest.Rows[n].Cells[0].Value = dr["PatientID"].ToString();
                    dataGridView_PatientLabTest.Rows[n].Cells[1].Value = dr["PatientName"].ToString();
                    dataGridView_PatientLabTest.Rows[n].Cells[2].Value = dr["TestName"].ToString();
                    dataGridView_PatientLabTest.Rows[n].Cells[3].Value = dr["DoctorName"].ToString();
                    //  dataGridView_PatientLabTest.Rows[n].Cells[4].Value = Convert.ToDateTime(dr["AppointmentDate"]).ToString("M/d/y");

                    foreach (DataRow dr2 in dt_status.Rows)
                    {

                        (dataGridView_PatientLabTest.Rows[n].Cells[4] as DataGridViewComboBoxCell).Items.Add(dr2["StatusName"].ToString());
                    }

                    (dataGridView_PatientLabTest.Rows[n].Cells[4] as DataGridViewComboBoxCell).Value = dr["Status"].ToString();

                    dataGridView_PatientLabTest.Rows[n].Tag = dr;
                }

                dataGridView_PatientProcedure.AutoGenerateColumns = false;
                dataGridView_PatientProcedure.Rows.Clear();


                foreach (DataRow dr in PatientProcedure_dt.Rows)
                {
                    int n = dataGridView_PatientProcedure.Rows.Add();
                    dataGridView_PatientProcedure.Rows[n].Cells[0].Value = dr["PatientID"].ToString();
                    dataGridView_PatientProcedure.Rows[n].Cells[1].Value = dr["PatientName"].ToString();
                    dataGridView_PatientProcedure.Rows[n].Cells[2].Value = dr["ProcedureName"].ToString();
                    dataGridView_PatientProcedure.Rows[n].Cells[3].Value = dr["DoctorName"].ToString();
                    dataGridView_PatientProcedure.Rows[n].Cells[4].Value = Convert.ToDateTime(dr["AppointmentDate"]).ToString("M/d/y");

                    foreach (DataRow dr2 in dt_status.Rows)
                    {

                        (dataGridView_PatientProcedure.Rows[n].Cells[5] as DataGridViewComboBoxCell).Items.Add(dr2["StatusName"].ToString());
                    }

                    (dataGridView_PatientProcedure.Rows[n].Cells[5] as DataGridViewComboBoxCell).Value = dr["Status"].ToString();

                    dataGridView_PatientProcedure.Rows[n].Tag = dr;
                }



            }
            catch (Exception ex) { }
        }


        public DataSet FlipDataSet(DataSet my_DataSet)
        {
            DataSet ds = new DataSet();

            foreach (DataTable dt in my_DataSet.Tables)
            {
                DataTable table = new DataTable();

                for (int i = 0; i <= dt.Rows.Count; i++)
                { table.Columns.Add(Convert.ToString(i)); }

                DataRow r;
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    r = table.NewRow();
                    r[0] = dt.Columns[k].ToString();
                    for (int j = 1; j <= dt.Rows.Count; j++)
                    { r[j] = dt.Rows[j - 1][k]; }
                    table.Rows.Add(r);
                }
                ds.Tables.Add(table);
            }

            return ds;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Appointment_Click(object sender, EventArgs e)
        {
            PatientAppointment frm_PatientAppointment = new PatientAppointment(UserName, UserID, int.Parse(Patient_dr["PatientID"].ToString()), Patient_dr[4].ToString());
            frm_PatientAppointment.Show();
        }

        private void SurgicalProcedure_Click(object sender, EventArgs e)
        {
            PatientSurgicalProcedure frm_PatientSurgicalProcedure = new PatientSurgicalProcedure(UserName, UserID, int.Parse(Patient_dr["PatientID"].ToString()), Patient_dr[4].ToString());
            frm_PatientSurgicalProcedure.Show();
        }

        private void LaboratoryTest_Click(object sender, EventArgs e)
        {
            PatientLabTest frm_PatientLabTest = new PatientLabTest(UserName, UserID, _PatientName,_PatientID);
            frm_PatientLabTest.Show();
        }

        private void Document_Click(object sender, EventArgs e)
        {
            //PatientDocumentAssign frm_PatientDocumentAssign = new PatientDocumentAssign(UserName, UserID, _PatientID,_PatientName);
            //frm_PatientDocumentAssign.Show();

            OpenFileDialog open = new OpenFileDialog();       
            open.Filter = "Office Files|*.doc;*.xls;*.ppt|All files (*.*)|*.*";         
            open.Title = "Browse Files";
            open.CheckFileExists = true;
            open.CheckPathExists = true; 
            if (open.ShowDialog() == DialogResult.OK)
            {

                string FileName=open.FileName;
                MessageBox.Show(FileName);


            }

        }

        private void PatientRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
            Patient_dr = null;
            // this.Close();
            e.Cancel = false;

        }

        private void dataGridView_PatientLabTest_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex > 0 && e.RowIndex > 0)
            //{
            //    if (e.ColumnIndex == dataGridView_PatientLabTest.Columns["Status"].Index && e.RowIndex >= 0)
            //    {
            //        DialogResult result = MessageBox.Show("Do you want to Change Status?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //        if (result == DialogResult.Yes)
            //        {
            //            DataRow dr = dataGridView_PatientLabTest.Rows[e.RowIndex].Tag as DataRow;
            //            //int n = Handler.PatientLabTestStatus_Update(int.Parse(dr["PatientID"].ToString()), int.Parse(dr["EmpID"].ToString()), int.Parse(dr["TestID"].ToString()), int.Parse(dataGridView_PatientLabTest.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            //            MessageBox.Show("Status has been Changed sucessfully !", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            //        }
            //        else { return; }
            //    }
            //}
        }



        private void dataGridView_Appointment_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
           
            int Colindex = dataGridView_Appointment.CurrentCell.ColumnIndex;
            DataGridViewColumn CurrentCell = dataGridView_Appointment.Columns[Colindex];
            int index = dataGridView_Appointment.CurrentRow.Index;
            if (dataGridView_Appointment.IsCurrentCellDirty){
                if (CurrentCell.CellType.Name == "DataGridViewComboBoxCell" && CurrentCell.HeaderText.ToString() == "Status")
                {
                    DialogResult result = MessageBox.Show("Do you want to Change Status?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //DataRow dr = dataGridView1.Rows[e.RowIndex].Tag as DataRow;
                        DataRow dr = dataGridView_Appointment.Rows[index].Tag as DataRow;
                        DataGridView gdv = (DataGridView)sender;

                        int n = Handler.PatientAppointmentStatus_Update(int.Parse(dr["PatientID"].ToString()), int.Parse(dr["AppointmentID"].ToString()), gdv.CurrentCell.EditedFormattedValue.ToString());

                        MessageBox.Show("Status has been Changed sucessfully !", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView_Appointment.Rows[index].Cells[0].Selected = true;
                        dataGridView_Appointment.CurrentCell = dataGridView_Appointment.Rows[index].Cells[0];

                    }
                    else
                    {
                        dataGridView_Appointment.Rows[index].Cells[0].Selected = true;
                        dataGridView_Appointment.CurrentCell = dataGridView_Appointment.Rows[index].Cells[0];
                        return;
                    }
                }
            }
        }

        private void dataGridView_PatientLabTest_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int Colindex = dataGridView_PatientLabTest.CurrentCell.ColumnIndex;
            DataGridViewColumn CurrentCell = dataGridView_PatientLabTest.Columns[Colindex];
            if (dataGridView_Appointment.IsCurrentCellDirty)
            {
                if (CurrentCell.CellType.Name == "DataGridViewComboBoxCell" && CurrentCell.HeaderText.ToString() == "Status")
                {
                    DialogResult result = MessageBox.Show("Do you want to Change Status?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int index = dataGridView_PatientLabTest.CurrentRow.Index;

                        //DataRow dr = dataGridView1.Rows[e.RowIndex].Tag as DataRow;
                        DataRow dr = dataGridView_PatientLabTest.Rows[index].Tag as DataRow;
                        DataGridView gdv = (DataGridView)sender;

                        int n = Handler.PatientLabTestStatus_Update(int.Parse(dr["PatientID"].ToString()), int.Parse(dr["EmpID"].ToString()), int.Parse(dr["TestID"].ToString()), gdv.CurrentCell.EditedFormattedValue.ToString());

                        MessageBox.Show("Status has been Changed sucessfully !", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else { return; }
                }
            }
        }

        private void dataGridView_PatientProcedure_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int Colindex = dataGridView_PatientLabTest.CurrentCell.ColumnIndex;
            DataGridViewColumn CurrentCell = dataGridView_PatientLabTest.Columns[Colindex];
            if (dataGridView_Appointment.IsCurrentCellDirty)
            {
                if (CurrentCell.CellType.Name == "DataGridViewComboBoxCell" && CurrentCell.HeaderText.ToString() == "Status")
                {
                    DialogResult result = MessageBox.Show("Do you want to Change Status?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int index = dataGridView_PatientLabTest.CurrentRow.Index;

                        //DataRow dr = dataGridView1.Rows[e.RowIndex].Tag as DataRow;
                        DataRow dr = dataGridView_PatientLabTest.Rows[index].Tag as DataRow;
                        DataGridView gdv = (DataGridView)sender;

                        int n = Handler.PatientSurgicalHistory_Update(int.Parse(dr["PatientID"].ToString()), int.Parse(dr["EmpID"].ToString()), dr["ProcedureName"].ToString(), gdv.CurrentCell.EditedFormattedValue.ToString());

                        MessageBox.Show("Status has been Changed sucessfully !", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else { return; }
                }
            }

        }

        private void Invoice_Click(object sender, EventArgs e)
        {
            PatientInvoice frm_PatientInvoice = new PatientInvoice(UserName, UserID, _PatientID, _PatientName);
            frm_PatientInvoice.Show();
        }
    }
}
