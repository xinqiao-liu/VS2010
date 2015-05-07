namespace KM.Common
{
    partial class LockDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockDialog));
            this.UIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CIDLabel = new System.Windows.Forms.Label();
            this.UIDText = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.CIDText = new System.Windows.Forms.TextBox();
            this.mainLine = new System.Windows.Forms.Label();
            this.UnlockButton = new System.Windows.Forms.Button();
            this.KeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIDLabel
            // 
            this.UIDLabel.ForeColor = System.Drawing.Color.Gray;
            this.UIDLabel.Location = new System.Drawing.Point(32, 32);
            this.UIDLabel.Name = "UIDLabel";
            this.UIDLabel.Size = new System.Drawing.Size(96, 24);
            this.UIDLabel.TabIndex = 0;
            this.UIDLabel.Text = "用户编号：";
            this.UIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabel
            // 
            this.NameLabel.ForeColor = System.Drawing.Color.Gray;
            this.NameLabel.Location = new System.Drawing.Point(32, 72);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 24);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "用户名称：";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CIDLabel
            // 
            this.CIDLabel.ForeColor = System.Drawing.Color.Gray;
            this.CIDLabel.Location = new System.Drawing.Point(32, 112);
            this.CIDLabel.Name = "CIDLabel";
            this.CIDLabel.Size = new System.Drawing.Size(96, 24);
            this.CIDLabel.TabIndex = 4;
            this.CIDLabel.Text = "口令或卡号：";
            this.CIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UIDText
            // 
            this.UIDText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UIDText.ForeColor = System.Drawing.Color.Black;
            this.UIDText.Location = new System.Drawing.Point(136, 32);
            this.UIDText.Name = "UIDText";
            this.UIDText.Size = new System.Drawing.Size(200, 24);
            this.UIDText.TabIndex = 1;
            this.UIDText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameText.Location = new System.Drawing.Point(136, 72);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(200, 24);
            this.NameText.TabIndex = 3;
            this.NameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CIDText
            // 
            this.CIDText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CIDText.Location = new System.Drawing.Point(136, 112);
            this.CIDText.Name = "CIDText";
            this.CIDText.PasswordChar = '*';
            this.CIDText.Size = new System.Drawing.Size(200, 23);
            this.CIDText.TabIndex = 5;
            this.CIDText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CIDText_KeyUp);
            // 
            // mainLine
            // 
            this.mainLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLine.Location = new System.Drawing.Point(8, 160);
            this.mainLine.Name = "mainLine";
            this.mainLine.Size = new System.Drawing.Size(360, 2);
            this.mainLine.TabIndex = 6;
            this.mainLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnlockButton
            // 
            this.UnlockButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UnlockButton.Enabled = false;
            this.UnlockButton.Image = ((System.Drawing.Image)(resources.GetObject("UnlockButton.Image")));
            this.UnlockButton.Location = new System.Drawing.Point(216, 184);
            this.UnlockButton.Name = "UnlockButton";
            this.UnlockButton.Size = new System.Drawing.Size(120, 48);
            this.UnlockButton.TabIndex = 7;
            this.UnlockButton.Text = "解除锁定";
            this.UnlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UnlockButton.UseVisualStyleBackColor = true;
            // 
            // KeyButton
            // 
            this.KeyButton.Image = ((System.Drawing.Image)(resources.GetObject("KeyButton.Image")));
            this.KeyButton.Location = new System.Drawing.Point(32, 184);
            this.KeyButton.Name = "KeyButton";
            this.KeyButton.Size = new System.Drawing.Size(48, 48);
            this.KeyButton.TabIndex = 10;
            this.KeyButton.UseVisualStyleBackColor = true;
            this.KeyButton.Click += new System.EventHandler(this.KeyButton_Click);
            // 
            // LockDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 254);
            this.ControlBox = false;
            this.Controls.Add(this.KeyButton);
            this.Controls.Add(this.UnlockButton);
            this.Controls.Add(this.mainLine);
            this.Controls.Add(this.CIDText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.UIDText);
            this.Controls.Add(this.CIDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UIDLabel);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockDialog";
            this.Opacity = 0.95;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "锁定";
            this.Load += new System.EventHandler(this.LockForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LockForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UIDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CIDLabel;
        private System.Windows.Forms.Label UIDText;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.TextBox CIDText;
        private System.Windows.Forms.Label mainLine;
        private System.Windows.Forms.Button UnlockButton;
        private System.Windows.Forms.Button KeyButton;
    }
}