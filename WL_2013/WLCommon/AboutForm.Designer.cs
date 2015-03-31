namespace WLCommon
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblSoftwareName = new System.Windows.Forms.Label();
            this.txtSoftwareName = new System.Windows.Forms.Label();
            this.txtSoftwareVersion = new System.Windows.Forms.Label();
            this.lblSoftwareVersion = new System.Windows.Forms.Label();
            this.signPicture = new System.Windows.Forms.PictureBox();
            this.txtTechnicalSupport = new System.Windows.Forms.Label();
            this.lblTechnicalSupport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.signPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSoftwareName.ForeColor = System.Drawing.Color.DimGray;
            this.lblSoftwareName.Location = new System.Drawing.Point(16, 48);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(72, 24);
            this.lblSoftwareName.TabIndex = 0;
            this.lblSoftwareName.Text = "软件名称：";
            this.lblSoftwareName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSoftwareName.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // txtSoftwareName
            // 
            this.txtSoftwareName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSoftwareName.Location = new System.Drawing.Point(96, 48);
            this.txtSoftwareName.Name = "txtSoftwareName";
            this.txtSoftwareName.Size = new System.Drawing.Size(256, 24);
            this.txtSoftwareName.TabIndex = 1;
            this.txtSoftwareName.Text = "公路客运联网物流系统 - 管理平台";
            this.txtSoftwareName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSoftwareName.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // txtSoftwareVersion
            // 
            this.txtSoftwareVersion.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSoftwareVersion.Location = new System.Drawing.Point(96, 88);
            this.txtSoftwareVersion.Name = "txtSoftwareVersion";
            this.txtSoftwareVersion.Size = new System.Drawing.Size(216, 24);
            this.txtSoftwareVersion.TabIndex = 3;
            this.txtSoftwareVersion.Text = "2013";
            this.txtSoftwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSoftwareVersion.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSoftwareVersion.ForeColor = System.Drawing.Color.DimGray;
            this.lblSoftwareVersion.Location = new System.Drawing.Point(16, 88);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(72, 24);
            this.lblSoftwareVersion.TabIndex = 2;
            this.lblSoftwareVersion.Text = "软件版本：";
            this.lblSoftwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSoftwareVersion.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // signPicture
            // 
            this.signPicture.Image = ((System.Drawing.Image)(resources.GetObject("signPicture.Image")));
            this.signPicture.Location = new System.Drawing.Point(360, 48);
            this.signPicture.Name = "signPicture";
            this.signPicture.Size = new System.Drawing.Size(128, 128);
            this.signPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.signPicture.TabIndex = 7;
            this.signPicture.TabStop = false;
            this.signPicture.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // txtTechnicalSupport
            // 
            this.txtTechnicalSupport.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTechnicalSupport.Location = new System.Drawing.Point(96, 152);
            this.txtTechnicalSupport.Name = "txtTechnicalSupport";
            this.txtTechnicalSupport.Size = new System.Drawing.Size(216, 23);
            this.txtTechnicalSupport.TabIndex = 11;
            this.txtTechnicalSupport.Text = "0431-86769937";
            this.txtTechnicalSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTechnicalSupport.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // lblTechnicalSupport
            // 
            this.lblTechnicalSupport.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTechnicalSupport.ForeColor = System.Drawing.Color.DimGray;
            this.lblTechnicalSupport.Location = new System.Drawing.Point(16, 152);
            this.lblTechnicalSupport.Name = "lblTechnicalSupport";
            this.lblTechnicalSupport.Size = new System.Drawing.Size(72, 23);
            this.lblTechnicalSupport.TabIndex = 10;
            this.lblTechnicalSupport.Text = "技术支持：";
            this.lblTechnicalSupport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTechnicalSupport.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 241);
            this.Controls.Add(this.txtTechnicalSupport);
            this.Controls.Add(this.lblTechnicalSupport);
            this.Controls.Add(this.signPicture);
            this.Controls.Add(this.txtSoftwareVersion);
            this.Controls.Add(this.lblSoftwareVersion);
            this.Controls.Add(this.txtSoftwareName);
            this.Controls.Add(this.lblSoftwareName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Click += new System.EventHandler(this.AboutForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.signPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.Label txtSoftwareName;
        private System.Windows.Forms.Label txtSoftwareVersion;
        private System.Windows.Forms.Label lblSoftwareVersion;
        private System.Windows.Forms.PictureBox signPicture;
        private System.Windows.Forms.Label txtTechnicalSupport;
        private System.Windows.Forms.Label lblTechnicalSupport;
    }
}