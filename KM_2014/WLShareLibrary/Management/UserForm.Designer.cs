namespace WLCommon.Management
{
    partial class UserForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.listPage = new System.Windows.Forms.TabPage();
            this.list = new Common.ListViewEx();
            this.columnUserid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNodeCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNodeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEnable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearPassword = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.listPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAppend
            // 
            this.btnAppend.Enabled = false;
            this.btnAppend.Location = new System.Drawing.Point(8, 384);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "添加";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.listPage);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(488, 360);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // listPage
            // 
            this.listPage.Controls.Add(this.list);
            this.listPage.Location = new System.Drawing.Point(4, 24);
            this.listPage.Name = "listPage";
            this.listPage.Padding = new System.Windows.Forms.Padding(3);
            this.listPage.Size = new System.Drawing.Size(480, 332);
            this.listPage.TabIndex = 0;
            this.listPage.Text = "用户列表";
            this.listPage.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserid,
            this.columnUsername,
            this.columnNodeCode,
            this.columnNodeName,
            this.columnEnable});
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FullRowSelect = true;
            this.list.Location = new System.Drawing.Point(3, 3);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(474, 326);
            this.list.TabIndex = 0;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            this.list.DoubleClick += new System.EventHandler(this.lstUser_DoubleClick);
            // 
            // columnUserid
            // 
            this.columnUserid.Text = "工号";
            this.columnUserid.Width = 80;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "姓名";
            this.columnUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUsername.Width = 80;
            // 
            // columnNodeCode
            // 
            this.columnNodeCode.Text = "网点代码";
            this.columnNodeCode.Width = 100;
            // 
            // columnNodeName
            // 
            this.columnNodeName.Text = "网点名称";
            this.columnNodeName.Width = 130;
            // 
            // columnEnable
            // 
            this.columnEnable.Text = "标志";
            this.columnEnable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(88, 384);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(168, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearPassword
            // 
            this.btnClearPassword.Enabled = false;
            this.btnClearPassword.Location = new System.Drawing.Point(256, 384);
            this.btnClearPassword.Name = "btnClearPassword";
            this.btnClearPassword.Size = new System.Drawing.Size(75, 23);
            this.btnClearPassword.TabIndex = 4;
            this.btnClearPassword.Text = "清除密码";
            this.btnClearPassword.UseVisualStyleBackColor = true;
            this.btnClearPassword.Click += new System.EventHandler(this.btnClearPassword_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(505, 423);
            this.Controls.Add(this.btnClearPassword);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Shown += new System.EventHandler(this.UsersForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage listPage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private Common.ListViewEx list;
        private System.Windows.Forms.ColumnHeader columnUserid;
        private System.Windows.Forms.Button btnClearPassword;
        private System.Windows.Forms.ColumnHeader columnNodeCode;
        private System.Windows.Forms.ColumnHeader columnNodeName;
        private System.Windows.Forms.ColumnHeader columnEnable;
        private System.Windows.Forms.ColumnHeader columnUsername;
    }
}