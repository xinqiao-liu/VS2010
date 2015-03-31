namespace WLCommon.Management
{
    partial class PrintFormatEditForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.Label();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblFontName = new System.Windows.Forms.Label();
            this.lblFontMode = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.cboFontName = new System.Windows.Forms.ComboBox();
            this.cboFontMode = new System.Windows.Forms.ComboBox();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.lineMain = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(56, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "名称：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 72);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.ForeColor = System.Drawing.Color.Gray;
            this.lblCode.Location = new System.Drawing.Point(56, 40);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(96, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "编号：";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(168, 40);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(152, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(168, 144);
            this.numY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(152, 21);
            this.numY.TabIndex = 7;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(168, 112);
            this.numX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(152, 21);
            this.numX.TabIndex = 5;
            // 
            // lblY
            // 
            this.lblY.ForeColor = System.Drawing.Color.Gray;
            this.lblY.Location = new System.Drawing.Point(56, 144);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(96, 23);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "Y：";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX
            // 
            this.lblX.ForeColor = System.Drawing.Color.Gray;
            this.lblX.Location = new System.Drawing.Point(56, 112);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(96, 23);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X：";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFontName
            // 
            this.lblFontName.ForeColor = System.Drawing.Color.Gray;
            this.lblFontName.Location = new System.Drawing.Point(56, 184);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(96, 23);
            this.lblFontName.TabIndex = 8;
            this.lblFontName.Text = "字体名称：";
            this.lblFontName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFontMode
            // 
            this.lblFontMode.ForeColor = System.Drawing.Color.Gray;
            this.lblFontMode.Location = new System.Drawing.Point(56, 248);
            this.lblFontMode.Name = "lblFontMode";
            this.lblFontMode.Size = new System.Drawing.Size(96, 23);
            this.lblFontMode.TabIndex = 12;
            this.lblFontMode.Text = "字体风格：";
            this.lblFontMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(168, 216);
            this.numFontSize.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numFontSize.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(152, 21);
            this.numFontSize.TabIndex = 11;
            this.numFontSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // lblFontSize
            // 
            this.lblFontSize.ForeColor = System.Drawing.Color.Gray;
            this.lblFontSize.Location = new System.Drawing.Point(56, 216);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(96, 23);
            this.lblFontSize.TabIndex = 10;
            this.lblFontSize.Text = "字体大小：";
            this.lblFontSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboFontName
            // 
            this.cboFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFontName.FormattingEnabled = true;
            this.cboFontName.Location = new System.Drawing.Point(168, 184);
            this.cboFontName.Name = "cboFontName";
            this.cboFontName.Size = new System.Drawing.Size(152, 20);
            this.cboFontName.TabIndex = 9;
            // 
            // cboFontMode
            // 
            this.cboFontMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFontMode.FormattingEnabled = true;
            this.cboFontMode.Items.AddRange(new object[] {
            "常规",
            "粗体",
            "斜体",
            "粗斜体"});
            this.cboFontMode.Location = new System.Drawing.Point(168, 248);
            this.cboFontMode.Name = "cboFontMode";
            this.cboFontMode.Size = new System.Drawing.Size(152, 20);
            this.cboFontMode.TabIndex = 13;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(168, 288);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(48, 16);
            this.chkEnable.TabIndex = 14;
            this.chkEnable.Text = "启用";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // lineMain
            // 
            this.lineMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineMain.Location = new System.Drawing.Point(16, 344);
            this.lineMain.Name = "lineMain";
            this.lineMain.Size = new System.Drawing.Size(344, 2);
            this.lineMain.TabIndex = 15;
            this.lineMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(272, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(184, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // PrintFormatEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 413);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lineMain);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.cboFontMode);
            this.Controls.Add(this.cboFontName);
            this.Controls.Add(this.numFontSize);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.lblFontMode);
            this.Controls.Add(this.lblFontName);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintFormatEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑打印格式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintFormatEditForm_FormClosing);
            this.Shown += new System.EventHandler(this.PrintFormatEditForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label txtCode;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.Label lblFontMode;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.ComboBox cboFontName;
        private System.Windows.Forms.ComboBox cboFontMode;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label lineMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}