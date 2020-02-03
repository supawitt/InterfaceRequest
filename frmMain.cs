using InterfaceRequest.conndb;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InterfaceRequest
{
    public partial class frmMain : Form
    {
        private readonly ConnectDB connectDB = new ConnectDB();

        private string rawlabreqreceive = null;
        private DateTime labreqdatetime = DateTime.Now;
        private string labreqhn = null;
        private string labrequestfilename = null;
        private string labreqid = null;

        private string _logstart = null;
        private string _logchkreqdata = null;
        private string _logupdatedata = null;

        private readonly Stopwatch watch = new Stopwatch();

        #region Attributes
        private Point pointClick = new Point();
        private bool isStop = false;
        #endregion Attributes

        #region Operations

        /// <summary>
        ///
        /// </summary>
        private void CheckStartStop()
        {
            if (this.isStop)
            {
                #region//-set status stop
                //-set lblStatus
                this.lblStatus.Text = "Status: Stop";
                this.lblStatus.ForeColor = System.Drawing.Color.Red;
                //-set timer
                this.tmrMain.Enabled = false;
                this.stopwatch.Enabled = false;
                //-set button
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = false;
                this.lilSetting.Enabled = true;
                #endregion Operations
            }
            else
            {
                #region//-set status start
                //-set lblStatus
                this.lblStatus.Text = "Status: Start";
                this.lblStatus.ForeColor = System.Drawing.Color.Blue;
                //-set txtActive
                this.txtActive.ForeColor = Color.Black;
                //-set timer
                this.tmrMain.Enabled = true;
                //-loop to start
                tmrMain.Interval = 2000;
                #endregion
            }
        }

        #endregion

        /// <summary>
        ///
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            #region//-check process running
            Process currentProcess = Process.GetCurrentProcess();
            Process[] localAll = Process.GetProcesses();
            foreach (Process localProces in localAll)
            {
                if (currentProcess.ProcessName == localProces.ProcessName &&
                    currentProcess.Id != localProces.Id)
                {
                    //Duplicate Process
                    MessageBox.Show("Program already running.", "Program start", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    currentProcess.Kill();
                    this.Close();
                }
            }
            #endregion

            //-set screen
            this.FormBorderStyle = FormBorderStyle.None;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - pointClick.X;
                this.Top += e.Y - pointClick.Y;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointClick = e.Location;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //-set isStop
            this.isStop = false;
            CheckStartStop();
            //-set timer
            this.tmrMain.Interval = 2000;
            this.tmrMain.Enabled = true;
            //-set button
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.lilSetting.Enabled = false;
            //-set stopwatch
            watch.Start();
            this.stopwatch.Interval = 1000;
            this.lblrunningtime.ForeColor = System.Drawing.Color.Black;
            this.stopwatch.Enabled = true;
        }

        public void Writelabrequestfile()
        {
            FileStream create = File.Open(labrequestfilename, FileMode.Create);
            using StreamWriter newtask = new StreamWriter(create);
            newtask.WriteLine(rawlabreqreceive);
        }

        public void Writelogfile()
        {
            System.IO.Directory.CreateDirectory(connectDB.INI_path + @"\Event_Log");

            FileStream create = File.Open(connectDB.INI_path + @"\Event_Log\labrequest_log.log", FileMode.Append);
            using StreamWriter newtask = new StreamWriter(create);
            newtask.WriteLine(_logstart + @"  Start Running !!");
            newtask.WriteLine(_logchkreqdata + @" Have request ID = " + labreqid);
            newtask.WriteLine(_logchkreqdata + @" Lab_request_data(NW) are: " + rawlabreqreceive);
            newtask.WriteLine(_logupdatedata + @" Save Lab_request_data to : " + labrequestfilename);
            newtask.WriteLine("\n\n");
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStop_Click(object sender, EventArgs e)
        {
            //-set isStop
            this.isStop = true;
            watch.Stop();
            watch.Reset();
            CheckStartStop();

            try
            {
                MessageBox.Show("Program has stopped !");
                connectDB.con.Close();
                lblServerValue.Text = @"Not Connected";
                lblServerValue.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("cannot stop program"+ex.Message);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrMain_Tick(object sender, EventArgs e)
        {
            //-set tmrMain.Enabled
            this.tmrMain.Enabled = false;
            //-set connection state
            connectDB.Getconnstring();
            lblServerValue.Text = @"Connected";
            lblServerValue.ForeColor = Color.Green;

            #region//-Process Select Request
            MySqlCommand cmd;
            try
            {
                _logstart = GetTimestamp(DateTime.Now);
                var sql = @"select * from lab_request where lab_request_receive = 'N' limit 1";
                cmd = new MySqlCommand(sql, connectDB.con);
                connectDB.con.Open();
                var queryResult = cmd.ExecuteReader();
                #endregion

                #region //-Process Check Request
                if (queryResult.HasRows)
                {
                    _logchkreqdata = GetTimestamp(DateTime.Now);
                    queryResult.Read();
                    labreqid = queryResult.GetString(0);
                    byte[] rawlabdata = (byte[])queryResult.GetValue(3);
                    rawlabreqreceive = System.Text.Encoding.Default.GetString(rawlabdata);
                    labreqdatetime = queryResult.GetDateTime(4);
                    labreqhn = queryResult.GetString(8);
                    var labrequestdatetime_s = labreqdatetime.ToString("yyyyMMddhhmmss");
                    labrequestfilename = string.Format(connectDB.INI_path + @"\" + labrequestdatetime_s + @"_" + labreqhn + @".HL7");
                    #endregion

                    #region //-Process Save Request
                    Writelabrequestfile();
                    #endregion

                    #region //Display Data
                    txtActive.Text = rawlabreqreceive;
                    connectDB.con.Close();
                    #endregion

                    #region //-Process Update Data,Process Save Log
                    var sqlupdate = @"update lab_request set lab_request_receive = 'Y' where lab_request_id = " + labreqid;
                    cmd = new MySqlCommand(sqlupdate, connectDB.con);
                    connectDB.con.Open();
                    var updateResult = cmd.ExecuteReader();
                    updateResult.Read();
                    _logupdatedata = GetTimestamp(DateTime.Now);

                    Writelogfile();

                    connectDB.con.Close();
                    #endregion
                }
                #region //show last lab datarow
                else
                {
                    connectDB.con.Close();
                    sql = @"select * from lab_request order by lab_request_id desc limit 1";
                    cmd = new MySqlCommand(sql, connectDB.con);
                    connectDB.con.Open();
                    var lastlabdata = cmd.ExecuteReader();
                    lastlabdata.Read();
                    byte[] lastrawlabdata = (byte[])lastlabdata.GetValue(3);
                    rawlabreqreceive = System.Text.Encoding.Default.GetString(lastrawlabdata);
                    txtActive.Text = rawlabreqreceive;
                }
                #endregion
            }
            catch
            {
                lblServerValue.Text = @"Not Connected";
                lblServerValue.ForeColor = System.Drawing.Color.Red;
            }

            #region//-Process Check Stop
            connectDB.con.Close();
            this.CheckStartStop();
            #endregion
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LilSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSetting frmSetting = new FrmSetting {Owner = this};
            frmSetting.Closed += new EventHandler(FrmSetting_Closed);
            frmSetting.ShowDialog();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSetting_Closed(object sender, EventArgs e)
        {
            FrmSetting frmSetting = (FrmSetting)sender;
            if (frmSetting.DialogResult == DialogResult.OK)
            {
                //-set objects
            }
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void Stopwatch_Tick(object sender, EventArgs e)
        {
            lblrunningtime.Text = string.Format("{0:00}:{1:00}:{2:00}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds);
        }
    }
}