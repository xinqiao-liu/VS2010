namespace KM.Common
{
    partial class MessageDialog
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtMsg = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.Label();
            this.btn03 = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMsg.Location = new System.Drawing.Point(112, 24);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(432, 184);
            this.txtMsg.TabIndex = 0;
            this.txtMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCount.ForeColor = System.Drawing.Color.Green;
            this.txtCount.Location = new System.Drawing.Point(32, 248);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(17, 16);
            this.txtCount.TabIndex = 1;
            this.txtCount.Text = "0";
            this.txtCount.Visible = false;
            // 
            // btn03
            // 
            this.btn03.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn03.Location = new System.Drawing.Point(416, 232);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(120, 48);
            this.btn03.TabIndex = 4;
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Visible = false;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(32, 96);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(48, 48);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // btn02
            // 
            this.btn02.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn02.Location = new System.Drawing.Point(280, 232);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(120, 48);
            this.btn02.TabIndex = 3;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Visible = false;
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn01.Location = new System.Drawing.Point(144, 232);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(120, 48);
            this.btn01.TabIndex = 2;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Visible = false;
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 304);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageDialog";
            this.Opacity = 0.95;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label txtMsg;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
    }
}