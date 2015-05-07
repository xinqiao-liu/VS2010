namespace WLCommon.Operation
{
    partial class UploadToCollectForm
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblToDate = new System.Windows.Forms.Label();
            this.chkUploadDailySheet = new System.Windows.Forms.CheckBox();
            this.txtFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.DateTimePicker();
            this.chkIncludeFreeze = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Location = new System.Drawing.Point(72, 176);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(80, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(168, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblFromDate
            // 
            this.lblFromDate.ForeColor = System.Drawing.Color.Gray;
            this.lblFromDate.Location = new System.Drawing.Point(32, 32);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(80, 23);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "起始日期：";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 226);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(320, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 16);
            this.progressBar.Step = 1;
            // 
            // lblToDate
            // 
            this.lblToDate.ForeColor = System.Drawing.Color.Gray;
            this.lblToDate.Location = new System.Drawing.Point(32, 64);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(80, 23);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "截止日期：";
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkUploadDailySheet
            // 
            this.chkUploadDailySheet.AutoSize = true;
            this.chkUploadDailySheet.Checked = true;
            this.chkUploadDailySheet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUploadDailySheet.Location = new System.Drawing.Point(112, 104);
            this.chkUploadDailySheet.Name = "chkUploadDailySheet";
            this.chkUploadDailySheet.Size = new System.Drawing.Size(108, 16);
            this.chkUploadDailySheet.TabIndex = 4;
            this.chkUploadDailySheet.Text = "同步上传日报表";
            this.chkUploadDailySheet.UseVisualStyleBackColor = true;
            // 
            // txtFromDate
            // 
            this.txtFromDate.CustomFormat = "yyyy-MM-dd";
            this.txtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFromDate.Location = new System.Drawing.Point(112, 32);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(168, 21);
            this.txtFromDate.TabIndex = 1;
            // 
            // txtToDate
            // 
            this.txtToDate.CustomFormat = "yyyy-MM-dd";
            this.txtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtToDate.Location = new System.Drawing.Point(112, 64);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(168, 21);
            this.txtToDate.TabIndex = 3;
            // 
            // chkIncludeFreeze
            // 
            this.chkIncludeFreeze.AutoSize = true;
            this.chkIncludeFreeze.Location = new System.Drawing.Point(112, 136);
            this.chkIncludeFreeze.Name = "chkIncludeFreeze";
            this.chkIncludeFreeze.Size = new System.Drawing.Size(108, 16);
            this.chkIncludeFreeze.TabIndex = 5;
            this.chkIncludeFreeze.Text = "包括已上传运单";
            this.chkIncludeFreeze.UseVisualStyleBackColor = true;
            // 
            // UploadToCollectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 248);
            this.ControlBox = false;
            this.Controls.Add(this.chkIncludeFreeze);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.chkUploadDailySheet);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadToCollectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上传运单记录到汇总数据库";
            this.Shown += new System.EventHandler(this.UploadForm_Shown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.CheckBox chkUploadDailySheet;
        private System.Windows.Forms.DateTimePicker txtFromDate;
        private System.Windows.Forms.DateTimePicker txtToDate;
        private System.Windows.Forms.CheckBox chkIncludeFreeze;
    }
}