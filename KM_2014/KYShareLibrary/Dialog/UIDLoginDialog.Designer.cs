namespace KM.Common
{
    partial class UIDLoginDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIDLoginDialog));
            this.m_Line = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.UserIDText = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.KeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_Line
            // 
            this.m_Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_Line.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_Line.Location = new System.Drawing.Point(8, 144);
            this.m_Line.Name = "m_Line";
            this.m_Line.Size = new System.Drawing.Size(384, 2);
            this.m_Line.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Gray;
            this.PasswordLabel.Location = new System.Drawing.Point(32, 80);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(93, 23);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "用户口令：";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordText.Location = new System.Drawing.Point(128, 80);
            this.PasswordText.MaxLength = 80;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(223, 23);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordText_KeyUp);
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserIDLabel.ForeColor = System.Drawing.Color.Gray;
            this.UserIDLabel.Location = new System.Drawing.Point(32, 40);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(92, 24);
            this.UserIDLabel.TabIndex = 0;
            this.UserIDLabel.Text = "用户工号：";
            this.UserIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserIDText
            // 
            this.UserIDText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserIDText.Location = new System.Drawing.Point(128, 40);
            this.UserIDText.MaxLength = 20;
            this.UserIDText.Name = "UserIDText";
            this.UserIDText.Size = new System.Drawing.Size(223, 23);
            this.UserIDText.TabIndex = 1;
            this.UserIDText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserIDText_KeyUp);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(240, 168);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 48);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(104, 168);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 48);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确定";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // KeyButton
            // 
            this.KeyButton.Image = ((System.Drawing.Image)(resources.GetObject("KeyButton.Image")));
            this.KeyButton.Location = new System.Drawing.Point(32, 168);
            this.KeyButton.Name = "KeyButton";
            this.KeyButton.Size = new System.Drawing.Size(48, 48);
            this.KeyButton.TabIndex = 5;
            this.KeyButton.UseVisualStyleBackColor = true;
            this.KeyButton.Click += new System.EventHandler(this.KeyButton_Click);
            // 
            // UIDLoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 241);
            this.Controls.Add(this.KeyButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.m_Line);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.UserIDText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIDLoginDialog";
            this.Opacity = 0.9;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Shown += new System.EventHandler(this.LoginDialog_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_Line;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.TextBox UserIDText;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button KeyButton;
    }
}