namespace WLCommon.Management
{
    partial class BaseSettingForm
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
            this.tabDTConnection = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.chkBillZeroize = new System.Windows.Forms.CheckBox();
            this.numBillBits = new System.Windows.Forms.NumericUpDown();
            this.lblBillBits = new System.Windows.Forms.Label();
            this.cboNode = new System.Windows.Forms.ComboBox();
            this.lblNode = new System.Windows.Forms.Label();
            this.tabBD = new System.Windows.Forms.TabPage();
            this.chkAutoSelectYF = new System.Windows.Forms.CheckBox();
            this.chkSecurityCheck = new System.Windows.Forms.CheckBox();
            this.chkSyncCentral = new System.Windows.Forms.CheckBox();
            this.chkAllowJZ = new System.Windows.Forms.CheckBox();
            this.chkAllowDF = new System.Windows.Forms.CheckBox();
            this.chkSaveCustomer = new System.Windows.Forms.CheckBox();
            this.chkManualModify = new System.Windows.Forms.CheckBox();
            this.chkHWJSJoinCalc = new System.Windows.Forms.CheckBox();
            this.chkOnlyToday = new System.Windows.Forms.CheckBox();
            this.chkBZF = new System.Windows.Forms.CheckBox();
            this.tabBX = new System.Windows.Forms.TabPage();
            this.chkBXF = new System.Windows.Forms.CheckBox();
            this.lblBXFRatio = new System.Windows.Forms.Label();
            this.numBXFRatio = new System.Windows.Forms.NumericUpDown();
            this.lblBXFMax = new System.Windows.Forms.Label();
            this.numBXFMax = new System.Windows.Forms.NumericUpDown();
            this.numBXFMin = new System.Windows.Forms.NumericUpDown();
            this.chkBXFRound = new System.Windows.Forms.CheckBox();
            this.chkBXFAutoCalc = new System.Windows.Forms.CheckBox();
            this.lblBXFMin = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkGDCheckCPH = new System.Windows.Forms.CheckBox();
            this.tabDTConnection.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBillBits)).BeginInit();
            this.tabBD.SuspendLayout();
            this.tabBX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBXFRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBXFMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBXFMin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDTConnection
            // 
            this.tabDTConnection.Controls.Add(this.tabBase);
            this.tabDTConnection.Controls.Add(this.tabBD);
            this.tabDTConnection.Controls.Add(this.tabBX);
            this.tabDTConnection.ItemSize = new System.Drawing.Size(80, 20);
            this.tabDTConnection.Location = new System.Drawing.Point(8, 8);
            this.tabDTConnection.Name = "tabDTConnection";
            this.tabDTConnection.SelectedIndex = 0;
            this.tabDTConnection.Size = new System.Drawing.Size(536, 312);
            this.tabDTConnection.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDTConnection.TabIndex = 0;
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.chkBillZeroize);
            this.tabBase.Controls.Add(this.numBillBits);
            this.tabBase.Controls.Add(this.lblBillBits);
            this.tabBase.Controls.Add(this.cboNode);
            this.tabBase.Controls.Add(this.lblNode);
            this.tabBase.Location = new System.Drawing.Point(4, 24);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(528, 284);
            this.tabBase.TabIndex = 3;
            this.tabBase.Text = "基础参数";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // chkBillZeroize
            // 
            this.chkBillZeroize.AutoSize = true;
            this.chkBillZeroize.Location = new System.Drawing.Point(136, 144);
            this.chkBillZeroize.Name = "chkBillZeroize";
            this.chkBillZeroize.Size = new System.Drawing.Size(120, 16);
            this.chkBillZeroize.TabIndex = 4;
            this.chkBillZeroize.Text = "自动前置补‘零’";
            this.chkBillZeroize.UseVisualStyleBackColor = true;
            // 
            // numBillBits
            // 
            this.numBillBits.Location = new System.Drawing.Point(136, 96);
            this.numBillBits.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numBillBits.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numBillBits.Name = "numBillBits";
            this.numBillBits.Size = new System.Drawing.Size(112, 21);
            this.numBillBits.TabIndex = 3;
            this.numBillBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBillBits.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblBillBits
            // 
            this.lblBillBits.ForeColor = System.Drawing.Color.Gray;
            this.lblBillBits.Location = new System.Drawing.Point(32, 96);
            this.lblBillBits.Name = "lblBillBits";
            this.lblBillBits.Size = new System.Drawing.Size(96, 24);
            this.lblBillBits.TabIndex = 2;
            this.lblBillBits.Text = "单据位数：";
            this.lblBillBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboNode
            // 
            this.cboNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNode.FormattingEnabled = true;
            this.cboNode.Location = new System.Drawing.Point(136, 40);
            this.cboNode.Name = "cboNode";
            this.cboNode.Size = new System.Drawing.Size(304, 20);
            this.cboNode.TabIndex = 1;
            // 
            // lblNode
            // 
            this.lblNode.ForeColor = System.Drawing.Color.Gray;
            this.lblNode.Location = new System.Drawing.Point(32, 40);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(96, 23);
            this.lblNode.TabIndex = 0;
            this.lblNode.Text = "当前网点：";
            this.lblNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabBD
            // 
            this.tabBD.Controls.Add(this.chkGDCheckCPH);
            this.tabBD.Controls.Add(this.chkAutoSelectYF);
            this.tabBD.Controls.Add(this.chkSecurityCheck);
            this.tabBD.Controls.Add(this.chkSyncCentral);
            this.tabBD.Controls.Add(this.chkAllowJZ);
            this.tabBD.Controls.Add(this.chkAllowDF);
            this.tabBD.Controls.Add(this.chkSaveCustomer);
            this.tabBD.Controls.Add(this.chkManualModify);
            this.tabBD.Controls.Add(this.chkHWJSJoinCalc);
            this.tabBD.Controls.Add(this.chkOnlyToday);
            this.tabBD.Controls.Add(this.chkBZF);
            this.tabBD.Location = new System.Drawing.Point(4, 24);
            this.tabBD.Name = "tabBD";
            this.tabBD.Padding = new System.Windows.Forms.Padding(3);
            this.tabBD.Size = new System.Drawing.Size(528, 284);
            this.tabBD.TabIndex = 0;
            this.tabBD.Text = "办单参数";
            this.tabBD.UseVisualStyleBackColor = true;
            // 
            // chkAutoSelectYF
            // 
            this.chkAutoSelectYF.AutoSize = true;
            this.chkAutoSelectYF.Location = new System.Drawing.Point(48, 176);
            this.chkAutoSelectYF.Name = "chkAutoSelectYF";
            this.chkAutoSelectYF.Size = new System.Drawing.Size(120, 16);
            this.chkAutoSelectYF.TabIndex = 6;
            this.chkAutoSelectYF.Text = "允许手动修改运费";
            this.chkAutoSelectYF.UseVisualStyleBackColor = true;
            // 
            // chkSecurityCheck
            // 
            this.chkSecurityCheck.Location = new System.Drawing.Point(48, 24);
            this.chkSecurityCheck.Name = "chkSecurityCheck";
            this.chkSecurityCheck.Size = new System.Drawing.Size(208, 24);
            this.chkSecurityCheck.TabIndex = 0;
            this.chkSecurityCheck.Text = "办单之前必须开箱安全检查";
            this.chkSecurityCheck.UseVisualStyleBackColor = true;
            // 
            // chkSyncCentral
            // 
            this.chkSyncCentral.Location = new System.Drawing.Point(48, 56);
            this.chkSyncCentral.Name = "chkSyncCentral";
            this.chkSyncCentral.Size = new System.Drawing.Size(208, 24);
            this.chkSyncCentral.TabIndex = 1;
            this.chkSyncCentral.Text = "同步办单数据到中央服务器";
            this.chkSyncCentral.UseVisualStyleBackColor = true;
            // 
            // chkAllowJZ
            // 
            this.chkAllowJZ.AutoSize = true;
            this.chkAllowJZ.Location = new System.Drawing.Point(416, 232);
            this.chkAllowJZ.Name = "chkAllowJZ";
            this.chkAllowJZ.Size = new System.Drawing.Size(72, 16);
            this.chkAllowJZ.TabIndex = 10;
            this.chkAllowJZ.Text = "允许记账";
            this.chkAllowJZ.UseVisualStyleBackColor = true;
            this.chkAllowJZ.Visible = false;
            // 
            // chkAllowDF
            // 
            this.chkAllowDF.AutoSize = true;
            this.chkAllowDF.Location = new System.Drawing.Point(232, 232);
            this.chkAllowDF.Name = "chkAllowDF";
            this.chkAllowDF.Size = new System.Drawing.Size(72, 16);
            this.chkAllowDF.TabIndex = 9;
            this.chkAllowDF.Text = "允许到付";
            this.chkAllowDF.UseVisualStyleBackColor = true;
            // 
            // chkSaveCustomer
            // 
            this.chkSaveCustomer.AutoSize = true;
            this.chkSaveCustomer.Location = new System.Drawing.Point(232, 112);
            this.chkSaveCustomer.Name = "chkSaveCustomer";
            this.chkSaveCustomer.Size = new System.Drawing.Size(120, 16);
            this.chkSaveCustomer.TabIndex = 3;
            this.chkSaveCustomer.Text = "自动保存客户信息";
            this.chkSaveCustomer.UseVisualStyleBackColor = true;
            // 
            // chkManualModify
            // 
            this.chkManualModify.AutoSize = true;
            this.chkManualModify.Location = new System.Drawing.Point(48, 144);
            this.chkManualModify.Name = "chkManualModify";
            this.chkManualModify.Size = new System.Drawing.Size(120, 16);
            this.chkManualModify.TabIndex = 4;
            this.chkManualModify.Text = "允许手动修改运费";
            this.chkManualModify.UseVisualStyleBackColor = true;
            // 
            // chkHWJSJoinCalc
            // 
            this.chkHWJSJoinCalc.AutoSize = true;
            this.chkHWJSJoinCalc.Location = new System.Drawing.Point(48, 112);
            this.chkHWJSJoinCalc.Name = "chkHWJSJoinCalc";
            this.chkHWJSJoinCalc.Size = new System.Drawing.Size(120, 16);
            this.chkHWJSJoinCalc.TabIndex = 2;
            this.chkHWJSJoinCalc.Text = "货物件数参与计算";
            this.chkHWJSJoinCalc.UseVisualStyleBackColor = true;
            // 
            // chkOnlyToday
            // 
            this.chkOnlyToday.AutoSize = true;
            this.chkOnlyToday.Location = new System.Drawing.Point(232, 144);
            this.chkOnlyToday.Name = "chkOnlyToday";
            this.chkOnlyToday.Size = new System.Drawing.Size(120, 16);
            this.chkOnlyToday.TabIndex = 5;
            this.chkOnlyToday.Text = "仅能办理当日业务";
            this.chkOnlyToday.UseVisualStyleBackColor = true;
            // 
            // chkBZF
            // 
            this.chkBZF.AutoSize = true;
            this.chkBZF.Location = new System.Drawing.Point(48, 232);
            this.chkBZF.Name = "chkBZF";
            this.chkBZF.Size = new System.Drawing.Size(84, 16);
            this.chkBZF.TabIndex = 8;
            this.chkBZF.Text = "收取包装费";
            this.chkBZF.UseVisualStyleBackColor = true;
            // 
            // tabBX
            // 
            this.tabBX.Controls.Add(this.chkBXF);
            this.tabBX.Controls.Add(this.lblBXFRatio);
            this.tabBX.Controls.Add(this.numBXFRatio);
            this.tabBX.Controls.Add(this.lblBXFMax);
            this.tabBX.Controls.Add(this.numBXFMax);
            this.tabBX.Controls.Add(this.numBXFMin);
            this.tabBX.Controls.Add(this.chkBXFRound);
            this.tabBX.Controls.Add(this.chkBXFAutoCalc);
            this.tabBX.Controls.Add(this.lblBXFMin);
            this.tabBX.Location = new System.Drawing.Point(4, 24);
            this.tabBX.Name = "tabBX";
            this.tabBX.Padding = new System.Windows.Forms.Padding(3);
            this.tabBX.Size = new System.Drawing.Size(528, 284);
            this.tabBX.TabIndex = 1;
            this.tabBX.Text = "保险参数";
            this.tabBX.UseVisualStyleBackColor = true;
            // 
            // chkBXF
            // 
            this.chkBXF.AutoSize = true;
            this.chkBXF.Location = new System.Drawing.Point(64, 32);
            this.chkBXF.Name = "chkBXF";
            this.chkBXF.Size = new System.Drawing.Size(84, 16);
            this.chkBXF.TabIndex = 0;
            this.chkBXF.Text = "收取保险费";
            this.chkBXF.UseVisualStyleBackColor = true;
            // 
            // lblBXFRatio
            // 
            this.lblBXFRatio.ForeColor = System.Drawing.Color.Gray;
            this.lblBXFRatio.Location = new System.Drawing.Point(32, 224);
            this.lblBXFRatio.Name = "lblBXFRatio";
            this.lblBXFRatio.Size = new System.Drawing.Size(128, 24);
            this.lblBXFRatio.TabIndex = 7;
            this.lblBXFRatio.Text = "保险费计算比率：";
            this.lblBXFRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBXFRatio
            // 
            this.numBXFRatio.DecimalPlaces = 3;
            this.numBXFRatio.Location = new System.Drawing.Point(168, 224);
            this.numBXFRatio.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBXFRatio.Name = "numBXFRatio";
            this.numBXFRatio.Size = new System.Drawing.Size(112, 21);
            this.numBXFRatio.TabIndex = 8;
            this.numBXFRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBXFRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // lblBXFMax
            // 
            this.lblBXFMax.ForeColor = System.Drawing.Color.Gray;
            this.lblBXFMax.Location = new System.Drawing.Point(32, 184);
            this.lblBXFMax.Name = "lblBXFMax";
            this.lblBXFMax.Size = new System.Drawing.Size(128, 24);
            this.lblBXFMax.TabIndex = 5;
            this.lblBXFMax.Text = "最大保险费：";
            this.lblBXFMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBXFMax
            // 
            this.numBXFMax.DecimalPlaces = 2;
            this.numBXFMax.Location = new System.Drawing.Point(168, 184);
            this.numBXFMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBXFMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBXFMax.Name = "numBXFMax";
            this.numBXFMax.Size = new System.Drawing.Size(112, 21);
            this.numBXFMax.TabIndex = 6;
            this.numBXFMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBXFMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numBXFMin
            // 
            this.numBXFMin.DecimalPlaces = 2;
            this.numBXFMin.Location = new System.Drawing.Point(168, 144);
            this.numBXFMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBXFMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBXFMin.Name = "numBXFMin";
            this.numBXFMin.Size = new System.Drawing.Size(112, 21);
            this.numBXFMin.TabIndex = 4;
            this.numBXFMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBXFMin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // chkBXFRound
            // 
            this.chkBXFRound.AutoSize = true;
            this.chkBXFRound.Location = new System.Drawing.Point(64, 96);
            this.chkBXFRound.Name = "chkBXFRound";
            this.chkBXFRound.Size = new System.Drawing.Size(156, 16);
            this.chkBXFRound.TabIndex = 2;
            this.chkBXFRound.Text = "允许计算保险费自动取整";
            this.chkBXFRound.UseVisualStyleBackColor = true;
            // 
            // chkBXFAutoCalc
            // 
            this.chkBXFAutoCalc.AutoSize = true;
            this.chkBXFAutoCalc.Location = new System.Drawing.Point(64, 64);
            this.chkBXFAutoCalc.Name = "chkBXFAutoCalc";
            this.chkBXFAutoCalc.Size = new System.Drawing.Size(156, 16);
            this.chkBXFAutoCalc.TabIndex = 1;
            this.chkBXFAutoCalc.Text = "允许通过保额计算保险费";
            this.chkBXFAutoCalc.UseVisualStyleBackColor = true;
            // 
            // lblBXFMin
            // 
            this.lblBXFMin.ForeColor = System.Drawing.Color.Gray;
            this.lblBXFMin.Location = new System.Drawing.Point(32, 144);
            this.lblBXFMin.Name = "lblBXFMin";
            this.lblBXFMin.Size = new System.Drawing.Size(128, 24);
            this.lblBXFMin.TabIndex = 3;
            this.lblBXFMin.Text = "最小保险费：";
            this.lblBXFMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(368, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(456, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkGDCheckCPH
            // 
            this.chkGDCheckCPH.AutoSize = true;
            this.chkGDCheckCPH.Location = new System.Drawing.Point(232, 176);
            this.chkGDCheckCPH.Name = "chkGDCheckCPH";
            this.chkGDCheckCPH.Size = new System.Drawing.Size(264, 16);
            this.chkGDCheckCPH.TabIndex = 7;
            this.chkGDCheckCPH.Text = "改单时检测车牌号是否存在于客运站车辆库中";
            this.chkGDCheckCPH.UseVisualStyleBackColor = true;
            // 
            // BaseSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 378);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabDTConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseSettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运行配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseSettingForm_FormClosing);
            this.Shown += new System.EventHandler(this.BaseSettingForm_Shown);
            this.tabDTConnection.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBillBits)).EndInit();
            this.tabBD.ResumeLayout(false);
            this.tabBD.PerformLayout();
            this.tabBX.ResumeLayout(false);
            this.tabBX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBXFRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBXFMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBXFMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDTConnection;
        private System.Windows.Forms.TabPage tabBD;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkOnlyToday;
        private System.Windows.Forms.CheckBox chkBZF;
        private System.Windows.Forms.CheckBox chkSaveCustomer;
        private System.Windows.Forms.CheckBox chkManualModify;
        private System.Windows.Forms.CheckBox chkHWJSJoinCalc;
        private System.Windows.Forms.TabPage tabBX;
        private System.Windows.Forms.Label lblBXFRatio;
        private System.Windows.Forms.NumericUpDown numBXFRatio;
        private System.Windows.Forms.Label lblBXFMax;
        private System.Windows.Forms.NumericUpDown numBXFMax;
        private System.Windows.Forms.NumericUpDown numBXFMin;
        private System.Windows.Forms.CheckBox chkBXFRound;
        private System.Windows.Forms.CheckBox chkBXFAutoCalc;
        private System.Windows.Forms.Label lblBXFMin;
        private System.Windows.Forms.CheckBox chkBXF;
        private System.Windows.Forms.CheckBox chkAllowDF;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.ComboBox cboNode;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.NumericUpDown numBillBits;
        private System.Windows.Forms.Label lblBillBits;
        private System.Windows.Forms.CheckBox chkBillZeroize;
        private System.Windows.Forms.CheckBox chkAllowJZ;
        private System.Windows.Forms.CheckBox chkSecurityCheck;
        private System.Windows.Forms.CheckBox chkSyncCentral;
        private System.Windows.Forms.CheckBox chkAutoSelectYF;
        private System.Windows.Forms.CheckBox chkGDCheckCPH;

    }
}