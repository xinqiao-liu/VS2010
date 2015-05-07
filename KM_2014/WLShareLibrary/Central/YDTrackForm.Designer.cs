namespace WLCommon.Central
{
    partial class YDTrackForm
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
            this.txtSN = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.list = new Common.ListViewEx();
            this.columnNode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(104, 416);
            this.txtSN.MaxLength = 12;
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(144, 21);
            this.txtSN.TabIndex = 0;
            this.txtSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSN_KeyUp);
            // 
            // lblSN
            // 
            this.lblSN.ForeColor = System.Drawing.Color.Gray;
            this.lblSN.Location = new System.Drawing.Point(16, 416);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(80, 23);
            this.lblSN.TabIndex = 1;
            this.lblSN.Text = "运单编号：";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(648, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNode,
            this.columnDate,
            this.columnCDT,
            this.columnContent});
            this.list.FullRowSelect = true;
            this.list.Location = new System.Drawing.Point(16, 16);
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(720, 376);
            this.list.TabIndex = 2;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // columnNode
            // 
            this.columnNode.Text = "办单网点";
            this.columnNode.Width = 120;
            // 
            // columnDate
            // 
            this.columnDate.Text = "办单日期";
            this.columnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDate.Width = 100;
            // 
            // columnCDT
            // 
            this.columnCDT.Text = "追踪时间";
            this.columnCDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCDT.Width = 160;
            // 
            // columnContent
            // 
            this.columnContent.Text = "追踪信息";
            this.columnContent.Width = 315;
            // 
            // YDTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.list);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.lblSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YDTrackForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运单追踪";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lblSN;
        private Common.ListViewEx list;
        private System.Windows.Forms.ColumnHeader columnNode;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnCDT;
        private System.Windows.Forms.ColumnHeader columnContent;
        private System.Windows.Forms.Button btnCancel;
    }
}