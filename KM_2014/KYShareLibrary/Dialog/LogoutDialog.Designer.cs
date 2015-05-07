namespace KM.Common
{
    partial class LogoutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoutDialog));
            this.m_CancelButton = new System.Windows.Forms.Button();
            this.m_SwitchButton = new System.Windows.Forms.Button();
            this.m_LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_CancelButton
            // 
            this.m_CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_CancelButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("m_CancelButton.Image")));
            this.m_CancelButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.m_CancelButton.Location = new System.Drawing.Point(248, 24);
            this.m_CancelButton.Name = "m_CancelButton";
            this.m_CancelButton.Size = new System.Drawing.Size(87, 84);
            this.m_CancelButton.TabIndex = 2;
            this.m_CancelButton.Text = "取消";
            this.m_CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.m_CancelButton.UseVisualStyleBackColor = true;
            this.m_CancelButton.Click += new System.EventHandler(this.m_CancelButton_Click);
            // 
            // m_SwitchButton
            // 
            this.m_SwitchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_SwitchButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_SwitchButton.Image = ((System.Drawing.Image)(resources.GetObject("m_SwitchButton.Image")));
            this.m_SwitchButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.m_SwitchButton.Location = new System.Drawing.Point(136, 24);
            this.m_SwitchButton.Name = "m_SwitchButton";
            this.m_SwitchButton.Size = new System.Drawing.Size(87, 84);
            this.m_SwitchButton.TabIndex = 1;
            this.m_SwitchButton.Text = "切换";
            this.m_SwitchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.m_SwitchButton.UseVisualStyleBackColor = true;
            this.m_SwitchButton.Click += new System.EventHandler(this.m_SwitchButton_Click);
            // 
            // m_LogoutButton
            // 
            this.m_LogoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_LogoutButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("m_LogoutButton.Image")));
            this.m_LogoutButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.m_LogoutButton.Location = new System.Drawing.Point(24, 24);
            this.m_LogoutButton.Name = "m_LogoutButton";
            this.m_LogoutButton.Size = new System.Drawing.Size(87, 84);
            this.m_LogoutButton.TabIndex = 0;
            this.m_LogoutButton.Text = "注销";
            this.m_LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.m_LogoutButton.UseVisualStyleBackColor = true;
            this.m_LogoutButton.Click += new System.EventHandler(this.m_LogoutButton_Click);
            // 
            // LogoutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 133);
            this.Controls.Add(this.m_CancelButton);
            this.Controls.Add(this.m_SwitchButton);
            this.Controls.Add(this.m_LogoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogoutDialog";
            this.Opacity = 0.95;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注销";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_CancelButton;
        private System.Windows.Forms.Button m_SwitchButton;
        private System.Windows.Forms.Button m_LogoutButton;
    }
}