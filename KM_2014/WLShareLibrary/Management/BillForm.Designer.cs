namespace WLCommon.Management
{
    partial class BillForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.listPage = new System.Windows.Forms.TabPage();
            this.list = new Common.ListViewEx();
            this.columnUserid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.listPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(616, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.listPage);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(688, 408);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // listPage
            // 
            this.listPage.Controls.Add(this.list);
            this.listPage.Location = new System.Drawing.Point(4, 24);
            this.listPage.Name = "listPage";
            this.listPage.Padding = new System.Windows.Forms.Padding(3);
            this.listPage.Size = new System.Drawing.Size(680, 380);
            this.listPage.TabIndex = 0;
            this.listPage.Text = "票据列表";
            this.listPage.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserid,
            this.columnPStart,
            this.columnPCount,
            this.columnPIndex,
            this.columnPState,
            this.columnCDT});
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FullRowSelect = true;
            this.list.Location = new System.Drawing.Point(3, 3);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(674, 374);
            this.list.TabIndex = 0;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.billsList_SelectedIndexChanged);
            this.list.DoubleClick += new System.EventHandler(this.billsList_DoubleClick);
            // 
            // columnUserid
            // 
            this.columnUserid.Text = "工号";
            this.columnUserid.Width = 90;
            // 
            // columnPStart
            // 
            this.columnPStart.Text = "起始票号";
            this.columnPStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPStart.Width = 100;
            // 
            // columnPCount
            // 
            this.columnPCount.Text = "票据总数";
            this.columnPCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPCount.Width = 100;
            // 
            // columnPIndex
            // 
            this.columnPIndex.Text = "使用计数";
            this.columnPIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPIndex.Width = 100;
            // 
            // columnPState
            // 
            this.columnPState.Text = "票据标志";
            this.columnPState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPState.Width = 100;
            // 
            // columnCDT
            // 
            this.columnCDT.Text = "创建时间";
            this.columnCDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCDT.Width = 160;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(88, 432);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 24);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Enabled = false;
            this.btnAppend.Location = new System.Drawing.Point(8, 432);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 24);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "添加";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppent_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Enabled = false;
            this.btnClearHistory.Location = new System.Drawing.Point(256, 432);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(112, 24);
            this.btnClearHistory.TabIndex = 4;
            this.btnClearHistory.Text = "清除历史票据";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(168, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 475);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "票据管理";
            this.Shown += new System.EventHandler(this.BillsForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage listPage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnClearHistory;
        private Common.ListViewEx list;
        private System.Windows.Forms.ColumnHeader columnUserid;
        private System.Windows.Forms.ColumnHeader columnPStart;
        private System.Windows.Forms.ColumnHeader columnCDT;
        private System.Windows.Forms.ColumnHeader columnPCount;
        private System.Windows.Forms.ColumnHeader columnPIndex;
        private System.Windows.Forms.ColumnHeader columnPState;
        private System.Windows.Forms.Button btnDelete;
    }
}