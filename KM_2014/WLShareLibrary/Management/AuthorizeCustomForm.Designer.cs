namespace WLCommon.Management
{
    partial class AuthorizeCustomForm
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
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.txtVerifyPassword = new System.Windows.Forms.TextBox();
            this.lblVerifyPassword = new System.Windows.Forms.Label();
            this.chkPingEnabled = new System.Windows.Forms.CheckBox();
            this.txtPingTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblPingTimeout = new System.Windows.Forms.Label();
            this.txtConnectionTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblConnectionTimeout = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserid = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPingTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConnectionTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCustomer);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(360, 432);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.txtVerifyPassword);
            this.tabCustomer.Controls.Add(this.lblVerifyPassword);
            this.tabCustomer.Controls.Add(this.chkPingEnabled);
            this.tabCustomer.Controls.Add(this.txtPingTimeout);
            this.tabCustomer.Controls.Add(this.lblPingTimeout);
            this.tabCustomer.Controls.Add(this.txtConnectionTimeout);
            this.tabCustomer.Controls.Add(this.lblConnectionTimeout);
            this.tabCustomer.Controls.Add(this.lblDatabaseName);
            this.tabCustomer.Controls.Add(this.txtDatabaseName);
            this.tabCustomer.Controls.Add(this.lblUserPassword);
            this.tabCustomer.Controls.Add(this.txtUserPassword);
            this.tabCustomer.Controls.Add(this.lblUserid);
            this.tabCustomer.Controls.Add(this.txtUserid);
            this.tabCustomer.Controls.Add(this.lblServerAddress);
            this.tabCustomer.Controls.Add(this.txtServerAddress);
            this.tabCustomer.Location = new System.Drawing.Point(4, 24);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(352, 404);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "授权信息";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.Location = new System.Drawing.Point(136, 160);
            this.txtVerifyPassword.MaxLength = 100;
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.PasswordChar = '*';
            this.txtVerifyPassword.Size = new System.Drawing.Size(152, 21);
            this.txtVerifyPassword.TabIndex = 7;
            // 
            // lblVerifyPassword
            // 
            this.lblVerifyPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblVerifyPassword.Location = new System.Drawing.Point(32, 160);
            this.lblVerifyPassword.Name = "lblVerifyPassword";
            this.lblVerifyPassword.Size = new System.Drawing.Size(100, 23);
            this.lblVerifyPassword.TabIndex = 6;
            this.lblVerifyPassword.Text = "验证密码：";
            this.lblVerifyPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkPingEnabled
            // 
            this.chkPingEnabled.AutoSize = true;
            this.chkPingEnabled.Checked = true;
            this.chkPingEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPingEnabled.Location = new System.Drawing.Point(136, 304);
            this.chkPingEnabled.Name = "chkPingEnabled";
            this.chkPingEnabled.Size = new System.Drawing.Size(84, 16);
            this.chkPingEnabled.TabIndex = 12;
            this.chkPingEnabled.Text = "连接前Ping";
            this.chkPingEnabled.UseVisualStyleBackColor = true;
            this.chkPingEnabled.CheckedChanged += new System.EventHandler(this.chkPingEnabled_CheckedChanged);
            // 
            // txtPingTimeout
            // 
            this.txtPingTimeout.Location = new System.Drawing.Point(136, 336);
            this.txtPingTimeout.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtPingTimeout.Name = "txtPingTimeout";
            this.txtPingTimeout.Size = new System.Drawing.Size(152, 21);
            this.txtPingTimeout.TabIndex = 14;
            this.txtPingTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPingTimeout
            // 
            this.lblPingTimeout.ForeColor = System.Drawing.Color.Gray;
            this.lblPingTimeout.Location = new System.Drawing.Point(32, 336);
            this.lblPingTimeout.Name = "lblPingTimeout";
            this.lblPingTimeout.Size = new System.Drawing.Size(100, 23);
            this.lblPingTimeout.TabIndex = 13;
            this.lblPingTimeout.Text = "Ping超时时间：";
            this.lblPingTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConnectionTimeout
            // 
            this.txtConnectionTimeout.Location = new System.Drawing.Point(136, 256);
            this.txtConnectionTimeout.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtConnectionTimeout.Name = "txtConnectionTimeout";
            this.txtConnectionTimeout.Size = new System.Drawing.Size(152, 21);
            this.txtConnectionTimeout.TabIndex = 11;
            this.txtConnectionTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblConnectionTimeout
            // 
            this.lblConnectionTimeout.ForeColor = System.Drawing.Color.Gray;
            this.lblConnectionTimeout.Location = new System.Drawing.Point(32, 256);
            this.lblConnectionTimeout.Name = "lblConnectionTimeout";
            this.lblConnectionTimeout.Size = new System.Drawing.Size(100, 23);
            this.lblConnectionTimeout.TabIndex = 10;
            this.lblConnectionTimeout.Text = "连接超时时间：";
            this.lblConnectionTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.ForeColor = System.Drawing.Color.Gray;
            this.lblDatabaseName.Location = new System.Drawing.Point(32, 216);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(100, 23);
            this.lblDatabaseName.TabIndex = 8;
            this.lblDatabaseName.Text = "数据库名称：";
            this.lblDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(136, 216);
            this.txtDatabaseName.MaxLength = 100;
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(152, 21);
            this.txtDatabaseName.TabIndex = 9;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblUserPassword.Location = new System.Drawing.Point(32, 120);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(100, 23);
            this.lblUserPassword.TabIndex = 4;
            this.lblUserPassword.Text = "用户密码：";
            this.lblUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(136, 120);
            this.txtUserPassword.MaxLength = 100;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(152, 21);
            this.txtUserPassword.TabIndex = 5;
            // 
            // lblUserid
            // 
            this.lblUserid.ForeColor = System.Drawing.Color.Gray;
            this.lblUserid.Location = new System.Drawing.Point(32, 80);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(100, 23);
            this.lblUserid.TabIndex = 2;
            this.lblUserid.Text = "用户名称：";
            this.lblUserid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(136, 80);
            this.txtUserid.MaxLength = 100;
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(152, 21);
            this.txtUserid.TabIndex = 3;
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblServerAddress.Location = new System.Drawing.Point(32, 40);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(100, 23);
            this.lblServerAddress.TabIndex = 0;
            this.lblServerAddress.Text = "服务器名称：";
            this.lblServerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(136, 40);
            this.txtServerAddress.MaxLength = 100;
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(152, 21);
            this.txtServerAddress.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(288, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(200, 464);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // AuthorizeCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 513);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizeCustomForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自定义授权";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizeCustomForm_FormClosing);
            this.Shown += new System.EventHandler(this.AuthorizeCustomForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPingTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConnectionTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.NumericUpDown txtPingTimeout;
        private System.Windows.Forms.Label lblPingTimeout;
        private System.Windows.Forms.CheckBox chkPingEnabled;
        private System.Windows.Forms.NumericUpDown txtConnectionTimeout;
        private System.Windows.Forms.Label lblConnectionTimeout;
        private System.Windows.Forms.TextBox txtVerifyPassword;
        private System.Windows.Forms.Label lblVerifyPassword;
    }
}