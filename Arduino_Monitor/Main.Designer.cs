﻿namespace Arduino_Monitor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_LiveScan = new System.Windows.Forms.CheckBox();
            this.btScan = new System.Windows.Forms.Button();
            this.label_Campo1 = new System.Windows.Forms.Label();
            this.display_Campo1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.display_Campo5 = new System.Windows.Forms.Label();
            this.label_Campo5 = new System.Windows.Forms.Label();
            this.display_Campo4 = new System.Windows.Forms.Label();
            this.label_Campo4 = new System.Windows.Forms.Label();
            this.label_Campo3 = new System.Windows.Forms.Label();
            this.display_Campo3 = new System.Windows.Forms.Label();
            this.display_Campo2 = new System.Windows.Forms.Label();
            this.label_Campo2 = new System.Windows.Forms.Label();
            this.timerDATA = new System.Windows.Forms.Timer(this.components);
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timerSaver = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Tools_Plotter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Tools_Console = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Tools_Reboot = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Config = new System.Windows.Forms.Button();
            this.wb_Thingspeak = new System.Windows.Forms.WebBrowser();
            this.timerThingspeak = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConectar.Location = new System.Drawing.Point(12, 33);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(96, 23);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(114, 34);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 1;
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(259, 34);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(78, 21);
            this.comboBoxBaud.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Baud";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_LiveScan
            // 
            this.cb_LiveScan.AutoSize = true;
            this.cb_LiveScan.Checked = true;
            this.cb_LiveScan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_LiveScan.Location = new System.Drawing.Point(509, 38);
            this.cb_LiveScan.Name = "cb_LiveScan";
            this.cb_LiveScan.Size = new System.Drawing.Size(74, 17);
            this.cb_LiveScan.TabIndex = 7;
            this.cb_LiveScan.Text = "Live Scan";
            this.cb_LiveScan.UseVisualStyleBackColor = true;
            this.cb_LiveScan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btScan
            // 
            this.btScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btScan.Location = new System.Drawing.Point(393, 33);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(75, 23);
            this.btScan.TabIndex = 8;
            this.btScan.Text = "Scan";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // label_Campo1
            // 
            this.label_Campo1.AutoSize = true;
            this.label_Campo1.Location = new System.Drawing.Point(7, 19);
            this.label_Campo1.Name = "label_Campo1";
            this.label_Campo1.Size = new System.Drawing.Size(52, 13);
            this.label_Campo1.TabIndex = 9;
            this.label_Campo1.Text = "Campo 1:";
            this.label_Campo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // display_Campo1
            // 
            this.display_Campo1.AutoSize = true;
            this.display_Campo1.Location = new System.Drawing.Point(22, 41);
            this.display_Campo1.Name = "display_Campo1";
            this.display_Campo1.Size = new System.Drawing.Size(10, 13);
            this.display_Campo1.TabIndex = 10;
            this.display_Campo1.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.wb_Thingspeak);
            this.panel1.Controls.Add(this.display_Campo5);
            this.panel1.Controls.Add(this.label_Campo5);
            this.panel1.Controls.Add(this.display_Campo4);
            this.panel1.Controls.Add(this.label_Campo4);
            this.panel1.Controls.Add(this.label_Campo3);
            this.panel1.Controls.Add(this.display_Campo3);
            this.panel1.Controls.Add(this.display_Campo2);
            this.panel1.Controls.Add(this.label_Campo2);
            this.panel1.Controls.Add(this.label_Campo1);
            this.panel1.Controls.Add(this.display_Campo1);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 207);
            this.panel1.TabIndex = 11;
            // 
            // display_Campo5
            // 
            this.display_Campo5.AutoSize = true;
            this.display_Campo5.Location = new System.Drawing.Point(655, 41);
            this.display_Campo5.Name = "display_Campo5";
            this.display_Campo5.Size = new System.Drawing.Size(10, 13);
            this.display_Campo5.TabIndex = 18;
            this.display_Campo5.Text = "-";
            // 
            // label_Campo5
            // 
            this.label_Campo5.AutoSize = true;
            this.label_Campo5.Location = new System.Drawing.Point(640, 19);
            this.label_Campo5.Name = "label_Campo5";
            this.label_Campo5.Size = new System.Drawing.Size(52, 13);
            this.label_Campo5.TabIndex = 17;
            this.label_Campo5.Text = "Campo 5:";
            // 
            // display_Campo4
            // 
            this.display_Campo4.AutoSize = true;
            this.display_Campo4.Location = new System.Drawing.Point(501, 41);
            this.display_Campo4.Name = "display_Campo4";
            this.display_Campo4.Size = new System.Drawing.Size(10, 13);
            this.display_Campo4.TabIndex = 16;
            this.display_Campo4.Text = "-";
            // 
            // label_Campo4
            // 
            this.label_Campo4.AutoSize = true;
            this.label_Campo4.Location = new System.Drawing.Point(484, 19);
            this.label_Campo4.Name = "label_Campo4";
            this.label_Campo4.Size = new System.Drawing.Size(52, 13);
            this.label_Campo4.TabIndex = 15;
            this.label_Campo4.Text = "Campo 4:";
            // 
            // label_Campo3
            // 
            this.label_Campo3.AutoSize = true;
            this.label_Campo3.Location = new System.Drawing.Point(329, 19);
            this.label_Campo3.Name = "label_Campo3";
            this.label_Campo3.Size = new System.Drawing.Size(52, 13);
            this.label_Campo3.TabIndex = 13;
            this.label_Campo3.Text = "Campo 3:";
            this.label_Campo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // display_Campo3
            // 
            this.display_Campo3.AutoSize = true;
            this.display_Campo3.Location = new System.Drawing.Point(342, 41);
            this.display_Campo3.Name = "display_Campo3";
            this.display_Campo3.Size = new System.Drawing.Size(10, 13);
            this.display_Campo3.TabIndex = 14;
            this.display_Campo3.Text = "-";
            // 
            // display_Campo2
            // 
            this.display_Campo2.AutoSize = true;
            this.display_Campo2.Location = new System.Drawing.Point(176, 41);
            this.display_Campo2.Name = "display_Campo2";
            this.display_Campo2.Size = new System.Drawing.Size(10, 13);
            this.display_Campo2.TabIndex = 12;
            this.display_Campo2.Text = "-";
            // 
            // label_Campo2
            // 
            this.label_Campo2.AutoSize = true;
            this.label_Campo2.Location = new System.Drawing.Point(162, 19);
            this.label_Campo2.Name = "label_Campo2";
            this.label_Campo2.Size = new System.Drawing.Size(52, 13);
            this.label_Campo2.TabIndex = 11;
            this.label_Campo2.Text = "Campo 2:";
            // 
            // timerDATA
            // 
            this.timerDATA.Interval = 2000;
            this.timerDATA.Tick += new System.EventHandler(this.timerDATA_Tick);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(601, 33);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(47, 21);
            this.comboBoxTime.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Refresh Time (seg.)";
            // 
            // timerSaver
            // 
            this.timerSaver.Enabled = true;
            this.timerSaver.Interval = 5000;
            this.timerSaver.Tick += new System.EventHandler(this.timerSaver_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Tools});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_Tools
            // 
            this.tsm_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Tools_Plotter,
            this.tsm_Tools_Console,
            this.tsm_Tools_Reboot});
            this.tsm_Tools.Name = "tsm_Tools";
            this.tsm_Tools.Size = new System.Drawing.Size(84, 20);
            this.tsm_Tools.Text = "Ferramentas";
            // 
            // tsm_Tools_Plotter
            // 
            this.tsm_Tools_Plotter.Enabled = false;
            this.tsm_Tools_Plotter.Name = "tsm_Tools_Plotter";
            this.tsm_Tools_Plotter.Size = new System.Drawing.Size(180, 22);
            this.tsm_Tools_Plotter.Text = "Plotter";
            this.tsm_Tools_Plotter.Click += new System.EventHandler(this.tsm_Tools_Plotter_Click);
            // 
            // tsm_Tools_Console
            // 
            this.tsm_Tools_Console.Enabled = false;
            this.tsm_Tools_Console.Name = "tsm_Tools_Console";
            this.tsm_Tools_Console.Size = new System.Drawing.Size(180, 22);
            this.tsm_Tools_Console.Text = "Console";
            this.tsm_Tools_Console.Click += new System.EventHandler(this.tsm_Tools_Console_Click);
            // 
            // tsm_Tools_Reboot
            // 
            this.tsm_Tools_Reboot.Enabled = false;
            this.tsm_Tools_Reboot.Name = "tsm_Tools_Reboot";
            this.tsm_Tools_Reboot.Size = new System.Drawing.Size(180, 22);
            this.tsm_Tools_Reboot.Text = "Reiniciar Dispositivo";
            this.tsm_Tools_Reboot.Click += new System.EventHandler(this.tsm_Tools_Reboot_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackgroundImage = global::Arduino_Monitor.Properties.Resources.setings;
            this.btn_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Config.FlatAppearance.BorderSize = 0;
            this.btn_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Config.Location = new System.Drawing.Point(766, 26);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(32, 32);
            this.btn_Config.TabIndex = 14;
            this.btn_Config.UseVisualStyleBackColor = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // wb_Thingspeak
            // 
            this.wb_Thingspeak.IsWebBrowserContextMenuEnabled = false;
            this.wb_Thingspeak.Location = new System.Drawing.Point(790, 210);
            this.wb_Thingspeak.Name = "wb_Thingspeak";
            this.wb_Thingspeak.ScriptErrorsSuppressed = true;
            this.wb_Thingspeak.ScrollBarsEnabled = false;
            this.wb_Thingspeak.Size = new System.Drawing.Size(0, 0);
            this.wb_Thingspeak.TabIndex = 16;
            this.wb_Thingspeak.TabStop = false;
            this.wb_Thingspeak.Url = new System.Uri("", System.UriKind.Relative);
            this.wb_Thingspeak.WebBrowserShortcutsEnabled = false;
            // 
            // timerThingspeak
            // 
            this.timerThingspeak.Interval = 15000;
            this.timerThingspeak.Tick += new System.EventHandler(this.timerThingspeak_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(811, 281);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btScan);
            this.Controls.Add(this.cb_LiveScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBaud);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Timer timerCOM;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_LiveScan;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.Label label_Campo1;
        private System.Windows.Forms.Label display_Campo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label display_Campo2;
        private System.Windows.Forms.Label label_Campo2;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerSaver;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.Label display_Campo4;
        private System.Windows.Forms.Label label_Campo4;
        private System.Windows.Forms.Label label_Campo3;
        private System.Windows.Forms.Label display_Campo3;
        private System.Windows.Forms.Label display_Campo5;
        private System.Windows.Forms.Label label_Campo5;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Tools;
        private System.Windows.Forms.ToolStripMenuItem tsm_Tools_Plotter;
        private System.Windows.Forms.ToolStripMenuItem tsm_Tools_Reboot;
        private System.Windows.Forms.ToolStripMenuItem tsm_Tools_Console;
        public System.Windows.Forms.Timer timerDATA;
        private System.Windows.Forms.WebBrowser wb_Thingspeak;
        private System.Windows.Forms.Timer timerThingspeak;
    }
}

