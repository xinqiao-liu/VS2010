namespace WLCommon.Central
{
    partial class UploadToCentralForm
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
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAlreadySynced = new System.Windows.Forms.Label();
            this.lblAlreadySynced = new System.Windows.Forms.Label();
            this.txtWaitingSynced = new System.Windows.Forms.Label();
            this.lblWaitingSynced = new System.Windows.Forms.Label();
            this.lineMain = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "yyyy年MM月dd日";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(104, 24);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(128, 21);
            this.txtDate.TabIndex = 1;
            this.txtDate.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(24, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "选择日期：";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlreadySynced
            // 
            this.txtAlreadySynced.Location = new System.Drawing.Point(104, 72);
            this.txtAlreadySynced.Name = "txtAlreadySynced";
            this.txtAlreadySynced.Size = new System.Drawing.Size(128, 23);
            this.txtAlreadySynced.TabIndex = 3;
            this.txtAlreadySynced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlreadySynced
            // 
            this.lblAlreadySynced.ForeColor = System.Drawing.Color.Gray;
            this.lblAlreadySynced.Location = new System.Drawing.Point(24, 72);
            this.lblAlreadySynced.Name = "lblAlreadySynced";
            this.lblAlreadySynced.Size = new System.Drawing.Size(72, 23);
            this.lblAlreadySynced.TabIndex = 2;
            this.lblAlreadySynced.Text = "已提交：";
            this.lblAlreadySynced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWaitingSynced
            // 
            this.txtWaitingSynced.Location = new System.Drawing.Point(104, 104);
            this.txtWaitingSynced.Name = "txtWaitingSynced";
            this.txtWaitingSynced.Size = new System.Drawing.Size(128, 23);
            this.txtWaitingSynced.TabIndex = 5;
            this.txtWaitingSynced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWaitingSynced
            // 
            this.lblWaitingSynced.ForeColor = System.Drawing.Color.Gray;
            this.lblWaitingSynced.Location = new System.Drawing.Point(24, 104);
            this.lblWaitingSynced.Name = "lblWaitingSynced";
            this.lblWaitingSynced.Size = new System.Drawing.Size(72, 23);
            this.lblWaitingSynced.TabIndex = 4;
            this.lblWaitingSynced.Text = "未提交：";
            this.lblWaitingSynced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lineMain
            // 
            this.lineMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineMain.Location = new System.Drawing.Point(8, 152);
            this.lineMain.Name = "lineMain";
            this.lineMain.Size = new System.Drawing.Size(288, 2);
            this.lineMain.TabIndex = 6;
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Location = new System.Drawing.Point(136, 176);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "提交";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(216, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(16, 176);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UploadToCentralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 222);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lineMain);
            this.Controls.Add(this.txtWaitingSynced);
            this.Controls.Add(this.lblWaitingSynced);
            this.Controls.Add(this.txtAlreadySynced);
            this.Controls.Add(this.lblAlreadySynced);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadToCentralForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提交运单到中心服务器";
            this.Shown += new System.EventHandler(this.UploadToCentralForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label txtAlreadySynced;
        private System.Windows.Forms.Label lblAlreadySynced;
        private System.Windows.Forms.Label txtWaitingSynced;
        private System.Windows.Forms.Label lblWaitingSynced;
        private System.Windows.Forms.Label lineMain;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
    }
}