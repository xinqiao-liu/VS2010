namespace WLCommon.Checkout
{
    partial class JZDMEditForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnCheckJZDMExists = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(488, 352);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.cboMode);
            this.tabPage.Controls.Add(this.lblMode);
            this.tabPage.Controls.Add(this.txtTel);
            this.tabPage.Controls.Add(this.lblTel);
            this.tabPage.Controls.Add(this.txtAddress);
            this.tabPage.Controls.Add(this.lblAddress);
            this.tabPage.Controls.Add(this.txtName);
            this.tabPage.Controls.Add(this.txtCode);
            this.tabPage.Controls.Add(this.lblValue);
            this.tabPage.Controls.Add(this.numValue);
            this.tabPage.Controls.Add(this.lblName);
            this.tabPage.Controls.Add(this.lblCode);
            this.tabPage.Controls.Add(this.btnCheckJZDMExists);
            this.tabPage.Location = new System.Drawing.Point(4, 24);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(480, 324);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "常规";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Location = new System.Drawing.Point(144, 168);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(136, 20);
            this.cboMode.TabIndex = 8;
            // 
            // lblMode
            // 
            this.lblMode.ForeColor = System.Drawing.Color.Gray;
            this.lblMode.Location = new System.Drawing.Point(40, 168);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(100, 23);
            this.lblMode.TabIndex = 7;
            this.lblMode.Text = "结账模式：";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(144, 256);
            this.txtTel.MaxLength = 16;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(136, 21);
            this.txtTel.TabIndex = 12;
            // 
            // lblTel
            // 
            this.lblTel.ForeColor = System.Drawing.Color.Gray;
            this.lblTel.Location = new System.Drawing.Point(40, 256);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 23);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "联系电话：";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(144, 216);
            this.txtAddress.MaxLength = 32;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 21);
            this.txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(40, 216);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "联系地址：";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 80);
            this.txtName.MaxLength = 16;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 21);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "未确定";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(144, 40);
            this.txtCode.MaxLength = 4;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(136, 21);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblValue
            // 
            this.lblValue.ForeColor = System.Drawing.Color.Gray;
            this.lblValue.Location = new System.Drawing.Point(40, 136);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(100, 23);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "结账比率：";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numValue
            // 
            this.numValue.DecimalPlaces = 2;
            this.numValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numValue.Location = new System.Drawing.Point(144, 136);
            this.numValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(136, 21);
            this.numValue.TabIndex = 6;
            this.numValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(40, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "单位名称：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.ForeColor = System.Drawing.Color.Gray;
            this.lblCode.Location = new System.Drawing.Point(40, 40);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(100, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "结账代码：";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckJZDMExists
            // 
            this.btnCheckJZDMExists.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnCheckJZDMExists.Location = new System.Drawing.Point(304, 40);
            this.btnCheckJZDMExists.Name = "btnCheckJZDMExists";
            this.btnCheckJZDMExists.Size = new System.Drawing.Size(128, 23);
            this.btnCheckJZDMExists.TabIndex = 2;
            this.btnCheckJZDMExists.TabStop = true;
            this.btnCheckJZDMExists.Text = "检测结账代码是否存在";
            this.btnCheckJZDMExists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckJZDMExists.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCheckJZDMExists_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(328, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // JZDMEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 416);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JZDMEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JZDMEditForm_FormClosing);
            this.Shown += new System.EventHandler(this.JZDMEditForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.LinkLabel btnCheckJZDMExists;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label lblMode;
    }
}