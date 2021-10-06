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
    public partial class LabQueue : Form
    {
        private static LabQueue _instance;
        public string UserID;
        public string UserName;




        public LabQueue(string UserName, string UserID)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_PopUp.Text = UserName;
            LoadPatientData();
        }

        private void LoadPatientData()
        {
            DataTable dt = Handler.LabQueue_SelectAll();
            //dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();

            DataTable dt_status = Handler.GetPatientStatus();
          

            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr["PatientID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr["PatientName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr["PhoneNo"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr["DoctorName"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr["TestName"].ToString();
               // dataGridView1.Rows[n].Cells[5] = StatusList;

                foreach (DataRow dr2 in dt_status.Rows)
                {

                    (dataGridView1.Rows[n].Cells[5] as DataGridViewComboBoxCell).Items.Add(dr2["StatusName"].ToString());
                }

                (dataGridView1.Rows[n].Cells[5] as DataGridViewComboBoxCell).Value = dr["Status"].ToString();

                dataGridView1.Rows[n].Cells[6].Value = "View";

                dataGridView1.Rows[n].Tag = dr;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["View"].Index && e.RowIndex >= 0)
            {
                PatientRecord frm_PatientRecord = PatientRecord.GetInstance();

                if (frm_PatientRecord != null)
                {
                    MessageBox.Show("Patient Record window is already opened. Please close that first to open other Patient Record.", "Patient Record window opened", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    PatientRecord frm_PatientRecordObj = new PatientRecord(UserName, UserID, (DataRow)dataGridView1.Rows[e.RowIndex].Tag);
                    frm_PatientRecordObj.Show();
                }

                // PatientRecordView();
            }

          
        }

        public static LabQueue GetInstance()
        {
            return _instance;
        }

      

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int Colindex = dataGridView1.CurrentCell.ColumnIndex;
            DataGridViewColumn CurrentCell = dataGridView1.Columns[Colindex];
           
            if (CurrentCell.CellType.Name == "DataGridViewComboBoxCell" && CurrentCell.HeaderText.ToString() == "Status")
            {
                DialogResult result = MessageBox.Show("Do you want to Change Status?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = dataGridView1.CurrentRow.Index;

                    //DataRow dr = dataGridView1.Rows[e.RowIndex].Tag as DataRow;
                    DataRow dr = dataGridView1.Rows[index].Tag as DataRow;
                    DataGridView gdv = (DataGridView)sender;

                    int n = Handler.PatientLabTestStatus_Update(int.Parse(dr["PatientID"].ToString()), int.Parse(dr["EmpID"].ToString()), int.Parse(dr["TestID"].ToString()), gdv.CurrentCell.EditedFormattedValue.ToString());

                    MessageBox.Show("Status has been Changed sucessfully !", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { return; }
            }
            //if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.RowIndex >= 0)
            //{
            //    DialogResult result = MessageBox.Show("Do you want to Change Status?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        DataRow dr = dataGridView1.Rows[e.RowIndex].Tag as DataRow;
            //        // int n = Handler.PatientLabTestStatus_Update(int.Parse(dr["PatientID"].ToString()), int.Parse(dr["EmpID"].ToString()), int.Parse(dr["TestID"].ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            //        MessageBox.Show("Status has been Changed sucessfully !", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            //    }
            //    else { return; }
            //}     
        }


    }
}
