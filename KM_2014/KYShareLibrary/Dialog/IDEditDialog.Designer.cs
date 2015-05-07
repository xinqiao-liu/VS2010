namespace KM.Common
{
    partial class IDEditDialog
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
            this.lblUID = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.m_MainLine = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUID
            // 
            this.lblUID.ForeColor = System.Drawing.Color.Gray;
            this.lblUID.Location = new System.Drawing.Point(32, 40);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(104, 24);
            this.lblUID.TabIndex = 0;
            this.lblUID.Text = "用户编号：";
            this.lblUID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCID
            // 
            this.lblCID.ForeColor = System.Drawing.Color.Gray;
            this.lblCID.Location = new System.Drawing.Point(32, 88);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(104, 24);
            this.lblCID.TabIndex = 2;
            this.lblCID.Text = "ID卡编号：";
            this.lblCID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(136, 88);
            this.txtCID.MaxLength = 10;
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(208, 23);
            this.txtCID.TabIndex = 3;
            // 
            // m_MainLine
            // 
            this.m_MainLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_MainLine.Location = new System.Drawing.Point(8, 152);
            this.m_MainLine.Name = "m_MainLine";
            this.m_MainLine.Size = new System.Drawing.Size(384, 2);
            this.m_MainLine.TabIndex = 4;
            this.m_MainLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(88, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 40);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(216, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUID
            // 
            this.txtUID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUID.Location = new System.Drawing.Point(136, 40);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(208, 24);
            this.txtUID.TabIndex = 1;
            this.txtUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IDEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 235);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.m_MainLine);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.lblCID);
            this.Controls.Add(this.lblUID);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IDEditDialog";
            this.Opacity = 0.95;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IDEditDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label m_MainLine;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label txtUID;
    }
}