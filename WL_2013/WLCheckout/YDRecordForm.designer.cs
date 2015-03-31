namespace WLCheckout
{
    partial class YDRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YDRecordForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQueryMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.miQueryModeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.miQueryModeSN = new System.Windows.Forms.ToolStripMenuItem();
            this.miQueryModeFHRName = new System.Windows.Forms.ToolStripMenuItem();
            this.miQueryModeFHRTel = new System.Windows.Forms.ToolStripMenuItem();
            this.cboQueryContent = new System.Windows.Forms.ToolStripComboBox();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.list);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1050, 522);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(1050, 561);
            this.toolStripContainer.TabIndex = 7;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
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
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list.FullRowSelect = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(1050, 522);
            this.list.TabIndex = 7;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
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
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQueryMode,
            this.cboQueryContent,
            this.btnFind,
            this.btnPrint});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1050, 39);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 2;
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
            this.btnQueryMode.Size = new System.Drawing.Size(92, 36);
            this.btnQueryMode.Text = "办单日期：";
            // 
            // miQueryModeDate
            // 
            this.miQueryModeDate.Name = "miQueryModeDate";
            this.miQueryModeDate.Size = new System.Drawing.Size(152, 24);
            this.miQueryModeDate.Text = "办单日期";
            this.miQueryModeDate.Click += new System.EventHandler(this.btnQueryMode_Click);
            // 
            // miQueryModeSN
            // 
            this.miQueryModeSN.Name = "miQueryModeSN";
            this.miQueryModeSN.Size = new System.Drawing.Size(152, 24);
            this.miQueryModeSN.Text = "运单编号";
            this.miQueryModeSN.Click += new System.EventHandler(this.btnQueryMode_Click);
            // 
            // miQueryModeFHRName
            // 
            this.miQueryModeFHRName.Name = "miQueryModeFHRName";
            this.miQueryModeFHRName.Size = new System.Drawing.Size(152, 24);
            this.miQueryModeFHRName.Text = "发货姓名";
            this.miQueryModeFHRName.Click += new System.EventHandler(this.btnQueryMode_Click);
            // 
            // miQueryModeFHRTel
            // 
            this.miQueryModeFHRTel.Name = "miQueryModeFHRTel";
            this.miQueryModeFHRTel.Size = new System.Drawing.Size(152, 24);
            this.miQueryModeFHRTel.Text = "发货电话";
            this.miQueryModeFHRTel.Click += new System.EventHandler(this.btnQueryMode_Click);
            // 
            // cboQueryContent
            // 
            this.cboQueryContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQueryContent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboQueryContent.IntegralHeight = false;
            this.cboQueryContent.Name = "cboQueryContent";
            this.cboQueryContent.Size = new System.Drawing.Size(120, 39);
            this.cboQueryContent.DropDown += new System.EventHandler(this.cboQueryContent_DropDown);
            this.cboQueryContent.DropDownClosed += new System.EventHandler(this.cboQueryContent_DropDownClosed);
            this.cboQueryContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboQueryContent_KeyDown);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(73, 36);
            this.btnFind.Text = "查找";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.ToolTipText = "查找";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 36);
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // YDRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.toolStripContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YDRecordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "运单明细";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton btnQueryMode;
        private System.Windows.Forms.ToolStripMenuItem miQueryModeDate;
        private System.Windows.Forms.ToolStripMenuItem miQueryModeSN;
        private System.Windows.Forms.ToolStripMenuItem miQueryModeFHRName;
        private System.Windows.Forms.ToolStripMenuItem miQueryModeFHRTel;
        private System.Windows.Forms.ToolStripComboBox cboQueryContent;
        private System.Windows.Forms.ToolStripButton btnFind;
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
        private System.Windows.Forms.ToolStripButton btnPrint;


    }
}