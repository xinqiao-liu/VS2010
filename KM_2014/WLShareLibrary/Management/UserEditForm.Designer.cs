namespace WLCommon.Management
{
    partial class UserEditForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkManagePriv = new System.Windows.Forms.CheckBox();
            this.chkSelectPriv = new System.Windows.Forms.CheckBox();
            this.chkDeletePriv = new System.Windows.Forms.CheckBox();
            this.chkInsertPriv = new System.Windows.Forms.CheckBox();
            this.chkUpdatePriv = new System.Windows.Forms.CheckBox();
            this.cboNode = new System.Windows.Forms.ComboBox();
            this.lblNode = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.btnCheckUserExists = new System.Windows.Forms.LinkLabel();
            this.lblValidate = new System.Windows.Forms.Label();
            this.txtValidate = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUserid = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(328, 384);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.cboNode);
            this.tabPage1.Controls.Add(this.lblNode);
            this.tabPage1.Controls.Add(this.chkEnable);
            this.tabPage1.Controls.Add(this.btnCheckUserExists);
            this.tabPage1.Controls.Add(this.lblValidate);
            this.tabPage1.Controls.Add(this.txtValidate);
            this.tabPage1.Controls.Add(this.lblPassword);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.lblUsername);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.lblUserid);
            this.tabPage1.Controls.Add(this.txtUserid);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkManagePriv);
            this.groupBox2.Controls.Add(this.chkSelectPriv);
            this.groupBox2.Controls.Add(this.chkDeletePriv);
            this.groupBox2.Controls.Add(this.chkInsertPriv);
            this.groupBox2.Controls.Add(this.chkUpdatePriv);
            this.groupBox2.Location = new System.Drawing.Point(32, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 56);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库权限";
            this.groupBox2.Visible = false;
            // 
            // chkManagePriv
            // 
            this.chkManagePriv.AutoSize = true;
            this.chkManagePriv.Location = new System.Drawing.Point(24, 24);
            this.chkManagePriv.Name = "chkManagePriv";
            this.chkManagePriv.Size = new System.Drawing.Size(48, 16);
            this.chkManagePriv.TabIndex = 0;
            this.chkManagePriv.Text = "管理";
            this.chkManagePriv.UseVisualStyleBackColor = true;
            // 
            // chkSelectPriv
            // 
            this.chkSelectPriv.AutoSize = true;
            this.chkSelectPriv.Location = new System.Drawing.Point(104, 24);
            this.chkSelectPriv.Name = "chkSelectPriv";
            this.chkSelectPriv.Size = new System.Drawing.Size(48, 16);
            this.chkSelectPriv.TabIndex = 1;
            this.chkSelectPriv.Text = "查询";
            this.chkSelectPriv.UseVisualStyleBackColor = true;
            // 
            // chkDeletePriv
            // 
            this.chkDeletePriv.AutoSize = true;
            this.chkDeletePriv.Location = new System.Drawing.Point(344, 24);
            this.chkDeletePriv.Name = "chkDeletePriv";
            this.chkDeletePriv.Size = new System.Drawing.Size(48, 16);
            this.chkDeletePriv.TabIndex = 4;
            this.chkDeletePriv.Text = "删除";
            this.chkDeletePriv.UseVisualStyleBackColor = true;
            // 
            // chkInsertPriv
            // 
            this.chkInsertPriv.AutoSize = true;
            this.chkInsertPriv.Location = new System.Drawing.Point(184, 24);
            this.chkInsertPriv.Name = "chkInsertPriv";
            this.chkInsertPriv.Size = new System.Drawing.Size(48, 16);
            this.chkInsertPriv.TabIndex = 2;
            this.chkInsertPriv.Text = "插入";
            this.chkInsertPriv.UseVisualStyleBackColor = true;
            // 
            // chkUpdatePriv
            // 
            this.chkUpdatePriv.AutoSize = true;
            this.chkUpdatePriv.Location = new System.Drawing.Point(264, 24);
            this.chkUpdatePriv.Name = "chkUpdatePriv";
            this.chkUpdatePriv.Size = new System.Drawing.Size(48, 16);
            this.chkUpdatePriv.TabIndex = 3;
            this.chkUpdatePriv.Text = "修改";
            this.chkUpdatePriv.UseVisualStyleBackColor = true;
            // 
            // cboNode
            // 
            this.cboNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNode.FormattingEnabled = true;
            this.cboNode.Location = new System.Drawing.Point(128, 32);
            this.cboNode.Name = "cboNode";
            this.cboNode.Size = new System.Drawing.Size(304, 20);
            this.cboNode.TabIndex = 1;
            // 
            // lblNode
            // 
            this.lblNode.ForeColor = System.Drawing.Color.Gray;
            this.lblNode.Location = new System.Drawing.Point(24, 32);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(100, 23);
            this.lblNode.TabIndex = 0;
            this.lblNode.Text = "隶属网点：";
            this.lblNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(376, 192);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(48, 16);
            this.chkEnable.TabIndex = 10;
            this.chkEnable.Text = "启用";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // btnCheckUserExists
            // 
            this.btnCheckUserExists.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnCheckUserExists.Location = new System.Drawing.Point(304, 80);
            this.btnCheckUserExists.Name = "btnCheckUserExists";
            this.btnCheckUserExists.Size = new System.Drawing.Size(128, 23);
            this.btnCheckUserExists.TabIndex = 11;
            this.btnCheckUserExists.TabStop = true;
            this.btnCheckUserExists.Text = "检测工号是否存在";
            this.btnCheckUserExists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckUserExists.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCheckUserExists_LinkClicked);
            // 
            // lblValidate
            // 
            this.lblValidate.ForeColor = System.Drawing.Color.Gray;
            this.lblValidate.Location = new System.Drawing.Point(24, 192);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(100, 23);
            this.lblValidate.TabIndex = 8;
            this.lblValidate.Text = "密码验证：";
            this.lblValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValidate
            // 
            this.txtValidate.Enabled = false;
            this.txtValidate.Location = new System.Drawing.Point(128, 192);
            this.txtValidate.MaxLength = 32;
            this.txtValidate.Name = "txtValidate";
            this.txtValidate.PasswordChar = '*';
            this.txtValidate.Size = new System.Drawing.Size(152, 21);
            this.txtValidate.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(24, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "用户密码：";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(128, 160);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(152, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.Location = new System.Drawing.Point(24, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "用户姓名：";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 112);
            this.txtUsername.MaxLength = 32;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 21);
            this.txtUsername.TabIndex = 5;
            // 
            // lblUserid
            // 
            this.lblUserid.ForeColor = System.Drawing.Color.Gray;
            this.lblUserid.Location = new System.Drawing.Point(24, 80);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(100, 23);
            this.lblUserid.TabIndex = 2;
            this.lblUserid.Text = "用户工号：";
            this.lblUserid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(128, 80);
            this.txtUserid.MaxLength = 8;
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(152, 21);
            this.txtUserid.TabIndex = 3;
            this.txtUserid.TextChanged += new System.EventHandler(this.txtUserid_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(488, 360);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 423);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserEditForm_FormClosing);
            this.Shown += new System.EventHandler(this.UserEditForm_Shown);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboNode;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.LinkLabel btnCheckUserExists;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.TextBox txtValidate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkManagePriv;
        private System.Windows.Forms.CheckBox chkSelectPriv;
        private System.Windows.Forms.CheckBox chkDeletePriv;
        private System.Windows.Forms.CheckBox chkInsertPriv;
        private System.Windows.Forms.CheckBox chkUpdatePriv;
    }
}