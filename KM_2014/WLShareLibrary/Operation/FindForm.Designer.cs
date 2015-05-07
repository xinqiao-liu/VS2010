namespace WLCommon.Operation
{
    partial class FindForm
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
            this.line01 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdoRQ = new System.Windows.Forms.RadioButton();
            this.rdoSN = new System.Windows.Forms.RadioButton();
            this.rdoFHRName = new System.Windows.Forms.RadioButton();
            this.rdoFHRMobile = new System.Windows.Forms.RadioButton();
            this.cboContent = new System.Windows.Forms.ComboBox();
            this.grpKeywords = new System.Windows.Forms.GroupBox();
            this.grpKeywords.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(240, 264);
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
            this.btnOK.Location = new System.Drawing.Point(152, 264);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // line01
            // 
            this.line01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line01.ForeColor = System.Drawing.Color.Gray;
            this.line01.Location = new System.Drawing.Point(16, 240);
            this.line01.Name = "line01";
            this.line01.Size = new System.Drawing.Size(304, 2);
            this.line01.TabIndex = 2;
            this.line01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(24, 200);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "办单日期：";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoRQ
            // 
            this.rdoRQ.AutoSize = true;
            this.rdoRQ.Checked = true;
            this.rdoRQ.Location = new System.Drawing.Point(24, 32);
            this.rdoRQ.Name = "rdoRQ";
            this.rdoRQ.Size = new System.Drawing.Size(71, 16);
            this.rdoRQ.TabIndex = 5;
            this.rdoRQ.TabStop = true;
            this.rdoRQ.Text = "办单日期";
            this.rdoRQ.UseVisualStyleBackColor = true;
            this.rdoRQ.CheckedChanged += new System.EventHandler(this.Keywords_CheckedChanged);
            // 
            // rdoSN
            // 
            this.rdoSN.AutoSize = true;
            this.rdoSN.Location = new System.Drawing.Point(24, 64);
            this.rdoSN.Name = "rdoSN";
            this.rdoSN.Size = new System.Drawing.Size(71, 16);
            this.rdoSN.TabIndex = 6;
            this.rdoSN.Text = "运单编号";
            this.rdoSN.UseVisualStyleBackColor = true;
            this.rdoSN.CheckedChanged += new System.EventHandler(this.Keywords_CheckedChanged);
            // 
            // rdoFHRName
            // 
            this.rdoFHRName.AutoSize = true;
            this.rdoFHRName.Location = new System.Drawing.Point(24, 96);
            this.rdoFHRName.Name = "rdoFHRName";
            this.rdoFHRName.Size = new System.Drawing.Size(83, 16);
            this.rdoFHRName.TabIndex = 7;
            this.rdoFHRName.Text = "发货人姓名";
            this.rdoFHRName.UseVisualStyleBackColor = true;
            this.rdoFHRName.CheckedChanged += new System.EventHandler(this.Keywords_CheckedChanged);
            // 
            // rdoFHRMobile
            // 
            this.rdoFHRMobile.AutoSize = true;
            this.rdoFHRMobile.Location = new System.Drawing.Point(24, 128);
            this.rdoFHRMobile.Name = "rdoFHRMobile";
            this.rdoFHRMobile.Size = new System.Drawing.Size(83, 16);
            this.rdoFHRMobile.TabIndex = 8;
            this.rdoFHRMobile.Text = "发货人电话";
            this.rdoFHRMobile.UseVisualStyleBackColor = true;
            this.rdoFHRMobile.Click += new System.EventHandler(this.Keywords_CheckedChanged);
            // 
            // cboContent
            // 
            this.cboContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContent.FormattingEnabled = true;
            this.cboContent.Location = new System.Drawing.Point(112, 200);
            this.cboContent.Name = "cboContent";
            this.cboContent.Size = new System.Drawing.Size(208, 20);
            this.cboContent.TabIndex = 9;
            this.cboContent.TextChanged += new System.EventHandler(this.cboContent_TextChanged);
            // 
            // grpKeywords
            // 
            this.grpKeywords.Controls.Add(this.rdoRQ);
            this.grpKeywords.Controls.Add(this.rdoSN);
            this.grpKeywords.Controls.Add(this.rdoFHRMobile);
            this.grpKeywords.Controls.Add(this.rdoFHRName);
            this.grpKeywords.Location = new System.Drawing.Point(24, 16);
            this.grpKeywords.Name = "grpKeywords";
            this.grpKeywords.Size = new System.Drawing.Size(296, 168);
            this.grpKeywords.TabIndex = 10;
            this.grpKeywords.TabStop = false;
            this.grpKeywords.Text = "查找关键字";
            // 
            // FindForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(337, 307);
            this.Controls.Add(this.grpKeywords);
            this.Controls.Add(this.cboContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.line01);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找运单";
            this.Shown += new System.EventHandler(this.Keywords_CheckedChanged);
            this.grpKeywords.ResumeLayout(false);
            this.grpKeywords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label line01;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdoRQ;
        private System.Windows.Forms.RadioButton rdoSN;
        private System.Windows.Forms.RadioButton rdoFHRName;
        private System.Windows.Forms.RadioButton rdoFHRMobile;
        private System.Windows.Forms.ComboBox cboContent;
        private System.Windows.Forms.GroupBox grpKeywords;
    }
}