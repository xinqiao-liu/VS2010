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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
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
            this.miQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.line10MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.line11MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miYDRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.miReports = new System.Windows.Forms.ToolStripMenuItem();
            this.miCollectByWD = new System.Windows.Forms.ToolStripMenuItem();
            this.miCollectByCP = new System.Windows.Forms.ToolStripMenuItem();
            this.miCollectByXL = new System.Windows.Forms.ToolStripMenuItem();
            this.miCollectByCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.line21MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miDayReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonthReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator01 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrintHZ = new System.Windows.Forms.ToolStripButton();
            this.btnPrintMX = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator02 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.cboMXShowRange = new System.Windows.Forms.ToolStripComboBox();
            this.btnTrackCPH = new System.Windows.Forms.ToolStripButton();
            this.txtTrackCPH = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator03 = new System.Windows.Forms.ToolStripSeparator();
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
            this.columnOwnerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYDS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYDE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRatio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJZJE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listYD = new Common.ListViewEx();
            this.columnSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSKType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYDType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYDState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCZ_RQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCZ_BC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCZ_CPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCZ_DZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCZ_SJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHW_MC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHW_LX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHW_JS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHW_BJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFHR_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFHR_Mobile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFHR_Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJHR_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJHR_Mobile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJFZL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJFTJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTYF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBZF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBXF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFHNode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJHNode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBXD_SN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
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
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainerMain);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1156, 549);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(1156, 603);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
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
            this.statusStrip.Size = new System.Drawing.Size(1156, 26);
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
            this.txtHint.Size = new System.Drawing.Size(751, 21);
            this.txtHint.Spring = true;
            this.txtHint.Text = "技术支持电话：0431-86769937";
            this.txtHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainer);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.listYD);
            this.splitContainerMain.Size = new System.Drawing.Size(1156, 549);
            this.splitContainerMain.SplitterDistance = 429;
            this.splitContainerMain.TabIndex = 7;
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
            this.splitContainer.Size = new System.Drawing.Size(1156, 429);
            this.splitContainer.SplitterDistance = 592;
            this.splitContainer.TabIndex = 7;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystem,
            this.miAccount,
            this.miReports,
            this.miAbout,
            this.toolStripSeparator01,
            this.btnPrintHZ,
            this.btnPrintMX,
            this.toolStripSeparator02,
            this.btnFind,
            this.cboMXShowRange,
            this.toolStripSeparator03,
            this.toolStripLabel1,
            this.txtTrackCPH,
            this.btnTrackCPH});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1156, 28);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 1;
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
            this.miSystem.Size = new System.Drawing.Size(95, 28);
            this.miSystem.Text = "系统管理(&S)";
            // 
            // miClientSetting
            // 
            this.miClientSetting.Name = "miClientSetting";
            this.miClientSetting.Size = new System.Drawing.Size(183, 24);
            this.miClientSetting.Text = "本地配置";
            this.miClientSetting.Click += new System.EventHandler(this.miClientSetting_Click);
            // 
            // miSetting
            // 
            this.miSetting.Enabled = false;
            this.miSetting.Name = "miSetting";
            this.miSetting.Size = new System.Drawing.Size(183, 24);
            this.miSetting.Text = "运行配置";
            this.miSetting.Click += new System.EventHandler(this.miSetting_Click);
            // 
            // line00MenuItem
            // 
            this.line00MenuItem.Name = "line00MenuItem";
            this.line00MenuItem.Size = new System.Drawing.Size(180, 6);
            // 
            // miBaseData
            // 
            this.miBaseData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMapping});
            this.miBaseData.Enabled = false;
            this.miBaseData.Name = "miBaseData";
            this.miBaseData.Size = new System.Drawing.Size(183, 24);
            this.miBaseData.Text = "基础数据";
            // 
            // miMapping
            // 
            this.miMapping.Name = "miMapping";
            this.miMapping.Size = new System.Drawing.Size(134, 24);
            this.miMapping.Text = "车牌映射";
            this.miMapping.Click += new System.EventHandler(this.miMapping_Click);
            // 
            // miJZDMB
            // 
            this.miJZDMB.Enabled = false;
            this.miJZDMB.Name = "miJZDMB";
            this.miJZDMB.Size = new System.Drawing.Size(183, 24);
            this.miJZDMB.Text = "结账代码";
            this.miJZDMB.Click += new System.EventHandler(this.miJZDMB_Click);
            // 
            // miCSXXB
            // 
            this.miCSXXB.Enabled = false;
            this.miCSXXB.Name = "miCSXXB";
            this.miCSXXB.Size = new System.Drawing.Size(183, 24);
            this.miCSXXB.Text = "车属信息";
            this.miCSXXB.Click += new System.EventHandler(this.miCSXXB_Click);
            // 
            // line01MenuItem
            // 
            this.line01MenuItem.Name = "line01MenuItem";
            this.line01MenuItem.Size = new System.Drawing.Size(180, 6);
            // 
            // miLogin
            // 
            this.miLogin.Name = "miLogin";
            this.miLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.miLogin.Size = new System.Drawing.Size(183, 24);
            this.miLogin.Text = "用户登录";
            this.miLogin.Click += new System.EventHandler(this.miLogin_Click);
            // 
            // miResetPassword
            // 
            this.miResetPassword.Enabled = false;
            this.miResetPassword.Name = "miResetPassword";
            this.miResetPassword.Size = new System.Drawing.Size(183, 24);
            this.miResetPassword.Text = "修改密码";
            this.miResetPassword.Click += new System.EventHandler(this.miResetPassword_Click);
            // 
            // line02MenuItem
            // 
            this.line02MenuItem.Name = "line02MenuItem";
            this.line02MenuItem.Size = new System.Drawing.Size(180, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(183, 24);
            this.miExit.Text = "退出";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miAccount
            // 
            this.miAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miQuery,
            this.line10MenuItem,
            this.miCreate,
            this.miOpen,
            this.miDelete,
            this.miClose,
            this.line11MenuItem,
            this.miYDRecord});
            this.miAccount.Name = "miAccount";
            this.miAccount.Size = new System.Drawing.Size(97, 28);
            this.miAccount.Text = "账单管理(&A)";
            // 
            // miQuery
            // 
            this.miQuery.Enabled = false;
            this.miQuery.Name = "miQuery";
            this.miQuery.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.miQuery.Size = new System.Drawing.Size(187, 24);
            this.miQuery.Text = "对账查询";
            this.miQuery.Click += new System.EventHandler(this.miQuery_Click);
            // 
            // line10MenuItem
            // 
            this.line10MenuItem.Name = "line10MenuItem";
            this.line10MenuItem.Size = new System.Drawing.Size(184, 6);
            // 
            // miCreate
            // 
            this.miCreate.Enabled = false;
            this.miCreate.Name = "miCreate";
            this.miCreate.Size = new System.Drawing.Size(187, 24);
            this.miCreate.Text = "创建账单";
            this.miCreate.Click += new System.EventHandler(this.miCreate_Click);
            // 
            // miOpen
            // 
            this.miOpen.Enabled = false;
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(187, 24);
            this.miOpen.Text = "打开账单";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miDelete
            // 
            this.miDelete.Enabled = false;
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(187, 24);
            this.miDelete.Text = "删除账单";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // miClose
            // 
            this.miClose.Enabled = false;
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(187, 24);
            this.miClose.Text = "关闭账单";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // line11MenuItem
            // 
            this.line11MenuItem.Name = "line11MenuItem";
            this.line11MenuItem.Size = new System.Drawing.Size(184, 6);
            // 
            // miYDRecord
            // 
            this.miYDRecord.Enabled = false;
            this.miYDRecord.Name = "miYDRecord";
            this.miYDRecord.Size = new System.Drawing.Size(187, 24);
            this.miYDRecord.Text = "运单记录";
            this.miYDRecord.Click += new System.EventHandler(this.miYDRecord_Click);
            // 
            // miReports
            // 
            this.miReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCollectByWD,
            this.miCollectByCP,
            this.miCollectByXL,
            this.miCollectByCustomer,
            this.line21MenuItem,
            this.miDayReport,
            this.miMonthReport});
            this.miReports.Name = "miReports";
            this.miReports.Size = new System.Drawing.Size(96, 28);
            this.miReports.Text = "统计报表(&R)";
            // 
            // miCollectByWD
            // 
            this.miCollectByWD.Enabled = false;
            this.miCollectByWD.Name = "miCollectByWD";
            this.miCollectByWD.Size = new System.Drawing.Size(176, 24);
            this.miCollectByWD.Text = "按网点汇总";
            this.miCollectByWD.Click += new System.EventHandler(this.miCollectByWD_Click);
            // 
            // miCollectByCP
            // 
            this.miCollectByCP.Enabled = false;
            this.miCollectByCP.Name = "miCollectByCP";
            this.miCollectByCP.Size = new System.Drawing.Size(176, 24);
            this.miCollectByCP.Text = "按车牌汇总";
            this.miCollectByCP.Click += new System.EventHandler(this.miCollectByCP_Click);
            // 
            // miCollectByXL
            // 
            this.miCollectByXL.Enabled = false;
            this.miCollectByXL.Name = "miCollectByXL";
            this.miCollectByXL.Size = new System.Drawing.Size(176, 24);
            this.miCollectByXL.Text = "按线路汇总";
            this.miCollectByXL.Click += new System.EventHandler(this.miCollectByXL_Click);
            // 
            // miCollectByCustomer
            // 
            this.miCollectByCustomer.Enabled = false;
            this.miCollectByCustomer.Name = "miCollectByCustomer";
            this.miCollectByCustomer.Size = new System.Drawing.Size(176, 24);
            this.miCollectByCustomer.Text = "按客户汇总";
            this.miCollectByCustomer.Click += new System.EventHandler(this.miCollectByCustomer_Click);
            // 
            // line21MenuItem
            // 
            this.line21MenuItem.Name = "line21MenuItem";
            this.line21MenuItem.Size = new System.Drawing.Size(173, 6);
            // 
            // miDayReport
            // 
            this.miDayReport.Enabled = false;
            this.miDayReport.Name = "miDayReport";
            this.miDayReport.Size = new System.Drawing.Size(176, 24);
            this.miDayReport.Text = "日报表";
            this.miDayReport.Click += new System.EventHandler(this.miDayReport_Click);
            // 
            // miMonthReport
            // 
            this.miMonthReport.Enabled = false;
            this.miMonthReport.Name = "miMonthReport";
            this.miMonthReport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miMonthReport.Size = new System.Drawing.Size(176, 24);
            this.miMonthReport.Text = "月报表";
            this.miMonthReport.Click += new System.EventHandler(this.miMonthReport_Click);
            // 
            // miAbout
            // 
            this.miAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(69, 28);
            this.miAbout.Text = "关于(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // toolStripSeparator01
            // 
            this.toolStripSeparator01.Name = "toolStripSeparator01";
            this.toolStripSeparator01.Size = new System.Drawing.Size(6, 28);
            // 
            // btnPrintHZ
            // 
            this.btnPrintHZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrintHZ.Enabled = false;
            this.btnPrintHZ.ForeColor = System.Drawing.Color.Green;
            this.btnPrintHZ.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintHZ.Image")));
            this.btnPrintHZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintHZ.Name = "btnPrintHZ";
            this.btnPrintHZ.Size = new System.Drawing.Size(97, 25);
            this.btnPrintHZ.Text = "打印当前汇总";
            this.btnPrintHZ.Click += new System.EventHandler(this.btnPrintHZ_Click);
            // 
            // btnPrintMX
            // 
            this.btnPrintMX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrintMX.Enabled = false;
            this.btnPrintMX.ForeColor = System.Drawing.Color.Green;
            this.btnPrintMX.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMX.Image")));
            this.btnPrintMX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintMX.Name = "btnPrintMX";
            this.btnPrintMX.Size = new System.Drawing.Size(97, 25);
            this.btnPrintMX.Text = "打印当前明细";
            this.btnPrintMX.Click += new System.EventHandler(this.btnPrintMX_Click);
            // 
            // toolStripSeparator02
            // 
            this.toolStripSeparator02.Name = "toolStripSeparator02";
            this.toolStripSeparator02.Size = new System.Drawing.Size(6, 28);
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFind.Enabled = false;
            this.btnFind.ForeColor = System.Drawing.Color.Green;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 25);
            this.btnFind.Text = "查找汇总记录";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboMXShowRange
            // 
            this.cboMXShowRange.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cboMXShowRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMXShowRange.Enabled = false;
            this.cboMXShowRange.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboMXShowRange.ForeColor = System.Drawing.Color.Green;
            this.cboMXShowRange.Items.AddRange(new object[] {
            "显示关联明细",
            "显示全部明细"});
            this.cboMXShowRange.Name = "cboMXShowRange";
            this.cboMXShowRange.Size = new System.Drawing.Size(121, 28);
            this.cboMXShowRange.SelectedIndexChanged += new System.EventHandler(this.listHZ_SelectedIndexChanged);
            // 
            // btnTrackCPH
            // 
            this.btnTrackCPH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTrackCPH.Enabled = false;
            this.btnTrackCPH.ForeColor = System.Drawing.Color.Green;
            this.btnTrackCPH.Image = ((System.Drawing.Image)(resources.GetObject("btnTrackCPH.Image")));
            this.btnTrackCPH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrackCPH.Name = "btnTrackCPH";
            this.btnTrackCPH.Size = new System.Drawing.Size(41, 25);
            this.btnTrackCPH.Text = "追踪";
            this.btnTrackCPH.Click += new System.EventHandler(this.btnTrackCPH_Click);
            // 
            // txtTrackCPH
            // 
            this.txtTrackCPH.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTrackCPH.ForeColor = System.Drawing.Color.Blue;
            this.txtTrackCPH.MaxLength = 7;
            this.txtTrackCPH.Name = "txtTrackCPH";
            this.txtTrackCPH.Size = new System.Drawing.Size(80, 28);
            // 
            // toolStripSeparator03
            // 
            this.toolStripSeparator03.Name = "toolStripSeparator03";
            this.toolStripSeparator03.Size = new System.Drawing.Size(6, 28);
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
            this.listHZ.Size = new System.Drawing.Size(592, 429);
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
            this.columnOwnerName,
            this.columnYDS,
            this.columnYDE,
            this.columnRatio,
            this.columnJZJE});
            this.listMX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMX.Enabled = false;
            this.listMX.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listMX.FullRowSelect = true;
            this.listMX.Location = new System.Drawing.Point(0, 0);
            this.listMX.MultiSelect = false;
            this.listMX.Name = "listMX";
            this.listMX.OneColor = System.Drawing.SystemColors.Window;
            this.listMX.Size = new System.Drawing.Size(560, 429);
            this.listMX.TabIndex = 3;
            this.listMX.TwoColor = System.Drawing.SystemColors.Window;
            this.listMX.UseCompatibleStateImageBehavior = false;
            this.listMX.View = System.Windows.Forms.View.Details;
            this.listMX.SelectedIndexChanged += new System.EventHandler(this.listMX_SelectedIndexChanged);
            // 
            // columnCPH
            // 
            this.columnCPH.Text = "车牌号";
            this.columnCPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCPH.Width = 90;
            // 
            // columnOwnerName
            // 
            this.columnOwnerName.Text = "车主信息";
            this.columnOwnerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOwnerName.Width = 80;
            // 
            // columnYDS
            // 
            this.columnYDS.Text = "运单数";
            this.columnYDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnYDS.Width = 90;
            // 
            // columnYDE
            // 
            this.columnYDE.Text = "运单额";
            this.columnYDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnYDE.Width = 90;
            // 
            // columnRatio
            // 
            this.columnRatio.Text = "结账比率";
            this.columnRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnRatio.Width = 90;
            // 
            // columnJZJE
            // 
            this.columnJZJE.Text = "结账金额";
            this.columnJZJE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnJZJE.Width = 90;
            // 
            // listYD
            // 
            this.listYD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSN,
            this.columnHeader1,
            this.columnHeader2,
            this.columnSKType,
            this.columnYDType,
            this.columnYDState,
            this.columnCZ_RQ,
            this.columnCZ_BC,
            this.columnCZ_CPH,
            this.columnCZ_DZ,
            this.columnCZ_SJ,
            this.columnHW_MC,
            this.columnHW_LX,
            this.columnHW_JS,
            this.columnHW_BJ,
            this.columnFHR_Name,
            this.columnFHR_Mobile,
            this.columnFHR_Remark,
            this.columnJHR_Name,
            this.columnJHR_Mobile,
            this.columnJFZL,
            this.columnJFTJ,
            this.columnTYF,
            this.columnBZF,
            this.columnBXF,
            this.columnHeader3,
            this.columnHeader4,
            this.columnFHNode,
            this.columnJHNode,
            this.columnBXD_SN});
            this.listYD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listYD.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listYD.FullRowSelect = true;
            this.listYD.HideSelection = false;
            this.listYD.Location = new System.Drawing.Point(0, 0);
            this.listYD.MultiSelect = false;
            this.listYD.Name = "listYD";
            this.listYD.OneColor = System.Drawing.SystemColors.Window;
            this.listYD.Size = new System.Drawing.Size(1156, 116);
            this.listYD.TabIndex = 7;
            this.listYD.TwoColor = System.Drawing.SystemColors.Window;
            this.listYD.UseCompatibleStateImageBehavior = false;
            this.listYD.View = System.Windows.Forms.View.Details;
            // 
            // columnSN
            // 
            this.columnSN.Text = "单号";
            this.columnSN.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "操作员";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "操作时间";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 160;
            // 
            // columnSKType
            // 
            this.columnSKType.Text = "收款类型";
            this.columnSKType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSKType.Width = 80;
            // 
            // columnYDType
            // 
            this.columnYDType.Text = "运单类型";
            this.columnYDType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnYDType.Width = 80;
            // 
            // columnYDState
            // 
            this.columnYDState.Text = "运单状态";
            this.columnYDState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnYDState.Width = 80;
            // 
            // columnCZ_RQ
            // 
            this.columnCZ_RQ.Text = "承载日期";
            this.columnCZ_RQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCZ_RQ.Width = 90;
            // 
            // columnCZ_BC
            // 
            this.columnCZ_BC.Text = "承载班次";
            this.columnCZ_BC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCZ_BC.Width = 80;
            // 
            // columnCZ_CPH
            // 
            this.columnCZ_CPH.Text = "承载车牌号";
            this.columnCZ_CPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCZ_CPH.Width = 90;
            // 
            // columnCZ_DZ
            // 
            this.columnCZ_DZ.Text = "承载到站";
            this.columnCZ_DZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCZ_DZ.Width = 80;
            // 
            // columnCZ_SJ
            // 
            this.columnCZ_SJ.Text = "承载时间";
            this.columnCZ_SJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCZ_SJ.Width = 80;
            // 
            // columnHW_MC
            // 
            this.columnHW_MC.Text = "货物名称";
            this.columnHW_MC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHW_MC.Width = 80;
            // 
            // columnHW_LX
            // 
            this.columnHW_LX.Text = "货物类型";
            this.columnHW_LX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHW_LX.Width = 80;
            // 
            // columnHW_JS
            // 
            this.columnHW_JS.Text = "货物件数";
            this.columnHW_JS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHW_JS.Width = 80;
            // 
            // columnHW_BJ
            // 
            this.columnHW_BJ.Text = "货物保金";
            this.columnHW_BJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHW_BJ.Width = 80;
            // 
            // columnFHR_Name
            // 
            this.columnFHR_Name.Text = "发货人";
            this.columnFHR_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFHR_Name.Width = 80;
            // 
            // columnFHR_Mobile
            // 
            this.columnFHR_Mobile.Text = "发货电话";
            this.columnFHR_Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFHR_Mobile.Width = 100;
            // 
            // columnFHR_Remark
            // 
            this.columnFHR_Remark.Text = "发货备注";
            this.columnFHR_Remark.Width = 100;
            // 
            // columnJHR_Name
            // 
            this.columnJHR_Name.Text = "接货人";
            this.columnJHR_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJHR_Name.Width = 80;
            // 
            // columnJHR_Mobile
            // 
            this.columnJHR_Mobile.Text = "接货电话";
            this.columnJHR_Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJHR_Mobile.Width = 100;
            // 
            // columnJFZL
            // 
            this.columnJFZL.Text = "计费重量";
            this.columnJFZL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJFZL.Width = 80;
            // 
            // columnJFTJ
            // 
            this.columnJFTJ.Text = "计费体积";
            this.columnJFTJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnJFTJ.Width = 80;
            // 
            // columnTYF
            // 
            this.columnTYF.Text = "托运费";
            this.columnTYF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnTYF.Width = 80;
            // 
            // columnBZF
            // 
            this.columnBZF.Text = "包装费";
            this.columnBZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnBZF.Width = 80;
            // 
            // columnBXF
            // 
            this.columnBXF.Text = "保险费";
            this.columnBXF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnBXF.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "合计";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "实收";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 80;
            // 
            // columnFHNode
            // 
            this.columnFHNode.Text = "发货网点";
            this.columnFHNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFHNode.Width = 160;
            // 
            // columnJHNode
            // 
            this.columnJHNode.Text = "接货网点";
            this.columnJHNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJHNode.Width = 160;
            // 
            // columnBXD_SN
            // 
            this.columnBXD_SN.Text = "保单编号";
            this.columnBXD_SN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBXD_SN.Width = 80;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 25);
            this.toolStripLabel1.Text = "车牌号：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 603);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectionState;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginState;
        private System.Windows.Forms.ToolStripStatusLabel txtLoginState;
        private System.Windows.Forms.ToolStripStatusLabel txtHint;
        private System.Windows.Forms.ToolStripStatusLabel txtConnectionState;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator01;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator02;
        private System.Windows.Forms.ToolStripButton btnPrintHZ;
        private System.Windows.Forms.ToolStripButton btnPrintMX;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripComboBox cboMXShowRange;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miClientSetting;
        private System.Windows.Forms.ToolStripMenuItem miSetting;
        private System.Windows.Forms.ToolStripSeparator line00MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miBaseData;
        private System.Windows.Forms.ToolStripMenuItem miMapping;
        private System.Windows.Forms.ToolStripMenuItem miJZDMB;
        private System.Windows.Forms.ToolStripMenuItem miCSXXB;
        private System.Windows.Forms.ToolStripSeparator line01MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLogin;
        private System.Windows.Forms.ToolStripMenuItem miResetPassword;
        private System.Windows.Forms.ToolStripSeparator line02MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miReports;
        private System.Windows.Forms.ToolStripMenuItem miCollectByWD;
        private System.Windows.Forms.ToolStripMenuItem miCollectByCP;
        private System.Windows.Forms.ToolStripMenuItem miCollectByXL;
        private System.Windows.Forms.ToolStripSeparator line21MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDayReport;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Common.ListViewEx listHZ;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnMonth;
        private System.Windows.Forms.ColumnHeader columnCode;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCars;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.ColumnHeader columnTotal;
        private System.Windows.Forms.ColumnHeader columnMoney;
        private System.Windows.Forms.ColumnHeader columnUID;
        private System.Windows.Forms.ColumnHeader columnCDT;
        private Common.ListViewEx listMX;
        private System.Windows.Forms.ColumnHeader columnCPH;
        private System.Windows.Forms.ColumnHeader columnOwnerName;
        private System.Windows.Forms.ColumnHeader columnYDS;
        private System.Windows.Forms.ColumnHeader columnYDE;
        private System.Windows.Forms.ColumnHeader columnRatio;
        private System.Windows.Forms.ColumnHeader columnJZJE;
        private Common.ListViewEx listYD;
        private System.Windows.Forms.ColumnHeader columnSN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnSKType;
        private System.Windows.Forms.ColumnHeader columnYDType;
        private System.Windows.Forms.ColumnHeader columnYDState;
        private System.Windows.Forms.ColumnHeader columnCZ_RQ;
        private System.Windows.Forms.ColumnHeader columnCZ_BC;
        private System.Windows.Forms.ColumnHeader columnCZ_CPH;
        private System.Windows.Forms.ColumnHeader columnCZ_DZ;
        private System.Windows.Forms.ColumnHeader columnCZ_SJ;
        private System.Windows.Forms.ColumnHeader columnHW_MC;
        private System.Windows.Forms.ColumnHeader columnHW_LX;
        private System.Windows.Forms.ColumnHeader columnHW_JS;
        private System.Windows.Forms.ColumnHeader columnHW_BJ;
        private System.Windows.Forms.ColumnHeader columnFHR_Name;
        private System.Windows.Forms.ColumnHeader columnFHR_Mobile;
        private System.Windows.Forms.ColumnHeader columnFHR_Remark;
        private System.Windows.Forms.ColumnHeader columnJHR_Name;
        private System.Windows.Forms.ColumnHeader columnJHR_Mobile;
        private System.Windows.Forms.ColumnHeader columnJFZL;
        private System.Windows.Forms.ColumnHeader columnJFTJ;
        private System.Windows.Forms.ColumnHeader columnTYF;
        private System.Windows.Forms.ColumnHeader columnBZF;
        private System.Windows.Forms.ColumnHeader columnBXF;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnFHNode;
        private System.Windows.Forms.ColumnHeader columnJHNode;
        private System.Windows.Forms.ColumnHeader columnBXD_SN;
        private System.Windows.Forms.ToolStripMenuItem miCollectByCustomer;
        private System.Windows.Forms.ToolStripMenuItem miMonthReport;
        private System.Windows.Forms.ToolStripMenuItem miAccount;
        private System.Windows.Forms.ToolStripMenuItem miQuery;
        private System.Windows.Forms.ToolStripSeparator line10MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCreate;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripSeparator line11MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miYDRecord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator03;
        private System.Windows.Forms.ToolStripTextBox txtTrackCPH;
        private System.Windows.Forms.ToolStripButton btnTrackCPH;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

