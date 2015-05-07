namespace WLCommon
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblValidate = new System.Windows.Forms.Label();
            this.txtValidate = new System.Windows.Forms.TextBox();
            this.lineMain = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblOldPassword.Location = new System.Drawing.Point(16, 24);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(100, 23);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "用户原密码：";
            this.lblOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Enabled = false;
            this.txtOldPassword.Location = new System.Drawing.Point(120, 24);
            this.txtOldPassword.MaxLength = 32;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(136, 21);
            this.txtOldPassword.TabIndex = 1;
            this.txtOldPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOldPassword_KeyUp);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblNewPassword.Location = new System.Drawing.Point(16, 64);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(100, 23);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "用户新密码：";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Location = new System.Drawing.Point(120, 64);
            this.txtNewPassword.MaxLength = 32;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(136, 21);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyUp);
            // 
            // lblValidate
            // 
            this.lblValidate.ForeColor = System.Drawing.Color.Gray;
            this.lblValidate.Location = new System.Drawing.Point(16, 96);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(100, 23);
            this.lblValidate.TabIndex = 4;
            this.lblValidate.Text = "新密码验证：";
            this.lblValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValidate
            // 
            this.txtValidate.Enabled = false;
            this.txtValidate.Location = new System.Drawing.Point(120, 96);
            this.txtValidate.MaxLength = 32;
            this.txtValidate.Name = "txtValidate";
            this.txtValidate.PasswordChar = '*';
            this.txtValidate.Size = new System.Drawing.Size(136, 21);
            this.txtValidate.TabIndex = 5;
            this.txtValidate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValidate_KeyUp);
            // 
            // lineMain
            // 
            this.lineMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineMain.Location = new System.Drawing.Point(8, 144);
            this.lineMain.Name = "lineMain";
            this.lineMain.Size = new System.Drawing.Size(392, 2);
            this.lineMain.TabIndex = 6;
            this.lineMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(216, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(304, 48);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 214);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lineMain);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.txtValidate);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.txtOldPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPasswordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPasswordForm_FormClosing);
            this.Shown += new System.EventHandler(this.ResetPasswordForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.TextBox txtValidate;
        private System.Windows.Forms.Label lineMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox picLogo;
    }
}