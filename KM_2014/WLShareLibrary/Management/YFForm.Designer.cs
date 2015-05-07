namespace WLCommon.Management
{
    partial class YFForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.listPage = new System.Windows.Forms.TabPage();
            this.list = new Common.ListViewEx();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFactor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.listPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(568, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.listPage);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(640, 352);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // listPage
            // 
            this.listPage.Controls.Add(this.list);
            this.listPage.Location = new System.Drawing.Point(4, 24);
            this.listPage.Name = "listPage";
            this.listPage.Padding = new System.Windows.Forms.Padding(3);
            this.listPage.Size = new System.Drawing.Size(632, 324);
            this.listPage.TabIndex = 0;
            this.listPage.Text = "运费列表";
            this.listPage.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSM,
            this.columnEM,
            this.columnBF,
            this.columnBW,
            this.columnWeight,
            this.columnExcess,
            this.columnFactor});
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FullRowSelect = true;
            this.list.Location = new System.Drawing.Point(3, 3);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.OneColor = System.Drawing.SystemColors.Window;
            this.list.Size = new System.Drawing.Size(626, 318);
            this.list.TabIndex = 0;
            this.list.TwoColor = System.Drawing.SystemColors.Window;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            this.list.DoubleClick += new System.EventHandler(this.list_DoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "运费标准名称";
            this.columnName.Width = 160;
            // 
            // columnSM
            // 
            this.columnSM.Text = "起里程";
            this.columnSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnEM
            // 
            this.columnEM.Text = "截里程";
            this.columnEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnBF
            // 
            this.columnBF.Text = "按文件";
            this.columnBF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnBF.Width = 70;
            // 
            // columnBW
            // 
            this.columnBW.Text = "按重量";
            this.columnBW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnBW.Width = 70;
            // 
            // columnWeight
            // 
            this.columnWeight.Text = "起重";
            this.columnWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnExcess
            // 
            this.columnExcess.Text = "续重金额";
            this.columnExcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnExcess.Width = 70;
            // 
            // columnFactor
            // 
            this.columnFactor.Text = "体积系数";
            this.columnFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnFactor.Width = 70;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(480, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // YFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(656, 419);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YFForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运费标准";
            this.Shown += new System.EventHandler(this.YFForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage listPage;
        private System.Windows.Forms.Button btnEdit;
        private Common.ListViewEx list;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnBW;
        private System.Windows.Forms.ColumnHeader columnWeight;
        private System.Windows.Forms.ColumnHeader columnExcess;
        private System.Windows.Forms.ColumnHeader columnBF;
        private System.Windows.Forms.ColumnHeader columnFactor;
        private System.Windows.Forms.ColumnHeader columnSM;
        private System.Windows.Forms.ColumnHeader columnEM;
    }
}