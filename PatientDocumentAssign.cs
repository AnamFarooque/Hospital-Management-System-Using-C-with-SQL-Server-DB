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
    public partial class PatientDocumentAssign : Form
    {
        public PatientDocumentAssign()
        {
            InitializeComponent();
        }
        public PatientDocumentAssign(string UserName, string UserID, int PatientID,string PatientName)
        {
            InitializeComponent();
        }

        private void Assign_Click(object sender, EventArgs e)
        {

        }
    }
}
