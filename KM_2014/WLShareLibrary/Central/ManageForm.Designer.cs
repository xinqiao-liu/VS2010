namespace WLCommon.Central
{
    partial class ManageForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miJH = new System.Windows.Forms.ToolStripMenuItem();
            this.miZC = new System.Windows.Forms.ToolStripMenuItem();
            this.miXC = new System.Windows.Forms.ToolStripMenuItem();
            this.miQH = new System.Windows.Forms.ToolStripMenuItem();
            this.miFD = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine01 = new System.Windows.Forms.ToolStripSeparator();
            this.miRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnJH = new System.Windows.Forms.Button();
            this.btnFD = new System.Windows.Forms.Button();
            this.btnQH = new System.Windows.Forms.Button();
            this.btnXC = new System.Windows.Forms.Button();
            this.btnZC = new System.Windows.Forms.Button();
            this.cboSelectDate = new System.Windows.Forms.ComboBox();
            this.lblSelectDate = new System.Windows.Forms.Label();
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
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miJH,
            this.miZC,
            this.miXC,
            this.miQH,
            this.miFD,
            this.miLine01,
            this.miRefresh});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 142);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // miJH
            // 
            this.miJH.Enabled = false;
            this.miJH.Name = "miJH";
            this.miJH.Size = new System.Drawing.Size(118, 22);
            this.miJH.Text = "接货(&J)";
            this.miJH.Click += new System.EventHandler(this.btnJH_Click);
            // 
            // miZC
            // 
            this.miZC.Enabled = false;
            this.miZC.Name = "miZC";
            this.miZC.Size = new System.Drawing.Size(118, 22);
            this.miZC.Text = "装车(&Z)";
            this.miZC.Click += new System.EventHandler(this.btnZC_Click);
            // 
            // miXC
            // 
            this.miXC.Enabled = false;
            this.miXC.Name = "miXC";
            this.miXC.Size = new System.Drawing.Size(118, 22);
            this.miXC.Text = "卸车(&X)";
            this.miXC.Click += new System.EventHandler(this.btnXC_Click);
            // 
            // miQH
            // 
            this.miQH.Enabled = false;
            this.miQH.Name = "miQH";
            this.miQH.Size = new System.Drawing.Size(118, 22);
            this.miQH.Text = "取货(&Q)";
            this.miQH.Click += new System.EventHandler(this.btnQH_Click);
            // 
            // miFD
            // 
            this.miFD.Enabled = false;
            this.miFD.Name = "miFD";
            this.miFD.Size = new System.Drawing.Size(118, 22);
            this.miFD.Text = "废单(&F)";
            this.miFD.Click += new System.EventHandler(this.btnFD_Click);
            // 
            // miLine01
            // 
            this.miLine01.Name = "miLine01";
            this.miLine01.Size = new System.Drawing.Size(115, 6);
            // 
            // miRefresh
            // 
            this.miRefresh.Enabled = false;
            this.miRefresh.Name = "miRefresh";
            this.miRefresh.Size = new System.Drawing.Size(118, 22);
            this.miRefresh.Text = "刷新(&R)";
            this.miRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.list);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtSN);
            this.splitContainer.Panel2.Controls.Add(this.lblSN);
            this.splitContainer.Panel2.Controls.Add(this.btnClose);
            this.splitContainer.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer.Panel2.Controls.Add(this.btnJH);
            this.splitContainer.Panel2.Controls.Add(this.btnFD);
            this.splitContainer.Panel2.Controls.Add(this.btnQH);
            this.splitContainer.Panel2.Controls.Add(this.btnXC);
            this.splitContainer.Panel2.Controls.Add(this.btnZC);
            this.splitContainer.Panel2.Controls.Add(this.cboSelectDate);
            this.splitContainer.Panel2.Controls.Add(this.lblSelectDate);
            this.splitContainer.Size = new System.Drawing.Size(1051, 667);
            this.splitContainer.SplitterDistance = 611;
            this.splitContainer.TabIndex = 0;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(296, 16);
            this.txtSN.MaxLength = 16;
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(120, 21);
            this.txtSN.TabIndex = 3;
            this.txtSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSN_KeyPress);
            this.txtSN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSN_KeyUp);
            // 
            // lblSN
            // 
            this.lblSN.Location = new System.Drawing.Point(224, 16);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(72, 23);
            this.lblSN.TabIndex = 2;
            this.lblSN.Text = "运单查找：";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(960, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(456, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "刷新列表";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnJH
            // 
            this.btnJH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJH.Enabled = false;
            this.btnJH.Location = new System.Drawing.Point(536, 16);
            this.btnJH.Name = "btnJH";
            this.btnJH.Size = new System.Drawing.Size(75, 23);
            this.btnJH.TabIndex = 5;
            this.btnJH.Text = "重置接货";
            this.btnJH.UseVisualStyleBackColor = true;
            this.btnJH.Click += new System.EventHandler(this.btnJH_Click);
            // 
            // btnFD
            // 
            this.btnFD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFD.Enabled = false;
            this.btnFD.Location = new System.Drawing.Point(864, 16);
            this.btnFD.Name = "btnFD";
            this.btnFD.Size = new System.Drawing.Size(75, 23);
            this.btnFD.TabIndex = 9;
            this.btnFD.Text = "废单";
            this.btnFD.UseVisualStyleBackColor = true;
            this.btnFD.Click += new System.EventHandler(this.btnFD_Click);
            // 
            // btnQH
            // 
            this.btnQH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQH.Enabled = false;
            this.btnQH.Location = new System.Drawing.Point(784, 16);
            this.btnQH.Name = "btnQH";
            this.btnQH.Size = new System.Drawing.Size(75, 23);
            this.btnQH.TabIndex = 8;
            this.btnQH.Text = "取货";
            this.btnQH.UseVisualStyleBackColor = true;
            this.btnQH.Click += new System.EventHandler(this.btnQH_Click);
            // 
            // btnXC
            // 
            this.btnXC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXC.Enabled = false;
            this.btnXC.Location = new System.Drawing.Point(704, 16);
            this.btnXC.Name = "btnXC";
            this.btnXC.Size = new System.Drawing.Size(75, 23);
            this.btnXC.TabIndex = 7;
            this.btnXC.Text = "卸车";
            this.btnXC.UseVisualStyleBackColor = true;
            this.btnXC.Click += new System.EventHandler(this.btnXC_Click);
            // 
            // btnZC
            // 
            this.btnZC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZC.Enabled = false;
            this.btnZC.Location = new System.Drawing.Point(624, 16);
            this.btnZC.Name = "btnZC";
            this.btnZC.Size = new System.Drawing.Size(75, 23);
            this.btnZC.TabIndex = 6;
            this.btnZC.Text = "装车";
            this.btnZC.UseVisualStyleBackColor = true;
            this.btnZC.Click += new System.EventHandler(this.btnZC_Click);
            // 
            // cboSelectDate
            // 
            this.cboSelectDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectDate.FormattingEnabled = true;
            this.cboSelectDate.Location = new System.Drawing.Point(88, 16);
            this.cboSelectDate.Name = "cboSelectDate";
            this.cboSelectDate.Size = new System.Drawing.Size(121, 20);
            this.cboSelectDate.TabIndex = 1;
            this.cboSelectDate.DropDown += new System.EventHandler(this.cboSelectDate_DropDown);
            this.cboSelectDate.SelectedIndexChanged += new System.EventHandler(this.cboSelectDate_SelectedIndexChanged);
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.Location = new System.Drawing.Point(16, 16);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(72, 23);
            this.lblSelectDate.TabIndex = 0;
            this.lblSelectDate.Text = "选择日期：";
            this.lblSelectDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.list.Enabled = false;
            this.list.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list.FullRowSelect = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(1051, 611);
            this.list.TabIndex = 0;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
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
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 667);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运单管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageForm_FormClosing);
            this.Shown += new System.EventHandler(this.ManageForm_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
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
        private System.Windows.Forms.ColumnHeader columnMoney;
        private System.Windows.Forms.ColumnHeader columnFHNode;
        private System.Windows.Forms.ColumnHeader columnJHNode;
        private System.Windows.Forms.ColumnHeader columnBXD_SN;
        private System.Windows.Forms.ComboBox cboSelectDate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Button btnFD;
        private System.Windows.Forms.Button btnQH;
        private System.Windows.Forms.Button btnXC;
        private System.Windows.Forms.Button btnZC;
        private System.Windows.Forms.Button btnJH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem miJH;
        private System.Windows.Forms.ToolStripMenuItem miZC;
        private System.Windows.Forms.ToolStripMenuItem miXC;
        private System.Windows.Forms.ToolStripMenuItem miQH;
        private System.Windows.Forms.ToolStripSeparator miLine01;
        private System.Windows.Forms.ToolStripMenuItem miFD;
        private System.Windows.Forms.ToolStripMenuItem miRefresh;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lblSN;
    }
}