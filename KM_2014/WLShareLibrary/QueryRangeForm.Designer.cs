namespace WLCommon
{
    partial class QueryRangeForm
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
            this.txtMinDate = new System.Windows.Forms.DateTimePicker();
            this.lblMinDate = new System.Windows.Forms.Label();
            this.lblMaxDate = new System.Windows.Forms.Label();
            this.txtMaxDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(160, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(64, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtMinDate
            // 
            this.txtMinDate.CustomFormat = "yyyy-MM-dd";
            this.txtMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtMinDate.Location = new System.Drawing.Point(136, 32);
            this.txtMinDate.Name = "txtMinDate";
            this.txtMinDate.Size = new System.Drawing.Size(120, 21);
            this.txtMinDate.TabIndex = 5;
            // 
            // lblMinDate
            // 
            this.lblMinDate.Location = new System.Drawing.Point(32, 32);
            this.lblMinDate.Name = "lblMinDate";
            this.lblMinDate.Size = new System.Drawing.Size(100, 23);
            this.lblMinDate.TabIndex = 7;
            this.lblMinDate.Text = "起始日期：";
            this.lblMinDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaxDate
            // 
            this.lblMaxDate.Location = new System.Drawing.Point(32, 80);
            this.lblMaxDate.Name = "lblMaxDate";
            this.lblMaxDate.Size = new System.Drawing.Size(100, 23);
            this.lblMaxDate.TabIndex = 10;
            this.lblMaxDate.Text = "截止日期：";
            this.lblMaxDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaxDate
            // 
            this.txtMaxDate.CustomFormat = "yyyy-MM-dd";
            this.txtMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtMaxDate.Location = new System.Drawing.Point(136, 80);
            this.txtMaxDate.Name = "txtMaxDate";
            this.txtMaxDate.Size = new System.Drawing.Size(120, 21);
            this.txtMaxDate.TabIndex = 9;
            // 
            // QueryRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 228);
            this.Controls.Add(this.lblMaxDate);
            this.Controls.Add(this.txtMaxDate);
            this.Controls.Add(this.lblMinDate);
            this.Controls.Add(this.txtMinDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryRangeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询范围";
            this.Shown += new System.EventHandler(this.QueryRangeForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker txtMinDate;
        private System.Windows.Forms.Label lblMinDate;
        private System.Windows.Forms.Label lblMaxDate;
        private System.Windows.Forms.DateTimePicker txtMaxDate;
    }
}