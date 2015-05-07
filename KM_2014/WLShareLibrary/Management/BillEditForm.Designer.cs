namespace WLCommon.Management
{
    partial class BillEditForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.txtUserid = new System.Windows.Forms.Label();
            this.cboP_State = new System.Windows.Forms.ComboBox();
            this.lblP_State = new System.Windows.Forms.Label();
            this.numP_Index = new System.Windows.Forms.NumericUpDown();
            this.lblP_Index = new System.Windows.Forms.Label();
            this.numP_Count = new System.Windows.Forms.NumericUpDown();
            this.lblP_Count = new System.Windows.Forms.Label();
            this.numP_Start = new System.Windows.Forms.NumericUpDown();
            this.lblP_Start = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.btnCheckBillExists = new System.Windows.Forms.LinkLabel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numP_Index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(408, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(320, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
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
            this.tabPage1.Controls.Add(this.cboUser);
            this.tabPage1.Controls.Add(this.txtUserid);
            this.tabPage1.Controls.Add(this.cboP_State);
            this.tabPage1.Controls.Add(this.lblP_State);
            this.tabPage1.Controls.Add(this.numP_Index);
            this.tabPage1.Controls.Add(this.lblP_Index);
            this.tabPage1.Controls.Add(this.numP_Count);
            this.tabPage1.Controls.Add(this.lblP_Count);
            this.tabPage1.Controls.Add(this.numP_Start);
            this.tabPage1.Controls.Add(this.lblP_Start);
            this.tabPage1.Controls.Add(this.lblUserid);
            this.tabPage1.Controls.Add(this.btnCheckBillExists);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboUser
            // 
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "备用",
            "使用",
            "用完"});
            this.cboUser.Location = new System.Drawing.Point(144, 40);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(136, 20);
            this.cboUser.TabIndex = 1;
            this.cboUser.Visible = false;
            // 
            // txtUserid
            // 
            this.txtUserid.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserid.Location = new System.Drawing.Point(144, 40);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(136, 23);
            this.txtUserid.TabIndex = 2;
            this.txtUserid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUserid.Visible = false;
            // 
            // cboP_State
            // 
            this.cboP_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboP_State.FormattingEnabled = true;
            this.cboP_State.Items.AddRange(new object[] {
            "备用",
            "使用",
            "用完"});
            this.cboP_State.Location = new System.Drawing.Point(144, 216);
            this.cboP_State.Name = "cboP_State";
            this.cboP_State.Size = new System.Drawing.Size(136, 20);
            this.cboP_State.TabIndex = 10;
            // 
            // lblP_State
            // 
            this.lblP_State.ForeColor = System.Drawing.Color.Gray;
            this.lblP_State.Location = new System.Drawing.Point(40, 216);
            this.lblP_State.Name = "lblP_State";
            this.lblP_State.Size = new System.Drawing.Size(100, 23);
            this.lblP_State.TabIndex = 9;
            this.lblP_State.Text = "票据状态：";
            this.lblP_State.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numP_Index
            // 
            this.numP_Index.Location = new System.Drawing.Point(144, 168);
            this.numP_Index.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numP_Index.Name = "numP_Index";
            this.numP_Index.Size = new System.Drawing.Size(136, 21);
            this.numP_Index.TabIndex = 8;
            // 
            // lblP_Index
            // 
            this.lblP_Index.ForeColor = System.Drawing.Color.Gray;
            this.lblP_Index.Location = new System.Drawing.Point(40, 168);
            this.lblP_Index.Name = "lblP_Index";
            this.lblP_Index.Size = new System.Drawing.Size(100, 23);
            this.lblP_Index.TabIndex = 7;
            this.lblP_Index.Text = "使用计数：";
            this.lblP_Index.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numP_Count
            // 
            this.numP_Count.Location = new System.Drawing.Point(144, 128);
            this.numP_Count.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numP_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numP_Count.Name = "numP_Count";
            this.numP_Count.Size = new System.Drawing.Size(136, 21);
            this.numP_Count.TabIndex = 6;
            this.numP_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblP_Count
            // 
            this.lblP_Count.ForeColor = System.Drawing.Color.Gray;
            this.lblP_Count.Location = new System.Drawing.Point(40, 128);
            this.lblP_Count.Name = "lblP_Count";
            this.lblP_Count.Size = new System.Drawing.Size(100, 23);
            this.lblP_Count.TabIndex = 5;
            this.lblP_Count.Text = "票据总数：";
            this.lblP_Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numP_Start
            // 
            this.numP_Start.Location = new System.Drawing.Point(144, 88);
            this.numP_Start.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numP_Start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numP_Start.Name = "numP_Start";
            this.numP_Start.Size = new System.Drawing.Size(136, 21);
            this.numP_Start.TabIndex = 4;
            this.numP_Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblP_Start
            // 
            this.lblP_Start.ForeColor = System.Drawing.Color.Gray;
            this.lblP_Start.Location = new System.Drawing.Point(40, 88);
            this.lblP_Start.Name = "lblP_Start";
            this.lblP_Start.Size = new System.Drawing.Size(100, 23);
            this.lblP_Start.TabIndex = 3;
            this.lblP_Start.Text = "起始票号：";
            this.lblP_Start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserid
            // 
            this.lblUserid.ForeColor = System.Drawing.Color.Gray;
            this.lblUserid.Location = new System.Drawing.Point(40, 40);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(100, 23);
            this.lblUserid.TabIndex = 0;
            this.lblUserid.Text = "用户工号：";
            this.lblUserid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckBillExists
            // 
            this.btnCheckBillExists.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnCheckBillExists.Location = new System.Drawing.Point(304, 88);
            this.btnCheckBillExists.Name = "btnCheckBillExists";
            this.btnCheckBillExists.Size = new System.Drawing.Size(128, 23);
            this.btnCheckBillExists.TabIndex = 11;
            this.btnCheckBillExists.TabStop = true;
            this.btnCheckBillExists.Text = "检测票据是否存在";
            this.btnCheckBillExists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckBillExists.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCheckBillExists_LinkClicked);
            // 
            // BillEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 417);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillEditForm_FormClosing);
            this.Shown += new System.EventHandler(this.BillEditForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numP_Index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP_Start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label txtUserid;
        private System.Windows.Forms.ComboBox cboP_State;
        private System.Windows.Forms.Label lblP_State;
        private System.Windows.Forms.NumericUpDown numP_Index;
        private System.Windows.Forms.Label lblP_Index;
        private System.Windows.Forms.NumericUpDown numP_Count;
        private System.Windows.Forms.Label lblP_Count;
        private System.Windows.Forms.NumericUpDown numP_Start;
        private System.Windows.Forms.Label lblP_Start;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.LinkLabel btnCheckBillExists;
        private System.Windows.Forms.ComboBox cboUser;
    }
}