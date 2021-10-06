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
    public partial class Billing : Form
    {
        private static Billing _instance;
        public string UserID;
        public string UserName;

        public Billing(string UserName, string UserID)
        {
            InitializeComponent();
            _instance = this;
            this.UserID = UserID;
            this.UserName = UserName;
            btn_PopUp.Text = UserName;
            LoadPatientData();
        }

        public void LoadPatientData()
        {
            DataTable dt = Handler.PatientPayment_SelectAll();

            
                foreach (DataRow dr in dt.Rows)
                {
                   
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr["PatientID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr["PatientName"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr["PaymentTypeName"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr["Amount"].ToString();
                    //dataGridView1.Rows[n].Cells[4].Value = Convert.ToDateTime(dr["AppointmentDate"]).ToString("M/d/y");
                    (dataGridView1.Rows[n].Cells[4] as DataGridViewComboBoxCell).Value = dr["PaymentStatus"].ToString();
                    dataGridView1.Rows[n].Tag = dr;
                }
        }

        private static Billing GetInstance()
        {
            return _instance;
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int Colindex = dataGridView1.CurrentCell.ColumnIndex;
            DataGridViewColumn CurrentCell = dataGridView1.Columns[Colindex];
            int index = dataGridView1.CurrentRow.Index;
            if (dataGridView1.IsCurrentCellDirty)
            {
                if (CurrentCell.CellType.Name == "DataGridViewComboBoxCell" && CurrentCell.HeaderText.ToString() == "Status")
                {
                    DialogResult result = MessageBox.Show("Do you want to Change Status?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //DataRow dr = dataGridView1.Rows[e.RowIndex].Tag as DataRow;
                        DataRow dr = dataGridView1.Rows[index].Tag as DataRow;
                        DataGridView gdv = (DataGridView)sender;

                        int n = Handler.PatientPayment_Update(int.Parse(dr["PatientID"].ToString()), int.Parse(dr["PaymentTypeID"].ToString()), "Payment Completed", int.Parse(dr["Amount"].ToString()), gdv.CurrentCell.EditedFormattedValue.ToString());

                        MessageBox.Show("Status has been Changed sucessfully !", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                       return;
                    }
                }
            }
        }

        
    }
}
