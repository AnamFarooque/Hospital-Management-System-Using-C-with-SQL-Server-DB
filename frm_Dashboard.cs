
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinApp
{
    public partial class frm_Dashboard : Form
    {
        private string buttonClicked = "";
        private frm_PopUp pop = null;
        BackgroundWorker BW_AwaitServerResponse;
        private static bool isResponseRecieved = false;
        private List<cStore> _storeList;
        private DataTable _companyList;

        #region Temporary Held Data Tables
        private DataTable _dtIncompleteMonitoringData, _dtReviewData, AllowSale_Companies, _dtGATQuestions;
        #endregion

        #region Constructor and Initialization
        public frm_Dashboard()
        {
            
            InitializeComponent();
            newsTicker1.Text = "";
            pop = new frm_PopUp();

            ApplicationState.Clientsocket.WhenSocketStatusChanges = OnSocketStatusChanges;
            ApplicationState.Clientsocket.WhenErrorOccrus = OnErrorOccurs;
            ApplicationState.Clientsocket.WhenStoreListRecieved = OnStoreListRecieved;
            ApplicationState.Clientsocket.WhenShutDownCalled = OnShutDownCalled;
            ApplicationState.Clientsocket.WhenReconnectWithServer = OnReconnectWithServer;
            ApplicationState.Clientsocket.WhenGATStoreListRecieved = OnGATStoreListRecieved;
            ApplicationState.Clientsocket.WhenGATQuestionsRecieved = OnGATQuestionsRecieved;
            ApplicationState.Clientsocket.WhenAutoUpdateRecieved = OnAutoUpdateRecieved;
            ApplicationState.Clientsocket.WhenCallGetCompanyList = OnAllowSalesReceived;
            
            OnSocketStatusChanges("Connected to server.");

            BW_AwaitServerResponse = new BackgroundWorker();
            BW_AwaitServerResponse.DoWork += BW_AwaitServerResponse_DoWork;
            BW_AwaitServerResponse.WorkerReportsProgress = true;
            BW_AwaitServerResponse.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BW_AwaitServerResponse_RunWorkerCompleted);
            BW_AwaitServerResponse.ProgressChanged += BW_AwaitServerResponse_ProgressChanged;

            InitializeDashboard();
        }

        void InitializeDashboard()
        {
            uC_UserProfile1.LoadControls();
            HideAllTiles();
            foreach (cEmployeeRole ER in ApplicationState.UserSession.EmployeeRoleList)
            {
                switch (ER.DesignationID)
                {
                    
                    case 300:
                        btn_Tile_DeleteMonitoring.Visible = true;
                        btn_Tile_ResendUnknownEmails.Visible = true;
                        btn_Tile_MonitoringInterval.Visible = true;
                        btn_Tile_AgentSession.Visible = true;
                        btn_Tile_AllowMonitoringWithOutSales.Visible = true;
                        break;
                    case 400:
                        btn_Tile_MonitoringInterval.Visible = true;
                        btn_Tile_AgentSession.Visible = true;
                        btn_Tile_AllowMonitoringWithOutSales.Visible = true;
                        break;
                    case 600:
                        btn_Tile_Review.Visible = true;
                        btn_Tile_AuditReports.Visible = true;
                        
                        break;
                    case 700:
                        btn_Tile_MonitoringForAgent.Visible = true;
                        btn_Tile_PersonalView.Visible = true;
                        break;
                    case 800:
                        btn_Tile_GATMonitoring.Visible = true;
                        break;
                    case 900:
                        btn_Tile_ReviewGATMonitoring.Visible = true;
                        break;
                }
            }
        }
        #endregion

        #region UI Events
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btn_Tile_PersonalView_Click(object sender, EventArgs e)
        {
            buttonClicked = "PersonalView";
            DisableControls();

            BW_AwaitServerResponse.RunWorkerAsync();

        }

        private void btn_Tile_MonitoringForAgent_Click(object sender, EventArgs e)
        {
            buttonClicked = "Monitor";

            frm_MonitoringForAgent presentObj = frm_MonitoringForAgent.GetInstance();
            if (presentObj != null)
            {
                presentObj.BringToFront();
            }
            else
            {
                DisableControls();
                BW_AwaitServerResponse.RunWorkerAsync();
            }

        }

        private void btn_Tile_AuditReports_Click(object sender, EventArgs e)
        {
            buttonClicked = "Audit";

            frm_Audit presentObj = frm_Audit.GetInstance();

            if (presentObj != null)
            {
                presentObj.BringToFront();
            }
            else
            {
                DisableControls();
                BW_AwaitServerResponse.RunWorkerAsync();
            }
        }

        private void btn_Tile_Review_Click(object sender, EventArgs e)
        {
            buttonClicked = "Review";
            
            frm_PersonalView presentObj = frm_PersonalView.GetInstance();
            if (presentObj != null)
            {
                presentObj.BringToFront();
            }
            else
            {
                DisableControls();
                BW_AwaitServerResponse.RunWorkerAsync();
            }

        }

        private void btn_Tile_Reports_Click(object sender, EventArgs e)
        {
            frm_Reports obj = new frm_Reports();
            obj.Show();
        }

        private void btn_Tile_AllowMonitoringWithOutSales_Click(object sender, EventArgs e)
        {
            buttonClicked = "AllowSales";

            frm_AllowMonitoringWithoutSales presentObj = frm_AllowMonitoringWithoutSales.GetInstance();
            if (presentObj != null)
            {
                if (!presentObj.IsDisposed)
                    presentObj.BringToFront();
                else {
                    DisableControls();
                    BW_AwaitServerResponse.RunWorkerAsync();
                }
            }
            else
            {
                DisableControls();
                BW_AwaitServerResponse.RunWorkerAsync();
            }
        }

        private void btn_Tile_AgentSession_Click(object sender, EventArgs e)
        {
            frm_AgentSession AgentSession = new frm_AgentSession();
            AgentSession.Show();
        }

        private void btn_Tile_DiscardMonitoring_Click(object sender, EventArgs e)
        {
            frm_DiscardMonitoring DiscardMonitoring = new frm_DiscardMonitoring();
            DiscardMonitoring.Show();
        }

        private void btn_Tile_DeleteMonitoring_Click(object sender, EventArgs e)
        {
            frm_DeleteDisputeMonitoring Delete = new frm_DeleteDisputeMonitoring();
            Delete.Show();
        }

        private void btn_Tile_ResendUnknownEmails_Click(object sender, EventArgs e)
        {
            frm_ResendUnknownEmail Resend = new frm_ResendUnknownEmail();
            Resend.Show();
        }

        private void btn_Tile_MonitoringInterval_Click(object sender, EventArgs e)
        {
            frm_MonitoringInterval Interval = new frm_MonitoringInterval();
            Interval.Show();
        }
        private void frm_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ApplicationState.Clientsocket.CloseClient();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do You Really Want To Exit?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ApplicationState.IsApplicationClosing = true;
                    ApplicationState.Clientsocket.CloseClient();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region GAT Client socket methods
        //private void GATLocationDatesRecieved(cMessagePacket Packet)
        //{
        //    List<cMessagePacket> Packets = Packet.ReadValue<List<cMessagePacket>>();
        //    List<cLocation> LocationList = Packets[0].ReadValue<List<cLocation>>();
        //    frm_GATStartWindow SW = new frm_GATStartWindow(LocationList);
        //    SW.Show();
        //}
        #endregion
        #region Client socket methods


        void OnSocketStatusChanges(string status)
        {
            toolStripStatusLabel1.Text = "● " + status;

            if (status == "Connected to server.")
            {
                toolStripStatusLabel1.ForeColor = Color.Green;

            }
            else
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        void OnReconnectWithServer()
        {
            if (ApplicationState.UserSession != null)
            {
                ApplicationState.Clientsocket.SendUserSessionToServer(ApplicationState.UserSession);
            }
        }
        private void OnErrorOccurs(cMessagePacket Packet)
        {
            Exception ex = Packet.ReadValue<Exception>();
            MessageBox.Show("Server says \n" + ex.Message);

            if (!isResponseRecieved
                && BW_AwaitServerResponse !=null
                && BW_AwaitServerResponse.IsBusy)
            {
                BW_AwaitServerResponse.CancelAsync();
            }
            EnableControls();
        }

        private void OnAutoUpdateRecieved(cMessagePacket Packet)
        {
            string latestVersion = Packet.ReadValue<string>();

            UpdateApplication(latestVersion);
        }
        private void OnStoreListRecieved(cMessagePacket Packet)
        {
            List<cMessagePacket> Packets = Packet.ReadValue<List<cMessagePacket>>();
            _storeList = Packets[0].ReadValue<List<cStore>>();
            _dtIncompleteMonitoringData = Packets[1].ReadValue<DataTable>();
            _dtReviewData = Packets[2].ReadValue<DataTable>();

            isResponseRecieved = true;
        }

        private void OnGATStoreListRecieved(cMessagePacket Packet)
        {
            List<cMessagePacket> Packets = Packet.ReadValue<List<cMessagePacket>>();
            _storeList = Packets[0].ReadValue<List<cStore>>();
            _dtIncompleteMonitoringData = Packets[1].ReadValue<DataTable>();
            _dtReviewData = Packets[2].ReadValue<DataTable>();
            isResponseRecieved = true;
        }

        private void OnGATQuestionsRecieved(cMessagePacket Packet)
        {
            _dtGATQuestions= Packet.ReadValue<DataTable>();
            isResponseRecieved = true;
        }
        void OnShutDownCalled(cMessagePacket Packet)
        {
            Environment.Exit(0);
        }

        void OnPingRecieved(cMessagePacket Packet)
        {

        }
        private void OnAllowSalesReceived(cMessagePacket Packet) //By Altamash
        {
            AllowSale_Companies = Packet.ReadValue<DataTable>();
            isResponseRecieved = true;
        }

        #endregion

        #region Custom Methods
        void HideAllTiles()
        {
            btn_Tile_MonitoringForAgent.Visible = false;
            btn_Tile_PersonalView.Visible = false;
            btn_Tile_Review.Visible = false;
            btn_Tile_AuditReports.Visible = false;
            btn_Tile_AllowMonitoringWithOutSales.Visible = false;
            btn_Tile_DeleteMonitoring.Visible = false;
            btn_Tile_MonitoringInterval.Visible = false;
            btn_Tile_ResendUnknownEmails.Visible = false;
            btn_Tile_Reports.Visible = false;
            btn_Tile_AgentSession.Visible = false;
            btn_Tile_DiscardMonitoring.Visible = false;
            btn_Tile_GATMonitoring.Visible = false;
            btn_Tile_ReviewGATMonitoring.Visible = false;
        }
        #endregion

        private void btn_PopUp_Click(object sender, EventArgs e)
        {
                pop.StartPosition = FormStartPosition.Manual;
                pop.Left = 1200;
                pop.Top = 80;
                pop.ShowDialog();
         }

        private void btn_Tile_GATMonitoring_Click(object sender, EventArgs e)
        {
            buttonClicked = "GATMonitor";

            frm_GATStartWindow presentObj = frm_GATStartWindow.GetInstance();
            if (presentObj != null)
            {
                presentObj.BringToFront();
            }
            else
            {
                DisableControls();
                BW_AwaitServerResponse.RunWorkerAsync();
            }
            
        }

        #region BackGroundWorker Methods
        private void BW_AwaitServerResponse_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void BW_AwaitServerResponse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableControls();
            isResponseRecieved = false;

            if (e.Cancelled) return;

            if (buttonClicked == "Review")
            {
                frm_Review reviewWindow = new frm_Review(_dtReviewData);
                reviewWindow.Show();
            }
            else if (buttonClicked == "Monitor")
            {
                frm_MonitoringForAgent monitoringStartWindow = new frm_MonitoringForAgent(_storeList);
                monitoringStartWindow.Show();
            }
            else if (buttonClicked == "PersonalView")
            {
                frm_PersonalView objPersonalView = new frm_PersonalView(_dtIncompleteMonitoringData);
                objPersonalView.Show();
            }
            else if (buttonClicked == "GATMonitor")
            {
                frm_GATStartWindow newWindow = new frm_GATStartWindow(_storeList, _dtIncompleteMonitoringData);
                newWindow.Show();
            }
            else if (buttonClicked == "GATReview")
            {
                frm_GATReview gatReviewWindow = new frm_GATReview(_dtReviewData);
                gatReviewWindow.Show();
                // frm_GATMonitoringWindow gatMonitoringWindow = new frm_GATMonitoringWindow(_dtGATQuestions, @"Z:\CMS_DB\MonitoringFiles\200\1_122518_79.json", "Review");
                // gatMonitoringWindow.Show();
            }
            else if (buttonClicked == "AllowSales")
            {
                frm_AllowMonitoringWithoutSales objAllowSales = new frm_AllowMonitoringWithoutSales(AllowSale_Companies);
                objAllowSales.Show();
            }
            else if (buttonClicked == "Audit")
            {
                frm_Audit AuditWindow = new frm_Audit(AllowSale_Companies);
                AuditWindow.Show();
            }
        }

        private void BW_AwaitServerResponse_DoWork(object sender, DoWorkEventArgs e)
        {
            BW_AwaitServerResponse.ReportProgress(30);

            if (buttonClicked == "Monitor" || buttonClicked == "Review" || buttonClicked == "PersonalView")
                ApplicationState.Clientsocket.GetAssignedStoresAndDates(ApplicationState.UserSession.UserID);
            else if (buttonClicked == "GATMonitor" || buttonClicked == "GATReview")
                ApplicationState.Clientsocket.GetGATAssignedStoresAndDates(ApplicationState.UserSession.UserID);
            else if (buttonClicked == "AllowSales")
                ApplicationState.Clientsocket.OnGetCompanyList();
            else if (buttonClicked == "Audit")
                ApplicationState.Clientsocket.GetAssignedCompanies();

            BW_AwaitServerResponse.ReportProgress(60);

            while (!isResponseRecieved && !BW_AwaitServerResponse.CancellationPending)
            {
            }
            BW_AwaitServerResponse.ReportProgress(100);
        }
        #endregion

        public void EnableControls()
        {
            foreach (Control C in flowLayoutPanelTiles.Controls.OfType<Button>())
            {
                C.Enabled = true;
            }
        }

        public void DisableControls()
        {
            foreach (Control C in flowLayoutPanelTiles.Controls.OfType<Button>())
            {
                C.Enabled = false;
            }
        }

        private void btn_Tile_ReviewGATMonitoring_Click(object sender, EventArgs e)
        {
            buttonClicked = "GATReview";

            DisableControls();
            BW_AwaitServerResponse.RunWorkerAsync();
            
        }
        static void UpdateApplication(string versionNo)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm is frm_MainWindow ||
                    frm is frm_ReviewReports ||
                    frm is frm_GATMonitoringWindow)
                    frm.Close();
            }
            Process updateProcess = new Process();
            updateProcess.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "\\SoftwareUpdateApp.exe";
            updateProcess.StartInfo.Arguments = versionNo;
            updateProcess.Start();

            Environment.Exit(0);
        }
    }
}
