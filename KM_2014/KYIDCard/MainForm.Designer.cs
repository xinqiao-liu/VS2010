namespace KM.IDManage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.CopyrightInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstUser = new System.Windows.Forms.ListView();
            this.columnUID = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnFullname = new System.Windows.Forms.ColumnHeader();
            this.columnCID = new System.Windows.Forms.ColumnHeader();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.txtUserNumber = new System.Windows.Forms.ToolStripLabel();
            this.ConnectionSettingButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtUserType = new System.Windows.Forms.ToolStripLabel();
            this.cboUserType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.toolStripContainer.ContentPanel.Controls.Add(this.lstUser);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(807, 429);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(807, 490);
            this.toolStripContainer.TabIndex = 4;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyrightInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(807, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // CopyrightInfo
            // 
            this.CopyrightInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CopyrightInfo.Name = "CopyrightInfo";
            this.CopyrightInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // lstUser
            // 
            this.lstUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUID,
            this.columnName,
            this.columnFullname,
            this.columnCID});
            this.lstUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstUser.FullRowSelect = true;
            this.lstUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstUser.HideSelection = false;
            this.lstUser.Location = new System.Drawing.Point(0, 0);
            this.lstUser.MultiSelect = false;
            this.lstUser.Name = "lstUser";
            this.lstUser.ShowGroups = false;
            this.lstUser.Size = new System.Drawing.Size(807, 429);
            this.lstUser.SmallImageList = this.imageList;
            this.lstUser.TabIndex = 4;
            this.lstUser.UseCompatibleStateImageBehavior = false;
            this.lstUser.View = System.Windows.Forms.View.Details;
            this.lstUser.DoubleClick += new System.EventHandler(this.lstUser_DoubleClick);
            // 
            // columnUID
            // 
            this.columnUID.Text = "用户编号";
            this.columnUID.Width = 120;
            // 
            // columnName
            // 
            this.columnName.Text = "用户名称";
            this.columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnName.Width = 120;
            // 
            // columnFullname
            // 
            this.columnFullname.Text = "类型";
            this.columnFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFullname.Width = 200;
            // 
            // columnCID
            // 
            this.columnCID.Text = "卡号";
            this.columnCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCID.Width = 200;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(1, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUserNumber,
            this.ConnectionSettingButton,
            this.toolStripSeparator1,
            this.txtUserType,
            this.cboUserType});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStrip.Size = new System.Drawing.Size(807, 39);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtUserNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(15, 36);
            this.txtUserNumber.Text = "0";
            // 
            // ConnectionSettingButton
            // 
            this.ConnectionSettingButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectionSettingButton.Image")));
            this.ConnectionSettingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectionSettingButton.Name = "ConnectionSettingButton";
            this.ConnectionSettingButton.Size = new System.Drawing.Size(99, 36);
            this.ConnectionSettingButton.Text = "连接配置";
            this.ConnectionSettingButton.Click += new System.EventHandler(this.ConnectionSettingButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // txtUserType
            // 
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(77, 36);
            this.txtUserType.Text = "用户类型：";
            // 
            // cboUserType
            // 
            this.cboUserType.DropDownHeight = 200;
            this.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboUserType.IntegralHeight = false;
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(121, 39);
            this.cboUserType.SelectedIndexChanged += new System.EventHandler(this.cboUserType_SelectedIndexChanged);
            this.cboUserType.DropDown += new System.EventHandler(this.cboUserType_DropDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 490);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "MainForm";
            this.Text = "站内ID卡管理系统（2010-9）";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ListView lstUser;
        private System.Windows.Forms.ColumnHeader columnUID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCID;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel txtUserNumber;
        private System.Windows.Forms.ToolStripLabel txtUserType;
        private System.Windows.Forms.ToolStripComboBox cboUserType;
        private System.Windows.Forms.ToolStripButton ConnectionSettingButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CopyrightInfo;
        private System.Windows.Forms.ColumnHeader columnFullname;


    }
}