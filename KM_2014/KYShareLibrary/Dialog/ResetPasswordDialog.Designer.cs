namespace KM.Common
{
    partial class ResetPasswordDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordDialog));
            this.m_Line = new System.Windows.Forms.Label();
            this.ValidateLabel = new System.Windows.Forms.Label();
            this.ValidateText = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordText = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordText = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.KeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_Line
            // 
            this.m_Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_Line.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_Line.Location = new System.Drawing.Point(9, 172);
            this.m_Line.Name = "m_Line";
            this.m_Line.Size = new System.Drawing.Size(352, 2);
            this.m_Line.TabIndex = 6;
            // 
            // ValidateLabel
            // 
            this.ValidateLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ValidateLabel.ForeColor = System.Drawing.Color.Gray;
            this.ValidateLabel.Location = new System.Drawing.Point(24, 121);
            this.ValidateLabel.Name = "ValidateLabel";
            this.ValidateLabel.Size = new System.Drawing.Size(93, 32);
            this.ValidateLabel.TabIndex = 4;
            this.ValidateLabel.Text = "新口令验证：";
            this.ValidateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValidateText
            // 
            this.ValidateText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ValidateText.Location = new System.Drawing.Point(121, 124);
            this.ValidateText.Name = "ValidateText";
            this.ValidateText.PasswordChar = '*';
            this.ValidateText.Size = new System.Drawing.Size(223, 23);
            this.ValidateText.TabIndex = 5;
            this.ValidateText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_ValidateText_KeyUp);
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPasswordLabel.ForeColor = System.Drawing.Color.Gray;
            this.NewPasswordLabel.Location = new System.Drawing.Point(24, 72);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(93, 32);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "用户新口令：";
            this.NewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewPasswordText
            // 
            this.NewPasswordText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPasswordText.Location = new System.Drawing.Point(121, 75);
            this.NewPasswordText.Name = "NewPasswordText";
            this.NewPasswordText.PasswordChar = '*';
            this.NewPasswordText.Size = new System.Drawing.Size(223, 23);
            this.NewPasswordText.TabIndex = 3;
            this.NewPasswordText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_NewPasswordText_KeyUp);
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldPasswordLabel.ForeColor = System.Drawing.Color.Gray;
            this.OldPasswordLabel.Location = new System.Drawing.Point(24, 24);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(92, 32);
            this.OldPasswordLabel.TabIndex = 0;
            this.OldPasswordLabel.Text = "用户原口令：";
            this.OldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OldPasswordText
            // 
            this.OldPasswordText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldPasswordText.Location = new System.Drawing.Point(121, 28);
            this.OldPasswordText.Name = "OldPasswordText";
            this.OldPasswordText.PasswordChar = '*';
            this.OldPasswordText.Size = new System.Drawing.Size(223, 23);
            this.OldPasswordText.TabIndex = 1;
            this.OldPasswordText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_OldPasswordText_KeyUp);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(224, 192);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(96, 192);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 48);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "确定";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // KeyButton
            // 
            this.KeyButton.Image = ((System.Drawing.Image)(resources.GetObject("KeyButton.Image")));
            this.KeyButton.Location = new System.Drawing.Point(24, 192);
            this.KeyButton.Name = "KeyButton";
            this.KeyButton.Size = new System.Drawing.Size(48, 48);
            this.KeyButton.TabIndex = 9;
            this.KeyButton.UseVisualStyleBackColor = true;
            this.KeyButton.Click += new System.EventHandler(this.KeyButton_Click);
            // 
            // ResetPasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.KeyButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.m_Line);
            this.Controls.Add(this.ValidateLabel);
            this.Controls.Add(this.ValidateText);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.NewPasswordText);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.OldPasswordText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPasswordDialog";
            this.Opacity = 0.95;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改口令";
            this.Shown += new System.EventHandler(this.ResetPasswordDialog_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPasswordDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_Line;
        private System.Windows.Forms.Label ValidateLabel;
        private System.Windows.Forms.TextBox ValidateText;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordText;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordText;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button KeyButton;
    }
}