namespace WLCommon.Checkout
{
    partial class CheckoutSettingForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.cboNode = new System.Windows.Forms.ComboBox();
            this.lblNode = new System.Windows.Forms.Label();
            this.tabJZ = new System.Windows.Forms.TabPage();
            this.numJZDay = new System.Windows.Forms.NumericUpDown();
            this.lblJZDay = new System.Windows.Forms.Label();
            this.numCSDefValue = new System.Windows.Forms.NumericUpDown();
            this.numJZDefValue = new System.Windows.Forms.NumericUpDown();
            this.lblCSDefValue = new System.Windows.Forms.Label();
            this.lblJZDefValue = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.tabJZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJZDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCSDefValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJZDefValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBase);
            this.tabControl1.Controls.Add(this.tabJZ);
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 320);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.cboNode);
            this.tabBase.Controls.Add(this.lblNode);
            this.tabBase.Location = new System.Drawing.Point(4, 24);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(528, 292);
            this.tabBase.TabIndex = 4;
            this.tabBase.Text = "基础参数";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // cboNode
            // 
            this.cboNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNode.FormattingEnabled = true;
            this.cboNode.Location = new System.Drawing.Point(176, 32);
            this.cboNode.Name = "cboNode";
            this.cboNode.Size = new System.Drawing.Size(304, 20);
            this.cboNode.TabIndex = 1;
            // 
            // lblNode
            // 
            this.lblNode.ForeColor = System.Drawing.Color.Gray;
            this.lblNode.Location = new System.Drawing.Point(32, 32);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(136, 23);
            this.lblNode.TabIndex = 0;
            this.lblNode.Text = "当前网点：";
            this.lblNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabJZ
            // 
            this.tabJZ.Controls.Add(this.numJZDay);
            this.tabJZ.Controls.Add(this.lblJZDay);
            this.tabJZ.Controls.Add(this.numCSDefValue);
            this.tabJZ.Controls.Add(this.numJZDefValue);
            this.tabJZ.Controls.Add(this.lblCSDefValue);
            this.tabJZ.Controls.Add(this.lblJZDefValue);
            this.tabJZ.Location = new System.Drawing.Point(4, 24);
            this.tabJZ.Name = "tabJZ";
            this.tabJZ.Padding = new System.Windows.Forms.Padding(3);
            this.tabJZ.Size = new System.Drawing.Size(528, 292);
            this.tabJZ.TabIndex = 3;
            this.tabJZ.Text = "结账参数";
            this.tabJZ.UseVisualStyleBackColor = true;
            // 
            // numJZDay
            // 
            this.numJZDay.Location = new System.Drawing.Point(176, 32);
            this.numJZDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numJZDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJZDay.Name = "numJZDay";
            this.numJZDay.Size = new System.Drawing.Size(120, 21);
            this.numJZDay.TabIndex = 1;
            this.numJZDay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblJZDay
            // 
            this.lblJZDay.ForeColor = System.Drawing.Color.Gray;
            this.lblJZDay.Location = new System.Drawing.Point(32, 32);
            this.lblJZDay.Name = "lblJZDay";
            this.lblJZDay.Size = new System.Drawing.Size(136, 23);
            this.lblJZDay.TabIndex = 0;
            this.lblJZDay.Text = "月结账日：";
            this.lblJZDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numCSDefValue
            // 
            this.numCSDefValue.DecimalPlaces = 2;
            this.numCSDefValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCSDefValue.Location = new System.Drawing.Point(176, 104);
            this.numCSDefValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCSDefValue.Name = "numCSDefValue";
            this.numCSDefValue.Size = new System.Drawing.Size(120, 21);
            this.numCSDefValue.TabIndex = 5;
            // 
            // numJZDefValue
            // 
            this.numJZDefValue.DecimalPlaces = 2;
            this.numJZDefValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numJZDefValue.Location = new System.Drawing.Point(176, 72);
            this.numJZDefValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numJZDefValue.Name = "numJZDefValue";
            this.numJZDefValue.Size = new System.Drawing.Size(120, 21);
            this.numJZDefValue.TabIndex = 3;
            // 
            // lblCSDefValue
            // 
            this.lblCSDefValue.ForeColor = System.Drawing.Color.Gray;
            this.lblCSDefValue.Location = new System.Drawing.Point(32, 104);
            this.lblCSDefValue.Name = "lblCSDefValue";
            this.lblCSDefValue.Size = new System.Drawing.Size(136, 23);
            this.lblCSDefValue.TabIndex = 4;
            this.lblCSDefValue.Text = "车属信息缺省比例：";
            this.lblCSDefValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJZDefValue
            // 
            this.lblJZDefValue.ForeColor = System.Drawing.Color.Gray;
            this.lblJZDefValue.Location = new System.Drawing.Point(32, 72);
            this.lblJZDefValue.Name = "lblJZDefValue";
            this.lblJZDefValue.Size = new System.Drawing.Size(136, 23);
            this.lblJZDefValue.TabIndex = 2;
            this.lblJZDefValue.Text = "结算代码缺省比例：";
            this.lblJZDefValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(456, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(368, 344);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // CheckoutSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 378);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckoutSettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运行配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckoutSettingForm_FormClosing);
            this.Shown += new System.EventHandler(this.CheckoutSettingForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabJZ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numJZDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCSDefValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJZDefValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabJZ;
        private System.Windows.Forms.NumericUpDown numJZDay;
        private System.Windows.Forms.Label lblJZDay;
        private System.Windows.Forms.NumericUpDown numCSDefValue;
        private System.Windows.Forms.NumericUpDown numJZDefValue;
        private System.Windows.Forms.Label lblCSDefValue;
        private System.Windows.Forms.Label lblJZDefValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.ComboBox cboNode;
        private System.Windows.Forms.Label lblNode;
    }
}