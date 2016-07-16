namespace Arduino_Monitor
{
    partial class Console_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Console_form));
            this.cb_CleanOnSend = new System.Windows.Forms.CheckBox();
            this.tb_Receive = new System.Windows.Forms.TextBox();
            this.tb_Send = new System.Windows.Forms.TextBox();
            this.bt_Send = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_CleanOnSend
            // 
            this.cb_CleanOnSend.AutoSize = true;
            this.cb_CleanOnSend.Location = new System.Drawing.Point(596, 16);
            this.cb_CleanOnSend.Name = "cb_CleanOnSend";
            this.cb_CleanOnSend.Size = new System.Drawing.Size(104, 17);
            this.cb_CleanOnSend.TabIndex = 14;
            this.cb_CleanOnSend.Text = "Limpar ao enviar";
            this.cb_CleanOnSend.UseVisualStyleBackColor = true;
            this.cb_CleanOnSend.CheckedChanged += new System.EventHandler(this.cb_CleanOnSend_CheckedChanged);
            // 
            // tb_Receive
            // 
            this.tb_Receive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Receive.Location = new System.Drawing.Point(12, 56);
            this.tb_Receive.Multiline = true;
            this.tb_Receive.Name = "tb_Receive";
            this.tb_Receive.ReadOnly = true;
            this.tb_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Receive.Size = new System.Drawing.Size(735, 163);
            this.tb_Receive.TabIndex = 13;
            // 
            // tb_Send
            // 
            this.tb_Send.Location = new System.Drawing.Point(114, 14);
            this.tb_Send.Name = "tb_Send";
            this.tb_Send.Size = new System.Drawing.Size(466, 20);
            this.tb_Send.TabIndex = 12;
            this.tb_Send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Send_KeyPress);
            // 
            // bt_Send
            // 
            this.bt_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Send.Location = new System.Drawing.Point(12, 12);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(96, 23);
            this.bt_Send.TabIndex = 11;
            this.bt_Send.Text = "Enviar";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Clear.Image = global::Arduino_Monitor.Properties.Resources.clear;
            this.bt_Clear.Location = new System.Drawing.Point(712, 6);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(35, 35);
            this.bt_Clear.TabIndex = 15;
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // Console_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(760, 232);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.cb_CleanOnSend);
            this.Controls.Add(this.tb_Receive);
            this.Controls.Add(this.tb_Send);
            this.Controls.Add(this.bt_Send);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Console_form";
            this.Text = "Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Console_form_FormClosed);
            this.Load += new System.EventHandler(this.Console_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.CheckBox cb_CleanOnSend;
        private System.Windows.Forms.Button bt_Send;
        public System.Windows.Forms.TextBox tb_Receive;
        public System.Windows.Forms.TextBox tb_Send;
    }
}