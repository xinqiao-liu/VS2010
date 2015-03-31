namespace WLCollect
{
    partial class ClientSettingForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.lblPingTimeoutHint = new System.Windows.Forms.Label();
            this.txtPingTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblPingTimeout = new System.Windows.Forms.Label();
            this.chkPingEnabled = new System.Windows.Forms.CheckBox();
            this.chkConfirmClose = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserid = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.chkAutoLogin = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkImportDailySheet = new System.Windows.Forms.CheckBox();
            this.chkCollectFD = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPingTimeout)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBase);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(392, 352);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.lblPingTimeoutHint);
            this.tabBase.Controls.Add(this.txtPingTimeout);
            this.tabBase.Controls.Add(this.lblPingTimeout);
            this.tabBase.Controls.Add(this.chkPingEnabled);
            this.tabBase.Controls.Add(this.chkConfirmClose);
            this.tabBase.Controls.Add(this.lblPassword);
            this.tabBase.Controls.Add(this.txtPassword);
            this.tabBase.Controls.Add(this.lblUserid);
            this.tabBase.Controls.Add(this.txtUserid);
            this.tabBase.Controls.Add(this.chkAutoLogin);
            this.tabBase.Location = new System.Drawing.Point(4, 24);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(384, 324);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "常规";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // lblPingTimeoutHint
            // 
            this.lblPingTimeoutHint.ForeColor = System.Drawing.Color.Gray;
            this.lblPingTimeoutHint.Location = new System.Drawing.Point(256, 144);
            this.lblPingTimeoutHint.Name = "lblPingTimeoutHint";
            this.lblPingTimeoutHint.Size = new System.Drawing.Size(80, 23);
            this.lblPingTimeoutHint.TabIndex = 5;
            this.lblPingTimeoutHint.Text = "（微妙）";
            this.lblPingTimeoutHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPingTimeout
            // 
            this.txtPingTimeout.Enabled = false;
            this.txtPingTimeout.Location = new System.Drawing.Point(120, 144);
            this.txtPingTimeout.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtPingTimeout.Name = "txtPingTimeout";
            this.txtPingTimeout.Size = new System.Drawing.Size(136, 21);
            this.txtPingTimeout.TabIndex = 4;
            this.txtPingTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPingTimeout
            // 
            this.lblPingTimeout.ForeColor = System.Drawing.Color.Gray;
            this.lblPingTimeout.Location = new System.Drawing.Point(40, 144);
            this.lblPingTimeout.Name = "lblPingTimeout";
            this.lblPingTimeout.Size = new System.Drawing.Size(80, 23);
            this.lblPingTimeout.TabIndex = 3;
            this.lblPingTimeout.Text = "溢出时间：";
            this.lblPingTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkPingEnabled
            // 
            this.chkPingEnabled.AutoSize = true;
            this.chkPingEnabled.Location = new System.Drawing.Point(40, 112);
            this.chkPingEnabled.Name = "chkPingEnabled";
            this.chkPingEnabled.Size = new System.Drawing.Size(132, 16);
            this.chkPingEnabled.TabIndex = 2;
            this.chkPingEnabled.Text = "打开连接前检测网络";
            this.chkPingEnabled.UseVisualStyleBackColor = true;
            this.chkPingEnabled.CheckedChanged += new System.EventHandler(this.chkPingEnabled_CheckedChanged);
            // 
            // chkConfirmClose
            // 
            this.chkConfirmClose.AutoSize = true;
            this.chkConfirmClose.Location = new System.Drawing.Point(40, 32);
            this.chkConfirmClose.Name = "chkConfirmClose";
            this.chkConfirmClose.Size = new System.Drawing.Size(108, 16);
            this.chkConfirmClose.TabIndex = 0;
            this.chkConfirmClose.Text = "系统退出须确认";
            this.chkConfirmClose.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(40, 256);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "用户密码：";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(120, 256);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(136, 21);
            this.txtPassword.TabIndex = 10;
            // 
            // lblUserid
            // 
            this.lblUserid.ForeColor = System.Drawing.Color.Gray;
            this.lblUserid.Location = new System.Drawing.Point(40, 224);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(80, 23);
            this.lblUserid.TabIndex = 7;
            this.lblUserid.Text = "用户工号：";
            this.lblUserid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserid
            // 
            this.txtUserid.Enabled = false;
            this.txtUserid.Location = new System.Drawing.Point(120, 224);
            this.txtUserid.MaxLength = 8;
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(136, 21);
            this.txtUserid.TabIndex = 8;
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.Location = new System.Drawing.Point(40, 192);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(132, 16);
            this.chkAutoLogin.TabIndex = 6;
            this.chkAutoLogin.Text = "进入系统后自动登录";
            this.chkAutoLogin.UseVisualStyleBackColor = true;
            this.chkAutoLogin.CheckedChanged += new System.EventHandler(this.chkAutoLogin_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkImportDailySheet);
            this.tabPage1.Controls.Add(this.chkCollectFD);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 324);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "汇总";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkImportDailySheet
            // 
            this.chkImportDailySheet.AutoSize = true;
            this.chkImportDailySheet.Location = new System.Drawing.Point(40, 64);
            this.chkImportDailySheet.Name = "chkImportDailySheet";
            this.chkImportDailySheet.Size = new System.Drawing.Size(84, 16);
            this.chkImportDailySheet.TabIndex = 2;
            this.chkImportDailySheet.Text = "导入日报表";
            this.chkImportDailySheet.UseVisualStyleBackColor = true;
            // 
            // chkCollectFD
            // 
            this.chkCollectFD.AutoSize = true;
            this.chkCollectFD.Location = new System.Drawing.Point(40, 32);
            this.chkCollectFD.Name = "chkCollectFD";
            this.chkCollectFD.Size = new System.Drawing.Size(72, 16);
            this.chkCollectFD.TabIndex = 1;
            this.chkCollectFD.Text = "汇总废单";
            this.chkCollectFD.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(232, 376);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(320, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ClientSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 417);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientSettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本地配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientSettingForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPingTimeout)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.CheckBox chkAutoLogin;
        private System.Windows.Forms.CheckBox chkConfirmClose;
        private System.Windows.Forms.Label lblPingTimeoutHint;
        private System.Windows.Forms.NumericUpDown txtPingTimeout;
        private System.Windows.Forms.Label lblPingTimeout;
        private System.Windows.Forms.CheckBox chkPingEnabled;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkImportDailySheet;
        private System.Windows.Forms.CheckBox chkCollectFD;
    }
}