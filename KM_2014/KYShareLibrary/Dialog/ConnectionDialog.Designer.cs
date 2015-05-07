namespace KM.Common
{
    partial class ConnectionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionDialog));
            this.lblOneConnectionString = new System.Windows.Forms.Label();
            this.txtOneConnectionString = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.mainLine = new System.Windows.Forms.Label();
            this.KeyButton = new System.Windows.Forms.Button();
            this.txtTwoConnectionString = new System.Windows.Forms.TextBox();
            this.lblTwoConnectionString = new System.Windows.Forms.Label();
            this.txtOleConnectionString = new System.Windows.Forms.TextBox();
            this.lblOleConnectionString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOneConnectionString
            // 
            this.lblOneConnectionString.ForeColor = System.Drawing.Color.Gray;
            this.lblOneConnectionString.Location = new System.Drawing.Point(16, 56);
            this.lblOneConnectionString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOneConnectionString.Name = "lblOneConnectionString";
            this.lblOneConnectionString.Size = new System.Drawing.Size(120, 28);
            this.lblOneConnectionString.TabIndex = 0;
            this.lblOneConnectionString.Text = "主数据连接：";
            this.lblOneConnectionString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOneConnectionString
            // 
            this.txtOneConnectionString.Enabled = false;
            this.txtOneConnectionString.Location = new System.Drawing.Point(136, 56);
            this.txtOneConnectionString.Name = "txtOneConnectionString";
            this.txtOneConnectionString.Size = new System.Drawing.Size(424, 23);
            this.txtOneConnectionString.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(440, 272);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 48);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(296, 272);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 48);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // mainLine
            // 
            this.mainLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLine.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainLine.Location = new System.Drawing.Point(8, 248);
            this.mainLine.Name = "mainLine";
            this.mainLine.Size = new System.Drawing.Size(568, 2);
            this.mainLine.TabIndex = 6;
            // 
            // KeyButton
            // 
            this.KeyButton.Image = ((System.Drawing.Image)(resources.GetObject("KeyButton.Image")));
            this.KeyButton.Location = new System.Drawing.Point(24, 272);
            this.KeyButton.Name = "KeyButton";
            this.KeyButton.Size = new System.Drawing.Size(48, 48);
            this.KeyButton.TabIndex = 7;
            this.KeyButton.UseVisualStyleBackColor = true;
            this.KeyButton.Click += new System.EventHandler(this.KeyButton_Click);
            // 
            // txtTwoConnectionString
            // 
            this.txtTwoConnectionString.Enabled = false;
            this.txtTwoConnectionString.Location = new System.Drawing.Point(136, 112);
            this.txtTwoConnectionString.Name = "txtTwoConnectionString";
            this.txtTwoConnectionString.Size = new System.Drawing.Size(424, 23);
            this.txtTwoConnectionString.TabIndex = 3;
            // 
            // lblTwoConnectionString
            // 
            this.lblTwoConnectionString.ForeColor = System.Drawing.Color.Gray;
            this.lblTwoConnectionString.Location = new System.Drawing.Point(16, 112);
            this.lblTwoConnectionString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTwoConnectionString.Name = "lblTwoConnectionString";
            this.lblTwoConnectionString.Size = new System.Drawing.Size(120, 28);
            this.lblTwoConnectionString.TabIndex = 2;
            this.lblTwoConnectionString.Text = "辅数据连接：";
            this.lblTwoConnectionString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOleConnectionString
            // 
            this.txtOleConnectionString.Enabled = false;
            this.txtOleConnectionString.Location = new System.Drawing.Point(136, 168);
            this.txtOleConnectionString.Name = "txtOleConnectionString";
            this.txtOleConnectionString.Size = new System.Drawing.Size(424, 23);
            this.txtOleConnectionString.TabIndex = 5;
            // 
            // lblOleConnectionString
            // 
            this.lblOleConnectionString.ForeColor = System.Drawing.Color.Gray;
            this.lblOleConnectionString.Location = new System.Drawing.Point(16, 168);
            this.lblOleConnectionString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOleConnectionString.Name = "lblOleConnectionString";
            this.lblOleConnectionString.Size = new System.Drawing.Size(120, 28);
            this.lblOleConnectionString.TabIndex = 4;
            this.lblOleConnectionString.Text = "OLE 数据连接：";
            this.lblOleConnectionString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConnectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 343);
            this.Controls.Add(this.txtOleConnectionString);
            this.Controls.Add(this.lblOleConnectionString);
            this.Controls.Add(this.txtTwoConnectionString);
            this.Controls.Add(this.lblTwoConnectionString);
            this.Controls.Add(this.KeyButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mainLine);
            this.Controls.Add(this.txtOneConnectionString);
            this.Controls.Add(this.lblOneConnectionString);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionDialog";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOneConnectionString;
        private System.Windows.Forms.TextBox txtOneConnectionString;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label mainLine;
        private System.Windows.Forms.Button KeyButton;
        private System.Windows.Forms.TextBox txtTwoConnectionString;
        private System.Windows.Forms.Label lblTwoConnectionString;
        private System.Windows.Forms.TextBox txtOleConnectionString;
        private System.Windows.Forms.Label lblOleConnectionString;
    }
}