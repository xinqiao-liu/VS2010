namespace WLManager
{
    partial class ChangeForm
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
            this.lblCPH = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoading = new System.Windows.Forms.Button();
            this.mainLine = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.Label();
            this.txtCPH = new Common.TextBoxEx();
            this.SuspendLayout();
            // 
            // lblCPH
            // 
            this.lblCPH.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCPH.ForeColor = System.Drawing.Color.Gray;
            this.lblCPH.Location = new System.Drawing.Point(24, 88);
            this.lblCPH.Name = "lblCPH";
            this.lblCPH.Size = new System.Drawing.Size(72, 23);
            this.lblCPH.TabIndex = 2;
            this.lblCPH.Text = "车牌号：";
            this.lblCPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSN
            // 
            this.lblSN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSN.ForeColor = System.Drawing.Color.Gray;
            this.lblSN.Location = new System.Drawing.Point(24, 40);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(72, 23);
            this.lblSN.TabIndex = 0;
            this.lblSN.Text = "单据号：";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(168, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoading
            // 
            this.btnLoading.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLoading.Location = new System.Drawing.Point(80, 176);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(75, 23);
            this.btnLoading.TabIndex = 7;
            this.btnLoading.Text = "换车";
            this.btnLoading.UseVisualStyleBackColor = true;
            // 
            // mainLine
            // 
            this.mainLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLine.Location = new System.Drawing.Point(8, 152);
            this.mainLine.Name = "mainLine";
            this.mainLine.Size = new System.Drawing.Size(248, 2);
            this.mainLine.TabIndex = 5;
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSN.ForeColor = System.Drawing.Color.Black;
            this.txtSN.Location = new System.Drawing.Point(96, 40);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(144, 23);
            this.txtSN.TabIndex = 9;
            this.txtSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCPH
            // 
            this.txtCPH.AutoSelectNextControl = true;
            this.txtCPH.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtCPH.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCPH.EnterSelectAll = true;
            this.txtCPH.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCPH.Location = new System.Drawing.Point(96, 88);
            this.txtCPH.MaxLength = 7;
            this.txtCPH.MustNonEmpty = true;
            this.txtCPH.Name = "txtCPH";
            this.txtCPH.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtCPH.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCPH.Size = new System.Drawing.Size(144, 23);
            this.txtCPH.TabIndex = 3;
            this.txtCPH.TabStop = false;
            this.txtCPH.TextChanged += new System.EventHandler(this.txtCPH_TextChanged);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 222);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.mainLine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.lblCPH);
            this.Controls.Add(this.txtCPH);
            this.Controls.Add(this.lblSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换车";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPH;
        private Common.TextBoxEx txtCPH;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoading;
        private System.Windows.Forms.Label mainLine;
        private System.Windows.Forms.Label txtSN;
    }
}