namespace WLCommon
{
    partial class QueryDateForm
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
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.mainLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.MonthCalendar.Location = new System.Drawing.Point(0, 0);
            this.MonthCalendar.MaxSelectionCount = 1;
            this.MonthCalendar.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.ShowToday = false;
            this.MonthCalendar.ShowTodayCircle = false;
            this.MonthCalendar.TabIndex = 0;
            this.MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            this.MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(24, 192);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // mainLine
            // 
            this.mainLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainLine.Location = new System.Drawing.Point(0, 177);
            this.mainLine.Name = "mainLine";
            this.mainLine.Size = new System.Drawing.Size(220, 2);
            this.mainLine.TabIndex = 3;
            // 
            // QueryDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 229);
            this.Controls.Add(this.mainLine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.MonthCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryDateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryDateForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label mainLine;
    }
}