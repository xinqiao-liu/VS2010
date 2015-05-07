namespace KM.JP
{
    partial class JSForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0001",
            "齐齐哈尔",
            "00:00",
            "吉A00000",
            "客运一公司",
            "1111",
            "123456",
            "11",
            "10000.00",
            "10000.00",
            "2010-05-10 10:10:10"}, -1);
            this.RfreshButton = new System.Windows.Forms.Button();
            this.JSList = new System.Windows.Forms.ListView();
            this.m_BIDColumn = new System.Windows.Forms.ColumnHeader();
            this.m_ESNColumn = new System.Windows.Forms.ColumnHeader();
            this.m_STColumn = new System.Windows.Forms.ColumnHeader();
            this.m_CIDColumn = new System.Windows.Forms.ColumnHeader();
            this.m_CCColumn = new System.Windows.Forms.ColumnHeader();
            this.m_BCColumn = new System.Windows.Forms.ColumnHeader();
            this.m_BUColumn = new System.Windows.Forms.ColumnHeader();
            this.m_CNColumn = new System.Windows.Forms.ColumnHeader();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.PrintButton = new System.Windows.Forms.Button();
            this.ReJSButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.line01 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RfreshButton
            // 
            this.RfreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RfreshButton.Enabled = false;
            this.RfreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RfreshButton.Location = new System.Drawing.Point(392, 520);
            this.RfreshButton.Name = "RfreshButton";
            this.RfreshButton.Size = new System.Drawing.Size(120, 48);
            this.RfreshButton.TabIndex = 4;
            this.RfreshButton.Text = "刷新列表";
            this.RfreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RfreshButton.UseVisualStyleBackColor = true;
            this.RfreshButton.Click += new System.EventHandler(this.RfreshButton_Click);
            // 
            // JSList
            // 
            this.JSList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.JSList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_BIDColumn,
            this.m_ESNColumn,
            this.m_STColumn,
            this.m_CIDColumn,
            this.m_CCColumn,
            this.m_BCColumn,
            this.m_BUColumn,
            this.m_CNColumn});
            this.JSList.Enabled = false;
            this.JSList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JSList.FullRowSelect = true;
            this.JSList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.JSList.HideSelection = false;
            this.JSList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.JSList.Location = new System.Drawing.Point(8, 48);
            this.JSList.MultiSelect = false;
            this.JSList.Name = "JSList";
            this.JSList.ShowGroups = false;
            this.JSList.Size = new System.Drawing.Size(952, 455);
            this.JSList.SmallImageList = this.imageList;
            this.JSList.TabIndex = 0;
            this.JSList.UseCompatibleStateImageBehavior = false;
            this.JSList.View = System.Windows.Forms.View.Details;
            this.JSList.SelectedIndexChanged += new System.EventHandler(this.JSList_SelectedIndexChanged);
            // 
            // m_BIDColumn
            // 
            this.m_BIDColumn.Text = "班次";
            this.m_BIDColumn.Width = 100;
            // 
            // m_ESNColumn
            // 
            this.m_ESNColumn.Text = "终到站";
            this.m_ESNColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_ESNColumn.Width = 100;
            // 
            // m_STColumn
            // 
            this.m_STColumn.Text = "发车";
            this.m_STColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_STColumn.Width = 100;
            // 
            // m_CIDColumn
            // 
            this.m_CIDColumn.Text = "车牌号";
            this.m_CIDColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_CIDColumn.Width = 100;
            // 
            // m_CCColumn
            // 
            this.m_CCColumn.Text = "车属单位";
            this.m_CCColumn.Width = 210;
            // 
            // m_BCColumn
            // 
            this.m_BCColumn.Text = "结算码";
            this.m_BCColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_BCColumn.Width = 100;
            // 
            // m_BUColumn
            // 
            this.m_BUColumn.Text = "结算员";
            this.m_BUColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_BUColumn.Width = 100;
            // 
            // m_CNColumn
            // 
            this.m_CNColumn.Text = "客票数";
            this.m_CNColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_CNColumn.Width = 100;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(1, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintButton.Enabled = false;
            this.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintButton.Location = new System.Drawing.Point(264, 520);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(120, 48);
            this.PrintButton.TabIndex = 3;
            this.PrintButton.Text = "打印单据";
            this.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ReJSButton
            // 
            this.ReJSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReJSButton.Enabled = false;
            this.ReJSButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReJSButton.Location = new System.Drawing.Point(136, 520);
            this.ReJSButton.Name = "ReJSButton";
            this.ReJSButton.Size = new System.Drawing.Size(120, 48);
            this.ReJSButton.TabIndex = 2;
            this.ReJSButton.Text = "重新结算";
            this.ReJSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReJSButton.UseVisualStyleBackColor = true;
            this.ReJSButton.Click += new System.EventHandler(this.ReJSButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResumeButton.Enabled = false;
            this.ResumeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResumeButton.Location = new System.Drawing.Point(8, 520);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(120, 48);
            this.ResumeButton.TabIndex = 1;
            this.ResumeButton.Text = "恢复检票";
            this.ResumeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseButton.Location = new System.Drawing.Point(840, 520);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(120, 48);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "关闭";
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // line01
            // 
            this.line01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line01.Location = new System.Drawing.Point(8, 24);
            this.line01.Name = "line01";
            this.line01.Size = new System.Drawing.Size(952, 2);
            this.line01.TabIndex = 6;
            this.line01.Text = "label1";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(8, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(129, 14);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = "全部：0  当前：0";
            // 
            // JSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 583);
            this.ControlBox = false;
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.line01);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RfreshButton);
            this.Controls.Add(this.JSList);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ReJSButton);
            this.Controls.Add(this.ResumeButton);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JSForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结算";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RfreshButton;
        private System.Windows.Forms.ListView JSList;
        private System.Windows.Forms.ColumnHeader m_BIDColumn;
        private System.Windows.Forms.ColumnHeader m_ESNColumn;
        private System.Windows.Forms.ColumnHeader m_STColumn;
        private System.Windows.Forms.ColumnHeader m_CIDColumn;
        private System.Windows.Forms.ColumnHeader m_CCColumn;
        private System.Windows.Forms.ColumnHeader m_BCColumn;
        private System.Windows.Forms.ColumnHeader m_BUColumn;
        private System.Windows.Forms.ColumnHeader m_CNColumn;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ReJSButton;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label line01;
        private System.Windows.Forms.Label txtTitle;
    }
}