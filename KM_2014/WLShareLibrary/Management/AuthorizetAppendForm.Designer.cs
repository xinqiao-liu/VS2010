namespace WLCommon.Management
{
    partial class AuthorizetAppendForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboNode = new System.Windows.Forms.ComboBox();
            this.lblNode = new System.Windows.Forms.Label();
            this.line01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(208, 136);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(296, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboNode
            // 
            this.cboNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNode.FormattingEnabled = true;
            this.cboNode.Location = new System.Drawing.Point(152, 48);
            this.cboNode.Name = "cboNode";
            this.cboNode.Size = new System.Drawing.Size(224, 20);
            this.cboNode.TabIndex = 1;
            // 
            // lblNode
            // 
            this.lblNode.ForeColor = System.Drawing.Color.Gray;
            this.lblNode.Location = new System.Drawing.Point(40, 48);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(104, 23);
            this.lblNode.TabIndex = 0;
            this.lblNode.Text = "选择网点：";
            this.lblNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // line01
            // 
            this.line01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line01.Location = new System.Drawing.Point(8, 112);
            this.line01.Name = "line01";
            this.line01.Size = new System.Drawing.Size(440, 2);
            this.line01.TabIndex = 2;
            // 
            // AuthorizetAppendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 182);
            this.Controls.Add(this.line01);
            this.Controls.Add(this.cboNode);
            this.Controls.Add(this.lblNode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizetAppendForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizetAppendForm_FormClosing);
            this.Shown += new System.EventHandler(this.AuthorizetAppendForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboNode;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.Label line01;
    }
}