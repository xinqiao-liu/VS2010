namespace _32ServoManager
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblServoCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtServoCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblScriptCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtScriptCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpServo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelServoTool = new System.Windows.Forms.Panel();
            this.btnDeleteServo = new System.Windows.Forms.Button();
            this.chkRealtimeTrack = new System.Windows.Forms.CheckBox();
            this.btnAppendServo = new System.Windows.Forms.Button();
            this.btnAllEnabled = new System.Windows.Forms.Button();
            this.btnAllDisable = new System.Windows.Forms.Button();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.grpScript = new System.Windows.Forms.GroupBox();
            this.panelScriptTool = new System.Windows.Forms.Panel();
            this.btnInsertItem = new System.Windows.Forms.Button();
            this.btnMoveupItem = new System.Windows.Forms.Button();
            this.btnMovedownItem = new System.Windows.Forms.Button();
            this.btnAppendItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnSendScript = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.panelScriptMain = new System.Windows.Forms.Panel();
            this.lstScript = new System.Windows.Forms.ListBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkSendingLoop = new System.Windows.Forms.CheckBox();
            this.lblSendIntervalHint = new System.Windows.Forms.Label();
            this.cboSendPortBaud = new System.Windows.Forms.ComboBox();
            this.cboSendPortName = new System.Windows.Forms.ComboBox();
            this.numSendInterval = new System.Windows.Forms.NumericUpDown();
            this.lblSendPortBaud = new System.Windows.Forms.Label();
            this.lblSendPortName = new System.Windows.Forms.Label();
            this.lblSendInterval = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewScript = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewScript_16 = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewScript_32 = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine = new System.Windows.Forms.ToolStripSeparator();
            this.miNewScript_Custom = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenScript = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveScript = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine10 = new System.Windows.Forms.ToolStripSeparator();
            this.miSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine11 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpServo.SuspendLayout();
            this.panelServoTool.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.grpScript.SuspendLayout();
            this.panelScriptTool.SuspendLayout();
            this.panelScriptMain.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendInterval)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
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
            this.toolStripContainer.ContentPanel.Controls.Add(this.grpServo);
            this.toolStripContainer.ContentPanel.Controls.Add(this.toolPanel);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1285, 692);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(1285, 739);
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
            this.statusStrip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServoCount,
            this.txtServoCount,
            this.lblScriptCount,
            this.txtScriptCount,
            this.lblMsg,
            this.txtMsg});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1285, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // lblServoCount
            // 
            this.lblServoCount.ForeColor = System.Drawing.Color.Gray;
            this.lblServoCount.Name = "lblServoCount";
            this.lblServoCount.Size = new System.Drawing.Size(70, 17);
            this.lblServoCount.Text = "舵机路数：";
            // 
            // txtServoCount
            // 
            this.txtServoCount.AutoSize = false;
            this.txtServoCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtServoCount.ForeColor = System.Drawing.Color.Blue;
            this.txtServoCount.Name = "txtServoCount";
            this.txtServoCount.Size = new System.Drawing.Size(40, 17);
            this.txtServoCount.Text = "0";
            this.txtServoCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScriptCount
            // 
            this.lblScriptCount.ForeColor = System.Drawing.Color.Gray;
            this.lblScriptCount.Name = "lblScriptCount";
            this.lblScriptCount.Size = new System.Drawing.Size(70, 17);
            this.lblScriptCount.Text = "脚本行数：";
            // 
            // txtScriptCount
            // 
            this.txtScriptCount.AutoSize = false;
            this.txtScriptCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtScriptCount.ForeColor = System.Drawing.Color.Blue;
            this.txtScriptCount.Name = "txtScriptCount";
            this.txtScriptCount.Size = new System.Drawing.Size(40, 17);
            this.txtScriptCount.Text = "0";
            this.txtScriptCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMsg
            // 
            this.lblMsg.ForeColor = System.Drawing.Color.Gray;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(70, 17);
            this.lblMsg.Text = "系统信息：";
            // 
            // txtMsg
            // 
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(166, 17);
            this.txtMsg.Text = "xinqiao.liu@hotmail.com";
            // 
            // grpServo
            // 
            this.grpServo.Controls.Add(this.flowLayoutPanel);
            this.grpServo.Controls.Add(this.panelServoTool);
            this.grpServo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpServo.Location = new System.Drawing.Point(0, 0);
            this.grpServo.Name = "grpServo";
            this.grpServo.Size = new System.Drawing.Size(807, 692);
            this.grpServo.TabIndex = 0;
            this.grpServo.TabStop = false;
            this.grpServo.Text = "舵机管理";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(801, 626);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel_ControlAdded);
            this.flowLayoutPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel_ControlRemoved);
            // 
            // panelServoTool
            // 
            this.panelServoTool.Controls.Add(this.btnDeleteServo);
            this.panelServoTool.Controls.Add(this.chkRealtimeTrack);
            this.panelServoTool.Controls.Add(this.btnAppendServo);
            this.panelServoTool.Controls.Add(this.btnAllEnabled);
            this.panelServoTool.Controls.Add(this.btnAllDisable);
            this.panelServoTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelServoTool.Location = new System.Drawing.Point(3, 643);
            this.panelServoTool.Name = "panelServoTool";
            this.panelServoTool.Size = new System.Drawing.Size(801, 46);
            this.panelServoTool.TabIndex = 1;
            // 
            // btnDeleteServo
            // 
            this.btnDeleteServo.Enabled = false;
            this.btnDeleteServo.Location = new System.Drawing.Point(88, 8);
            this.btnDeleteServo.Name = "btnDeleteServo";
            this.btnDeleteServo.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteServo.TabIndex = 2;
            this.btnDeleteServo.Text = "删除舵机";
            this.btnDeleteServo.UseVisualStyleBackColor = true;
            this.btnDeleteServo.Click += new System.EventHandler(this.btnDeleteServo_Click);
            // 
            // chkRealtimeTrack
            // 
            this.chkRealtimeTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRealtimeTrack.AutoSize = true;
            this.chkRealtimeTrack.Enabled = false;
            this.chkRealtimeTrack.Location = new System.Drawing.Point(696, 16);
            this.chkRealtimeTrack.Name = "chkRealtimeTrack";
            this.chkRealtimeTrack.Size = new System.Drawing.Size(76, 16);
            this.chkRealtimeTrack.TabIndex = 0;
            this.chkRealtimeTrack.Text = "实时跟踪";
            this.chkRealtimeTrack.UseVisualStyleBackColor = true;
            this.chkRealtimeTrack.CheckedChanged += new System.EventHandler(this.chkRealtimeTrack_CheckedChanged);
            // 
            // btnAppendServo
            // 
            this.btnAppendServo.Location = new System.Drawing.Point(8, 8);
            this.btnAppendServo.Name = "btnAppendServo";
            this.btnAppendServo.Size = new System.Drawing.Size(75, 32);
            this.btnAppendServo.TabIndex = 1;
            this.btnAppendServo.Text = "添加舵机";
            this.btnAppendServo.UseVisualStyleBackColor = true;
            this.btnAppendServo.Click += new System.EventHandler(this.btnAppendServo_Click);
            // 
            // btnAllEnabled
            // 
            this.btnAllEnabled.Enabled = false;
            this.btnAllEnabled.Location = new System.Drawing.Point(176, 8);
            this.btnAllEnabled.Name = "btnAllEnabled";
            this.btnAllEnabled.Size = new System.Drawing.Size(75, 32);
            this.btnAllEnabled.TabIndex = 3;
            this.btnAllEnabled.Text = "全部使能";
            this.btnAllEnabled.UseVisualStyleBackColor = true;
            this.btnAllEnabled.Click += new System.EventHandler(this.btnAllEnabled_Click);
            // 
            // btnAllDisable
            // 
            this.btnAllDisable.Enabled = false;
            this.btnAllDisable.Location = new System.Drawing.Point(256, 8);
            this.btnAllDisable.Name = "btnAllDisable";
            this.btnAllDisable.Size = new System.Drawing.Size(75, 32);
            this.btnAllDisable.TabIndex = 4;
            this.btnAllDisable.Text = "全部禁用";
            this.btnAllDisable.UseVisualStyleBackColor = true;
            this.btnAllDisable.Click += new System.EventHandler(this.btnAllDisable_Click);
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.grpScript);
            this.toolPanel.Controls.Add(this.grpOptions);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolPanel.Location = new System.Drawing.Point(807, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(478, 692);
            this.toolPanel.TabIndex = 0;
            // 
            // grpScript
            // 
            this.grpScript.Controls.Add(this.panelScriptTool);
            this.grpScript.Controls.Add(this.panelScriptMain);
            this.grpScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpScript.Location = new System.Drawing.Point(0, 0);
            this.grpScript.Name = "grpScript";
            this.grpScript.Size = new System.Drawing.Size(478, 552);
            this.grpScript.TabIndex = 0;
            this.grpScript.TabStop = false;
            this.grpScript.Text = "脚本管理";
            // 
            // panelScriptTool
            // 
            this.panelScriptTool.Controls.Add(this.btnInsertItem);
            this.panelScriptTool.Controls.Add(this.btnMoveupItem);
            this.panelScriptTool.Controls.Add(this.btnMovedownItem);
            this.panelScriptTool.Controls.Add(this.btnAppendItem);
            this.panelScriptTool.Controls.Add(this.btnDeleteItem);
            this.panelScriptTool.Controls.Add(this.btnSendScript);
            this.panelScriptTool.Controls.Add(this.btnEditItem);
            this.panelScriptTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelScriptTool.Location = new System.Drawing.Point(3, 503);
            this.panelScriptTool.Name = "panelScriptTool";
            this.panelScriptTool.Size = new System.Drawing.Size(472, 46);
            this.panelScriptTool.TabIndex = 0;
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.Enabled = false;
            this.btnInsertItem.Location = new System.Drawing.Point(200, 8);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.Size = new System.Drawing.Size(64, 32);
            this.btnInsertItem.TabIndex = 3;
            this.btnInsertItem.Text = "插入项";
            this.btnInsertItem.UseVisualStyleBackColor = true;
            this.btnInsertItem.Click += new System.EventHandler(this.btnInsertItem_Click);
            // 
            // btnMoveupItem
            // 
            this.btnMoveupItem.Enabled = false;
            this.btnMoveupItem.Location = new System.Drawing.Point(272, 8);
            this.btnMoveupItem.Name = "btnMoveupItem";
            this.btnMoveupItem.Size = new System.Drawing.Size(48, 32);
            this.btnMoveupItem.TabIndex = 4;
            this.btnMoveupItem.Text = "上移";
            this.btnMoveupItem.UseVisualStyleBackColor = true;
            this.btnMoveupItem.Click += new System.EventHandler(this.btnMoveupItem_Click);
            // 
            // btnMovedownItem
            // 
            this.btnMovedownItem.Enabled = false;
            this.btnMovedownItem.Location = new System.Drawing.Point(320, 8);
            this.btnMovedownItem.Name = "btnMovedownItem";
            this.btnMovedownItem.Size = new System.Drawing.Size(48, 32);
            this.btnMovedownItem.TabIndex = 5;
            this.btnMovedownItem.Text = "下移";
            this.btnMovedownItem.UseVisualStyleBackColor = true;
            this.btnMovedownItem.Click += new System.EventHandler(this.btnMovedownItem_Click);
            // 
            // btnAppendItem
            // 
            this.btnAppendItem.Enabled = false;
            this.btnAppendItem.Location = new System.Drawing.Point(8, 8);
            this.btnAppendItem.Name = "btnAppendItem";
            this.btnAppendItem.Size = new System.Drawing.Size(64, 32);
            this.btnAppendItem.TabIndex = 0;
            this.btnAppendItem.Text = "添加项";
            this.btnAppendItem.UseVisualStyleBackColor = true;
            this.btnAppendItem.Click += new System.EventHandler(this.btnAppendItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Enabled = false;
            this.btnDeleteItem.Location = new System.Drawing.Point(72, 8);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(64, 32);
            this.btnDeleteItem.TabIndex = 1;
            this.btnDeleteItem.Text = "删除项";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnSendScript
            // 
            this.btnSendScript.Enabled = false;
            this.btnSendScript.Location = new System.Drawing.Point(376, 8);
            this.btnSendScript.Name = "btnSendScript";
            this.btnSendScript.Size = new System.Drawing.Size(85, 32);
            this.btnSendScript.TabIndex = 6;
            this.btnSendScript.Text = "发送脚本";
            this.btnSendScript.UseVisualStyleBackColor = true;
            this.btnSendScript.Click += new System.EventHandler(this.btnSendScript_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Enabled = false;
            this.btnEditItem.Location = new System.Drawing.Point(136, 8);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(64, 32);
            this.btnEditItem.TabIndex = 2;
            this.btnEditItem.Text = "编辑项";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // panelScriptMain
            // 
            this.panelScriptMain.Controls.Add(this.lstScript);
            this.panelScriptMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScriptMain.Location = new System.Drawing.Point(3, 17);
            this.panelScriptMain.Name = "panelScriptMain";
            this.panelScriptMain.Size = new System.Drawing.Size(472, 532);
            this.panelScriptMain.TabIndex = 0;
            // 
            // lstScript
            // 
            this.lstScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstScript.FormattingEnabled = true;
            this.lstScript.ItemHeight = 12;
            this.lstScript.Location = new System.Drawing.Point(0, 0);
            this.lstScript.Name = "lstScript";
            this.lstScript.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstScript.Size = new System.Drawing.Size(472, 532);
            this.lstScript.TabIndex = 0;
            this.lstScript.SelectedIndexChanged += new System.EventHandler(this.lstScript_SelectedIndexChanged);
            this.lstScript.DoubleClick += new System.EventHandler(this.btnEditItem_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkSendingLoop);
            this.grpOptions.Controls.Add(this.lblSendIntervalHint);
            this.grpOptions.Controls.Add(this.cboSendPortBaud);
            this.grpOptions.Controls.Add(this.cboSendPortName);
            this.grpOptions.Controls.Add(this.numSendInterval);
            this.grpOptions.Controls.Add(this.lblSendPortBaud);
            this.grpOptions.Controls.Add(this.lblSendPortName);
            this.grpOptions.Controls.Add(this.lblSendInterval);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpOptions.Location = new System.Drawing.Point(0, 552);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(478, 140);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "发送配置";
            // 
            // chkSendingLoop
            // 
            this.chkSendingLoop.AutoSize = true;
            this.chkSendingLoop.Location = new System.Drawing.Point(16, 104);
            this.chkSendingLoop.Name = "chkSendingLoop";
            this.chkSendingLoop.Size = new System.Drawing.Size(89, 16);
            this.chkSendingLoop.TabIndex = 7;
            this.chkSendingLoop.Text = "发送时循环";
            this.chkSendingLoop.UseVisualStyleBackColor = true;
            // 
            // lblSendIntervalHint
            // 
            this.lblSendIntervalHint.ForeColor = System.Drawing.Color.Gray;
            this.lblSendIntervalHint.Location = new System.Drawing.Point(216, 64);
            this.lblSendIntervalHint.Name = "lblSendIntervalHint";
            this.lblSendIntervalHint.Size = new System.Drawing.Size(80, 24);
            this.lblSendIntervalHint.TabIndex = 6;
            this.lblSendIntervalHint.Text = "（毫秒）";
            this.lblSendIntervalHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSendPortBaud
            // 
            this.cboSendPortBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSendPortBaud.FormattingEnabled = true;
            this.cboSendPortBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cboSendPortBaud.Location = new System.Drawing.Point(376, 32);
            this.cboSendPortBaud.Name = "cboSendPortBaud";
            this.cboSendPortBaud.Size = new System.Drawing.Size(88, 20);
            this.cboSendPortBaud.TabIndex = 3;
            // 
            // cboSendPortName
            // 
            this.cboSendPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSendPortName.FormattingEnabled = true;
            this.cboSendPortName.Location = new System.Drawing.Point(136, 32);
            this.cboSendPortName.Name = "cboSendPortName";
            this.cboSendPortName.Size = new System.Drawing.Size(80, 20);
            this.cboSendPortName.TabIndex = 1;
            this.cboSendPortName.DropDown += new System.EventHandler(this.cboSendPort_DropDown);
            // 
            // numSendInterval
            // 
            this.numSendInterval.ForeColor = System.Drawing.Color.Blue;
            this.numSendInterval.Location = new System.Drawing.Point(136, 64);
            this.numSendInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numSendInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSendInterval.Name = "numSendInterval";
            this.numSendInterval.Size = new System.Drawing.Size(80, 21);
            this.numSendInterval.TabIndex = 5;
            this.numSendInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblSendPortBaud
            // 
            this.lblSendPortBaud.ForeColor = System.Drawing.Color.Gray;
            this.lblSendPortBaud.Location = new System.Drawing.Point(240, 32);
            this.lblSendPortBaud.Name = "lblSendPortBaud";
            this.lblSendPortBaud.Size = new System.Drawing.Size(136, 24);
            this.lblSendPortBaud.TabIndex = 2;
            this.lblSendPortBaud.Text = "发送端口波特率：";
            this.lblSendPortBaud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSendPortName
            // 
            this.lblSendPortName.ForeColor = System.Drawing.Color.Gray;
            this.lblSendPortName.Location = new System.Drawing.Point(16, 32);
            this.lblSendPortName.Name = "lblSendPortName";
            this.lblSendPortName.Size = new System.Drawing.Size(120, 24);
            this.lblSendPortName.TabIndex = 0;
            this.lblSendPortName.Text = "发送端口名称：";
            this.lblSendPortName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSendInterval
            // 
            this.lblSendInterval.ForeColor = System.Drawing.Color.Gray;
            this.lblSendInterval.Location = new System.Drawing.Point(16, 64);
            this.lblSendInterval.Name = "lblSendInterval";
            this.lblSendInterval.Size = new System.Drawing.Size(120, 24);
            this.lblSendInterval.TabIndex = 4;
            this.lblSendInterval.Text = "脚本发送间隔：";
            this.lblSendInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystem});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1285, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // miSystem
            // 
            this.miSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewScript,
            this.miOpenScript,
            this.miSaveScript,
            this.miLine10,
            this.miSetting,
            this.miLine11,
            this.miExit});
            this.miSystem.Name = "miSystem";
            this.miSystem.Size = new System.Drawing.Size(64, 25);
            this.miSystem.Text = "文件(&F)";
            // 
            // miNewScript
            // 
            this.miNewScript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewScript_16,
            this.miNewScript_32,
            this.miLine,
            this.miNewScript_Custom});
            this.miNewScript.Name = "miNewScript";
            this.miNewScript.Size = new System.Drawing.Size(190, 22);
            this.miNewScript.Text = "新建脚本(&N)";
            // 
            // miNewScript_16
            // 
            this.miNewScript_16.Name = "miNewScript_16";
            this.miNewScript_16.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.miNewScript_16.Size = new System.Drawing.Size(191, 22);
            this.miNewScript_16.Tag = "16";
            this.miNewScript_16.Text = "16路舵机(&1)";
            this.miNewScript_16.Click += new System.EventHandler(this.miNewScript_Custom_Click);
            // 
            // miNewScript_32
            // 
            this.miNewScript_32.Name = "miNewScript_32";
            this.miNewScript_32.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.miNewScript_32.Size = new System.Drawing.Size(191, 22);
            this.miNewScript_32.Tag = "32";
            this.miNewScript_32.Text = "32路舵机(&2)";
            this.miNewScript_32.Click += new System.EventHandler(this.miNewScript_Custom_Click);
            // 
            // miLine
            // 
            this.miLine.Name = "miLine";
            this.miLine.Size = new System.Drawing.Size(188, 6);
            // 
            // miNewScript_Custom
            // 
            this.miNewScript_Custom.Name = "miNewScript_Custom";
            this.miNewScript_Custom.Size = new System.Drawing.Size(191, 22);
            this.miNewScript_Custom.Tag = "0";
            this.miNewScript_Custom.Text = "自定义(&C)";
            this.miNewScript_Custom.Click += new System.EventHandler(this.miNewScript_Custom_Click);
            // 
            // miOpenScript
            // 
            this.miOpenScript.Name = "miOpenScript";
            this.miOpenScript.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpenScript.Size = new System.Drawing.Size(190, 22);
            this.miOpenScript.Text = "打开脚本(&O)";
            this.miOpenScript.Click += new System.EventHandler(this.miOpenScript_Click);
            // 
            // miSaveScript
            // 
            this.miSaveScript.Enabled = false;
            this.miSaveScript.Name = "miSaveScript";
            this.miSaveScript.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSaveScript.Size = new System.Drawing.Size(190, 22);
            this.miSaveScript.Text = "保存脚本(&S)";
            this.miSaveScript.Click += new System.EventHandler(this.miSaveScript_Click);
            // 
            // miLine10
            // 
            this.miLine10.Name = "miLine10";
            this.miLine10.Size = new System.Drawing.Size(187, 6);
            // 
            // miSetting
            // 
            this.miSetting.Name = "miSetting";
            this.miSetting.Size = new System.Drawing.Size(190, 22);
            this.miSetting.Text = "本地设置(&O)";
            this.miSetting.Click += new System.EventHandler(this.miSetting_Click);
            // 
            // miLine11
            // 
            this.miLine11.Name = "miLine11";
            this.miLine11.Size = new System.Drawing.Size(187, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(190, 22);
            this.miExit.Text = "退出(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 739);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "MainForm";
            this.Text = "32路舵机管理器";
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
            this.grpServo.ResumeLayout(false);
            this.panelServoTool.ResumeLayout(false);
            this.panelServoTool.PerformLayout();
            this.toolPanel.ResumeLayout(false);
            this.grpScript.ResumeLayout(false);
            this.panelScriptTool.ResumeLayout(false);
            this.panelScriptMain.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendInterval)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.GroupBox grpScript;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblSendInterval;
        private System.Windows.Forms.GroupBox grpServo;
        private System.Windows.Forms.ComboBox cboSendPortBaud;
        private System.Windows.Forms.ComboBox cboSendPortName;
        private System.Windows.Forms.NumericUpDown numSendInterval;
        private System.Windows.Forms.Button btnSendScript;
        private System.Windows.Forms.Label lblSendPortBaud;
        private System.Windows.Forms.Label lblSendPortName;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAppendItem;
        private System.Windows.Forms.Label lblSendIntervalHint;
        private System.Windows.Forms.ToolStripStatusLabel txtMsg;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel panelScriptTool;
        private System.Windows.Forms.Panel panelScriptMain;
        private System.Windows.Forms.ListBox lstScript;
        private System.Windows.Forms.Button btnMoveupItem;
        private System.Windows.Forms.Button btnMovedownItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panelServoTool;
        private System.Windows.Forms.CheckBox chkRealtimeTrack;
        private System.Windows.Forms.Button btnAppendServo;
        private System.Windows.Forms.Button btnAllEnabled;
        private System.Windows.Forms.Button btnAllDisable;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miNewScript;
        private System.Windows.Forms.ToolStripMenuItem miNewScript_16;
        private System.Windows.Forms.ToolStripMenuItem miNewScript_32;
        private System.Windows.Forms.ToolStripSeparator miLine;
        private System.Windows.Forms.ToolStripMenuItem miNewScript_Custom;
        private System.Windows.Forms.ToolStripMenuItem miOpenScript;
        private System.Windows.Forms.ToolStripMenuItem miSaveScript;
        private System.Windows.Forms.ToolStripSeparator miLine10;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miSetting;
        private System.Windows.Forms.ToolStripSeparator miLine11;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnDeleteServo;
        private System.Windows.Forms.ToolStripStatusLabel lblServoCount;
        private System.Windows.Forms.ToolStripStatusLabel txtServoCount;
        private System.Windows.Forms.ToolStripStatusLabel lblScriptCount;
        private System.Windows.Forms.ToolStripStatusLabel txtScriptCount;
        private System.Windows.Forms.Button btnInsertItem;
        private System.Windows.Forms.CheckBox chkSendingLoop;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
    }
}

