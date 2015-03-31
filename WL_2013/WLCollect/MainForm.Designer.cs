namespace WLCollect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblConnectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtConnectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginState = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLoginState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.txtHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lstCollectItems = new Common.ListViewEx();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPackage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblKYZList = new System.Windows.Forms.ToolStripLabel();
            this.cboKYZList = new System.Windows.Forms.ToolStripComboBox();
            this.lblMinDate = new System.Windows.Forms.ToolStripLabel();
            this.txtMinDate = new System.Windows.Forms.ToolStripTextBox();
            this.lblMaxDate = new System.Windows.Forms.ToolStripLabel();
            this.txtMaxDate = new System.Windows.Forms.ToolStripTextBox();
            this.btnDateRange = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator01 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.btnUnselectAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator02 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCollect = new System.Windows.Forms.ToolStripButton();
            this.btnClientSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(876, 472);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(876, 554);
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
            this.toolStripProgressBar,
            this.txtHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(876, 26);
            this.statusStrip.TabIndex = 1;
            // 
            // lblConnectionState
            // 
            this.lblConnectionState.ForeColor = System.Drawing.Color.Black;
            this.lblConnectionState.Name = "lblConnectionState";
            this.lblConnectionState.Size = new System.Drawing.Size(68, 21);
            this.lblConnectionState.Text = "数据连接：";
            // 
            // txtConnectionState
            // 
            this.txtConnectionState.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtConnectionState.ForeColor = System.Drawing.Color.Gray;
            this.txtConnectionState.Name = "txtConnectionState";
            this.txtConnectionState.Size = new System.Drawing.Size(36, 21);
            this.txtConnectionState.Text = "关闭";
            // 
            // lblLoginState
            // 
            this.lblLoginState.ForeColor = System.Drawing.Color.Black;
            this.lblLoginState.Name = "lblLoginState";
            this.lblLoginState.Size = new System.Drawing.Size(68, 21);
            this.lblLoginState.Text = "登录状态：";
            // 
            // txtLoginState
            // 
            this.txtLoginState.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtLoginState.ForeColor = System.Drawing.Color.Red;
            this.txtLoginState.Name = "txtLoginState";
            this.txtLoginState.Size = new System.Drawing.Size(60, 21);
            this.txtLoginState.Text = "双击登录";
            this.txtLoginState.Click += new System.EventHandler(this.txtLoginState_Click);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(240, 20);
            this.toolStripProgressBar.Visible = false;
            // 
            // txtHint
            // 
            this.txtHint.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(356, 21);
            this.txtHint.Spring = true;
            this.txtHint.Text = "技术支持：0431-86769937";
            this.txtHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lstCollectItems);
            this.splitContainer.Panel1MinSize = 480;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lstMsg);
            this.splitContainer.Size = new System.Drawing.Size(876, 472);
            this.splitContainer.SplitterDistance = 480;
            this.splitContainer.TabIndex = 0;
            // 
            // lstCollectItems
            // 
            this.lstCollectItems.CheckBoxes = true;
            this.lstCollectItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colCount,
            this.colPackage,
            this.colMoney});
            this.lstCollectItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCollectItems.FullRowSelect = true;
            this.lstCollectItems.Location = new System.Drawing.Point(0, 0);
            this.lstCollectItems.Name = "lstCollectItems";
            this.lstCollectItems.OneColor = System.Drawing.SystemColors.Window;
            this.lstCollectItems.Size = new System.Drawing.Size(480, 472);
            this.lstCollectItems.TabIndex = 1;
            this.lstCollectItems.TwoColor = System.Drawing.SystemColors.Window;
            this.lstCollectItems.UseCompatibleStateImageBehavior = false;
            this.lstCollectItems.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "日期";
            this.colDate.Width = 120;
            // 
            // colCount
            // 
            this.colCount.Text = "单数（含废单）";
            this.colCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCount.Width = 100;
            // 
            // colPackage
            // 
            this.colPackage.Text = "件数（含废单）";
            this.colPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPackage.Width = 100;
            // 
            // colMoney
            // 
            this.colMoney.Text = "金额（含废单）";
            this.colMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colMoney.Width = 120;
            // 
            // lstMsg
            // 
            this.lstMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMsg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.IntegralHeight = false;
            this.lstMsg.ItemHeight = 16;
            this.lstMsg.Location = new System.Drawing.Point(0, 0);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(392, 472);
            this.lstMsg.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Enabled = false;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKYZList,
            this.cboKYZList,
            this.lblMinDate,
            this.txtMinDate,
            this.lblMaxDate,
            this.txtMaxDate,
            this.btnDateRange,
            this.toolStripSeparator01,
            this.btnRefresh,
            this.btnSelectAll,
            this.btnUnselectAll,
            this.toolStripSeparator02,
            this.btnCollect,
            this.btnClientSetting});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(876, 56);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // lblKYZList
            // 
            this.lblKYZList.Name = "lblKYZList";
            this.lblKYZList.Size = new System.Drawing.Size(68, 53);
            this.lblKYZList.Text = "网点列表：";
            // 
            // cboKYZList
            // 
            this.cboKYZList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKYZList.Items.AddRange(new object[] {
            "AAA",
            "BBB",
            "CCC"});
            this.cboKYZList.Name = "cboKYZList";
            this.cboKYZList.Size = new System.Drawing.Size(220, 56);
            this.cboKYZList.SelectedIndexChanged += new System.EventHandler(this.cboKYZList_SelectedIndexChanged);
            // 
            // lblMinDate
            // 
            this.lblMinDate.Name = "lblMinDate";
            this.lblMinDate.Size = new System.Drawing.Size(68, 53);
            this.lblMinDate.Text = "起始日期：";
            // 
            // txtMinDate
            // 
            this.txtMinDate.Name = "txtMinDate";
            this.txtMinDate.Size = new System.Drawing.Size(80, 56);
            this.txtMinDate.Text = "0000-00-00";
            // 
            // lblMaxDate
            // 
            this.lblMaxDate.Name = "lblMaxDate";
            this.lblMaxDate.Size = new System.Drawing.Size(68, 53);
            this.lblMaxDate.Text = "截止日期：";
            // 
            // txtMaxDate
            // 
            this.txtMaxDate.Name = "txtMaxDate";
            this.txtMaxDate.Size = new System.Drawing.Size(80, 56);
            this.txtMaxDate.Text = "0000-00-00";
            // 
            // btnDateRange
            // 
            this.btnDateRange.Image = ((System.Drawing.Image)(resources.GetObject("btnDateRange.Image")));
            this.btnDateRange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDateRange.Name = "btnDateRange";
            this.btnDateRange.Size = new System.Drawing.Size(36, 53);
            this.btnDateRange.Text = "昨日";
            this.btnDateRange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDateRange.Click += new System.EventHandler(this.btnDateRange_Click);
            // 
            // toolStripSeparator01
            // 
            this.toolStripSeparator01.Name = "toolStripSeparator01";
            this.toolStripSeparator01.Size = new System.Drawing.Size(6, 56);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 53);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.Image")));
            this.btnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(36, 53);
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Image = ((System.Drawing.Image)(resources.GetObject("btnUnselectAll.Image")));
            this.btnUnselectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(36, 53);
            this.btnUnselectAll.Text = "全消";
            this.btnUnselectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // toolStripSeparator02
            // 
            this.toolStripSeparator02.Name = "toolStripSeparator02";
            this.toolStripSeparator02.Size = new System.Drawing.Size(6, 56);
            // 
            // btnCollect
            // 
            this.btnCollect.Image = ((System.Drawing.Image)(resources.GetObject("btnCollect.Image")));
            this.btnCollect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(36, 53);
            this.btnCollect.Text = "汇总";
            this.btnCollect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // btnClientSetting
            // 
            this.btnClientSetting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClientSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnClientSetting.Image")));
            this.btnClientSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientSetting.Name = "btnClientSetting";
            this.btnClientSetting.Size = new System.Drawing.Size(60, 53);
            this.btnClientSetting.Text = "本地配置";
            this.btnClientSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientSetting.Click += new System.EventHandler(this.btnClientSetting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 554);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "MainForm";
            this.Text = "汇总数据";
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
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel lblKYZList;
        private System.Windows.Forms.ToolStripComboBox cboKYZList;
        private System.Windows.Forms.ToolStripLabel lblMinDate;
        private System.Windows.Forms.ToolStripLabel lblMaxDate;
        private System.Windows.Forms.ToolStripButton btnCollect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator01;
        private System.Windows.Forms.ToolStripButton btnUnselectAll;
        private System.Windows.Forms.ToolStripButton btnSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator02;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectionState;
        private System.Windows.Forms.ToolStripStatusLabel txtConnectionState;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginState;
        private System.Windows.Forms.ToolStripStatusLabel txtLoginState;
        private System.Windows.Forms.ToolStripStatusLabel txtHint;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnClientSetting;
        private System.Windows.Forms.ToolStripTextBox txtMinDate;
        private System.Windows.Forms.ToolStripTextBox txtMaxDate;
        private System.Windows.Forms.ToolStripButton btnDateRange;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Common.ListViewEx lstCollectItems;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPackage;
        private System.Windows.Forms.ColumnHeader colMoney;
        private System.Windows.Forms.ListBox lstMsg;
    }
}

