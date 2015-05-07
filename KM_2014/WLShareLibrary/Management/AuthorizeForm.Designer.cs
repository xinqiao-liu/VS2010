namespace WLCommon.Management
{
    partial class AuthorizeForm
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
            this.listPage = new System.Windows.Forms.TabPage();
            this.list = new Common.ListViewEx();
            this.columnCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.columnCityCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.listPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.listPage);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(696, 264);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // listPage
            // 
            this.listPage.Controls.Add(this.list);
            this.listPage.Location = new System.Drawing.Point(4, 24);
            this.listPage.Name = "listPage";
            this.listPage.Padding = new System.Windows.Forms.Padding(3);
            this.listPage.Size = new System.Drawing.Size(688, 236);
            this.listPage.TabIndex = 0;
            this.listPage.Text = "授权列表";
            this.listPage.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCode,
            this.columnName,
            this.columnCityCode,
            this.columnCityName,
            this.ColumnContent});
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FullRowSelect = true;
            this.list.Location = new System.Drawing.Point(3, 3);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(682, 230);
            this.list.TabIndex = 0;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            this.list.DoubleClick += new System.EventHandler(this.list_DoubleClick);
            // 
            // columnCode
            // 
            this.columnCode.Text = "网点代码";
            this.columnCode.Width = 120;
            // 
            // columnName
            // 
            this.columnName.Text = "网点名称";
            this.columnName.Width = 190;
            // 
            // ColumnContent
            // 
            this.ColumnContent.Text = "是否授权";
            this.ColumnContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnContent.Width = 105;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(624, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(96, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除网点";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(8, 288);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(80, 23);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "添加网点";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Enabled = false;
            this.btnCustom.Location = new System.Drawing.Point(192, 288);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(80, 23);
            this.btnCustom.TabIndex = 3;
            this.btnCustom.Text = "自定义授权";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // columnCityCode
            // 
            this.columnCityCode.Text = "所在市/县代码";
            this.columnCityCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCityCode.Width = 120;
            // 
            // columnCityName
            // 
            this.columnCityName.Text = "所在市/县名称";
            this.columnCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCityName.Width = 120;
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(280, 288);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "导入授权";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(368, 288);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "导出授权";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 332);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "授权管理";
            this.Shown += new System.EventHandler(this.AuthorizeForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage listPage;
        private Common.ListViewEx list;
        private System.Windows.Forms.ColumnHeader columnCode;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.ColumnHeader ColumnContent;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.ColumnHeader columnCityCode;
        private System.Windows.Forms.ColumnHeader columnCityName;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
    }
}