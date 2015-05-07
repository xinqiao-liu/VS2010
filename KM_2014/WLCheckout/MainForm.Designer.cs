namespace WLCheckout
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblConnectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtConnectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginState = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLoginState = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listHZ = new Common.ListViewEx();
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMX = new Common.ListViewEx();
            this.columnCPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRatio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miClientSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.miSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.line00MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miBaseData = new System.Windows.Forms.ToolStripMenuItem();
            this.miMapping = new System.Windows.Forms.ToolStripMenuItem();
            this.miJZDMB = new System.Windows.Forms.ToolStripMenuItem();
            this.miCSXXB = new System.Windows.Forms.ToolStripMenuItem();
            this.line01MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.miResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.line02MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.miAccountNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miAccountOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miAccountDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miAccountClose = new System.Windows.Forms.ToolStripMenuItem();
            this.line12MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miYDView = new System.Windows.Forms.ToolStripMenuItem();
            this.line15MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintHZ = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintMX = new System.Windows.Forms.ToolStripMenuItem();
            this.miExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.miExportHZ = new System.Windows.Forms.ToolStripMenuItem();
            this.miExportMX = new System.Windows.Forms.ToolStripMenuItem();
            this.line13MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miFind = new System.Windows.Forms.ToolStripMenuItem();
            this.line14MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.miReports = new System.Windows.Forms.ToolStripMenuItem();
            this.miCollectByWD = new System.Windows.Forms.ToolStripMenuItem();
            this.miCollectByCP = new System.Windows.Forms.ToolStripMenuItem();
            this.miCollectByXL = new System.Windows.Forms.ToolStripMenuItem();
            this.miDaySummary = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.line21MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1107, 592);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(1107, 643);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnectionState,
            this.txtConnectionState,
            this.lblLoginState,
            this.txtLoginState,
            this.txtHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1107, 26);
            this.statusStrip.TabIndex = 0;
            // 
            // lblConnectionState
            // 
            this.lblConnectionState.ForeColor = System.Drawing.Color.Gray;
            this.lblConnectionState.Name = "lblConnectionState";
            this.lblConnectionState.Size = new System.Drawing.Size(68, 21);
            this.lblConnectionState.Text = "数据连接：";
            // 
            // txtConnectionState
            // 
            this.txtConnectionState.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtConnectionState.ForeColor = System.Drawing.Color.DarkGray;
            this.txtConnectionState.Name = "txtConnectionState";
            this.txtConnectionState.Size = new System.Drawing.Size(36, 21);
            this.txtConnectionState.Text = "关闭";
            // 
            // lblLoginState
            // 
            this.lblLoginState.ForeColor = System.Drawing.Color.Gray;
            this.lblLoginState.Name = "lblLoginState";
            this.lblLoginState.Size = new System.Drawing.Size(92, 21);
            this.lblLoginState.Text = "用户登录状态：";
            // 
            // txtLoginState
            // 
            this.txtLoginState.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLoginState.Name = "txtLoginState";
            this.txtLoginState.Size = new System.Drawing.Size(44, 21);
            this.txtLoginState.Text = "未登录";
            // 
            // txtHint
            // 
            this.txtHint.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(852, 21);
            this.txtHint.Spring = true;
            this.txtHint.Text = "技术支持电话：0431-86769937";
            this.txtHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listHZ);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listMX);
            this.splitContainer.Size = new System.Drawing.Size(1107, 592);
            this.splitContainer.SplitterDistance = 628;
            this.splitContainer.TabIndex = 6;
            // 
            // listHZ
            // 
            this.listHZ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnYear,
            this.columnMonth,
            this.columnCode,
            this.columnName,
            this.columnCars,
            this.columnCount,
            this.columnTotal,
            this.columnMoney,
            this.columnUID,
            this.columnCDT});
            this.listHZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHZ.Enabled = false;
            this.listHZ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listHZ.FullRowSelect = true;
            this.listHZ.HideSelection = false;
            this.listHZ.Location = new System.Drawing.Point(0, 0);
            this.listHZ.MultiSelect = false;
            this.listHZ.Name = "listHZ";
            this.listHZ.OneColor = System.Drawing.SystemColors.Window;
            this.listHZ.Size = new System.Drawing.Size(628, 592);
            this.listHZ.TabIndex = 5;
            this.listHZ.TwoColor = System.Drawing.SystemColors.Window;
            this.listHZ.UseCompatibleStateImageBehavior = false;
            this.listHZ.View = System.Windows.Forms.View.Details;
            this.listHZ.SelectedIndexChanged += new System.EventHandler(this.listHZ_SelectedIndexChanged);
            // 
            // columnYear
            // 
            this.columnYear.Text = "年度";
            // 
            // columnMonth
            // 
            this.columnMonth.Text = "月份";
            this.columnMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnCode
            // 
            this.columnCode.Text = "结账代码";
            this.columnCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCode.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "单位名称";
            this.columnName.Width = 160;
            // 
            // columnCars
            // 
            this.columnCars.Text = "车辆总数";
            this.columnCars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCars.Width = 90;
            // 
            // columnCount
            // 
            this.columnCount.Text = "运单总数";
            this.columnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCount.Width = 90;
            // 
            // columnTotal
            // 
            this.columnTotal.Text = "运单总额";
            this.columnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnTotal.Width = 90;
            // 
            // columnMoney
            // 
            this.columnMoney.Text = "结账总额";
            this.columnMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnMoney.Width = 90;
            // 
            // columnUID
            // 
            this.columnUID.Text = "结账工号";
            this.columnUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUID.Width = 90;
            // 
            // columnCDT
            // 
            this.columnCDT.Text = "结账时间";
            this.columnCDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCDT.Width = 140;
            // 
            // listMX
            // 
            this.listMX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCPH,
            this.columnHeader1,
            this.columnHeader2,
            this.columnRatio,
            this.columnHeader3});
            this.listMX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMX.Enabled = false;
            this.listMX.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listMX.FullRowSelect = true;
            this.listMX.Location = new System.Drawing.Point(0, 0);
            this.listMX.MultiSelect = false;
            this.listMX.Name = "listMX";
            this.listMX.OneColor = System.Drawing.SystemColors.Window;
            this.listMX.Size = new System.Drawing.Size(475, 592);
            this.listMX.TabIndex = 1;
            this.listMX.TwoColor = System.Drawing.SystemColors.Window;
            this.listMX.UseCompatibleStateImageBehavior = false;
            this.listMX.View = System.Windows.Forms.View.Details;
            this.listMX.DoubleClick += new System.EventHandler(this.miYDView_Click);
            // 
            // columnCPH
            // 
            this.columnCPH.Text = "车牌号";
            this.columnCPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCPH.Width = 90;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "运单数";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "运单额";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnRatio
            // 
            this.columnRatio.Text = "结账比率";
            this.columnRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnRatio.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "结账金额";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystem,
            this.miAccount,
            this.miReports,
            this.miAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1107, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // miSystem
            // 
            this.miSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClientSetting,
            this.miSetting,
            this.line00MenuItem,
            this.miBaseData,
            this.miJZDMB,
            this.miCSXXB,
            this.line01MenuItem,
            this.miLogin,
            this.miResetPassword,
            this.line02MenuItem,
            this.miExit});
            this.miSystem.Name = "miSystem";
            this.miSystem.Size = new System.Drawing.Size(88, 21);
            this.miSystem.Text = "系统管理(&M)";
            this.miSystem.DropDownOpening += new System.EventHandler(this.miSystem_DropDownOpening);
            // 
            // miClientSetting
            // 
            this.miClientSetting.Name = "miClientSetting";
            this.miClientSetting.Size = new System.Drawing.Size(181, 22);
            this.miClientSetting.Text = "本地配置(&S)";
            this.miClientSetting.Click += new System.EventHandler(this.miClientSetting_Click);
            // 
            // miSetting
            // 
            this.miSetting.Enabled = false;
            this.miSetting.Name = "miSetting";
            this.miSetting.Size = new System.Drawing.Size(181, 22);
            this.miSetting.Text = "运行配置(&O)";
            this.miSetting.Click += new System.EventHandler(this.miSetting_Click);
            // 
            // line00MenuItem
            // 
            this.line00MenuItem.Name = "line00MenuItem";
            this.line00MenuItem.Size = new System.Drawing.Size(178, 6);
            // 
            // miBaseData
            // 
            this.miBaseData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMapping});
            this.miBaseData.Name = "miBaseData";
            this.miBaseData.Size = new System.Drawing.Size(181, 22);
            this.miBaseData.Text = "基础数据(&D)";
            // 
            // miMapping
            // 
            this.miMapping.Enabled = false;
            this.miMapping.Name = "miMapping";
            this.miMapping.Size = new System.Drawing.Size(144, 22);
            this.miMapping.Text = "车牌映射(&M)";
            this.miMapping.Click += new System.EventHandler(this.miMapping_Click);
            // 
            // miJZDMB
            // 
            this.miJZDMB.Enabled = false;
            this.miJZDMB.Name = "miJZDMB";
            this.miJZDMB.Size = new System.Drawing.Size(181, 22);
            this.miJZDMB.Text = "结账代码(&J)";
            this.miJZDMB.Click += new System.EventHandler(this.miJZDMB_Click);
            // 
            // miCSXXB
            // 
            this.miCSXXB.Enabled = false;
            this.miCSXXB.Name = "miCSXXB";
            this.miCSXXB.Size = new System.Drawing.Size(181, 22);
            this.miCSXXB.Text = "车属信息(&P)";
            this.miCSXXB.Click += new System.EventHandler(this.miCSXXB_Click);
            // 
            // line01MenuItem
            // 
            this.line01MenuItem.Name = "line01MenuItem";
            this.line01MenuItem.Size = new System.Drawing.Size(178, 6);
            // 
            // miLogin
            // 
            this.miLogin.Name = "miLogin";
            this.miLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.miLogin.Size = new System.Drawing.Size(181, 22);
            this.miLogin.Text = "用户登录(&L)";
            this.miLogin.Click += new System.EventHandler(this.miLogin_Click);
            // 
            // miResetPassword
            // 
            this.miResetPassword.Enabled = false;
            this.miResetPassword.Name = "miResetPassword";
            this.miResetPassword.Size = new System.Drawing.Size(181, 22);
            this.miResetPassword.Text = "修改密码(&R)";
            this.miResetPassword.Click += new System.EventHandler(this.miResetPassword_Click);
            // 
            // line02MenuItem
            // 
            this.line02MenuItem.Name = "line02MenuItem";
            this.line02MenuItem.Size = new System.Drawing.Size(178, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(181, 22);
            this.miExit.Text = "退出(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miAccount
            // 
            this.miAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAccountNew,
            this.miAccountOpen,
            this.miAccountDelete,
            this.miAccountClose,
            this.line12MenuItem,
            this.miYDView,
            this.line15MenuItem,
            this.miPrint,
            this.miExportExcel,
            this.line13MenuItem,
            this.miFind,
            this.line14MenuItem,
            this.miRefresh});
            this.miAccount.Name = "miAccount";
            this.miAccount.Size = new System.Drawing.Size(84, 21);
            this.miAccount.Text = "账单管理(&A)";
            this.miAccount.DropDownOpening += new System.EventHandler(this.miSystem_DropDownOpening);
            // 
            // miAccountNew
            // 
            this.miAccountNew.Enabled = false;
            this.miAccountNew.Name = "miAccountNew";
            this.miAccountNew.Size = new System.Drawing.Size(152, 22);
            this.miAccountNew.Text = "新建账单(&N)";
            this.miAccountNew.Click += new System.EventHandler(this.miAccountNew_Click);
            // 
            // miAccountOpen
            // 
            this.miAccountOpen.Enabled = false;
            this.miAccountOpen.Name = "miAccountOpen";
            this.miAccountOpen.Size = new System.Drawing.Size(152, 22);
            this.miAccountOpen.Text = "打开账单(&S)";
            this.miAccountOpen.Click += new System.EventHandler(this.miAccountOpen_Click);
            // 
            // miAccountDelete
            // 
            this.miAccountDelete.Enabled = false;
            this.miAccountDelete.Name = "miAccountDelete";
            this.miAccountDelete.Size = new System.Drawing.Size(152, 22);
            this.miAccountDelete.Text = "删除账单(&D)";
            this.miAccountDelete.Click += new System.EventHandler(this.miAccountDelete_Click);
            // 
            // miAccountClose
            // 
            this.miAccountClose.Enabled = false;
            this.miAccountClose.Name = "miAccountClose";
            this.miAccountClose.Size = new System.Drawing.Size(152, 22);
            this.miAccountClose.Text = "关闭账单(&C)";
            this.miAccountClose.Click += new System.EventHandler(this.miAccountClose_Click);
            // 
            // line12MenuItem
            // 
            this.line12MenuItem.Name = "line12MenuItem";
            this.line12MenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // miYDView
            // 
            this.miYDView.Enabled = false;
            this.miYDView.Name = "miYDView";
            this.miYDView.Size = new System.Drawing.Size(152, 22);
            this.miYDView.Text = "运单明细(&Y)";
            this.miYDView.Click += new System.EventHandler(this.miYDView_Click);
            // 
            // line15MenuItem
            // 
            this.line15MenuItem.Name = "line15MenuItem";
            this.line15MenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // miPrint
            // 
            this.miPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPrintHZ,
            this.miPrintMX});
            this.miPrint.Name = "miPrint";
            this.miPrint.Size = new System.Drawing.Size(152, 22);
            this.miPrint.Text = "打印(&P)";
            // 
            // miPrintHZ
            // 
            this.miPrintHZ.Enabled = false;
            this.miPrintHZ.Name = "miPrintHZ";
            this.miPrintHZ.Size = new System.Drawing.Size(141, 22);
            this.miPrintHZ.Text = "当前账单(&C)";
            this.miPrintHZ.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // miPrintMX
            // 
            this.miPrintMX.Enabled = false;
            this.miPrintMX.Name = "miPrintMX";
            this.miPrintMX.Size = new System.Drawing.Size(141, 22);
            this.miPrintMX.Text = "当前明细(&D)";
            this.miPrintMX.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // miExportExcel
            // 
            this.miExportExcel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExportHZ,
            this.miExportMX});
            this.miExportExcel.Name = "miExportExcel";
            this.miExportExcel.Size = new System.Drawing.Size(152, 22);
            this.miExportExcel.Text = "导出(&E)";
            // 
            // miExportHZ
            // 
            this.miExportHZ.Enabled = false;
            this.miExportHZ.Name = "miExportHZ";
            this.miExportHZ.Size = new System.Drawing.Size(141, 22);
            this.miExportHZ.Text = "当前账单(&C)";
            this.miExportHZ.Click += new System.EventHandler(this.miExportExcel_Click);
            // 
            // miExportMX
            // 
            this.miExportMX.Enabled = false;
            this.miExportMX.Name = "miExportMX";
            this.miExportMX.Size = new System.Drawing.Size(141, 22);
            this.miExportMX.Text = "当前明细(&D)";
            this.miExportMX.Click += new System.EventHandler(this.miExportExcel_Click);
            // 
            // line13MenuItem
            // 
            this.line13MenuItem.Name = "line13MenuItem";
            this.line13MenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // miFind
            // 
            this.miFind.Enabled = false;
            this.miFind.Name = "miFind";
            this.miFind.Size = new System.Drawing.Size(152, 22);
            this.miFind.Text = "查找(&F)";
            this.miFind.Click += new System.EventHandler(this.miFind_Click);
            // 
            // line14MenuItem
            // 
            this.line14MenuItem.Name = "line14MenuItem";
            this.line14MenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // miRefresh
            // 
            this.miRefresh.Enabled = false;
            this.miRefresh.Name = "miRefresh";
            this.miRefresh.Size = new System.Drawing.Size(152, 22);
            this.miRefresh.Text = "刷新(&R)";
            this.miRefresh.Click += new System.EventHandler(this.miRefresh_Click);
            // 
            // miReports
            // 
            this.miReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCollectByWD,
            this.miCollectByCP,
            this.miCollectByXL,
            this.line21MenuItem,
            this.miDaySummary});
            this.miReports.Name = "miReports";
            this.miReports.Size = new System.Drawing.Size(84, 21);
            this.miReports.Text = "统计报表(&R)";
            this.miReports.DropDownOpening += new System.EventHandler(this.miSystem_DropDownOpening);
            // 
            // miCollectByWD
            // 
            this.miCollectByWD.Enabled = false;
            this.miCollectByWD.Name = "miCollectByWD";
            this.miCollectByWD.Size = new System.Drawing.Size(154, 22);
            this.miCollectByWD.Text = "按网点汇总(&N)";
            this.miCollectByWD.Click += new System.EventHandler(this.miCollectByWD_Click);
            // 
            // miCollectByCP
            // 
            this.miCollectByCP.Enabled = false;
            this.miCollectByCP.Name = "miCollectByCP";
            this.miCollectByCP.Size = new System.Drawing.Size(154, 22);
            this.miCollectByCP.Text = "按车牌汇总(&C)";
            this.miCollectByCP.Click += new System.EventHandler(this.miCollectByCP_Click);
            // 
            // miCollectByXL
            // 
            this.miCollectByXL.Enabled = false;
            this.miCollectByXL.Name = "miCollectByXL";
            this.miCollectByXL.Size = new System.Drawing.Size(154, 22);
            this.miCollectByXL.Text = "按线路汇总(&X)";
            this.miCollectByXL.Click += new System.EventHandler(this.miCollectByXL_Click);
            // 
            // miDaySummary
            // 
            this.miDaySummary.Enabled = false;
            this.miDaySummary.Name = "miDaySummary";
            this.miDaySummary.Size = new System.Drawing.Size(154, 22);
            this.miDaySummary.Text = "日报表(&D)";
            this.miDaySummary.Click += new System.EventHandler(this.miDaySummary_Click);
            // 
            // miAbout
            // 
            this.miAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(60, 21);
            this.miAbout.Text = "关于(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // line21MenuItem
            // 
            this.line21MenuItem.Name = "line21MenuItem";
            this.line21MenuItem.Size = new System.Drawing.Size(151, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 643);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "公路客运联网小件系统-结账平台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripSeparator line01MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miResetPassword;
        private System.Windows.Forms.ToolStripMenuItem miLogin;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectionState;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginState;
        private System.Windows.Forms.ToolStripStatusLabel txtLoginState;
        private System.Windows.Forms.ToolStripStatusLabel txtHint;
        private System.Windows.Forms.ToolStripMenuItem miJZDMB;
        private System.Windows.Forms.ToolStripSeparator line02MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAccount;
        private System.Windows.Forms.ToolStripMenuItem miReports;
        private System.Windows.Forms.ToolStripMenuItem miFind;
        private System.Windows.Forms.ToolStripSeparator line12MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRefresh;
        private System.Windows.Forms.ToolStripMenuItem miCollectByXL;
        private System.Windows.Forms.ToolStripMenuItem miCSXXB;
        private System.Windows.Forms.ToolStripMenuItem miAccountNew;
        private System.Windows.Forms.ToolStripMenuItem miAccountOpen;
        private System.Windows.Forms.ToolStripMenuItem miAccountClose;
        private System.Windows.Forms.ToolStripSeparator line13MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripMenuItem miExportExcel;
        private System.Windows.Forms.ToolStripSeparator line14MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPrintHZ;
        private System.Windows.Forms.ToolStripMenuItem miPrintMX;
        private System.Windows.Forms.ToolStripMenuItem miExportHZ;
        private System.Windows.Forms.ToolStripMenuItem miExportMX;
        private Common.ListViewEx listHZ;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnMonth;
        private System.Windows.Forms.ColumnHeader columnCode;
        private System.Windows.Forms.ColumnHeader columnCars;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.ColumnHeader columnMoney;
        private System.Windows.Forms.ColumnHeader columnUID;
        private System.Windows.Forms.ColumnHeader columnCDT;
        private System.Windows.Forms.ColumnHeader columnTotal;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Common.ListViewEx listMX;
        private System.Windows.Forms.ColumnHeader columnCPH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnRatio;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem miAccountDelete;
        private System.Windows.Forms.ToolStripMenuItem miYDView;
        private System.Windows.Forms.ToolStripSeparator line15MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCollectByWD;
        private System.Windows.Forms.ToolStripMenuItem miCollectByCP;
        private System.Windows.Forms.ToolStripMenuItem miDaySummary;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miSetting;
        private System.Windows.Forms.ToolStripSeparator line00MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miClientSetting;
        private System.Windows.Forms.ToolStripStatusLabel txtConnectionState;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ToolStripMenuItem miBaseData;
        private System.Windows.Forms.ToolStripMenuItem miMapping;
        private System.Windows.Forms.ToolStripSeparator line21MenuItem;
    }
}

