namespace WLCommon.Management
{
    partial class PrintFormatForm
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
            this.toolPanel = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.list = new Common.ListViewEx();
            this.columnCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFontName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFontSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFontMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEnable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.btnEdit);
            this.toolPanel.Controls.Add(this.btnCancel);
            this.toolPanel.Controls.Add(this.btnPreview);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolPanel.Location = new System.Drawing.Point(0, 443);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(768, 56);
            this.toolPanel.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(16, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(676, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPreview.Location = new System.Drawing.Point(584, 16);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCode,
            this.columnName,
            this.columnX,
            this.columnY,
            this.columnFontName,
            this.columnFontSize,
            this.columnFontMode,
            this.columnEnable});
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FullRowSelect = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(768, 443);
            this.list.TabIndex = 1;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.lstPrintFormat_SelectedIndexChanged);
            this.list.DoubleClick += new System.EventHandler(this.lstPrintFormat_DoubleClick);
            // 
            // columnCode
            // 
            this.columnCode.Text = "编号";
            this.columnCode.Width = 80;
            // 
            // columnName
            // 
            this.columnName.Text = "名称";
            this.columnName.Width = 160;
            // 
            // columnX
            // 
            this.columnX.Text = "X";
            this.columnX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnX.Width = 80;
            // 
            // columnY
            // 
            this.columnY.Text = "Y";
            this.columnY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnY.Width = 80;
            // 
            // columnFontName
            // 
            this.columnFontName.Text = "字体名称";
            this.columnFontName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFontName.Width = 120;
            // 
            // columnFontSize
            // 
            this.columnFontSize.Text = "字体大小";
            this.columnFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFontSize.Width = 80;
            // 
            // columnFontMode
            // 
            this.columnFontMode.Text = "字体风格";
            this.columnFontMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFontMode.Width = 80;
            // 
            // columnEnable
            // 
            this.columnEnable.Text = "启用";
            this.columnEnable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEnable.Width = 80;
            // 
            // PrintFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 499);
            this.Controls.Add(this.list);
            this.Controls.Add(this.toolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintFormatForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "打印格式";
            this.Shown += new System.EventHandler(this.PrintSettingForm_Shown);
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private Common.ListViewEx list;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader columnCode;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnX;
        private System.Windows.Forms.ColumnHeader columnY;
        private System.Windows.Forms.ColumnHeader columnFontName;
        private System.Windows.Forms.ColumnHeader columnFontSize;
        private System.Windows.Forms.ColumnHeader columnFontMode;
        private System.Windows.Forms.ColumnHeader columnEnable;
    }
}