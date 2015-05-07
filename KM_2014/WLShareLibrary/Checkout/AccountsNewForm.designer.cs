namespace WLCommon.Checkout
{
    partial class AccountsNewForm
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.btnDetectCPH = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.maxDate = new System.Windows.Forms.DateTimePicker();
            this.lblAccountEndDate = new System.Windows.Forms.Label();
            this.minDate = new System.Windows.Forms.DateTimePicker();
            this.lblAccountStartDate = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOption = new System.Windows.Forms.TabPage();
            this.cboRoundingType = new System.Windows.Forms.ComboBox();
            this.lblRoundingType = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(240, 32);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(88, 23);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "账单月份：";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYear
            // 
            this.lblYear.ForeColor = System.Drawing.Color.Gray;
            this.lblYear.Location = new System.Drawing.Point(24, 32);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(88, 23);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "账单年度：";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(424, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(336, 376);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblAccountName
            // 
            this.lblAccountName.ForeColor = System.Drawing.Color.Gray;
            this.lblAccountName.Location = new System.Drawing.Point(24, 80);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(88, 23);
            this.lblAccountName.TabIndex = 4;
            this.lblAccountName.Text = "账单名称：";
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDetectCPH
            // 
            this.btnDetectCPH.Location = new System.Drawing.Point(16, 376);
            this.btnDetectCPH.Name = "btnDetectCPH";
            this.btnDetectCPH.Size = new System.Drawing.Size(136, 23);
            this.btnDetectCPH.TabIndex = 1;
            this.btnDetectCPH.Text = "检测运单车牌号";
            this.btnDetectCPH.UseVisualStyleBackColor = true;
            this.btnDetectCPH.Click += new System.EventHandler(this.btnDetectCPH_Click);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cboYear.Location = new System.Drawing.Point(120, 32);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(88, 20);
            this.cboYear.TabIndex = 1;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMonth.Location = new System.Drawing.Point(336, 32);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(88, 20);
            this.cboMonth.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 80);
            this.txtName.MaxLength = 16;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 21);
            this.txtName.TabIndex = 5;
            // 
            // maxDate
            // 
            this.maxDate.CustomFormat = "yyyy年MM月dd日";
            this.maxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.maxDate.Location = new System.Drawing.Point(120, 168);
            this.maxDate.Name = "maxDate";
            this.maxDate.Size = new System.Drawing.Size(136, 21);
            this.maxDate.TabIndex = 9;
            this.maxDate.Value = new System.DateTime(2012, 6, 1, 0, 0, 0, 0);
            // 
            // lblAccountEndDate
            // 
            this.lblAccountEndDate.ForeColor = System.Drawing.Color.Gray;
            this.lblAccountEndDate.Location = new System.Drawing.Point(24, 168);
            this.lblAccountEndDate.Name = "lblAccountEndDate";
            this.lblAccountEndDate.Size = new System.Drawing.Size(88, 23);
            this.lblAccountEndDate.TabIndex = 8;
            this.lblAccountEndDate.Text = "截止日期：";
            this.lblAccountEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minDate
            // 
            this.minDate.CustomFormat = "yyyy年MM月dd日";
            this.minDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.minDate.Location = new System.Drawing.Point(120, 128);
            this.minDate.Name = "minDate";
            this.minDate.Size = new System.Drawing.Size(136, 21);
            this.minDate.TabIndex = 7;
            this.minDate.Value = new System.DateTime(2012, 6, 1, 0, 0, 0, 0);
            // 
            // lblAccountStartDate
            // 
            this.lblAccountStartDate.ForeColor = System.Drawing.Color.Gray;
            this.lblAccountStartDate.Location = new System.Drawing.Point(24, 128);
            this.lblAccountStartDate.Name = "lblAccountStartDate";
            this.lblAccountStartDate.Size = new System.Drawing.Size(88, 23);
            this.lblAccountStartDate.TabIndex = 6;
            this.lblAccountStartDate.Text = "起始日期：";
            this.lblAccountStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOption);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(504, 352);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabOption
            // 
            this.tabOption.Controls.Add(this.cboRoundingType);
            this.tabOption.Controls.Add(this.lblRoundingType);
            this.tabOption.Controls.Add(this.lblYear);
            this.tabOption.Controls.Add(this.maxDate);
            this.tabOption.Controls.Add(this.lblMonth);
            this.tabOption.Controls.Add(this.lblAccountEndDate);
            this.tabOption.Controls.Add(this.lblAccountName);
            this.tabOption.Controls.Add(this.minDate);
            this.tabOption.Controls.Add(this.cboYear);
            this.tabOption.Controls.Add(this.lblAccountStartDate);
            this.tabOption.Controls.Add(this.cboMonth);
            this.tabOption.Controls.Add(this.txtName);
            this.tabOption.Location = new System.Drawing.Point(4, 24);
            this.tabOption.Name = "tabOption";
            this.tabOption.Padding = new System.Windows.Forms.Padding(3);
            this.tabOption.Size = new System.Drawing.Size(496, 324);
            this.tabOption.TabIndex = 0;
            this.tabOption.Text = "配置";
            this.tabOption.UseVisualStyleBackColor = true;
            // 
            // cboRoundingType
            // 
            this.cboRoundingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoundingType.FormattingEnabled = true;
            this.cboRoundingType.Items.AddRange(new object[] {
            "取整",
            "保留角",
            "保留分"});
            this.cboRoundingType.Location = new System.Drawing.Point(120, 216);
            this.cboRoundingType.Name = "cboRoundingType";
            this.cboRoundingType.Size = new System.Drawing.Size(88, 20);
            this.cboRoundingType.TabIndex = 11;
            // 
            // lblRoundingType
            // 
            this.lblRoundingType.ForeColor = System.Drawing.Color.Gray;
            this.lblRoundingType.Location = new System.Drawing.Point(24, 216);
            this.lblRoundingType.Name = "lblRoundingType";
            this.lblRoundingType.Size = new System.Drawing.Size(88, 23);
            this.lblRoundingType.TabIndex = 10;
            this.lblRoundingType.Text = "舍入模式：";
            this.lblRoundingType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountsNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 417);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnDetectCPH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountsNewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建账单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountsNewForm_FormClosing);
            this.Shown += new System.EventHandler(this.AccountsNewForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabOption.ResumeLayout(false);
            this.tabOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Button btnDetectCPH;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker maxDate;
        private System.Windows.Forms.Label lblAccountEndDate;
        private System.Windows.Forms.DateTimePicker minDate;
        private System.Windows.Forms.Label lblAccountStartDate;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabOption;
        private System.Windows.Forms.Label lblRoundingType;
        private System.Windows.Forms.ComboBox cboRoundingType;
    }
}