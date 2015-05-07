namespace WLCommon.Checkout
{
    partial class CSXXEditForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCode = new System.Windows.Forms.Label();
            this.cboCode = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCPH = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCPH = new System.Windows.Forms.Label();
            this.btnCheckCPHExists = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(488, 352);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCode);
            this.tabPage1.Controls.Add(this.cboCode);
            this.tabPage1.Controls.Add(this.txtTel);
            this.tabPage1.Controls.Add(this.lblTel);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtCPH);
            this.tabPage1.Controls.Add(this.lblValue);
            this.tabPage1.Controls.Add(this.numValue);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.lblCPH);
            this.tabPage1.Controls.Add(this.btnCheckCPHExists);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.ForeColor = System.Drawing.Color.Gray;
            this.lblCode.Location = new System.Drawing.Point(40, 32);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(100, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "结账代码：";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCode
            // 
            this.cboCode.FormattingEnabled = true;
            this.cboCode.Location = new System.Drawing.Point(144, 32);
            this.cboCode.Name = "cboCode";
            this.cboCode.Size = new System.Drawing.Size(136, 20);
            this.cboCode.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(144, 272);
            this.txtTel.MaxLength = 16;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(136, 21);
            this.txtTel.TabIndex = 11;
            // 
            // lblTel
            // 
            this.lblTel.ForeColor = System.Drawing.Color.Gray;
            this.lblTel.Location = new System.Drawing.Point(40, 272);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 23);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "联系电话：";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(144, 232);
            this.txtAddress.MaxLength = 32;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 21);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(40, 232);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "地联系址：";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 120);
            this.txtName.MaxLength = 16;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtCPH
            // 
            this.txtCPH.Location = new System.Drawing.Point(144, 80);
            this.txtCPH.MaxLength = 7;
            this.txtCPH.Name = "txtCPH";
            this.txtCPH.Size = new System.Drawing.Size(136, 21);
            this.txtCPH.TabIndex = 3;
            this.txtCPH.TextChanged += new System.EventHandler(this.txtCPH_TextChanged);
            // 
            // lblValue
            // 
            this.lblValue.ForeColor = System.Drawing.Color.Gray;
            this.lblValue.Location = new System.Drawing.Point(40, 176);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(100, 23);
            this.lblValue.TabIndex = 6;
            this.lblValue.Text = "默认结账比率：";
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
            this.numValue.Location = new System.Drawing.Point(144, 176);
            this.numValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(136, 21);
            this.numValue.TabIndex = 7;
            this.numValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(40, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "车主名称：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCPH
            // 
            this.lblCPH.ForeColor = System.Drawing.Color.Gray;
            this.lblCPH.Location = new System.Drawing.Point(40, 80);
            this.lblCPH.Name = "lblCPH";
            this.lblCPH.Size = new System.Drawing.Size(100, 23);
            this.lblCPH.TabIndex = 2;
            this.lblCPH.Text = "车牌号：";
            this.lblCPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckCPHExists
            // 
            this.btnCheckCPHExists.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnCheckCPHExists.Location = new System.Drawing.Point(296, 80);
            this.btnCheckCPHExists.Name = "btnCheckCPHExists";
            this.btnCheckCPHExists.Size = new System.Drawing.Size(128, 23);
            this.btnCheckCPHExists.TabIndex = 12;
            this.btnCheckCPHExists.TabStop = true;
            this.btnCheckCPHExists.Text = "检测车牌号是否存在";
            this.btnCheckCPHExists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckCPHExists.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCheckCPHExists_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(328, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // CSXXEditForm
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
            this.Name = "CSXXEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CSXXEditForm_FormClosing);
            this.Shown += new System.EventHandler(this.CSXXEditForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCPH;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCPH;
        private System.Windows.Forms.LinkLabel btnCheckCPHExists;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cboCode;
    }
}