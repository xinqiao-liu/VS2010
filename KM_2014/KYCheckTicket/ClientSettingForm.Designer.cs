namespace KM.JP
{
    partial class ClientSettingForm
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
            this.m_TabControl = new System.Windows.Forms.TabControl();
            this.m_BaseTab = new System.Windows.Forms.TabPage();
            this.EnableBSY_JPLabel = new System.Windows.Forms.Label();
            this.EnableBSY_JPCheck = new System.Windows.Forms.CheckBox();
            this.AllowReJSCheck = new System.Windows.Forms.CheckBox();
            this.AllowResumeJPCheck = new System.Windows.Forms.CheckBox();
            this.BCAutoRefreshCheck = new System.Windows.Forms.CheckBox();
            this.BCAutoRefreshUnit = new System.Windows.Forms.Label();
            this.BCRefreshTimeNumber = new System.Windows.Forms.NumericUpDown();
            this.BCAutoRefreshLabel = new System.Windows.Forms.Label();
            this.JPWindowCombo = new System.Windows.Forms.ComboBox();
            this.ShowConfirmCheck = new System.Windows.Forms.CheckBox();
            this.AllowWQDBalanceCheck = new System.Windows.Forms.CheckBox();
            this.BalanceAccountCheck = new System.Windows.Forms.CheckBox();
            this.AllowSyncServerTime = new System.Windows.Forms.CheckBox();
            this.BalancePrintCheck = new System.Windows.Forms.CheckBox();
            this.AllowNullBalanceCheck = new System.Windows.Forms.CheckBox();
            this.EnableSoundCheck = new System.Windows.Forms.CheckBox();
            this.UseCardLoginCheck = new System.Windows.Forms.CheckBox();
            this.ShowHintCheck = new System.Windows.Forms.CheckBox();
            this.ShowHintTimeUnit = new System.Windows.Forms.Label();
            this.ShowHintTimeNumber = new System.Windows.Forms.NumericUpDown();
            this.ShowHintTimeLabel = new System.Windows.Forms.Label();
            this.JPWindowLabel = new System.Windows.Forms.Label();
            this.m_PrintTab = new System.Windows.Forms.TabPage();
            this.MarginRightNumber = new System.Windows.Forms.NumericUpDown();
            this.MarginLeftNumber = new System.Windows.Forms.NumericUpDown();
            this.MarginRightLabel = new System.Windows.Forms.Label();
            this.MarginLeftLabel = new System.Windows.Forms.Label();
            this.MarginBottomNumber = new System.Windows.Forms.NumericUpDown();
            this.MarginTopNumber = new System.Windows.Forms.NumericUpDown();
            this.PageHeightNumber = new System.Windows.Forms.NumericUpDown();
            this.MarginBottomLabel = new System.Windows.Forms.Label();
            this.MarginTopLabel = new System.Windows.Forms.Label();
            this.PageHeightLabel = new System.Windows.Forms.Label();
            this.PageWidthLabel = new System.Windows.Forms.Label();
            this.PageWidthNumber = new System.Windows.Forms.NumericUpDown();
            this.PrintCopiesNumber = new System.Windows.Forms.NumericUpDown();
            this.PrintCopiesLabel = new System.Windows.Forms.Label();
            this.PrinterNameCombo = new System.Windows.Forms.ComboBox();
            this.PrinterNameLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.PrintDLFCheck = new System.Windows.Forms.CheckBox();
            this.m_TabControl.SuspendLayout();
            this.m_BaseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BCRefreshTimeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHintTimeNumber)).BeginInit();
            this.m_PrintTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarginRightNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginLeftNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginBottomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginTopNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageHeightNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageWidthNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintCopiesNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // m_TabControl
            // 
            this.m_TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TabControl.Controls.Add(this.m_BaseTab);
            this.m_TabControl.Controls.Add(this.m_PrintTab);
            this.m_TabControl.ItemSize = new System.Drawing.Size(90, 24);
            this.m_TabControl.Location = new System.Drawing.Point(19, 19);
            this.m_TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.m_TabControl.Name = "m_TabControl";
            this.m_TabControl.SelectedIndex = 0;
            this.m_TabControl.Size = new System.Drawing.Size(588, 509);
            this.m_TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.m_TabControl.TabIndex = 0;
            // 
            // m_BaseTab
            // 
            this.m_BaseTab.Controls.Add(this.PrintDLFCheck);
            this.m_BaseTab.Controls.Add(this.EnableBSY_JPLabel);
            this.m_BaseTab.Controls.Add(this.EnableBSY_JPCheck);
            this.m_BaseTab.Controls.Add(this.AllowReJSCheck);
            this.m_BaseTab.Controls.Add(this.AllowResumeJPCheck);
            this.m_BaseTab.Controls.Add(this.BCAutoRefreshCheck);
            this.m_BaseTab.Controls.Add(this.BCAutoRefreshUnit);
            this.m_BaseTab.Controls.Add(this.BCRefreshTimeNumber);
            this.m_BaseTab.Controls.Add(this.BCAutoRefreshLabel);
            this.m_BaseTab.Controls.Add(this.JPWindowCombo);
            this.m_BaseTab.Controls.Add(this.ShowConfirmCheck);
            this.m_BaseTab.Controls.Add(this.AllowWQDBalanceCheck);
            this.m_BaseTab.Controls.Add(this.BalanceAccountCheck);
            this.m_BaseTab.Controls.Add(this.AllowSyncServerTime);
            this.m_BaseTab.Controls.Add(this.BalancePrintCheck);
            this.m_BaseTab.Controls.Add(this.AllowNullBalanceCheck);
            this.m_BaseTab.Controls.Add(this.EnableSoundCheck);
            this.m_BaseTab.Controls.Add(this.UseCardLoginCheck);
            this.m_BaseTab.Controls.Add(this.ShowHintCheck);
            this.m_BaseTab.Controls.Add(this.ShowHintTimeUnit);
            this.m_BaseTab.Controls.Add(this.ShowHintTimeNumber);
            this.m_BaseTab.Controls.Add(this.ShowHintTimeLabel);
            this.m_BaseTab.Controls.Add(this.JPWindowLabel);
            this.m_BaseTab.Location = new System.Drawing.Point(4, 28);
            this.m_BaseTab.Margin = new System.Windows.Forms.Padding(2);
            this.m_BaseTab.Name = "m_BaseTab";
            this.m_BaseTab.Padding = new System.Windows.Forms.Padding(2);
            this.m_BaseTab.Size = new System.Drawing.Size(580, 477);
            this.m_BaseTab.TabIndex = 0;
            this.m_BaseTab.Text = "基础";
            this.m_BaseTab.UseVisualStyleBackColor = true;
            // 
            // EnableBSY_JPLabel
            // 
            this.EnableBSY_JPLabel.ForeColor = System.Drawing.Color.Red;
            this.EnableBSY_JPLabel.Location = new System.Drawing.Point(69, 412);
            this.EnableBSY_JPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnableBSY_JPLabel.Name = "EnableBSY_JPLabel";
            this.EnableBSY_JPLabel.Size = new System.Drawing.Size(475, 24);
            this.EnableBSY_JPLabel.TabIndex = 21;
            this.EnableBSY_JPLabel.Text = "开启/关闭本售异检票功能，须重启检票程序。如开启本站检票将不可用！";
            this.EnableBSY_JPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnableBSY_JPCheck
            // 
            this.EnableBSY_JPCheck.AutoSize = true;
            this.EnableBSY_JPCheck.Location = new System.Drawing.Point(72, 392);
            this.EnableBSY_JPCheck.Margin = new System.Windows.Forms.Padding(2);
            this.EnableBSY_JPCheck.Name = "EnableBSY_JPCheck";
            this.EnableBSY_JPCheck.Size = new System.Drawing.Size(124, 18);
            this.EnableBSY_JPCheck.TabIndex = 20;
            this.EnableBSY_JPCheck.Text = "开启本售异检票";
            this.EnableBSY_JPCheck.UseVisualStyleBackColor = true;
            // 
            // AllowReJSCheck
            // 
            this.AllowReJSCheck.AutoSize = true;
            this.AllowReJSCheck.Location = new System.Drawing.Point(304, 336);
            this.AllowReJSCheck.Margin = new System.Windows.Forms.Padding(2);
            this.AllowReJSCheck.Name = "AllowReJSCheck";
            this.AllowReJSCheck.Size = new System.Drawing.Size(138, 18);
            this.AllowReJSCheck.TabIndex = 19;
            this.AllowReJSCheck.Text = "允许使用重新结算";
            this.AllowReJSCheck.UseVisualStyleBackColor = true;
            // 
            // AllowResumeJPCheck
            // 
            this.AllowResumeJPCheck.AutoSize = true;
            this.AllowResumeJPCheck.Location = new System.Drawing.Point(72, 336);
            this.AllowResumeJPCheck.Margin = new System.Windows.Forms.Padding(2);
            this.AllowResumeJPCheck.Name = "AllowResumeJPCheck";
            this.AllowResumeJPCheck.Size = new System.Drawing.Size(138, 18);
            this.AllowResumeJPCheck.TabIndex = 18;
            this.AllowResumeJPCheck.Text = "允许使用恢复检票";
            this.AllowResumeJPCheck.UseVisualStyleBackColor = true;
            // 
            // BCAutoRefreshCheck
            // 
            this.BCAutoRefreshCheck.Location = new System.Drawing.Point(72, 120);
            this.BCAutoRefreshCheck.Margin = new System.Windows.Forms.Padding(2);
            this.BCAutoRefreshCheck.Name = "BCAutoRefreshCheck";
            this.BCAutoRefreshCheck.Size = new System.Drawing.Size(200, 24);
            this.BCAutoRefreshCheck.TabIndex = 6;
            this.BCAutoRefreshCheck.Text = "班次自动刷新";
            this.BCAutoRefreshCheck.UseVisualStyleBackColor = true;
            this.BCAutoRefreshCheck.CheckedChanged += new System.EventHandler(this.BCAutoRefreshCheck_CheckedChanged);
            // 
            // BCAutoRefreshUnit
            // 
            this.BCAutoRefreshUnit.Location = new System.Drawing.Point(496, 120);
            this.BCAutoRefreshUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BCAutoRefreshUnit.Name = "BCAutoRefreshUnit";
            this.BCAutoRefreshUnit.Size = new System.Drawing.Size(48, 24);
            this.BCAutoRefreshUnit.TabIndex = 9;
            this.BCAutoRefreshUnit.Text = "秒";
            this.BCAutoRefreshUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BCRefreshTimeNumber
            // 
            this.BCRefreshTimeNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BCRefreshTimeNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BCRefreshTimeNumber.Location = new System.Drawing.Point(408, 120);
            this.BCRefreshTimeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.BCRefreshTimeNumber.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.BCRefreshTimeNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BCRefreshTimeNumber.Name = "BCRefreshTimeNumber";
            this.BCRefreshTimeNumber.Size = new System.Drawing.Size(79, 23);
            this.BCRefreshTimeNumber.TabIndex = 8;
            this.BCRefreshTimeNumber.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // BCAutoRefreshLabel
            // 
            this.BCAutoRefreshLabel.Location = new System.Drawing.Point(280, 120);
            this.BCAutoRefreshLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BCAutoRefreshLabel.Name = "BCAutoRefreshLabel";
            this.BCAutoRefreshLabel.Size = new System.Drawing.Size(128, 24);
            this.BCAutoRefreshLabel.TabIndex = 7;
            this.BCAutoRefreshLabel.Text = "刷新间隔时间：";
            this.BCAutoRefreshLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // JPWindowCombo
            // 
            this.JPWindowCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.JPWindowCombo.DropDownHeight = 200;
            this.JPWindowCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JPWindowCombo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JPWindowCombo.FormattingEnabled = true;
            this.JPWindowCombo.IntegralHeight = false;
            this.JPWindowCombo.ItemHeight = 28;
            this.JPWindowCombo.Items.AddRange(new object[] {
            "全部",
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
            this.JPWindowCombo.Location = new System.Drawing.Point(160, 24);
            this.JPWindowCombo.Margin = new System.Windows.Forms.Padding(2);
            this.JPWindowCombo.MaxDropDownItems = 14;
            this.JPWindowCombo.Name = "JPWindowCombo";
            this.JPWindowCombo.Size = new System.Drawing.Size(137, 34);
            this.JPWindowCombo.TabIndex = 1;
            this.JPWindowCombo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.JPWindowCombo_DrawItem);
            // 
            // ShowConfirmCheck
            // 
            this.ShowConfirmCheck.AutoSize = true;
            this.ShowConfirmCheck.Location = new System.Drawing.Point(304, 256);
            this.ShowConfirmCheck.Margin = new System.Windows.Forms.Padding(2);
            this.ShowConfirmCheck.Name = "ShowConfirmCheck";
            this.ShowConfirmCheck.Size = new System.Drawing.Size(110, 18);
            this.ShowConfirmCheck.TabIndex = 17;
            this.ShowConfirmCheck.Text = "显示确认信息";
            this.ShowConfirmCheck.UseVisualStyleBackColor = true;
            // 
            // AllowWQDBalanceCheck
            // 
            this.AllowWQDBalanceCheck.AutoSize = true;
            this.AllowWQDBalanceCheck.Location = new System.Drawing.Point(72, 216);
            this.AllowWQDBalanceCheck.Margin = new System.Windows.Forms.Padding(2);
            this.AllowWQDBalanceCheck.Name = "AllowWQDBalanceCheck";
            this.AllowWQDBalanceCheck.Size = new System.Drawing.Size(124, 18);
            this.AllowWQDBalanceCheck.TabIndex = 12;
            this.AllowWQDBalanceCheck.Text = "允许未签到结算";
            this.AllowWQDBalanceCheck.UseVisualStyleBackColor = true;
            // 
            // BalanceAccountCheck
            // 
            this.BalanceAccountCheck.AutoSize = true;
            this.BalanceAccountCheck.Location = new System.Drawing.Point(72, 296);
            this.BalanceAccountCheck.Margin = new System.Windows.Forms.Padding(2);
            this.BalanceAccountCheck.Name = "BalanceAccountCheck";
            this.BalanceAccountCheck.Size = new System.Drawing.Size(124, 18);
            this.BalanceAccountCheck.TabIndex = 16;
            this.BalanceAccountCheck.Text = "结算计算代理费";
            this.BalanceAccountCheck.UseVisualStyleBackColor = true;
            // 
            // AllowSyncServerTime
            // 
            this.AllowSyncServerTime.AutoSize = true;
            this.AllowSyncServerTime.Location = new System.Drawing.Point(304, 384);
            this.AllowSyncServerTime.Margin = new System.Windows.Forms.Padding(2);
            this.AllowSyncServerTime.Name = "AllowSyncServerTime";
            this.AllowSyncServerTime.Size = new System.Drawing.Size(124, 18);
            this.AllowSyncServerTime.TabIndex = 15;
            this.AllowSyncServerTime.Text = "同步服务器时间";
            this.AllowSyncServerTime.UseVisualStyleBackColor = true;
            this.AllowSyncServerTime.Visible = false;
            // 
            // BalancePrintCheck
            // 
            this.BalancePrintCheck.AutoSize = true;
            this.BalancePrintCheck.Location = new System.Drawing.Point(72, 256);
            this.BalancePrintCheck.Margin = new System.Windows.Forms.Padding(2);
            this.BalancePrintCheck.Name = "BalancePrintCheck";
            this.BalancePrintCheck.Size = new System.Drawing.Size(124, 18);
            this.BalancePrintCheck.TabIndex = 14;
            this.BalancePrintCheck.Text = "结算时打印单据";
            this.BalancePrintCheck.UseVisualStyleBackColor = true;
            // 
            // AllowNullBalanceCheck
            // 
            this.AllowNullBalanceCheck.AutoSize = true;
            this.AllowNullBalanceCheck.Location = new System.Drawing.Point(72, 176);
            this.AllowNullBalanceCheck.Margin = new System.Windows.Forms.Padding(2);
            this.AllowNullBalanceCheck.Name = "AllowNullBalanceCheck";
            this.AllowNullBalanceCheck.Size = new System.Drawing.Size(124, 18);
            this.AllowNullBalanceCheck.TabIndex = 10;
            this.AllowNullBalanceCheck.Text = "允许零客票结算";
            this.AllowNullBalanceCheck.UseVisualStyleBackColor = true;
            // 
            // EnableSoundCheck
            // 
            this.EnableSoundCheck.AutoSize = true;
            this.EnableSoundCheck.Location = new System.Drawing.Point(304, 216);
            this.EnableSoundCheck.Margin = new System.Windows.Forms.Padding(2);
            this.EnableSoundCheck.Name = "EnableSoundCheck";
            this.EnableSoundCheck.Size = new System.Drawing.Size(110, 18);
            this.EnableSoundCheck.TabIndex = 13;
            this.EnableSoundCheck.Text = "开启声音提示";
            this.EnableSoundCheck.UseVisualStyleBackColor = true;
            // 
            // UseCardLoginCheck
            // 
            this.UseCardLoginCheck.AutoSize = true;
            this.UseCardLoginCheck.Location = new System.Drawing.Point(304, 176);
            this.UseCardLoginCheck.Margin = new System.Windows.Forms.Padding(2);
            this.UseCardLoginCheck.Name = "UseCardLoginCheck";
            this.UseCardLoginCheck.Size = new System.Drawing.Size(110, 18);
            this.UseCardLoginCheck.TabIndex = 11;
            this.UseCardLoginCheck.Text = "使用ID卡登录";
            this.UseCardLoginCheck.UseVisualStyleBackColor = true;
            // 
            // ShowHintCheck
            // 
            this.ShowHintCheck.Location = new System.Drawing.Point(72, 80);
            this.ShowHintCheck.Margin = new System.Windows.Forms.Padding(2);
            this.ShowHintCheck.Name = "ShowHintCheck";
            this.ShowHintCheck.Size = new System.Drawing.Size(200, 24);
            this.ShowHintCheck.TabIndex = 2;
            this.ShowHintCheck.Text = "显示提示信息";
            this.ShowHintCheck.UseVisualStyleBackColor = true;
            this.ShowHintCheck.CheckedChanged += new System.EventHandler(this.ShowHintCheck_CheckedChanged);
            // 
            // ShowHintTimeUnit
            // 
            this.ShowHintTimeUnit.Location = new System.Drawing.Point(496, 80);
            this.ShowHintTimeUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowHintTimeUnit.Name = "ShowHintTimeUnit";
            this.ShowHintTimeUnit.Size = new System.Drawing.Size(48, 24);
            this.ShowHintTimeUnit.TabIndex = 5;
            this.ShowHintTimeUnit.Text = "秒";
            this.ShowHintTimeUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowHintTimeNumber
            // 
            this.ShowHintTimeNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowHintTimeNumber.Location = new System.Drawing.Point(408, 80);
            this.ShowHintTimeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.ShowHintTimeNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ShowHintTimeNumber.Name = "ShowHintTimeNumber";
            this.ShowHintTimeNumber.Size = new System.Drawing.Size(79, 23);
            this.ShowHintTimeNumber.TabIndex = 4;
            // 
            // ShowHintTimeLabel
            // 
            this.ShowHintTimeLabel.Location = new System.Drawing.Point(280, 80);
            this.ShowHintTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowHintTimeLabel.Name = "ShowHintTimeLabel";
            this.ShowHintTimeLabel.Size = new System.Drawing.Size(128, 24);
            this.ShowHintTimeLabel.TabIndex = 3;
            this.ShowHintTimeLabel.Text = "显示提示时间：";
            this.ShowHintTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // JPWindowLabel
            // 
            this.JPWindowLabel.ForeColor = System.Drawing.Color.Gray;
            this.JPWindowLabel.Location = new System.Drawing.Point(24, 24);
            this.JPWindowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JPWindowLabel.Name = "JPWindowLabel";
            this.JPWindowLabel.Size = new System.Drawing.Size(136, 24);
            this.JPWindowLabel.TabIndex = 0;
            this.JPWindowLabel.Text = "选择检票口：";
            this.JPWindowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_PrintTab
            // 
            this.m_PrintTab.Controls.Add(this.MarginRightNumber);
            this.m_PrintTab.Controls.Add(this.MarginLeftNumber);
            this.m_PrintTab.Controls.Add(this.MarginRightLabel);
            this.m_PrintTab.Controls.Add(this.MarginLeftLabel);
            this.m_PrintTab.Controls.Add(this.MarginBottomNumber);
            this.m_PrintTab.Controls.Add(this.MarginTopNumber);
            this.m_PrintTab.Controls.Add(this.PageHeightNumber);
            this.m_PrintTab.Controls.Add(this.MarginBottomLabel);
            this.m_PrintTab.Controls.Add(this.MarginTopLabel);
            this.m_PrintTab.Controls.Add(this.PageHeightLabel);
            this.m_PrintTab.Controls.Add(this.PageWidthLabel);
            this.m_PrintTab.Controls.Add(this.PageWidthNumber);
            this.m_PrintTab.Controls.Add(this.PrintCopiesNumber);
            this.m_PrintTab.Controls.Add(this.PrintCopiesLabel);
            this.m_PrintTab.Controls.Add(this.PrinterNameCombo);
            this.m_PrintTab.Controls.Add(this.PrinterNameLabel);
            this.m_PrintTab.Location = new System.Drawing.Point(4, 28);
            this.m_PrintTab.Margin = new System.Windows.Forms.Padding(2);
            this.m_PrintTab.Name = "m_PrintTab";
            this.m_PrintTab.Padding = new System.Windows.Forms.Padding(2);
            this.m_PrintTab.Size = new System.Drawing.Size(580, 477);
            this.m_PrintTab.TabIndex = 1;
            this.m_PrintTab.Text = "打印";
            this.m_PrintTab.UseVisualStyleBackColor = true;
            // 
            // MarginRightNumber
            // 
            this.MarginRightNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MarginRightNumber.Location = new System.Drawing.Point(400, 248);
            this.MarginRightNumber.Margin = new System.Windows.Forms.Padding(2);
            this.MarginRightNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MarginRightNumber.Name = "MarginRightNumber";
            this.MarginRightNumber.Size = new System.Drawing.Size(96, 23);
            this.MarginRightNumber.TabIndex = 15;
            this.MarginRightNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MarginLeftNumber
            // 
            this.MarginLeftNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MarginLeftNumber.Location = new System.Drawing.Point(160, 247);
            this.MarginLeftNumber.Margin = new System.Windows.Forms.Padding(2);
            this.MarginLeftNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MarginLeftNumber.Name = "MarginLeftNumber";
            this.MarginLeftNumber.Size = new System.Drawing.Size(96, 23);
            this.MarginLeftNumber.TabIndex = 13;
            this.MarginLeftNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MarginRightLabel
            // 
            this.MarginRightLabel.ForeColor = System.Drawing.Color.Gray;
            this.MarginRightLabel.Location = new System.Drawing.Point(263, 247);
            this.MarginRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MarginRightLabel.Name = "MarginRightLabel";
            this.MarginRightLabel.Size = new System.Drawing.Size(136, 23);
            this.MarginRightLabel.TabIndex = 14;
            this.MarginRightLabel.Text = "右边距：";
            this.MarginRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarginLeftLabel
            // 
            this.MarginLeftLabel.ForeColor = System.Drawing.Color.Gray;
            this.MarginLeftLabel.Location = new System.Drawing.Point(20, 247);
            this.MarginLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MarginLeftLabel.Name = "MarginLeftLabel";
            this.MarginLeftLabel.Size = new System.Drawing.Size(136, 23);
            this.MarginLeftLabel.TabIndex = 12;
            this.MarginLeftLabel.Text = "左边距：";
            this.MarginLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarginBottomNumber
            // 
            this.MarginBottomNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MarginBottomNumber.Location = new System.Drawing.Point(400, 201);
            this.MarginBottomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.MarginBottomNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MarginBottomNumber.Name = "MarginBottomNumber";
            this.MarginBottomNumber.Size = new System.Drawing.Size(96, 23);
            this.MarginBottomNumber.TabIndex = 11;
            this.MarginBottomNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MarginTopNumber
            // 
            this.MarginTopNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MarginTopNumber.Location = new System.Drawing.Point(160, 200);
            this.MarginTopNumber.Margin = new System.Windows.Forms.Padding(2);
            this.MarginTopNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MarginTopNumber.Name = "MarginTopNumber";
            this.MarginTopNumber.Size = new System.Drawing.Size(96, 23);
            this.MarginTopNumber.TabIndex = 9;
            this.MarginTopNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PageHeightNumber
            // 
            this.PageHeightNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageHeightNumber.Location = new System.Drawing.Point(400, 137);
            this.PageHeightNumber.Margin = new System.Windows.Forms.Padding(2);
            this.PageHeightNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PageHeightNumber.Name = "PageHeightNumber";
            this.PageHeightNumber.Size = new System.Drawing.Size(96, 23);
            this.PageHeightNumber.TabIndex = 7;
            this.PageHeightNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MarginBottomLabel
            // 
            this.MarginBottomLabel.ForeColor = System.Drawing.Color.Gray;
            this.MarginBottomLabel.Location = new System.Drawing.Point(263, 200);
            this.MarginBottomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MarginBottomLabel.Name = "MarginBottomLabel";
            this.MarginBottomLabel.Size = new System.Drawing.Size(136, 22);
            this.MarginBottomLabel.TabIndex = 10;
            this.MarginBottomLabel.Text = "下边距：";
            this.MarginBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarginTopLabel
            // 
            this.MarginTopLabel.ForeColor = System.Drawing.Color.Gray;
            this.MarginTopLabel.Location = new System.Drawing.Point(20, 200);
            this.MarginTopLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MarginTopLabel.Name = "MarginTopLabel";
            this.MarginTopLabel.Size = new System.Drawing.Size(136, 22);
            this.MarginTopLabel.TabIndex = 8;
            this.MarginTopLabel.Text = "上边距：";
            this.MarginTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PageHeightLabel
            // 
            this.PageHeightLabel.ForeColor = System.Drawing.Color.Gray;
            this.PageHeightLabel.Location = new System.Drawing.Point(264, 136);
            this.PageHeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageHeightLabel.Name = "PageHeightLabel";
            this.PageHeightLabel.Size = new System.Drawing.Size(136, 24);
            this.PageHeightLabel.TabIndex = 6;
            this.PageHeightLabel.Text = "页面高度：";
            this.PageHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PageWidthLabel
            // 
            this.PageWidthLabel.ForeColor = System.Drawing.Color.Gray;
            this.PageWidthLabel.Location = new System.Drawing.Point(16, 136);
            this.PageWidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageWidthLabel.Name = "PageWidthLabel";
            this.PageWidthLabel.Size = new System.Drawing.Size(140, 23);
            this.PageWidthLabel.TabIndex = 4;
            this.PageWidthLabel.Text = "页面宽度：";
            this.PageWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PageWidthNumber
            // 
            this.PageWidthNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageWidthNumber.Location = new System.Drawing.Point(160, 136);
            this.PageWidthNumber.Margin = new System.Windows.Forms.Padding(2);
            this.PageWidthNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PageWidthNumber.Name = "PageWidthNumber";
            this.PageWidthNumber.Size = new System.Drawing.Size(96, 23);
            this.PageWidthNumber.TabIndex = 5;
            this.PageWidthNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PrintCopiesNumber
            // 
            this.PrintCopiesNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PrintCopiesNumber.Location = new System.Drawing.Point(160, 80);
            this.PrintCopiesNumber.Margin = new System.Windows.Forms.Padding(2);
            this.PrintCopiesNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PrintCopiesNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrintCopiesNumber.Name = "PrintCopiesNumber";
            this.PrintCopiesNumber.Size = new System.Drawing.Size(98, 23);
            this.PrintCopiesNumber.TabIndex = 3;
            this.PrintCopiesNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PrintCopiesLabel
            // 
            this.PrintCopiesLabel.ForeColor = System.Drawing.Color.Gray;
            this.PrintCopiesLabel.Location = new System.Drawing.Point(24, 80);
            this.PrintCopiesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrintCopiesLabel.Name = "PrintCopiesLabel";
            this.PrintCopiesLabel.Size = new System.Drawing.Size(136, 24);
            this.PrintCopiesLabel.TabIndex = 2;
            this.PrintCopiesLabel.Text = "结算单份数：";
            this.PrintCopiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PrinterNameCombo
            // 
            this.PrinterNameCombo.DropDownHeight = 200;
            this.PrinterNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrinterNameCombo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PrinterNameCombo.FormattingEnabled = true;
            this.PrinterNameCombo.IntegralHeight = false;
            this.PrinterNameCombo.ItemHeight = 14;
            this.PrinterNameCombo.Location = new System.Drawing.Point(160, 24);
            this.PrinterNameCombo.Margin = new System.Windows.Forms.Padding(2);
            this.PrinterNameCombo.Name = "PrinterNameCombo";
            this.PrinterNameCombo.Size = new System.Drawing.Size(391, 22);
            this.PrinterNameCombo.TabIndex = 1;
            // 
            // PrinterNameLabel
            // 
            this.PrinterNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.PrinterNameLabel.Location = new System.Drawing.Point(24, 24);
            this.PrinterNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrinterNameLabel.Name = "PrinterNameLabel";
            this.PrinterNameLabel.Size = new System.Drawing.Size(136, 24);
            this.PrinterNameLabel.TabIndex = 0;
            this.PrinterNameLabel.Text = "结算打印机：";
            this.PrinterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(483, 546);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 49);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(352, 546);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 49);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // PrintDLFCheck
            // 
            this.PrintDLFCheck.AutoSize = true;
            this.PrintDLFCheck.Location = new System.Drawing.Point(304, 296);
            this.PrintDLFCheck.Margin = new System.Windows.Forms.Padding(2);
            this.PrintDLFCheck.Name = "PrintDLFCheck";
            this.PrintDLFCheck.Size = new System.Drawing.Size(124, 18);
            this.PrintDLFCheck.TabIndex = 22;
            this.PrintDLFCheck.Text = "打印结算代理费";
            this.PrintDLFCheck.UseVisualStyleBackColor = true;
            // 
            // ClientSettingForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 613);
            this.Controls.Add(this.m_TabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientSettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本地配置";
            this.Load += new System.EventHandler(this.SettingDialog_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingDialog_FormClosing);
            this.m_TabControl.ResumeLayout(false);
            this.m_BaseTab.ResumeLayout(false);
            this.m_BaseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BCRefreshTimeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHintTimeNumber)).EndInit();
            this.m_PrintTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarginRightNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginLeftNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginBottomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginTopNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageHeightNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageWidthNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintCopiesNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl m_TabControl;
        private System.Windows.Forms.TabPage m_BaseTab;
        private System.Windows.Forms.Label ShowHintTimeUnit;
        private System.Windows.Forms.Label ShowHintTimeLabel;
        private System.Windows.Forms.NumericUpDown ShowHintTimeNumber;
        private System.Windows.Forms.Label JPWindowLabel;
        private System.Windows.Forms.TabPage m_PrintTab;
        private System.Windows.Forms.NumericUpDown PrintCopiesNumber;
        private System.Windows.Forms.Label PrintCopiesLabel;
        private System.Windows.Forms.ComboBox PrinterNameCombo;
        private System.Windows.Forms.Label PrinterNameLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox AllowWQDBalanceCheck;
        private System.Windows.Forms.CheckBox BalanceAccountCheck;
        private System.Windows.Forms.CheckBox AllowSyncServerTime;
        private System.Windows.Forms.CheckBox BalancePrintCheck;
        private System.Windows.Forms.CheckBox AllowNullBalanceCheck;
        private System.Windows.Forms.CheckBox EnableSoundCheck;
        private System.Windows.Forms.CheckBox UseCardLoginCheck;
        private System.Windows.Forms.CheckBox ShowHintCheck;
        private System.Windows.Forms.CheckBox ShowConfirmCheck;
        private System.Windows.Forms.NumericUpDown MarginRightNumber;
        private System.Windows.Forms.NumericUpDown MarginLeftNumber;
        private System.Windows.Forms.Label MarginRightLabel;
        private System.Windows.Forms.Label MarginLeftLabel;
        private System.Windows.Forms.NumericUpDown MarginBottomNumber;
        private System.Windows.Forms.NumericUpDown MarginTopNumber;
        private System.Windows.Forms.NumericUpDown PageHeightNumber;
        private System.Windows.Forms.Label MarginBottomLabel;
        private System.Windows.Forms.Label MarginTopLabel;
        private System.Windows.Forms.Label PageHeightLabel;
        private System.Windows.Forms.Label PageWidthLabel;
        private System.Windows.Forms.NumericUpDown PageWidthNumber;
        private System.Windows.Forms.ComboBox JPWindowCombo;
        private System.Windows.Forms.CheckBox BCAutoRefreshCheck;
        private System.Windows.Forms.Label BCAutoRefreshUnit;
        private System.Windows.Forms.NumericUpDown BCRefreshTimeNumber;
        private System.Windows.Forms.Label BCAutoRefreshLabel;
        private System.Windows.Forms.CheckBox AllowResumeJPCheck;
        private System.Windows.Forms.CheckBox AllowReJSCheck;
        private System.Windows.Forms.Label EnableBSY_JPLabel;
        private System.Windows.Forms.CheckBox EnableBSY_JPCheck;
        private System.Windows.Forms.CheckBox PrintDLFCheck;
    }
}