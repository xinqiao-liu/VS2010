namespace WLManager
{
    partial class EditForm
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
            this.grpSets = new System.Windows.Forms.GroupBox();
            this.chkTelService = new System.Windows.Forms.CheckBox();
            this.chkSMSService = new System.Windows.Forms.CheckBox();
            this.chkSecurityCheck = new System.Windows.Forms.CheckBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.Label();
            this.grpBase = new System.Windows.Forms.GroupBox();
            this.cboFH_List = new Common.ComboBoxEx();
            this.txtCZ_RQ = new Common.TextBoxEx();
            this.chkSyncToCentral = new System.Windows.Forms.CheckBox();
            this.lstCZ = new Common.ListViewEx();
            this.columnCPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboJH_List = new Common.ComboBoxEx();
            this.cboCZ_DZ = new Common.ComboBoxEx();
            this.lblCZ_DZ = new System.Windows.Forms.Label();
            this.lblCZ_RQ = new System.Windows.Forms.Label();
            this.lblJH_List = new System.Windows.Forms.Label();
            this.lblFH_List = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpJF = new System.Windows.Forms.GroupBox();
            this.txtSK_Type = new Common.TextBoxEx();
            this.txtMoney = new System.Windows.Forms.Label();
            this.line01 = new System.Windows.Forms.Label();
            this.numBZF = new Common.NumericUpDownEx();
            this.lblMoney = new System.Windows.Forms.Label();
            this.numBXF = new Common.NumericUpDownEx();
            this.numTYF = new Common.NumericUpDownEx();
            this.numJFTJ = new Common.NumericUpDownEx();
            this.lblSK_Type = new System.Windows.Forms.Label();
            this.numJFZL = new Common.NumericUpDownEx();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.numHW_JS = new Common.NumericUpDownEx();
            this.lblTYF = new System.Windows.Forms.Label();
            this.lblJFTJ = new System.Windows.Forms.Label();
            this.lblBZF = new System.Windows.Forms.Label();
            this.lblHW_JS = new System.Windows.Forms.Label();
            this.lblBXF = new System.Windows.Forms.Label();
            this.lblJFZL = new System.Windows.Forms.Label();
            this.grpHW = new System.Windows.Forms.GroupBox();
            this.txtFHR_Remark = new Common.TextBoxEx();
            this.txtHW_LX = new Common.TextBoxEx();
            this.txtFHR_Name = new Common.TextBoxEx();
            this.txtJHR_Mobile = new Common.TextBoxEx();
            this.txtJHR_Name = new Common.TextBoxEx();
            this.txtBXD_SN = new Common.TextBoxEx();
            this.txtHW_MC = new Common.TextBoxEx();
            this.numHW_BJ = new Common.NumericUpDownEx();
            this.txtFHR_Mobile = new Common.TextBoxEx();
            this.lblBXD_SN = new System.Windows.Forms.Label();
            this.lblFHR_Remark = new System.Windows.Forms.Label();
            this.lblHW_BJ = new System.Windows.Forms.Label();
            this.lblHW_MC = new System.Windows.Forms.Label();
            this.lblHW_LX = new System.Windows.Forms.Label();
            this.lblJHR_Mobile = new System.Windows.Forms.Label();
            this.lblJHR_Name = new System.Windows.Forms.Label();
            this.lblFHR_Mobile = new System.Windows.Forms.Label();
            this.lblFHR_Name = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpSets.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.grpBase.SuspendLayout();
            this.grpJF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBZF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBXF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTYF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJFTJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJFZL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHW_JS)).BeginInit();
            this.grpHW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHW_BJ)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSets
            // 
            this.grpSets.Controls.Add(this.chkTelService);
            this.grpSets.Controls.Add(this.chkSMSService);
            this.grpSets.Controls.Add(this.chkSecurityCheck);
            this.grpSets.ForeColor = System.Drawing.Color.Gray;
            this.grpSets.Location = new System.Drawing.Point(448, 488);
            this.grpSets.Name = "grpSets";
            this.grpSets.Size = new System.Drawing.Size(416, 56);
            this.grpSets.TabIndex = 4;
            this.grpSets.TabStop = false;
            this.grpSets.Text = "配置信息";
            // 
            // chkTelService
            // 
            this.chkTelService.AutoSize = true;
            this.chkTelService.Enabled = false;
            this.chkTelService.ForeColor = System.Drawing.Color.Blue;
            this.chkTelService.Location = new System.Drawing.Point(160, 24);
            this.chkTelService.Name = "chkTelService";
            this.chkTelService.Size = new System.Drawing.Size(96, 16);
            this.chkTelService.TabIndex = 1;
            this.chkTelService.Text = "电话通知服务";
            this.chkTelService.UseVisualStyleBackColor = true;
            // 
            // chkSMSService
            // 
            this.chkSMSService.AutoSize = true;
            this.chkSMSService.Enabled = false;
            this.chkSMSService.ForeColor = System.Drawing.Color.Blue;
            this.chkSMSService.Location = new System.Drawing.Point(296, 24);
            this.chkSMSService.Name = "chkSMSService";
            this.chkSMSService.Size = new System.Drawing.Size(96, 16);
            this.chkSMSService.TabIndex = 2;
            this.chkSMSService.Text = "短信通知服务";
            this.chkSMSService.UseVisualStyleBackColor = true;
            // 
            // chkSecurityCheck
            // 
            this.chkSecurityCheck.AutoSize = true;
            this.chkSecurityCheck.Enabled = false;
            this.chkSecurityCheck.ForeColor = System.Drawing.Color.Red;
            this.chkSecurityCheck.Location = new System.Drawing.Point(24, 24);
            this.chkSecurityCheck.Name = "chkSecurityCheck";
            this.chkSecurityCheck.Size = new System.Drawing.Size(96, 16);
            this.chkSecurityCheck.TabIndex = 0;
            this.chkSecurityCheck.Text = "开箱安全检查";
            this.chkSecurityCheck.UseVisualStyleBackColor = true;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.lblSN);
            this.InfoPanel.Controls.Add(this.lblSystemTime);
            this.InfoPanel.Controls.Add(this.txtSN);
            this.InfoPanel.Controls.Add(this.txtDT);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(881, 40);
            this.InfoPanel.TabIndex = 0;
            // 
            // lblSN
            // 
            this.lblSN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSN.ForeColor = System.Drawing.Color.Gray;
            this.lblSN.Location = new System.Drawing.Point(624, 8);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(95, 23);
            this.lblSN.TabIndex = 2;
            this.lblSN.Text = "单据号：";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSystemTime.ForeColor = System.Drawing.Color.Gray;
            this.lblSystemTime.Location = new System.Drawing.Point(24, 8);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(85, 23);
            this.lblSystemTime.TabIndex = 0;
            this.lblSystemTime.Text = "办单时间：";
            this.lblSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSN
            // 
            this.txtSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSN.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.txtSN.ForeColor = System.Drawing.Color.Red;
            this.txtSN.Location = new System.Drawing.Point(720, 8);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(149, 23);
            this.txtSN.TabIndex = 3;
            this.txtSN.Text = "000000000000";
            this.txtSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.txtDT.ForeColor = System.Drawing.Color.Blue;
            this.txtDT.Location = new System.Drawing.Point(112, 8);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(208, 24);
            this.txtDT.TabIndex = 1;
            this.txtDT.Text = "0000-00-00 00:00:00";
            this.txtDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBase
            // 
            this.grpBase.Controls.Add(this.cboFH_List);
            this.grpBase.Controls.Add(this.txtCZ_RQ);
            this.grpBase.Controls.Add(this.chkSyncToCentral);
            this.grpBase.Controls.Add(this.lstCZ);
            this.grpBase.Controls.Add(this.cboJH_List);
            this.grpBase.Controls.Add(this.cboCZ_DZ);
            this.grpBase.Controls.Add(this.lblCZ_DZ);
            this.grpBase.Controls.Add(this.lblCZ_RQ);
            this.grpBase.Controls.Add(this.lblJH_List);
            this.grpBase.Controls.Add(this.lblFH_List);
            this.grpBase.ForeColor = System.Drawing.Color.Gray;
            this.grpBase.Location = new System.Drawing.Point(24, 56);
            this.grpBase.Name = "grpBase";
            this.grpBase.Size = new System.Drawing.Size(416, 488);
            this.grpBase.TabIndex = 1;
            this.grpBase.TabStop = false;
            this.grpBase.Text = "承运信息";
            // 
            // cboFH_List
            // 
            this.cboFH_List.AutoSelectNextControl = true;
            this.cboFH_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFH_List.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.cboFH_List.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.cboFH_List.Enabled = false;
            this.cboFH_List.EnterSelectAll = true;
            this.cboFH_List.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboFH_List.FormattingEnabled = true;
            this.cboFH_List.Location = new System.Drawing.Point(96, 32);
            this.cboFH_List.MustNonEmpty = true;
            this.cboFH_List.Name = "cboFH_List";
            this.cboFH_List.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.cboFH_List.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.cboFH_List.Size = new System.Drawing.Size(304, 20);
            this.cboFH_List.TabIndex = 10;
            this.cboFH_List.TabStop = false;
            this.cboFH_List.SelectedIndexChanged += new System.EventHandler(this.cboFH_List_SelectedIndexChanged);
            // 
            // txtCZ_RQ
            // 
            this.txtCZ_RQ.AutoSelectNextControl = true;
            this.txtCZ_RQ.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtCZ_RQ.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCZ_RQ.Enabled = false;
            this.txtCZ_RQ.EnterSelectAll = true;
            this.txtCZ_RQ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCZ_RQ.Location = new System.Drawing.Point(96, 128);
            this.txtCZ_RQ.MaxLength = 16;
            this.txtCZ_RQ.MustNonEmpty = true;
            this.txtCZ_RQ.Name = "txtCZ_RQ";
            this.txtCZ_RQ.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtCZ_RQ.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCZ_RQ.ReadOnly = true;
            this.txtCZ_RQ.Size = new System.Drawing.Size(112, 21);
            this.txtCZ_RQ.TabIndex = 6;
            // 
            // chkSyncToCentral
            // 
            this.chkSyncToCentral.AutoSize = true;
            this.chkSyncToCentral.Enabled = false;
            this.chkSyncToCentral.ForeColor = System.Drawing.Color.Gray;
            this.chkSyncToCentral.Location = new System.Drawing.Point(96, 96);
            this.chkSyncToCentral.Name = "chkSyncToCentral";
            this.chkSyncToCentral.Size = new System.Drawing.Size(168, 16);
            this.chkSyncToCentral.TabIndex = 4;
            this.chkSyncToCentral.Text = "同步提交运单到中央服务器";
            this.chkSyncToCentral.UseVisualStyleBackColor = true;
            this.chkSyncToCentral.EnabledChanged += new System.EventHandler(this.chkSyncToCentral_EnabledChanged);
            // 
            // lstCZ
            // 
            this.lstCZ.BackColor = System.Drawing.Color.AliceBlue;
            this.lstCZ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCPH,
            this.columnBC,
            this.columnSJ,
            this.columnLC,
            this.columnZT});
            this.lstCZ.Enabled = false;
            this.lstCZ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstCZ.FullRowSelect = true;
            this.lstCZ.HideSelection = false;
            this.lstCZ.Location = new System.Drawing.Point(16, 160);
            this.lstCZ.MultiSelect = false;
            this.lstCZ.Name = "lstCZ";
            this.lstCZ.OneColor = System.Drawing.SystemColors.Window;
            this.lstCZ.Size = new System.Drawing.Size(384, 312);
            this.lstCZ.TabIndex = 9;
            this.lstCZ.TwoColor = System.Drawing.SystemColors.Window;
            this.lstCZ.UseCompatibleStateImageBehavior = false;
            this.lstCZ.View = System.Windows.Forms.View.Details;
            // 
            // columnCPH
            // 
            this.columnCPH.Text = "车牌号";
            this.columnCPH.Width = 85;
            // 
            // columnBC
            // 
            this.columnBC.Text = "班次";
            this.columnBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBC.Width = 70;
            // 
            // columnSJ
            // 
            this.columnSJ.Text = "时间";
            this.columnSJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSJ.Width = 70;
            // 
            // columnLC
            // 
            this.columnLC.Text = "里程";
            this.columnLC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLC.Width = 70;
            // 
            // columnZT
            // 
            this.columnZT.Text = "状态";
            this.columnZT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboJH_List
            // 
            this.cboJH_List.AutoSelectNextControl = true;
            this.cboJH_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJH_List.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.cboJH_List.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.cboJH_List.EnterSelectAll = true;
            this.cboJH_List.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboJH_List.FormattingEnabled = true;
            this.cboJH_List.Location = new System.Drawing.Point(96, 64);
            this.cboJH_List.MustNonEmpty = true;
            this.cboJH_List.Name = "cboJH_List";
            this.cboJH_List.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.cboJH_List.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.cboJH_List.Size = new System.Drawing.Size(304, 20);
            this.cboJH_List.TabIndex = 3;
            this.cboJH_List.TabStop = false;
            this.cboJH_List.SelectedIndexChanged += new System.EventHandler(this.cboJH_List_SelectedIndexChanged);
            // 
            // cboCZ_DZ
            // 
            this.cboCZ_DZ.AutoSelectNextControl = true;
            this.cboCZ_DZ.BackColor = System.Drawing.Color.AliceBlue;
            this.cboCZ_DZ.DisplayMember = "Name";
            this.cboCZ_DZ.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.cboCZ_DZ.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCZ_DZ.Enabled = false;
            this.cboCZ_DZ.EnterSelectAll = true;
            this.cboCZ_DZ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCZ_DZ.FormattingEnabled = true;
            this.cboCZ_DZ.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cboCZ_DZ.Location = new System.Drawing.Point(296, 128);
            this.cboCZ_DZ.MustNonEmpty = true;
            this.cboCZ_DZ.Name = "cboCZ_DZ";
            this.cboCZ_DZ.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.cboCZ_DZ.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCZ_DZ.Size = new System.Drawing.Size(104, 20);
            this.cboCZ_DZ.TabIndex = 8;
            this.cboCZ_DZ.SelectedIndexChanged += new System.EventHandler(this.cboCZ_DZ_SelectedIndexChanged);
            this.cboCZ_DZ.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboCZ_DZ_KeyUp);
            // 
            // lblCZ_DZ
            // 
            this.lblCZ_DZ.ForeColor = System.Drawing.Color.Gray;
            this.lblCZ_DZ.Location = new System.Drawing.Point(232, 128);
            this.lblCZ_DZ.Name = "lblCZ_DZ";
            this.lblCZ_DZ.Size = new System.Drawing.Size(64, 23);
            this.lblCZ_DZ.TabIndex = 7;
            this.lblCZ_DZ.Text = "到站：";
            this.lblCZ_DZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCZ_RQ
            // 
            this.lblCZ_RQ.ForeColor = System.Drawing.Color.Gray;
            this.lblCZ_RQ.Location = new System.Drawing.Point(16, 128);
            this.lblCZ_RQ.Name = "lblCZ_RQ";
            this.lblCZ_RQ.Size = new System.Drawing.Size(72, 23);
            this.lblCZ_RQ.TabIndex = 5;
            this.lblCZ_RQ.Text = "承运日期：";
            this.lblCZ_RQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJH_List
            // 
            this.lblJH_List.ForeColor = System.Drawing.Color.Gray;
            this.lblJH_List.Location = new System.Drawing.Point(16, 64);
            this.lblJH_List.Name = "lblJH_List";
            this.lblJH_List.Size = new System.Drawing.Size(72, 23);
            this.lblJH_List.TabIndex = 2;
            this.lblJH_List.Text = "接货网点：";
            this.lblJH_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFH_List
            // 
            this.lblFH_List.ForeColor = System.Drawing.Color.Gray;
            this.lblFH_List.Location = new System.Drawing.Point(16, 32);
            this.lblFH_List.Name = "lblFH_List";
            this.lblFH_List.Size = new System.Drawing.Size(72, 23);
            this.lblFH_List.TabIndex = 0;
            this.lblFH_List.Text = "发货网点：";
            this.lblFH_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(752, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // grpJF
            // 
            this.grpJF.Controls.Add(this.txtSK_Type);
            this.grpJF.Controls.Add(this.txtMoney);
            this.grpJF.Controls.Add(this.line01);
            this.grpJF.Controls.Add(this.numBZF);
            this.grpJF.Controls.Add(this.lblMoney);
            this.grpJF.Controls.Add(this.numBXF);
            this.grpJF.Controls.Add(this.numTYF);
            this.grpJF.Controls.Add(this.numJFTJ);
            this.grpJF.Controls.Add(this.lblSK_Type);
            this.grpJF.Controls.Add(this.numJFZL);
            this.grpJF.Controls.Add(this.lblTotal);
            this.grpJF.Controls.Add(this.txtTotal);
            this.grpJF.Controls.Add(this.numHW_JS);
            this.grpJF.Controls.Add(this.lblTYF);
            this.grpJF.Controls.Add(this.lblJFTJ);
            this.grpJF.Controls.Add(this.lblBZF);
            this.grpJF.Controls.Add(this.lblHW_JS);
            this.grpJF.Controls.Add(this.lblBXF);
            this.grpJF.Controls.Add(this.lblJFZL);
            this.grpJF.ForeColor = System.Drawing.Color.Gray;
            this.grpJF.Location = new System.Drawing.Point(448, 256);
            this.grpJF.Name = "grpJF";
            this.grpJF.Size = new System.Drawing.Size(416, 224);
            this.grpJF.TabIndex = 3;
            this.grpJF.TabStop = false;
            this.grpJF.Text = "计费信息（体积单位：公斤；体积单位：平方米）";
            // 
            // txtSK_Type
            // 
            this.txtSK_Type.AutoSelectNextControl = true;
            this.txtSK_Type.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtSK_Type.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSK_Type.Enabled = false;
            this.txtSK_Type.EnterSelectAll = true;
            this.txtSK_Type.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSK_Type.Location = new System.Drawing.Point(104, 128);
            this.txtSK_Type.MaxLength = 16;
            this.txtSK_Type.MustNonEmpty = true;
            this.txtSK_Type.Name = "txtSK_Type";
            this.txtSK_Type.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtSK_Type.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSK_Type.ReadOnly = true;
            this.txtSK_Type.Size = new System.Drawing.Size(96, 21);
            this.txtSK_Type.TabIndex = 11;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.ForeColor = System.Drawing.Color.Blue;
            this.txtMoney.Location = new System.Drawing.Point(312, 184);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(96, 24);
            this.txtMoney.TabIndex = 18;
            this.txtMoney.Text = "0.00";
            this.txtMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // line01
            // 
            this.line01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line01.ForeColor = System.Drawing.Color.Gray;
            this.line01.Location = new System.Drawing.Point(16, 168);
            this.line01.Name = "line01";
            this.line01.Size = new System.Drawing.Size(392, 2);
            this.line01.TabIndex = 14;
            this.line01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBZF
            // 
            this.numBZF.AutoSelectNextControl = true;
            this.numBZF.DecimalPlaces = 2;
            this.numBZF.Enabled = false;
            this.numBZF.EnterSelectAll = true;
            this.numBZF.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numBZF.ForeColor = System.Drawing.Color.Blue;
            this.numBZF.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numBZF.Location = new System.Drawing.Point(312, 128);
            this.numBZF.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBZF.MustNonZero = true;
            this.numBZF.Name = "numBZF";
            this.numBZF.NonZeroBackColor = System.Drawing.SystemColors.Window;
            this.numBZF.NonZeroForeColor = System.Drawing.SystemColors.WindowText;
            this.numBZF.ReadOnly = true;
            this.numBZF.Size = new System.Drawing.Size(96, 21);
            this.numBZF.TabIndex = 13;
            this.numBZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBZF.ZeroBackColor = System.Drawing.SystemColors.Window;
            this.numBZF.ZeroForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // lblMoney
            // 
            this.lblMoney.ForeColor = System.Drawing.Color.Gray;
            this.lblMoney.Location = new System.Drawing.Point(224, 184);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(88, 23);
            this.lblMoney.TabIndex = 17;
            this.lblMoney.Text = "实收金额：";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBXF
            // 
            this.numBXF.AutoSelectNextControl = true;
            this.numBXF.DecimalPlaces = 2;
            this.numBXF.Enabled = false;
            this.numBXF.EnterSelectAll = true;
            this.numBXF.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numBXF.ForeColor = System.Drawing.Color.Blue;
            this.numBXF.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numBXF.Location = new System.Drawing.Point(312, 96);
            this.numBXF.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBXF.MustNonZero = true;
            this.numBXF.Name = "numBXF";
            this.numBXF.NonZeroBackColor = System.Drawing.SystemColors.Window;
            this.numBXF.NonZeroForeColor = System.Drawing.SystemColors.WindowText;
            this.numBXF.ReadOnly = true;
            this.numBXF.Size = new System.Drawing.Size(96, 21);
            this.numBXF.TabIndex = 9;
            this.numBXF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBXF.ZeroBackColor = System.Drawing.SystemColors.Window;
            this.numBXF.ZeroForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // numTYF
            // 
            this.numTYF.AutoSelectNextControl = true;
            this.numTYF.BackColor = System.Drawing.SystemColors.Control;
            this.numTYF.DecimalPlaces = 2;
            this.numTYF.Enabled = false;
            this.numTYF.EnterSelectAll = true;
            this.numTYF.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numTYF.ForeColor = System.Drawing.Color.Blue;
            this.numTYF.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numTYF.Location = new System.Drawing.Point(312, 64);
            this.numTYF.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numTYF.MustNonZero = true;
            this.numTYF.Name = "numTYF";
            this.numTYF.NonZeroBackColor = System.Drawing.SystemColors.Window;
            this.numTYF.NonZeroForeColor = System.Drawing.SystemColors.WindowText;
            this.numTYF.ReadOnly = true;
            this.numTYF.Size = new System.Drawing.Size(96, 21);
            this.numTYF.TabIndex = 7;
            this.numTYF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTYF.ZeroBackColor = System.Drawing.SystemColors.Window;
            this.numTYF.ZeroForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // numJFTJ
            // 
            this.numJFTJ.AutoSelectNextControl = true;
            this.numJFTJ.DecimalPlaces = 1;
            this.numJFTJ.EnterSelectAll = true;
            this.numJFTJ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numJFTJ.ForeColor = System.Drawing.Color.Green;
            this.numJFTJ.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numJFTJ.Location = new System.Drawing.Point(104, 64);
            this.numJFTJ.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numJFTJ.MustNonZero = true;
            this.numJFTJ.Name = "numJFTJ";
            this.numJFTJ.NonZeroBackColor = System.Drawing.SystemColors.Window;
            this.numJFTJ.NonZeroForeColor = System.Drawing.SystemColors.WindowText;
            this.numJFTJ.ReadOnly = true;
            this.numJFTJ.Size = new System.Drawing.Size(96, 21);
            this.numJFTJ.TabIndex = 5;
            this.numJFTJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numJFTJ.ZeroBackColor = System.Drawing.SystemColors.Window;
            this.numJFTJ.ZeroForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // lblSK_Type
            // 
            this.lblSK_Type.ForeColor = System.Drawing.Color.Gray;
            this.lblSK_Type.Location = new System.Drawing.Point(16, 128);
            this.lblSK_Type.Name = "lblSK_Type";
            this.lblSK_Type.Size = new System.Drawing.Size(88, 23);
            this.lblSK_Type.TabIndex = 10;
            this.lblSK_Type.Text = "收款类型：";
            this.lblSK_Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numJFZL
            // 
            this.numJFZL.AutoSelectNextControl = true;
            this.numJFZL.DecimalPlaces = 1;
            this.numJFZL.EnterSelectAll = true;
            this.numJFZL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numJFZL.ForeColor = System.Drawing.Color.Green;
            this.numJFZL.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numJFZL.Location = new System.Drawing.Point(104, 32);
            this.numJFZL.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numJFZL.MustNonZero = true;
            this.numJFZL.Name = "numJFZL";
            this.numJFZL.NonZeroBackColor = System.Drawing.SystemColors.Window;
            this.numJFZL.NonZeroForeColor = System.Drawing.SystemColors.WindowText;
            this.numJFZL.ReadOnly = true;
            this.numJFZL.Size = new System.Drawing.Size(96, 21);
            this.numJFZL.TabIndex = 1;
            this.numJFZL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numJFZL.ZeroBackColor = System.Drawing.SystemColors.Window;
            this.numJFZL.ZeroForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // lblTotal
            // 
            this.lblTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblTotal.Location = new System.Drawing.Point(16, 184);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 23);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "应收金额：";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(104, 184);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 24);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numHW_JS
            // 
            this.numHW_JS.AutoSelectNextControl = true;
            this.numHW_JS.Enabled = false;
            this.numHW_JS.EnterSelectAll = true;
            this.numHW_JS.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numHW_JS.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numHW_JS.Location = new System.Drawing.Point(312, 32);
            this.numHW_JS.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numHW_JS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHW_JS.MustNonZero = true;
            this.numHW_JS.Name = "numHW_JS";
            this.numHW_JS.NonZeroBackColor = System.Drawing.SystemColors.Window;
            this.numHW_JS.NonZeroForeColor = System.Drawing.SystemColors.WindowText;
            this.numHW_JS.ReadOnly = true;
            this.numHW_JS.Size = new System.Drawing.Size(96, 21);
            this.numHW_JS.TabIndex = 3;
            this.numHW_JS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHW_JS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHW_JS.ZeroBackColor = System.Drawing.SystemColors.Window;
            this.numHW_JS.ZeroForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // lblTYF
            // 
            this.lblTYF.ForeColor = System.Drawing.Color.Gray;
            this.lblTYF.Location = new System.Drawing.Point(224, 64);
            this.lblTYF.Name = "lblTYF";
            this.lblTYF.Size = new System.Drawing.Size(88, 23);
            this.lblTYF.TabIndex = 6;
            this.lblTYF.Text = "托运费：";
            this.lblTYF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJFTJ
            // 
            this.lblJFTJ.ForeColor = System.Drawing.Color.Gray;
            this.lblJFTJ.Location = new System.Drawing.Point(16, 64);
            this.lblJFTJ.Name = "lblJFTJ";
            this.lblJFTJ.Size = new System.Drawing.Size(88, 23);
            this.lblJFTJ.TabIndex = 4;
            this.lblJFTJ.Text = "计费体积：";
            this.lblJFTJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBZF
            // 
            this.lblBZF.ForeColor = System.Drawing.Color.Gray;
            this.lblBZF.Location = new System.Drawing.Point(224, 128);
            this.lblBZF.Name = "lblBZF";
            this.lblBZF.Size = new System.Drawing.Size(88, 23);
            this.lblBZF.TabIndex = 12;
            this.lblBZF.Text = "包装费：";
            this.lblBZF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHW_JS
            // 
            this.lblHW_JS.ForeColor = System.Drawing.Color.Gray;
            this.lblHW_JS.Location = new System.Drawing.Point(224, 32);
            this.lblHW_JS.Name = "lblHW_JS";
            this.lblHW_JS.Size = new System.Drawing.Size(88, 23);
            this.lblHW_JS.TabIndex = 2;
            this.lblHW_JS.Text = "货物件数：";
            this.lblHW_JS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBXF
            // 
            this.lblBXF.ForeColor = System.Drawing.Color.Gray;
            this.lblBXF.Location = new System.Drawing.Point(224, 96);
            this.lblBXF.Name = "lblBXF";
            this.lblBXF.Size = new System.Drawing.Size(88, 23);
            this.lblBXF.TabIndex = 8;
            this.lblBXF.Text = "保险费：";
            this.lblBXF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJFZL
            // 
            this.lblJFZL.ForeColor = System.Drawing.Color.Gray;
            this.lblJFZL.Location = new System.Drawing.Point(16, 32);
            this.lblJFZL.Name = "lblJFZL";
            this.lblJFZL.Size = new System.Drawing.Size(88, 23);
            this.lblJFZL.TabIndex = 0;
            this.lblJFZL.Text = "计费重量：";
            this.lblJFZL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpHW
            // 
            this.grpHW.Controls.Add(this.txtFHR_Remark);
            this.grpHW.Controls.Add(this.txtHW_LX);
            this.grpHW.Controls.Add(this.txtFHR_Name);
            this.grpHW.Controls.Add(this.txtJHR_Mobile);
            this.grpHW.Controls.Add(this.txtJHR_Name);
            this.grpHW.Controls.Add(this.txtBXD_SN);
            this.grpHW.Controls.Add(this.txtHW_MC);
            this.grpHW.Controls.Add(this.numHW_BJ);
            this.grpHW.Controls.Add(this.txtFHR_Mobile);
            this.grpHW.Controls.Add(this.lblBXD_SN);
            this.grpHW.Controls.Add(this.lblFHR_Remark);
            this.grpHW.Controls.Add(this.lblHW_BJ);
            this.grpHW.Controls.Add(this.lblHW_MC);
            this.grpHW.Controls.Add(this.lblHW_LX);
            this.grpHW.Controls.Add(this.lblJHR_Mobile);
            this.grpHW.Controls.Add(this.lblJHR_Name);
            this.grpHW.Controls.Add(this.lblFHR_Mobile);
            this.grpHW.Controls.Add(this.lblFHR_Name);
            this.grpHW.ForeColor = System.Drawing.Color.Gray;
            this.grpHW.Location = new System.Drawing.Point(448, 56);
            this.grpHW.Name = "grpHW";
            this.grpHW.Size = new System.Drawing.Size(416, 192);
            this.grpHW.TabIndex = 2;
            this.grpHW.TabStop = false;
            this.grpHW.Text = "货物信息";
            // 
            // txtFHR_Remark
            // 
            this.txtFHR_Remark.AutoSelectNextControl = true;
            this.txtFHR_Remark.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtFHR_Remark.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFHR_Remark.Enabled = false;
            this.txtFHR_Remark.EnterSelectAll = true;
            this.txtFHR_Remark.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFHR_Remark.Location = new System.Drawing.Point(104, 152);
            this.txtFHR_Remark.MaxLength = 16;
            this.txtFHR_Remark.MustNonEmpty = true;
            this.txtFHR_Remark.Name = "txtFHR_Remark";
            this.txtFHR_Remark.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtFHR_Remark.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFHR_Remark.ReadOnly = true;
            this.txtFHR_Remark.Size = new System.Drawing.Size(304, 21);
            this.txtFHR_Remark.TabIndex = 17;
            // 
            // txtHW_LX
            // 
            this.txtHW_LX.AutoSelectNextControl = true;
            this.txtHW_LX.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtHW_LX.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHW_LX.Enabled = false;
            this.txtHW_LX.EnterSelectAll = true;
            this.txtHW_LX.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHW_LX.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHW_LX.Location = new System.Drawing.Point(312, 24);
            this.txtHW_LX.MaxLength = 16;
            this.txtHW_LX.MustNonEmpty = true;
            this.txtHW_LX.Name = "txtHW_LX";
            this.txtHW_LX.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtHW_LX.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHW_LX.ReadOnly = true;
            this.txtHW_LX.Size = new System.Drawing.Size(96, 21);
            this.txtHW_LX.TabIndex = 3;
            // 
            // txtFHR_Name
            // 
            this.txtFHR_Name.AutoSelectNextControl = true;
            this.txtFHR_Name.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtFHR_Name.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFHR_Name.Enabled = false;
            this.txtFHR_Name.EnterSelectAll = true;
            this.txtFHR_Name.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFHR_Name.Location = new System.Drawing.Point(104, 120);
            this.txtFHR_Name.MaxLength = 16;
            this.txtFHR_Name.MustNonEmpty = true;
            this.txtFHR_Name.Name = "txtFHR_Name";
            this.txtFHR_Name.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtFHR_Name.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFHR_Name.ReadOnly = true;
            this.txtFHR_Name.Size = new System.Drawing.Size(96, 21);
            this.txtFHR_Name.TabIndex = 13;
            // 
            // txtJHR_Mobile
            // 
            this.txtJHR_Mobile.AutoSelectNextControl = true;
            this.txtJHR_Mobile.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtJHR_Mobile.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJHR_Mobile.Enabled = false;
            this.txtJHR_Mobile.EnterSelectAll = true;
            this.txtJHR_Mobile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJHR_Mobile.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtJHR_Mobile.Location = new System.Drawing.Point(312, 88);
            this.txtJHR_Mobile.MaxLength = 16;
            this.txtJHR_Mobile.MustNonEmpty = true;
            this.txtJHR_Mobile.Name = "txtJHR_Mobile";
            this.txtJHR_Mobile.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtJHR_Mobile.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJHR_Mobile.ReadOnly = true;
            this.txtJHR_Mobile.Size = new System.Drawing.Size(96, 21);
            this.txtJHR_Mobile.TabIndex = 11;
            // 
            // txtJHR_Name
            // 
            this.txtJHR_Name.AutoSelectNextControl = true;
            this.txtJHR_Name.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtJHR_Name.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJHR_Name.Enabled = false;
            this.txtJHR_Name.EnterSelectAll = true;
            this.txtJHR_Name.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJHR_Name.Location = new System.Drawing.Point(312, 120);
            this.txtJHR_Name.MaxLength = 16;
            this.txtJHR_Name.MustNonEmpty = true;
            this.txtJHR_Name.Name = "txtJHR_Name";
            this.txtJHR_Name.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtJHR_Name.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJHR_Name.ReadOnly = true;
            this.txtJHR_Name.Size = new System.Drawing.Size(96, 21);
            this.txtJHR_Name.TabIndex = 15;
            // 
            // txtBXD_SN
            // 
            this.txtBXD_SN.AutoSelectNextControl = true;
            this.txtBXD_SN.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtBXD_SN.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBXD_SN.Enabled = false;
            this.txtBXD_SN.EnterSelectAll = true;
            this.txtBXD_SN.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBXD_SN.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtBXD_SN.Location = new System.Drawing.Point(312, 56);
            this.txtBXD_SN.MaxLength = 16;
            this.txtBXD_SN.MustNonEmpty = true;
            this.txtBXD_SN.Name = "txtBXD_SN";
            this.txtBXD_SN.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtBXD_SN.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBXD_SN.ReadOnly = true;
            this.txtBXD_SN.Size = new System.Drawing.Size(96, 21);
            this.txtBXD_SN.TabIndex = 7;
            // 
            // txtHW_MC
            // 
            this.txtHW_MC.AutoSelectNextControl = true;
            this.txtHW_MC.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtHW_MC.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHW_MC.Enabled = false;
            this.txtHW_MC.EnterSelectAll = true;
            this.txtHW_MC.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHW_MC.Location = new System.Drawing.Point(104, 24);
            this.txtHW_MC.MaxLength = 16;
            this.txtHW_MC.MustNonEmpty = true;
            this.txtHW_MC.Name = "txtHW_MC";
            this.txtHW_MC.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtHW_MC.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHW_MC.ReadOnly = true;
            this.txtHW_MC.Size = new System.Drawing.Size(96, 21);
            this.txtHW_MC.TabIndex = 1;
            // 
            // numHW_BJ
            // 
            this.numHW_BJ.AutoSelectNextControl = true;
            this.numHW_BJ.DecimalPlaces = 2;
            this.numHW_BJ.Enabled = false;
            this.numHW_BJ.EnterSelectAll = true;
            this.numHW_BJ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numHW_BJ.ForeColor = System.Drawing.Color.Blue;
            this.numHW_BJ.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numHW_BJ.Location = new System.Drawing.Point(104, 56);
            this.numHW_BJ.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numHW_BJ.MustNonZero = true;
            this.numHW_BJ.Name = "numHW_BJ";
            this.numHW_BJ.NonZeroBackColor = System.Drawing.SystemColors.Window;
            this.numHW_BJ.NonZeroForeColor = System.Drawing.SystemColors.WindowText;
            this.numHW_BJ.ReadOnly = true;
            this.numHW_BJ.Size = new System.Drawing.Size(96, 21);
            this.numHW_BJ.TabIndex = 5;
            this.numHW_BJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHW_BJ.ZeroBackColor = System.Drawing.SystemColors.Window;
            this.numHW_BJ.ZeroForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // txtFHR_Mobile
            // 
            this.txtFHR_Mobile.AutoSelectNextControl = true;
            this.txtFHR_Mobile.EmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtFHR_Mobile.EmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFHR_Mobile.Enabled = false;
            this.txtFHR_Mobile.EnterSelectAll = true;
            this.txtFHR_Mobile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFHR_Mobile.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtFHR_Mobile.Location = new System.Drawing.Point(104, 88);
            this.txtFHR_Mobile.MaxLength = 16;
            this.txtFHR_Mobile.MustNonEmpty = true;
            this.txtFHR_Mobile.Name = "txtFHR_Mobile";
            this.txtFHR_Mobile.NonEmptyBackColor = System.Drawing.SystemColors.Window;
            this.txtFHR_Mobile.NonEmptyForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFHR_Mobile.ReadOnly = true;
            this.txtFHR_Mobile.Size = new System.Drawing.Size(96, 21);
            this.txtFHR_Mobile.TabIndex = 9;
            // 
            // lblBXD_SN
            // 
            this.lblBXD_SN.ForeColor = System.Drawing.Color.Gray;
            this.lblBXD_SN.Location = new System.Drawing.Point(224, 56);
            this.lblBXD_SN.Name = "lblBXD_SN";
            this.lblBXD_SN.Size = new System.Drawing.Size(88, 23);
            this.lblBXD_SN.TabIndex = 6;
            this.lblBXD_SN.Text = "保险单编号：";
            this.lblBXD_SN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFHR_Remark
            // 
            this.lblFHR_Remark.ForeColor = System.Drawing.Color.Gray;
            this.lblFHR_Remark.Location = new System.Drawing.Point(16, 152);
            this.lblFHR_Remark.Name = "lblFHR_Remark";
            this.lblFHR_Remark.Size = new System.Drawing.Size(88, 23);
            this.lblFHR_Remark.TabIndex = 16;
            this.lblFHR_Remark.Text = "备注：";
            this.lblFHR_Remark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHW_BJ
            // 
            this.lblHW_BJ.ForeColor = System.Drawing.Color.Gray;
            this.lblHW_BJ.Location = new System.Drawing.Point(16, 56);
            this.lblHW_BJ.Name = "lblHW_BJ";
            this.lblHW_BJ.Size = new System.Drawing.Size(88, 23);
            this.lblHW_BJ.TabIndex = 4;
            this.lblHW_BJ.Text = "声明保险金：";
            this.lblHW_BJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHW_MC
            // 
            this.lblHW_MC.ForeColor = System.Drawing.Color.Gray;
            this.lblHW_MC.Location = new System.Drawing.Point(16, 24);
            this.lblHW_MC.Name = "lblHW_MC";
            this.lblHW_MC.Size = new System.Drawing.Size(88, 23);
            this.lblHW_MC.TabIndex = 0;
            this.lblHW_MC.Text = "货物名称：";
            this.lblHW_MC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHW_LX
            // 
            this.lblHW_LX.ForeColor = System.Drawing.Color.Gray;
            this.lblHW_LX.Location = new System.Drawing.Point(224, 24);
            this.lblHW_LX.Name = "lblHW_LX";
            this.lblHW_LX.Size = new System.Drawing.Size(88, 23);
            this.lblHW_LX.TabIndex = 2;
            this.lblHW_LX.Text = "货物类型：";
            this.lblHW_LX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJHR_Mobile
            // 
            this.lblJHR_Mobile.ForeColor = System.Drawing.Color.Gray;
            this.lblJHR_Mobile.Location = new System.Drawing.Point(224, 88);
            this.lblJHR_Mobile.Name = "lblJHR_Mobile";
            this.lblJHR_Mobile.Size = new System.Drawing.Size(88, 23);
            this.lblJHR_Mobile.TabIndex = 10;
            this.lblJHR_Mobile.Text = "收货人电话：";
            this.lblJHR_Mobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJHR_Name
            // 
            this.lblJHR_Name.ForeColor = System.Drawing.Color.Gray;
            this.lblJHR_Name.Location = new System.Drawing.Point(224, 120);
            this.lblJHR_Name.Name = "lblJHR_Name";
            this.lblJHR_Name.Size = new System.Drawing.Size(88, 23);
            this.lblJHR_Name.TabIndex = 14;
            this.lblJHR_Name.Text = "收货人名称：";
            this.lblJHR_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFHR_Mobile
            // 
            this.lblFHR_Mobile.ForeColor = System.Drawing.Color.Gray;
            this.lblFHR_Mobile.Location = new System.Drawing.Point(16, 88);
            this.lblFHR_Mobile.Name = "lblFHR_Mobile";
            this.lblFHR_Mobile.Size = new System.Drawing.Size(88, 23);
            this.lblFHR_Mobile.TabIndex = 8;
            this.lblFHR_Mobile.Text = "发货人电话：";
            this.lblFHR_Mobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFHR_Name
            // 
            this.lblFHR_Name.ForeColor = System.Drawing.Color.Gray;
            this.lblFHR_Name.Location = new System.Drawing.Point(16, 120);
            this.lblFHR_Name.Name = "lblFHR_Name";
            this.lblFHR_Name.Size = new System.Drawing.Size(88, 23);
            this.lblFHR_Name.TabIndex = 12;
            this.lblFHR_Name.Text = "发货人名称：";
            this.lblFHR_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(608, 560);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 32);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 609);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpSets);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.grpBase);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpJF);
            this.Controls.Add(this.grpHW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑运单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.grpSets.ResumeLayout(false);
            this.grpSets.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.grpBase.ResumeLayout(false);
            this.grpBase.PerformLayout();
            this.grpJF.ResumeLayout(false);
            this.grpJF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBZF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBXF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTYF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJFTJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJFZL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHW_JS)).EndInit();
            this.grpHW.ResumeLayout(false);
            this.grpHW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHW_BJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSets;
        private System.Windows.Forms.CheckBox chkTelService;
        private System.Windows.Forms.CheckBox chkSMSService;
        private System.Windows.Forms.CheckBox chkSecurityCheck;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.Label txtSN;
        private System.Windows.Forms.Label txtDT;
        private System.Windows.Forms.GroupBox grpBase;
        private System.Windows.Forms.CheckBox chkSyncToCentral;
        private Common.ListViewEx lstCZ;
        private System.Windows.Forms.ColumnHeader columnCPH;
        private System.Windows.Forms.ColumnHeader columnBC;
        private System.Windows.Forms.ColumnHeader columnSJ;
        private System.Windows.Forms.ColumnHeader columnLC;
        private System.Windows.Forms.ColumnHeader columnZT;
        private Common.ComboBoxEx cboJH_List;
        private Common.ComboBoxEx cboCZ_DZ;
        private System.Windows.Forms.Label lblCZ_DZ;
        private System.Windows.Forms.Label lblCZ_RQ;
        private System.Windows.Forms.Label lblJH_List;
        private System.Windows.Forms.Label lblFH_List;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpJF;
        private System.Windows.Forms.Label line01;
        private Common.NumericUpDownEx numBZF;
        private System.Windows.Forms.Label lblMoney;
        private Common.NumericUpDownEx numBXF;
        private Common.NumericUpDownEx numTYF;
        private Common.NumericUpDownEx numJFTJ;
        private System.Windows.Forms.Label lblSK_Type;
        private Common.NumericUpDownEx numJFZL;
        private Common.NumericUpDownEx numHW_JS;
        private System.Windows.Forms.Label lblTYF;
        private System.Windows.Forms.Label lblJFTJ;
        private System.Windows.Forms.Label lblBZF;
        private System.Windows.Forms.Label lblHW_JS;
        private System.Windows.Forms.Label lblBXF;
        private System.Windows.Forms.Label lblJFZL;
        private System.Windows.Forms.GroupBox grpHW;
        private Common.TextBoxEx txtFHR_Name;
        private Common.TextBoxEx txtJHR_Mobile;
        private Common.TextBoxEx txtJHR_Name;
        private Common.TextBoxEx txtBXD_SN;
        private Common.TextBoxEx txtHW_MC;
        private Common.NumericUpDownEx numHW_BJ;
        private Common.TextBoxEx txtFHR_Mobile;
        private System.Windows.Forms.Label lblBXD_SN;
        private System.Windows.Forms.Label lblFHR_Remark;
        private System.Windows.Forms.Label lblHW_BJ;
        private System.Windows.Forms.Label lblHW_MC;
        private System.Windows.Forms.Label lblHW_LX;
        private System.Windows.Forms.Label lblJHR_Mobile;
        private System.Windows.Forms.Label lblJHR_Name;
        private System.Windows.Forms.Label lblFHR_Mobile;
        private System.Windows.Forms.Label lblFHR_Name;
        private System.Windows.Forms.Label txtMoney;
        private System.Windows.Forms.Button btnOk;
        private Common.TextBoxEx txtHW_LX;
        private Common.TextBoxEx txtFHR_Remark;
        private Common.TextBoxEx txtSK_Type;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label txtTotal;
        private Common.TextBoxEx txtCZ_RQ;
        private Common.ComboBoxEx cboFH_List;
    }
}