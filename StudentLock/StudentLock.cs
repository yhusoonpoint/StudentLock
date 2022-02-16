using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace NichsLightningLaunch
{
    public partial class StudentLock : Form
    {
        public string lockpass = "";
        public bool closeable = true;
        public int randomLocker = 0;
        public List<string> allurl = new List<string>();
        public StudentLock()
        {
            InitializeComponent();
        }
        public int trolling,falseunlock;
        private void StudentLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeable)
            {
                MessageBox.Show("Sorry but you need to enter the password to close the window. \nIf you have forgotten your password, please ask Yardie to manually unlock this computer.");
                e.Cancel = true;
            }
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            if (closeable)
            {
                hide3.Text = password.Text;
                lockpass = password.Text; 
            }
            else 
            {
                if(password.Text==lockpass)
                {
                    if (google.Url.ToString() == allurl[0].ToString())
                    { }
                    else if (google.Url.ToString() != allurl[0].ToString())
                    {
                        DialogResult yesorno = MessageBox.Show("OPEN ALL URL'S YOU'VE BEEN TOO?", "Hi",
        MessageBoxButtons.YesNo);
                        switch (yesorno)
                        { 
                            case System.Windows.Forms.DialogResult.Yes:
                        
                        for (int i = 0; i < allurl.Count; i++)
                        {
                            System.Diagnostics.Process.Start("chrome.exe", allurl[i].ToString());
                        }
                        break;
                            case System.Windows.Forms.DialogResult.No:
                        break;
                        }
                    }
                    else { }
                    closeable=true;
                    this.Close();
                }
            }
            
        }
        private void lockbutton_Click(object sender, EventArgs e)
        {
            if (useTrollface.Checked) { trollface.Visible = true; trrolling.Enabled = true; }
            moveToTopmost.Enabled = true; //timer to move to top level
            closeable = false;  //whether the form will allow alt f4 or other interactions to close it
            useTrollface.Visible = false; //show troll face or nah
            lockbutton.Visible = false; //is lock button visible?
            hide2.Text = "Enter unlock password:"; //self explanitory
            falseunclock.Visible = true;
            hide3.Visible = false;
            password.Text = ""; //remove previous text from password box
            unfortunately.Visible = true;
            showPasswordCheck.Visible = false;
            Random randomID = new Random();
            randomLocker = randomID.Next(20000,80000);
            hide1.Text = "YardieRecovery ID: " + randomLocker;
            ForceUnlock.Enabled = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            progressBar.Visible = true;
            label5.Visible = true;
            textchangeable.Text = "This computer is in use";
            google.Visible = true;
            google.Navigate("http://www.google.com/");
        }
        private void showPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(showPasswordCheck.Checked)hide3.Visible=true;
            if (!showPasswordCheck.Checked) hide3.Visible = false;
        }
        private void ForceUnlock_Tick(object sender, EventArgs e)
        {
            Random doNOTcache = new Random();
            try { string WebData = new WebClient().DownloadString("http://otaupdate.yardie.cf/key.txt?dnd=" + doNOTcache.Next(100, 100000)); if (WebData == Convert.ToString(randomLocker)) { this.closeable = true; MessageBox.Show("This computer has been remotely unlocked."); this.Close(); } }
            catch (Exception) { }
        }
        private void realtimeclock_Tick(object sender, EventArgs e)
        {
            realclock.Text = "Local System Time: " + DateTime.Now.ToString("HH:mm:ss");
        }
        private void yardieonline_Tick(object sender, EventArgs e)
        {
            Random doNOTcache = new Random();
            try
            { 
                string WebData = new WebClient().DownloadString("http://otaupdate.yardie.cf/key.txt?dnd=" + doNOTcache.Next(100, 100000));
                servicesstatus.Text = "Connected to YardieOnline (Ready)";
            }
            catch (WebException) { servicesstatus.Text = "Not connected to YardieOnline (Server Unavailable)"; }
            catch (Exception X) { yardieonline.Enabled = false; servicesstatus.Text = "Not connected to YardieOnline (Critical Error)"; MessageBox.Show("A critical error has occured while trying to connect to YardieOnline, please send a screenshot of this to 12nelliott@greenwichutc.com\n\n"+X); }
        }
        private void moveToTopmost_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private void password_Enter(object sender, EventArgs e)
        {
            //this code has migrated
        }
        private void password_Leave(object sender, EventArgs e)
        {
            //also migrated elsewhere
        }
        private void StudentLock_MouseEnter(object sender, EventArgs e)
        {
            moveToTopmost.Enabled = false;
        }
        private void StudentLock_MouseLeave(object sender, EventArgs e)
        {
            moveToTopmost.Enabled = true;
        }
        private void trrolling_Tick(object sender, EventArgs e)
        {
                
                if (trolling == 0)
                {
                    this.trollface.Image = global::StudentLock.Properties.Resources._5746300106_c72a60131f;
                    this.trollface.Size = new System.Drawing.Size(407, 405);
                    trolling = 1;
                }
                else if (trolling == 1)
                {
                    this.trollface.Image = global::StudentLock.Properties.Resources.Krrcc; 
                    this.trollface.Size = new System.Drawing.Size(350, 300);
                    trolling = 2;
                }
                else if (trolling == 2)
                {
                    this.trollface.Image = global::StudentLock.Properties.Resources.lockimage_1_;
                    this.trollface.Size = new System.Drawing.Size(250, 250);
                    trolling = 3;
                }
                else if (trolling == 3)
                {
                    this.trollface.Image = global::StudentLock.Properties.Resources.meme;
                    this.trollface.Size = new System.Drawing.Size(407, 405);
                    trolling = 4;
                }
                else if (trolling == 4)
                {
                    this.trollface.Image = global::StudentLock.Properties.Resources.meme2;
                    this.trollface.Size = new System.Drawing.Size(407, 405);
                    trolling = 5;
                }
                else if (trolling == 5)
                {
                    this.trollface.Image = global::StudentLock.Properties.Resources.meme3;
                    this.trollface.Size = new System.Drawing.Size(407, 405);
                    trolling = 6;
                }
                else if (trolling == 6)
                {
                    this.trollface.Image = global::StudentLock.Properties.Resources.real_mad;
                    this.trollface.Size = new System.Drawing.Size(238, 162);
                    trolling = 7;
                }
                else if (trolling == 7)
                {
                    this.trollface.Image = global::StudentLock.Properties.Resources.u_mad_o;
                    this.trollface.Size = new System.Drawing.Size(320, 240);
                    trolling = 0;
                }

        }
        private void falseunclock_Click(object sender, EventArgs e)
        {
            if (password.Text != lockpass)
            {
                MessageBox.Show("Try Again");
                falseunlock += 1;
            }
            if (falseunlock == 5)
            {
                kelvinhart.Visible = true;
                this.kelvinhart.Location = new System.Drawing.Point(116, 134);
                this.noostop.Location = new System.Drawing.Point(399, 843);
                password.Visible = false;
                unfortunately.Visible = false;
                falseunclock.Visible = false;
                noodisplay.Enabled = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                progressBar.Visible = false;
                label5.Visible = false;
                trollface.Visible = false;
                noostop.Visible = true;
                google.Visible = false;
                noostop.BringToFront();
                falseunlock = 0;
            }
        }
        private void noodisplay_Tick(object sender, EventArgs e)
        {
            kelvinhart.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            progressBar.Visible = true;
            falseunclock.Visible = true;
            trollface.Visible = true;
            password.Visible = true;
            noostop.Visible = false;
            unfortunately.Visible = true;
            google.Visible = true;
            noodisplay.Enabled = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            google.Navigate("http://www.google.com/");
        }
        private void label3_Click(object sender, EventArgs e)
        {
            google.GoBack();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            google.GoForward();
        }
        private void google_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            allurl.Add(e.Url.ToString());
        }
        private void label5_Click(object sender, EventArgs e)
        {
            google.Refresh();
        }
        private void google_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if ((int)e.CurrentProgress > 0)
            {
                progressBar.Maximum = (int)e.MaximumProgress;
                if (progressBar.Maximum == (int)e.MaximumProgress)
                    progressBar.Value = 0;
                progressBar.Value = (int)e.CurrentProgress;
            }
            progressBar.Value = 0;
        }

        private void unfortunately_Click(object sender, EventArgs e)
        {

        }

        private void StudentLock_Load(object sender, EventArgs e)
        {
        }
    }
}
