namespace WLCommon.Operation
{
    partial class EndOfDayForm
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
            this.btnEOFD = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboRQ = new System.Windows.Forms.ComboBox();
            this.lblRQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEOFD
            // 
            this.btnEOFD.Enabled = false;
            this.btnEOFD.Location = new System.Drawing.Point(56, 88);
            this.btnEOFD.Name = "btnEOFD";
            this.btnEOFD.Size = new System.Drawing.Size(80, 23);
            this.btnEOFD.TabIndex = 3;
            this.btnEOFD.Text = "日结";
            this.btnEOFD.UseVisualStyleBackColor = true;
            this.btnEOFD.Click += new System.EventHandler(this.btnEOFD_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(152, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboRQ
            // 
            this.cboRQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRQ.FormattingEnabled = true;
            this.cboRQ.Location = new System.Drawing.Point(112, 32);
            this.cboRQ.Name = "cboRQ";
            this.cboRQ.Size = new System.Drawing.Size(144, 20);
            this.cboRQ.TabIndex = 1;
            // 
            // lblRQ
            // 
            this.lblRQ.ForeColor = System.Drawing.Color.Gray;
            this.lblRQ.Location = new System.Drawing.Point(32, 32);
            this.lblRQ.Name = "lblRQ";
            this.lblRQ.Size = new System.Drawing.Size(80, 24);
            this.lblRQ.TabIndex = 0;
            this.lblRQ.Text = "选择日期：";
            this.lblRQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndOfDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 146);
            this.Controls.Add(this.cboRQ);
            this.Controls.Add(this.lblRQ);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEOFD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndOfDayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日结（所选择日期日结后将不能办理运单）";
            this.Load += new System.EventHandler(this.EndOfDayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEOFD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboRQ;
        private System.Windows.Forms.Label lblRQ;
    }
}