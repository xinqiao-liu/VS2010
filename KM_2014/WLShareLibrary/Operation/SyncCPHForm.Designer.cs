namespace WLCommon.Operation
{
    partial class SyncCPHForm
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboRQ = new System.Windows.Forms.ComboBox();
            this.lblRQ = new System.Windows.Forms.Label();
            this.list = new Common.ListViewEx();
            this.columnSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOldCPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNewCPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(432, 464);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "检测";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSync
            // 
            this.btnSync.Enabled = false;
            this.btnSync.Location = new System.Drawing.Point(520, 464);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 4;
            this.btnSync.Text = "同步";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(616, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cboRQ
            // 
            this.cboRQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRQ.FormattingEnabled = true;
            this.cboRQ.Location = new System.Drawing.Point(96, 464);
            this.cboRQ.Name = "cboRQ";
            this.cboRQ.Size = new System.Drawing.Size(144, 20);
            this.cboRQ.TabIndex = 2;
            // 
            // lblRQ
            // 
            this.lblRQ.ForeColor = System.Drawing.Color.Gray;
            this.lblRQ.Location = new System.Drawing.Point(8, 464);
            this.lblRQ.Name = "lblRQ";
            this.lblRQ.Size = new System.Drawing.Size(80, 23);
            this.lblRQ.TabIndex = 1;
            this.lblRQ.Text = "承运日期：";
            this.lblRQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // list
            // 
            this.list.CheckBoxes = true;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSN,
            this.columnCDT,
            this.columnBC,
            this.columnOldCPH,
            this.columnNewCPH});
            this.list.FullRowSelect = true;
            this.list.Location = new System.Drawing.Point(8, 8);
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(688, 432);
            this.list.TabIndex = 0;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // columnSN
            // 
            this.columnSN.Text = "单号";
            this.columnSN.Width = 120;
            // 
            // columnCDT
            // 
            this.columnCDT.Text = "办单时间";
            this.columnCDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCDT.Width = 200;
            // 
            // columnBC
            // 
            this.columnBC.Text = "承运班次";
            this.columnBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBC.Width = 100;
            // 
            // columnOldCPH
            // 
            this.columnOldCPH.Text = "原承运车辆";
            this.columnOldCPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOldCPH.Width = 120;
            // 
            // columnNewCPH
            // 
            this.columnNewCPH.Text = "新承运车辆";
            this.columnNewCPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNewCPH.Width = 120;
            // 
            // SyncCPHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 510);
            this.Controls.Add(this.cboRQ);
            this.Controls.Add(this.lblRQ);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SyncCPHForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "同步车牌号";
            this.Load += new System.EventHandler(this.SyncCPHForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnClose;
        private Common.ListViewEx list;
        private System.Windows.Forms.ColumnHeader columnSN;
        private System.Windows.Forms.ColumnHeader columnBC;
        private System.Windows.Forms.ColumnHeader columnOldCPH;
        private System.Windows.Forms.ColumnHeader columnNewCPH;
        private System.Windows.Forms.ComboBox cboRQ;
        private System.Windows.Forms.Label lblRQ;
        private System.Windows.Forms.ColumnHeader columnCDT;
    }
}