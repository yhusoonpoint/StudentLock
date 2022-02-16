namespace NichsLightningLaunch
{
    partial class StudentLock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trollface = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.textchangeable = new System.Windows.Forms.Label();
            this.lockbutton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.useTrollface = new System.Windows.Forms.CheckBox();
            this.hide2 = new System.Windows.Forms.Label();
            this.hide1 = new System.Windows.Forms.Label();
            this.hide3 = new System.Windows.Forms.Label();
            this.unfortunately = new System.Windows.Forms.Label();
            this.showPasswordCheck = new System.Windows.Forms.CheckBox();
            this.ForceUnlock = new System.Windows.Forms.Timer(this.components);
            this.realclock = new System.Windows.Forms.Label();
            this.TimeAndRecoveryDock = new System.Windows.Forms.FlowLayoutPanel();
            this.servicesstatus = new System.Windows.Forms.Label();
            this.realtimeclock = new System.Windows.Forms.Timer(this.components);
            this.yardieonline = new System.Windows.Forms.Timer(this.components);
            this.moveToTopmost = new System.Windows.Forms.Timer(this.components);
            this.trrolling = new System.Windows.Forms.Timer(this.components);
            this.falseunclock = new System.Windows.Forms.Button();
            this.kelvinhart = new System.Windows.Forms.PictureBox();
            this.noodisplay = new System.Windows.Forms.Timer(this.components);
            this.noostop = new System.Windows.Forms.Label();
            this.google = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trollface)).BeginInit();
            this.TimeAndRecoveryDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelvinhart)).BeginInit();
            this.SuspendLayout();
            // 
            // trollface
            // 
            this.trollface.Image = global::StudentLock.Properties.Resources._5746300106_c72a60131f;
            this.trollface.Location = new System.Drawing.Point(11, 136);
            this.trollface.Name = "trollface";
            this.trollface.Size = new System.Drawing.Size(407, 405);
            this.trollface.TabIndex = 0;
            this.trollface.TabStop = false;
            this.trollface.Visible = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gold;
            this.title.Location = new System.Drawing.Point(12, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(369, 55);
            this.title.TabIndex = 1;
            this.title.Text = "Student Lock v1";
            // 
            // textchangeable
            // 
            this.textchangeable.AutoSize = true;
            this.textchangeable.BackColor = System.Drawing.Color.Transparent;
            this.textchangeable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textchangeable.ForeColor = System.Drawing.Color.Gold;
            this.textchangeable.Location = new System.Drawing.Point(119, 69);
            this.textchangeable.Name = "textchangeable";
            this.textchangeable.Size = new System.Drawing.Size(273, 33);
            this.textchangeable.TabIndex = 2;
            this.textchangeable.Text = "Quick Setup Wizard";
            // 
            // lockbutton
            // 
            this.lockbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lockbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockbutton.ForeColor = System.Drawing.Color.Gold;
            this.lockbutton.Location = new System.Drawing.Point(668, 332);
            this.lockbutton.Name = "lockbutton";
            this.lockbutton.Size = new System.Drawing.Size(175, 40);
            this.lockbutton.TabIndex = 3;
            this.lockbutton.Text = "Lock";
            this.lockbutton.UseVisualStyleBackColor = false;
            this.lockbutton.Click += new System.EventHandler(this.lockbutton_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.Location = new System.Drawing.Point(615, 243);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(272, 20);
            this.password.TabIndex = 4;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // useTrollface
            // 
            this.useTrollface.AutoSize = true;
            this.useTrollface.BackColor = System.Drawing.Color.Transparent;
            this.useTrollface.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useTrollface.ForeColor = System.Drawing.Color.Gold;
            this.useTrollface.Location = new System.Drawing.Point(615, 304);
            this.useTrollface.Name = "useTrollface";
            this.useTrollface.Size = new System.Drawing.Size(174, 24);
            this.useTrollface.TabIndex = 5;
            this.useTrollface.Text = "Use Trollface Picture";
            this.useTrollface.UseVisualStyleBackColor = false;
            // 
            // hide2
            // 
            this.hide2.AutoSize = true;
            this.hide2.BackColor = System.Drawing.Color.Transparent;
            this.hide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide2.ForeColor = System.Drawing.Color.Gold;
            this.hide2.Location = new System.Drawing.Point(436, 242);
            this.hide2.Name = "hide2";
            this.hide2.Size = new System.Drawing.Size(172, 20);
            this.hide2.TabIndex = 6;
            this.hide2.Text = "Set your lock password";
            // 
            // hide1
            // 
            this.hide1.AutoSize = true;
            this.hide1.BackColor = System.Drawing.Color.Transparent;
            this.hide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide1.ForeColor = System.Drawing.Color.Gold;
            this.hide1.Location = new System.Drawing.Point(269, 0);
            this.hide1.Name = "hide1";
            this.hide1.Size = new System.Drawing.Size(195, 20);
            this.hide1.TabIndex = 7;
            this.hide1.Text = "YardieRecovery ID: 00000";
            // 
            // hide3
            // 
            this.hide3.AutoSize = true;
            this.hide3.BackColor = System.Drawing.Color.Transparent;
            this.hide3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide3.ForeColor = System.Drawing.Color.Gold;
            this.hide3.Location = new System.Drawing.Point(612, 266);
            this.hide3.Name = "hide3";
            this.hide3.Size = new System.Drawing.Size(133, 14);
            this.hide3.TabIndex = 8;
            this.hide3.Text = "[password preview]";
            // 
            // unfortunately
            // 
            this.unfortunately.AutoSize = true;
            this.unfortunately.BackColor = System.Drawing.Color.Transparent;
            this.unfortunately.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unfortunately.ForeColor = System.Drawing.Color.Gold;
            this.unfortunately.Location = new System.Drawing.Point(436, 162);
            this.unfortunately.Name = "unfortunately";
            this.unfortunately.Size = new System.Drawing.Size(594, 40);
            this.unfortunately.TabIndex = 9;
            this.unfortunately.Text = "Unfortunately another student is using this computer right now.\r\nIf you\'ve forgot" +
    "ten your unlock password, ask Yardie to manually unlock this for you.";
            this.unfortunately.Visible = false;
            this.unfortunately.Click += new System.EventHandler(this.unfortunately_Click);
            // 
            // showPasswordCheck
            // 
            this.showPasswordCheck.AutoSize = true;
            this.showPasswordCheck.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordCheck.Checked = true;
            this.showPasswordCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPasswordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheck.ForeColor = System.Drawing.Color.Gold;
            this.showPasswordCheck.Location = new System.Drawing.Point(615, 283);
            this.showPasswordCheck.Name = "showPasswordCheck";
            this.showPasswordCheck.Size = new System.Drawing.Size(199, 24);
            this.showPasswordCheck.TabIndex = 10;
            this.showPasswordCheck.Text = "Show Password Preview";
            this.showPasswordCheck.UseVisualStyleBackColor = false;
            this.showPasswordCheck.CheckedChanged += new System.EventHandler(this.showPasswordCheck_CheckedChanged);
            // 
            // ForceUnlock
            // 
            this.ForceUnlock.Interval = 15000;
            this.ForceUnlock.Tick += new System.EventHandler(this.ForceUnlock_Tick);
            // 
            // realclock
            // 
            this.realclock.AutoSize = true;
            this.realclock.BackColor = System.Drawing.Color.Transparent;
            this.realclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realclock.ForeColor = System.Drawing.Color.Gold;
            this.realclock.Location = new System.Drawing.Point(809, 0);
            this.realclock.Name = "realclock";
            this.realclock.Size = new System.Drawing.Size(212, 20);
            this.realclock.TabIndex = 11;
            this.realclock.Text = "Local System Time: 00:00:00";
            // 
            // TimeAndRecoveryDock
            // 
            this.TimeAndRecoveryDock.BackColor = System.Drawing.Color.Transparent;
            this.TimeAndRecoveryDock.Controls.Add(this.realclock);
            this.TimeAndRecoveryDock.Controls.Add(this.servicesstatus);
            this.TimeAndRecoveryDock.Controls.Add(this.hide1);
            this.TimeAndRecoveryDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeAndRecoveryDock.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TimeAndRecoveryDock.Location = new System.Drawing.Point(0, 0);
            this.TimeAndRecoveryDock.Name = "TimeAndRecoveryDock";
            this.TimeAndRecoveryDock.Size = new System.Drawing.Size(1024, 22);
            this.TimeAndRecoveryDock.TabIndex = 12;
            // 
            // servicesstatus
            // 
            this.servicesstatus.AutoSize = true;
            this.servicesstatus.BackColor = System.Drawing.Color.Transparent;
            this.servicesstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.servicesstatus.Location = new System.Drawing.Point(470, 0);
            this.servicesstatus.Name = "servicesstatus";
            this.servicesstatus.Size = new System.Drawing.Size(333, 20);
            this.servicesstatus.TabIndex = 13;
            this.servicesstatus.Text = "Not connected to YardieOnline (Connecting...)";
            // 
            // realtimeclock
            // 
            this.realtimeclock.Enabled = true;
            this.realtimeclock.Interval = 1000;
            this.realtimeclock.Tick += new System.EventHandler(this.realtimeclock_Tick);
            // 
            // yardieonline
            // 
            this.yardieonline.Enabled = true;
            this.yardieonline.Interval = 15000;
            this.yardieonline.Tick += new System.EventHandler(this.yardieonline_Tick);
            // 
            // moveToTopmost
            // 
            this.moveToTopmost.Interval = 750;
            this.moveToTopmost.Tick += new System.EventHandler(this.moveToTopmost_Tick);
            // 
            // trrolling
            // 
            this.trrolling.Interval = 5000;
            this.trrolling.Tick += new System.EventHandler(this.trrolling_Tick);
            // 
            // falseunclock
            // 
            this.falseunclock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.falseunclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseunclock.ForeColor = System.Drawing.Color.Gold;
            this.falseunclock.Location = new System.Drawing.Point(907, 235);
            this.falseunclock.Name = "falseunclock";
            this.falseunclock.Size = new System.Drawing.Size(105, 38);
            this.falseunclock.TabIndex = 13;
            this.falseunclock.Text = "Unlock";
            this.falseunclock.UseVisualStyleBackColor = false;
            this.falseunclock.Visible = false;
            this.falseunclock.Click += new System.EventHandler(this.falseunclock_Click);
            // 
            // kelvinhart
            // 
            this.kelvinhart.Image = global::StudentLock.Properties.Resources.nooo;
            this.kelvinhart.Location = new System.Drawing.Point(1029, 266);
            this.kelvinhart.Name = "kelvinhart";
            this.kelvinhart.Size = new System.Drawing.Size(1024, 684);
            this.kelvinhart.TabIndex = 14;
            this.kelvinhart.TabStop = false;
            this.kelvinhart.Visible = false;
            // 
            // noodisplay
            // 
            this.noodisplay.Interval = 30000;
            this.noodisplay.Tick += new System.EventHandler(this.noodisplay_Tick);
            // 
            // noostop
            // 
            this.noostop.AutoSize = true;
            this.noostop.BackColor = System.Drawing.Color.Transparent;
            this.noostop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.noostop.ForeColor = System.Drawing.Color.Gold;
            this.noostop.Location = new System.Drawing.Point(528, 39);
            this.noostop.Name = "noostop";
            this.noostop.Size = new System.Drawing.Size(540, 234);
            this.noostop.TabIndex = 16;
            this.noostop.Text = "      HEY...NOOOO...STOP!!!\r\n           THATS GAY!!!\r\n\r\n\r\nLEAVE THIS COMPUTER ONL" +
    "Y..\r\n             ITS IN USE!!!";
            this.noostop.Visible = false;
            // 
            // google
            // 
            this.google.Location = new System.Drawing.Point(440, 304);
            this.google.MinimumSize = new System.Drawing.Size(20, 20);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(815, 696);
            this.google.TabIndex = 17;
            this.google.Visible = false;
            this.google.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.google_DocumentCompleted);
            this.google.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.google_ProgressChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(440, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "HOME";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(491, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "BACK";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(534, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "FORWARD";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.HotPink;
            this.label5.Location = new System.Drawing.Point(609, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "REFRESH";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(440, 294);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(815, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 22;
            this.progressBar.Visible = false;
            // 
            // StudentLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentLock.Properties.Resources.dark;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.google);
            this.Controls.Add(this.noostop);
            this.Controls.Add(this.kelvinhart);
            this.Controls.Add(this.falseunclock);
            this.Controls.Add(this.TimeAndRecoveryDock);
            this.Controls.Add(this.showPasswordCheck);
            this.Controls.Add(this.unfortunately);
            this.Controls.Add(this.hide3);
            this.Controls.Add(this.hide2);
            this.Controls.Add(this.useTrollface);
            this.Controls.Add(this.password);
            this.Controls.Add(this.lockbutton);
            this.Controls.Add(this.textchangeable);
            this.Controls.Add(this.title);
            this.Controls.Add(this.trollface);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "StudentLock";
            this.Text = "StudentLock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentLock_FormClosing);
            this.Load += new System.EventHandler(this.StudentLock_Load);
            this.MouseEnter += new System.EventHandler(this.StudentLock_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.StudentLock_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.trollface)).EndInit();
            this.TimeAndRecoveryDock.ResumeLayout(false);
            this.TimeAndRecoveryDock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelvinhart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trollface;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label textchangeable;
        private System.Windows.Forms.Button lockbutton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox useTrollface;
        private System.Windows.Forms.Label hide2;
        private System.Windows.Forms.Label hide1;
        private System.Windows.Forms.Label hide3;
        private System.Windows.Forms.Label unfortunately;
        private System.Windows.Forms.CheckBox showPasswordCheck;
        private System.Windows.Forms.Timer ForceUnlock;
        private System.Windows.Forms.Label realclock;
        private System.Windows.Forms.FlowLayoutPanel TimeAndRecoveryDock;
        private System.Windows.Forms.Timer realtimeclock;
        private System.Windows.Forms.Label servicesstatus;
        private System.Windows.Forms.Timer yardieonline;
        private System.Windows.Forms.Timer moveToTopmost;
        private System.Windows.Forms.Timer trrolling;
        private System.Windows.Forms.Button falseunclock;
        private System.Windows.Forms.PictureBox kelvinhart;
        private System.Windows.Forms.Timer noodisplay;
        private System.Windows.Forms.Label noostop;
        private System.Windows.Forms.WebBrowser google;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}