namespace WLManager
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
            this.chkAutoSyncServerDT = new System.Windows.Forms.CheckBox();
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
            this.tabPrint = new System.Windows.Forms.TabPage();
            this.numPageOffsetY = new System.Windows.Forms.NumericUpDown();
            this.numPageOffsetX = new System.Windows.Forms.NumericUpDown();
            this.numPageHeight = new System.Windows.Forms.NumericUpDown();
            this.numPageWidth = new System.Windows.Forms.NumericUpDown();
            this.lblPageOffsetY = new System.Windows.Forms.Label();
            this.lblPageOffsetX = new System.Windows.Forms.Label();
            this.lblPageHeight = new System.Windows.Forms.Label();
            this.lblPageWidth = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblQueryDateListLengthHint = new System.Windows.Forms.Label();
            this.numQueryDateListLength = new System.Windows.Forms.NumericUpDown();
            this.lblQueryDateListLength = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPingTimeout)).BeginInit();
            this.tabPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageWidth)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQueryDateListLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBase);
            this.tabControl.Controls.Add(this.tabPrint);
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
            this.tabBase.Controls.Add(this.chkAutoSyncServerDT);
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
            // chkAutoSyncServerDT
            // 
            this.chkAutoSyncServerDT.AutoSize = true;
            this.chkAutoSyncServerDT.Location = new System.Drawing.Point(40, 72);
            this.chkAutoSyncServerDT.Name = "chkAutoSyncServerDT";
            this.chkAutoSyncServerDT.Size = new System.Drawing.Size(252, 16);
            this.chkAutoSyncServerDT.TabIndex = 1;
            this.chkAutoSyncServerDT.Text = "进入系统后自动同步服务器时间（仅限XP）";
            this.chkAutoSyncServerDT.UseVisualStyleBackColor = true;
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
            // tabPrint
            // 
            this.tabPrint.Controls.Add(this.numPageOffsetY);
            this.tabPrint.Controls.Add(this.numPageOffsetX);
            this.tabPrint.Controls.Add(this.numPageHeight);
            this.tabPrint.Controls.Add(this.numPageWidth);
            this.tabPrint.Controls.Add(this.lblPageOffsetY);
            this.tabPrint.Controls.Add(this.lblPageOffsetX);
            this.tabPrint.Controls.Add(this.lblPageHeight);
            this.tabPrint.Controls.Add(this.lblPageWidth);
            this.tabPrint.Location = new System.Drawing.Point(4, 24);
            this.tabPrint.Name = "tabPrint";
            this.tabPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrint.Size = new System.Drawing.Size(384, 324);
            this.tabPrint.TabIndex = 1;
            this.tabPrint.Text = "打印";
            this.tabPrint.UseVisualStyleBackColor = true;
            // 
            // numPageOffsetY
            // 
            this.numPageOffsetY.Location = new System.Drawing.Point(136, 128);
            this.numPageOffsetY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPageOffsetY.Name = "numPageOffsetY";
            this.numPageOffsetY.Size = new System.Drawing.Size(120, 21);
            this.numPageOffsetY.TabIndex = 7;
            this.numPageOffsetY.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // numPageOffsetX
            // 
            this.numPageOffsetX.Location = new System.Drawing.Point(136, 96);
            this.numPageOffsetX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPageOffsetX.Name = "numPageOffsetX";
            this.numPageOffsetX.Size = new System.Drawing.Size(120, 21);
            this.numPageOffsetX.TabIndex = 5;
            // 
            // numPageHeight
            // 
            this.numPageHeight.Location = new System.Drawing.Point(136, 64);
            this.numPageHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPageHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageHeight.Name = "numPageHeight";
            this.numPageHeight.Size = new System.Drawing.Size(120, 21);
            this.numPageHeight.TabIndex = 3;
            this.numPageHeight.Value = new decimal(new int[] {
            415,
            0,
            0,
            0});
            // 
            // numPageWidth
            // 
            this.numPageWidth.Location = new System.Drawing.Point(136, 32);
            this.numPageWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPageWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageWidth.Name = "numPageWidth";
            this.numPageWidth.Size = new System.Drawing.Size(120, 21);
            this.numPageWidth.TabIndex = 1;
            this.numPageWidth.Value = new decimal(new int[] {
            756,
            0,
            0,
            0});
            // 
            // lblPageOffsetY
            // 
            this.lblPageOffsetY.Location = new System.Drawing.Point(32, 128);
            this.lblPageOffsetY.Name = "lblPageOffsetY";
            this.lblPageOffsetY.Size = new System.Drawing.Size(96, 23);
            this.lblPageOffsetY.TabIndex = 6;
            this.lblPageOffsetY.Text = "打印Y偏移：";
            this.lblPageOffsetY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageOffsetX
            // 
            this.lblPageOffsetX.Location = new System.Drawing.Point(32, 96);
            this.lblPageOffsetX.Name = "lblPageOffsetX";
            this.lblPageOffsetX.Size = new System.Drawing.Size(96, 23);
            this.lblPageOffsetX.TabIndex = 4;
            this.lblPageOffsetX.Text = "打印X偏移：";
            this.lblPageOffsetX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageHeight
            // 
            this.lblPageHeight.Location = new System.Drawing.Point(32, 64);
            this.lblPageHeight.Name = "lblPageHeight";
            this.lblPageHeight.Size = new System.Drawing.Size(96, 23);
            this.lblPageHeight.TabIndex = 2;
            this.lblPageHeight.Text = "打印页高：";
            this.lblPageHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageWidth
            // 
            this.lblPageWidth.Location = new System.Drawing.Point(32, 32);
            this.lblPageWidth.Name = "lblPageWidth";
            this.lblPageWidth.Size = new System.Drawing.Size(96, 23);
            this.lblPageWidth.TabIndex = 0;
            this.lblPageWidth.Text = "打印页宽：";
            this.lblPageWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblQueryDateListLengthHint);
            this.tabPage1.Controls.Add(this.numQueryDateListLength);
            this.tabPage1.Controls.Add(this.lblQueryDateListLength);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 324);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblQueryDateListLengthHint
            // 
            this.lblQueryDateListLengthHint.ForeColor = System.Drawing.Color.Gray;
            this.lblQueryDateListLengthHint.Location = new System.Drawing.Point(264, 40);
            this.lblQueryDateListLengthHint.Name = "lblQueryDateListLengthHint";
            this.lblQueryDateListLengthHint.Size = new System.Drawing.Size(96, 23);
            this.lblQueryDateListLengthHint.TabIndex = 8;
            this.lblQueryDateListLengthHint.Text = "（0 - 无限制）";
            this.lblQueryDateListLengthHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQueryDateListLength
            // 
            this.numQueryDateListLength.Location = new System.Drawing.Point(168, 40);
            this.numQueryDateListLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQueryDateListLength.Name = "numQueryDateListLength";
            this.numQueryDateListLength.Size = new System.Drawing.Size(88, 21);
            this.numQueryDateListLength.TabIndex = 7;
            this.numQueryDateListLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQueryDateListLength
            // 
            this.lblQueryDateListLength.ForeColor = System.Drawing.Color.Gray;
            this.lblQueryDateListLength.Location = new System.Drawing.Point(16, 40);
            this.lblQueryDateListLength.Name = "lblQueryDateListLength";
            this.lblQueryDateListLength.Size = new System.Drawing.Size(144, 23);
            this.lblQueryDateListLength.TabIndex = 6;
            this.lblQueryDateListLength.Text = "查询日期列表长度：";
            this.lblQueryDateListLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tabPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPageOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageWidth)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQueryDateListLength)).EndInit();
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
        private System.Windows.Forms.TabPage tabPrint;
        private System.Windows.Forms.NumericUpDown numPageOffsetY;
        private System.Windows.Forms.NumericUpDown numPageOffsetX;
        private System.Windows.Forms.NumericUpDown numPageHeight;
        private System.Windows.Forms.NumericUpDown numPageWidth;
        private System.Windows.Forms.Label lblPageOffsetY;
        private System.Windows.Forms.Label lblPageOffsetX;
        private System.Windows.Forms.Label lblPageHeight;
        private System.Windows.Forms.Label lblPageWidth;
        private System.Windows.Forms.CheckBox chkConfirmClose;
        private System.Windows.Forms.Label lblPingTimeoutHint;
        private System.Windows.Forms.NumericUpDown txtPingTimeout;
        private System.Windows.Forms.Label lblPingTimeout;
        private System.Windows.Forms.CheckBox chkPingEnabled;
        private System.Windows.Forms.CheckBox chkAutoSyncServerDT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblQueryDateListLengthHint;
        private System.Windows.Forms.NumericUpDown numQueryDateListLength;
        private System.Windows.Forms.Label lblQueryDateListLength;
    }
}