namespace WLManager
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
            this.list = new Common.ListViewEx();
            this.columnSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSKType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYDType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZTType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.columnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFHNode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJHNode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBXD_SN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miRefreshList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem01 = new System.Windows.Forms.ToolStripSeparator();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLine = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.miClientSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.miSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.line00MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miPrintFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.miNodeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.miAuthorizeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.miBillManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.line01MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miBaseData = new System.Windows.Forms.ToolStripMenuItem();
            this.miYF = new System.Windows.Forms.ToolStripMenuItem();
            this.miBZFLB = new System.Windows.Forms.ToolStripMenuItem();
            this.line03MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miHWLXB = new System.Windows.Forms.ToolStripMenuItem();
            this.miBZXXB = new System.Windows.Forms.ToolStripMenuItem();
            this.miMapping = new System.Windows.Forms.ToolStripMenuItem();
            this.line05MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miCustomerManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.line02MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.miResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.line04MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miReports = new System.Windows.Forms.ToolStripMenuItem();
            this.miPayinRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.line41MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miGDRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.miFDRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdvanceRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.line42MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miXCRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.miSHRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQueryMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.miQueryModeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.miQueryModeSN = new System.Windows.Forms.ToolStripMenuItem();
            this.miQueryModeFHRName = new System.Windows.Forms.ToolStripMenuItem();
            this.miQueryModeFHRTel = new System.Windows.Forms.ToolStripMenuItem();
            this.cboQueryContent = new System.Windows.Forms.ToolStripComboBox();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator01 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCreateDailySheet = new System.Windows.Forms.ToolStripButton();
            this.btnUserOver = new System.Windows.Forms.ToolStripButton();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator02 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnChange = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator03 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator04 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCentralManagement = new System.Windows.Forms.ToolStripDropDownButton();
            this.miUploadToCentral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem03 = new System.Windows.Forms.ToolStripSeparator();
            this.miConfirmLoaded = new System.Windows.Forms.ToolStripMenuItem();
            this.miConfirmUnload = new System.Windows.Forms.ToolStripMenuItem();
            this.miConfirmPickup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem04 = new System.Windows.Forms.ToolStripSeparator();
            this.miCentralQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSyncCPH = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            this.toolStripContainer.ContentPanel.Controls.Add(this.list);
            this.toolStripContainer.ContentPanel.Controls.Add(this.mainLine);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(928, 478);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(928, 557);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            this.toolStripContainer.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
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
            this.statusStrip.Size = new System.Drawing.Size(928, 26);
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
            this.lblLoginState.Size = new System.Drawing.Size(68, 21);
            this.lblLoginState.Text = "登录状态：";
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
            this.txtHint.Size = new System.Drawing.Size(697, 21);
            this.txtHint.Spring = true;
            this.txtHint.Text = "技术支持：0431-86769937";
            this.txtHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSN,
            this.columnUID,
            this.columnCDT,
            this.columnSKType,
            this.columnYDType,
            this.columnZTType,
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
            this.columnTotal,
            this.columnMoney,
            this.columnFHNode,
            this.columnJHNode,
            this.columnBXD_SN});
            this.list.ContextMenuStrip = this.contextMenuStrip;
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list.FullRowSelect = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 2);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(928, 476);
            this.list.TabIndex = 6;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            this.list.DoubleClick += new System.EventHandler(this.list_DoubleClick);
            // 
            // columnSN
            // 
            this.columnSN.Text = "单号";
            this.columnSN.Width = 100;
            // 
            // columnUID
            // 
            this.columnUID.Text = "操作员";
            this.columnUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUID.Width = 80;
            // 
            // columnCDT
            // 
            this.columnCDT.Text = "操作时间";
            this.columnCDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCDT.Width = 160;
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
            // columnZTType
            // 
            this.columnZTType.Text = "状态类型";
            this.columnZTType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnZTType.Width = 80;
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
            this.columnHW_BJ.Width = 90;
            // 
            // columnFHR_Name
            // 
            this.columnFHR_Name.Text = "发货人";
            this.columnFHR_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFHR_Name.Width = 80;
            // 
            // columnFHR_Mobile
            // 
            this.columnFHR_Mobile.Text = "发货移电";
            this.columnFHR_Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFHR_Mobile.Width = 80;
            // 
            // columnFHR_Remark
            // 
            this.columnFHR_Remark.Text = "发货备注";
            this.columnFHR_Remark.Width = 80;
            // 
            // columnJHR_Name
            // 
            this.columnJHR_Name.Text = "接货人";
            this.columnJHR_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJHR_Name.Width = 80;
            // 
            // columnJHR_Mobile
            // 
            this.columnJHR_Mobile.Text = "接货移电";
            this.columnJHR_Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJHR_Mobile.Width = 80;
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
            // columnTotal
            // 
            this.columnTotal.Text = "合计";
            this.columnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnTotal.Width = 80;
            // 
            // columnMoney
            // 
            this.columnMoney.Text = "实收";
            this.columnMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnMoney.Width = 80;
            // 
            // columnFHNode
            // 
            this.columnFHNode.Text = "发货网点";
            this.columnFHNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFHNode.Width = 240;
            // 
            // columnJHNode
            // 
            this.columnJHNode.Text = "接货网点";
            this.columnJHNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJHNode.Width = 240;
            // 
            // columnBXD_SN
            // 
            this.columnBXD_SN.Text = "保单编号";
            this.columnBXD_SN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBXD_SN.Width = 80;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRefreshList,
            this.toolStripMenuItem01,
            this.miEdit,
            this.miChange});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(125, 76);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // miRefreshList
            // 
            this.miRefreshList.Name = "miRefreshList";
            this.miRefreshList.Size = new System.Drawing.Size(124, 22);
            this.miRefreshList.Text = "刷新列表";
            this.miRefreshList.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripMenuItem01
            // 
            this.toolStripMenuItem01.Name = "toolStripMenuItem01";
            this.toolStripMenuItem01.Size = new System.Drawing.Size(121, 6);
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(124, 22);
            this.miEdit.Text = "编辑运单";
            this.miEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // miChange
            // 
            this.miChange.Name = "miChange";
            this.miChange.Size = new System.Drawing.Size(124, 22);
            this.miChange.Text = "运单换车";
            this.miChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // mainLine
            // 
            this.mainLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainLine.Location = new System.Drawing.Point(0, 0);
            this.mainLine.Name = "mainLine";
            this.mainLine.Size = new System.Drawing.Size(928, 2);
            this.mainLine.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miManagement,
            this.miReports,
            this.miAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(928, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // miManagement
            // 
            this.miManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClientSetting,
            this.miSetting,
            this.line00MenuItem,
            this.miPrintFormat,
            this.miNodeManagement,
            this.miAuthorizeManagement,
            this.miUserManagement,
            this.miBillManagement,
            this.line01MenuItem,
            this.miBaseData,
            this.line02MenuItem,
            this.miLogin,
            this.miResetPassword,
            this.line04MenuItem,
            this.miExit});
            this.miManagement.Name = "miManagement";
            this.miManagement.Size = new System.Drawing.Size(88, 21);
            this.miManagement.Text = "系统管理(&M)";
            this.miManagement.DropDownOpening += new System.EventHandler(this.miManagement_DropDownOpening);
            // 
            // miClientSetting
            // 
            this.miClientSetting.Name = "miClientSetting";
            this.miClientSetting.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miClientSetting.Size = new System.Drawing.Size(183, 22);
            this.miClientSetting.Text = "本地配置(&S)";
            this.miClientSetting.Click += new System.EventHandler(this.miClientSetting_Click);
            // 
            // miSetting
            // 
            this.miSetting.Enabled = false;
            this.miSetting.Name = "miSetting";
            this.miSetting.Size = new System.Drawing.Size(183, 22);
            this.miSetting.Text = "运行配置(&O)";
            this.miSetting.Click += new System.EventHandler(this.miSetting_Click);
            // 
            // line00MenuItem
            // 
            this.line00MenuItem.Name = "line00MenuItem";
            this.line00MenuItem.Size = new System.Drawing.Size(180, 6);
            // 
            // miPrintFormat
            // 
            this.miPrintFormat.Enabled = false;
            this.miPrintFormat.Name = "miPrintFormat";
            this.miPrintFormat.Size = new System.Drawing.Size(183, 22);
            this.miPrintFormat.Text = "打印格式(&P)";
            this.miPrintFormat.Click += new System.EventHandler(this.miPrintFormat_Click);
            // 
            // miNodeManagement
            // 
            this.miNodeManagement.Enabled = false;
            this.miNodeManagement.Name = "miNodeManagement";
            this.miNodeManagement.Size = new System.Drawing.Size(183, 22);
            this.miNodeManagement.Text = "网点管理(&N)";
            this.miNodeManagement.Click += new System.EventHandler(this.miNodeManagement_Click);
            // 
            // miAuthorizeManagement
            // 
            this.miAuthorizeManagement.Enabled = false;
            this.miAuthorizeManagement.Name = "miAuthorizeManagement";
            this.miAuthorizeManagement.Size = new System.Drawing.Size(183, 22);
            this.miAuthorizeManagement.Text = "授权管理(&A)";
            this.miAuthorizeManagement.Click += new System.EventHandler(this.miAuthorizeManagement_Click);
            // 
            // miUserManagement
            // 
            this.miUserManagement.Enabled = false;
            this.miUserManagement.Name = "miUserManagement";
            this.miUserManagement.Size = new System.Drawing.Size(183, 22);
            this.miUserManagement.Text = "用户管理(&U)";
            this.miUserManagement.Click += new System.EventHandler(this.miUserManagement_Click);
            // 
            // miBillManagement
            // 
            this.miBillManagement.Enabled = false;
            this.miBillManagement.Name = "miBillManagement";
            this.miBillManagement.Size = new System.Drawing.Size(183, 22);
            this.miBillManagement.Text = "票据管理(&B)";
            this.miBillManagement.Click += new System.EventHandler(this.miBillManagement_Click);
            // 
            // line01MenuItem
            // 
            this.line01MenuItem.Name = "line01MenuItem";
            this.line01MenuItem.Size = new System.Drawing.Size(180, 6);
            // 
            // miBaseData
            // 
            this.miBaseData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miYF,
            this.miBZFLB,
            this.line03MenuItem,
            this.miHWLXB,
            this.miBZXXB,
            this.miMapping,
            this.line05MenuItem,
            this.miCustomerManagement});
            this.miBaseData.Name = "miBaseData";
            this.miBaseData.Size = new System.Drawing.Size(183, 22);
            this.miBaseData.Text = "基础数据(&D)";
            // 
            // miYF
            // 
            this.miYF.Enabled = false;
            this.miYF.Name = "miYF";
            this.miYF.Size = new System.Drawing.Size(148, 22);
            this.miYF.Text = "运费标准(&Y)";
            this.miYF.Click += new System.EventHandler(this.miYF_Click);
            // 
            // miBZFLB
            // 
            this.miBZFLB.Enabled = false;
            this.miBZFLB.Name = "miBZFLB";
            this.miBZFLB.Size = new System.Drawing.Size(148, 22);
            this.miBZFLB.Text = "包装费率(&B)";
            this.miBZFLB.Click += new System.EventHandler(this.miBZFLB_Click);
            // 
            // line03MenuItem
            // 
            this.line03MenuItem.Name = "line03MenuItem";
            this.line03MenuItem.Size = new System.Drawing.Size(145, 6);
            // 
            // miHWLXB
            // 
            this.miHWLXB.Enabled = false;
            this.miHWLXB.Name = "miHWLXB";
            this.miHWLXB.Size = new System.Drawing.Size(148, 22);
            this.miHWLXB.Text = "货物类型(&H)";
            this.miHWLXB.Click += new System.EventHandler(this.miHWLXB_Click);
            // 
            // miBZXXB
            // 
            this.miBZXXB.Enabled = false;
            this.miBZXXB.Name = "miBZXXB";
            this.miBZXXB.Size = new System.Drawing.Size(148, 22);
            this.miBZXXB.Text = "备注信息(&R）";
            this.miBZXXB.Click += new System.EventHandler(this.miBZXXB_Click);
            // 
            // miMapping
            // 
            this.miMapping.Enabled = false;
            this.miMapping.Name = "miMapping";
            this.miMapping.Size = new System.Drawing.Size(148, 22);
            this.miMapping.Text = "车牌映射(&M)";
            this.miMapping.Click += new System.EventHandler(this.miMapping_Click);
            // 
            // line05MenuItem
            // 
            this.line05MenuItem.Name = "line05MenuItem";
            this.line05MenuItem.Size = new System.Drawing.Size(145, 6);
            // 
            // miCustomerManagement
            // 
            this.miCustomerManagement.Enabled = false;
            this.miCustomerManagement.Name = "miCustomerManagement";
            this.miCustomerManagement.Size = new System.Drawing.Size(148, 22);
            this.miCustomerManagement.Text = "客户管理(&C)";
            this.miCustomerManagement.Click += new System.EventHandler(this.miCustomerManagement_Click);
            // 
            // line02MenuItem
            // 
            this.line02MenuItem.Name = "line02MenuItem";
            this.line02MenuItem.Size = new System.Drawing.Size(180, 6);
            // 
            // miLogin
            // 
            this.miLogin.Name = "miLogin";
            this.miLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.miLogin.Size = new System.Drawing.Size(183, 22);
            this.miLogin.Text = "用户登录(&L)";
            this.miLogin.Click += new System.EventHandler(this.miLogin_Click);
            // 
            // miResetPassword
            // 
            this.miResetPassword.Enabled = false;
            this.miResetPassword.Name = "miResetPassword";
            this.miResetPassword.Size = new System.Drawing.Size(183, 22);
            this.miResetPassword.Text = "修改密码(&R)";
            this.miResetPassword.Click += new System.EventHandler(this.miResetPassword_Click);
            // 
            // line04MenuItem
            // 
            this.line04MenuItem.Name = "line04MenuItem";
            this.line04MenuItem.Size = new System.Drawing.Size(180, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(183, 22);
            this.miExit.Text = "退出(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miReports
            // 
            this.miReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPayinRecord,
            this.line41MenuItem,
            this.miGDRecord,
            this.miFDRecord,
            this.miAdvanceRecord,
            this.line42MenuItem,
            this.miXCRecord,
            this.miSHRecord});
            this.miReports.Name = "miReports";
            this.miReports.Size = new System.Drawing.Size(84, 21);
            this.miReports.Text = "日常报表(&R)";
            this.miReports.DropDownOpening += new System.EventHandler(this.miReports_DropDownOpening);
            // 
            // miPayinRecord
            // 
            this.miPayinRecord.Enabled = false;
            this.miPayinRecord.Name = "miPayinRecord";
            this.miPayinRecord.Size = new System.Drawing.Size(152, 22);
            this.miPayinRecord.Text = "缴款记录(&P)";
            this.miPayinRecord.Click += new System.EventHandler(this.miPayinRecord_Click);
            // 
            // line41MenuItem
            // 
            this.line41MenuItem.Name = "line41MenuItem";
            this.line41MenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // miGDRecord
            // 
            this.miGDRecord.Enabled = false;
            this.miGDRecord.Name = "miGDRecord";
            this.miGDRecord.Size = new System.Drawing.Size(152, 22);
            this.miGDRecord.Text = "改单记录(&G)";
            this.miGDRecord.Click += new System.EventHandler(this.miGDRecord_Click);
            // 
            // miFDRecord
            // 
            this.miFDRecord.Enabled = false;
            this.miFDRecord.Name = "miFDRecord";
            this.miFDRecord.Size = new System.Drawing.Size(152, 22);
            this.miFDRecord.Text = "废单记录(&F)";
            this.miFDRecord.Click += new System.EventHandler(this.miFDRecord_Click);
            // 
            // miAdvanceRecord
            // 
            this.miAdvanceRecord.Enabled = false;
            this.miAdvanceRecord.Name = "miAdvanceRecord";
            this.miAdvanceRecord.Size = new System.Drawing.Size(152, 22);
            this.miAdvanceRecord.Text = "预办记录(&A)";
            this.miAdvanceRecord.Click += new System.EventHandler(this.miAdvanceRecord_Click);
            // 
            // line42MenuItem
            // 
            this.line42MenuItem.Name = "line42MenuItem";
            this.line42MenuItem.Size = new System.Drawing.Size(149, 6);
            this.line42MenuItem.Visible = false;
            // 
            // miXCRecord
            // 
            this.miXCRecord.Enabled = false;
            this.miXCRecord.Name = "miXCRecord";
            this.miXCRecord.Size = new System.Drawing.Size(152, 22);
            this.miXCRecord.Text = "卸车报表(&X)";
            this.miXCRecord.Visible = false;
            this.miXCRecord.Click += new System.EventHandler(this.miXCRecord_Click);
            // 
            // miSHRecord
            // 
            this.miSHRecord.Enabled = false;
            this.miSHRecord.Name = "miSHRecord";
            this.miSHRecord.Size = new System.Drawing.Size(152, 22);
            this.miSHRecord.Text = "取货报表(&S)";
            this.miSHRecord.Visible = false;
            this.miSHRecord.Click += new System.EventHandler(this.miSHRecord_Click);
            // 
            // miAbout
            // 
            this.miAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(60, 21);
            this.miAbout.Text = "关于(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Enabled = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQueryMode,
            this.cboQueryContent,
            this.btnRefresh,
            this.toolStripSeparator01,
            this.btnCreateDailySheet,
            this.btnUserOver,
            this.btnCreate,
            this.toolStripSeparator02,
            this.btnEdit,
            this.btnChange,
            this.toolStripSeparator03,
            this.toolStripSeparator04,
            this.btnCentralManagement,
            this.btnSyncCPH});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(928, 28);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 1;
            // 
            // btnQueryMode
            // 
            this.btnQueryMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQueryMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miQueryModeDate,
            this.miQueryModeSN,
            this.miQueryModeFHRName,
            this.miQueryModeFHRTel});
            this.btnQueryMode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQueryMode.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryMode.Image")));
            this.btnQueryMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQueryMode.Name = "btnQueryMode";
            this.btnQueryMode.Size = new System.Drawing.Size(92, 25);
            this.btnQueryMode.Text = "办单日期：";
            // 
            // miQueryModeDate
            // 
            this.miQueryModeDate.Name = "miQueryModeDate";
            this.miQueryModeDate.Size = new System.Drawing.Size(148, 24);
            this.miQueryModeDate.Text = "办单日期";
            this.miQueryModeDate.Click += new System.EventHandler(this.miQueryMode_Click);
            // 
            // miQueryModeSN
            // 
            this.miQueryModeSN.Name = "miQueryModeSN";
            this.miQueryModeSN.Size = new System.Drawing.Size(148, 24);
            this.miQueryModeSN.Text = "运单编号";
            this.miQueryModeSN.Click += new System.EventHandler(this.miQueryMode_Click);
            // 
            // miQueryModeFHRName
            // 
            this.miQueryModeFHRName.Name = "miQueryModeFHRName";
            this.miQueryModeFHRName.Size = new System.Drawing.Size(148, 24);
            this.miQueryModeFHRName.Text = "发货人姓名";
            this.miQueryModeFHRName.Click += new System.EventHandler(this.miQueryMode_Click);
            // 
            // miQueryModeFHRTel
            // 
            this.miQueryModeFHRTel.Name = "miQueryModeFHRTel";
            this.miQueryModeFHRTel.Size = new System.Drawing.Size(148, 24);
            this.miQueryModeFHRTel.Text = "发货人电话";
            this.miQueryModeFHRTel.Click += new System.EventHandler(this.miQueryMode_Click);
            // 
            // cboQueryContent
            // 
            this.cboQueryContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQueryContent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboQueryContent.IntegralHeight = false;
            this.cboQueryContent.Name = "cboQueryContent";
            this.cboQueryContent.Size = new System.Drawing.Size(100, 28);
            this.cboQueryContent.DropDown += new System.EventHandler(this.cboQueryContent_DropDown);
            this.cboQueryContent.DropDownClosed += new System.EventHandler(this.cboQueryContent_DropDownClosed);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 25);
            this.btnRefresh.Text = "刷新列表";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.ToolTipText = "刷新运单列表";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator01
            // 
            this.toolStripSeparator01.Name = "toolStripSeparator01";
            this.toolStripSeparator01.Size = new System.Drawing.Size(6, 28);
            // 
            // btnCreateDailySheet
            // 
            this.btnCreateDailySheet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCreateDailySheet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreateDailySheet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateDailySheet.ForeColor = System.Drawing.Color.Maroon;
            this.btnCreateDailySheet.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDailySheet.Image")));
            this.btnCreateDailySheet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateDailySheet.Name = "btnCreateDailySheet";
            this.btnCreateDailySheet.Size = new System.Drawing.Size(69, 25);
            this.btnCreateDailySheet.Text = "生成日报";
            this.btnCreateDailySheet.ToolTipText = "仅创建指定日期日报表";
            this.btnCreateDailySheet.Click += new System.EventHandler(this.btnCreateDailySheet_Click);
            // 
            // btnUserOver
            // 
            this.btnUserOver.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUserOver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUserOver.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserOver.ForeColor = System.Drawing.Color.Maroon;
            this.btnUserOver.Image = ((System.Drawing.Image)(resources.GetObject("btnUserOver.Image")));
            this.btnUserOver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserOver.Name = "btnUserOver";
            this.btnUserOver.Size = new System.Drawing.Size(69, 25);
            this.btnUserOver.Text = "用户缴款";
            this.btnUserOver.ToolTipText = "仅创建指定缴款记录";
            this.btnUserOver.Click += new System.EventHandler(this.btnUserOver_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(69, 25);
            this.btnCreate.Text = "办单运单";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // toolStripSeparator02
            // 
            this.toolStripSeparator02.Name = "toolStripSeparator02";
            this.toolStripSeparator02.Size = new System.Drawing.Size(6, 28);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 25);
            this.btnEdit.Text = "编辑运单";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnChange
            // 
            this.btnChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnChange.Enabled = false;
            this.btnChange.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(69, 25);
            this.btnChange.Text = "运单换车";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // toolStripSeparator03
            // 
            this.toolStripSeparator03.Name = "toolStripSeparator03";
            this.toolStripSeparator03.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator04
            // 
            this.toolStripSeparator04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator04.Name = "toolStripSeparator04";
            this.toolStripSeparator04.Size = new System.Drawing.Size(6, 28);
            // 
            // btnCentralManagement
            // 
            this.btnCentralManagement.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCentralManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCentralManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUploadToCentral,
            this.toolStripMenuItem03,
            this.miConfirmLoaded,
            this.miConfirmUnload,
            this.miConfirmPickup,
            this.toolStripMenuItem04,
            this.miCentralQuery});
            this.btnCentralManagement.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCentralManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnCentralManagement.Image")));
            this.btnCentralManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCentralManagement.Name = "btnCentralManagement";
            this.btnCentralManagement.Size = new System.Drawing.Size(106, 29);
            this.btnCentralManagement.Text = "中心数据管理";
            this.btnCentralManagement.Visible = false;
            // 
            // miUploadToCentral
            // 
            this.miUploadToCentral.Name = "miUploadToCentral";
            this.miUploadToCentral.Size = new System.Drawing.Size(134, 24);
            this.miUploadToCentral.Text = "上传运单";
            this.miUploadToCentral.Click += new System.EventHandler(this.miUploadToCentral_Click);
            // 
            // toolStripMenuItem03
            // 
            this.toolStripMenuItem03.Name = "toolStripMenuItem03";
            this.toolStripMenuItem03.Size = new System.Drawing.Size(131, 6);
            // 
            // miConfirmLoaded
            // 
            this.miConfirmLoaded.Name = "miConfirmLoaded";
            this.miConfirmLoaded.Size = new System.Drawing.Size(134, 24);
            this.miConfirmLoaded.Text = "确认装车";
            this.miConfirmLoaded.Click += new System.EventHandler(this.miConfirmLoaded_Click);
            // 
            // miConfirmUnload
            // 
            this.miConfirmUnload.Name = "miConfirmUnload";
            this.miConfirmUnload.Size = new System.Drawing.Size(134, 24);
            this.miConfirmUnload.Text = "确认卸车";
            this.miConfirmUnload.Click += new System.EventHandler(this.miConfirmUnload_Click);
            // 
            // miConfirmPickup
            // 
            this.miConfirmPickup.Name = "miConfirmPickup";
            this.miConfirmPickup.Size = new System.Drawing.Size(134, 24);
            this.miConfirmPickup.Text = "确认取货";
            this.miConfirmPickup.Click += new System.EventHandler(this.miConfirmPickup_Click);
            // 
            // toolStripMenuItem04
            // 
            this.toolStripMenuItem04.Name = "toolStripMenuItem04";
            this.toolStripMenuItem04.Size = new System.Drawing.Size(131, 6);
            // 
            // miCentralQuery
            // 
            this.miCentralQuery.Name = "miCentralQuery";
            this.miCentralQuery.Size = new System.Drawing.Size(134, 24);
            this.miCentralQuery.Text = "运单查询";
            this.miCentralQuery.Click += new System.EventHandler(this.miCentralQuery_Click);
            // 
            // btnSyncCPH
            // 
            this.btnSyncCPH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSyncCPH.Enabled = false;
            this.btnSyncCPH.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSyncCPH.Image = ((System.Drawing.Image)(resources.GetObject("btnSyncCPH.Image")));
            this.btnSyncCPH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSyncCPH.Name = "btnSyncCPH";
            this.btnSyncCPH.Size = new System.Drawing.Size(83, 25);
            this.btnSyncCPH.Text = "同步车牌号";
            this.btnSyncCPH.Click += new System.EventHandler(this.btnSyncCPH_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 557);
            this.Controls.Add(this.toolStripContainer);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "公路客运联网小件系统-营运平台";
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
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miManagement;
        private System.Windows.Forms.ToolStripSeparator line00MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLogin;
        private System.Windows.Forms.ToolStripMenuItem miResetPassword;
        private System.Windows.Forms.ToolStripSeparator line01MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectionState;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginState;
        private System.Windows.Forms.ToolStripStatusLabel txtLoginState;
        private System.Windows.Forms.ToolStripStatusLabel txtHint;
        private System.Windows.Forms.ToolStripMenuItem miSetting;
        private System.Windows.Forms.ToolStripMenuItem miPrintFormat;
        private System.Windows.Forms.ToolStripSeparator line02MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miUserManagement;
        private System.Windows.Forms.ToolStripMenuItem miBillManagement;
        private System.Windows.Forms.ToolStripMenuItem miClientSetting;
        private System.Windows.Forms.ToolStripMenuItem miBaseData;
        private System.Windows.Forms.ToolStripMenuItem miBZFLB;
        private System.Windows.Forms.ToolStripMenuItem miHWLXB;
        private System.Windows.Forms.ToolStripMenuItem miBZXXB;
        private System.Windows.Forms.ToolStripSeparator line03MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCustomerManagement;
        private System.Windows.Forms.ToolStripSeparator line04MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miYF;
        private System.Windows.Forms.ToolStripSeparator line05MenuItem;
        private System.Windows.Forms.Label mainLine;
        private System.Windows.Forms.ToolStripMenuItem miReports;
        private System.Windows.Forms.ToolStripMenuItem miPayinRecord;
        private System.Windows.Forms.ToolStripMenuItem miGDRecord;
        private System.Windows.Forms.ToolStripMenuItem miFDRecord;
        private System.Windows.Forms.ToolStripMenuItem miNodeManagement;
        private System.Windows.Forms.ToolStripMenuItem miAuthorizeManagement;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripStatusLabel txtConnectionState;
        private System.Windows.Forms.ToolStripMenuItem miMapping;
        private System.Windows.Forms.ToolStripSeparator line41MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAdvanceRecord;
        private Common.ListViewEx list;
        private System.Windows.Forms.ColumnHeader columnSN;
        private System.Windows.Forms.ColumnHeader columnUID;
        private System.Windows.Forms.ColumnHeader columnCDT;
        private System.Windows.Forms.ColumnHeader columnSKType;
        private System.Windows.Forms.ColumnHeader columnYDType;
        private System.Windows.Forms.ColumnHeader columnZTType;
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
        private System.Windows.Forms.ColumnHeader columnTotal;
        private System.Windows.Forms.ColumnHeader columnFHNode;
        private System.Windows.Forms.ColumnHeader columnJHNode;
        private System.Windows.Forms.ColumnHeader columnBXD_SN;
        private System.Windows.Forms.ColumnHeader columnMoney;
        private System.Windows.Forms.ToolStripSeparator line42MenuItem;
        private System.Windows.Forms.ToolStripMenuItem miXCRecord;
        private System.Windows.Forms.ToolStripMenuItem miSHRecord;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox cboQueryContent;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator01;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnCreateDailySheet;
        private System.Windows.Forms.ToolStripButton btnUserOver;
        private System.Windows.Forms.ToolStripDropDownButton btnQueryMode;
        private System.Windows.Forms.ToolStripMenuItem miQueryModeDate;
        private System.Windows.Forms.ToolStripMenuItem miQueryModeSN;
        private System.Windows.Forms.ToolStripMenuItem miQueryModeFHRName;
        private System.Windows.Forms.ToolStripMenuItem miQueryModeFHRTel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator02;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator03;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator04;
        private System.Windows.Forms.ToolStripButton btnChange;
        private System.Windows.Forms.ToolStripDropDownButton btnCentralManagement;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miChange;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem01;
        private System.Windows.Forms.ToolStripMenuItem miRefreshList;
        private System.Windows.Forms.ToolStripMenuItem miCentralQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem03;
        private System.Windows.Forms.ToolStripMenuItem miConfirmLoaded;
        private System.Windows.Forms.ToolStripMenuItem miConfirmUnload;
        private System.Windows.Forms.ToolStripMenuItem miConfirmPickup;
        private System.Windows.Forms.ToolStripMenuItem miUploadToCentral;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem04;
        private System.Windows.Forms.ToolStripButton btnSyncCPH;
    }
}

