namespace KM.PrintJSD
{
    partial class SettingDialog
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.标签控件 = new System.Windows.Forms.TabControl();
            this.常规标签 = new System.Windows.Forms.TabPage();
            this.过滤标签 = new System.Windows.Forms.TabPage();
            this.chkTotalNonDec = new System.Windows.Forms.CheckBox();
            this.chkTotalIsZero = new System.Windows.Forms.CheckBox();
            this.chkTotalIsNull = new System.Windows.Forms.CheckBox();
            this.chkIdNonInt = new System.Windows.Forms.CheckBox();
            this.chkIdIsNull = new System.Windows.Forms.CheckBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.标签控件.SuspendLayout();
            this.常规标签.SuspendLayout();
            this.过滤标签.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(296, 328);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(384, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // 标签控件
            // 
            this.标签控件.Controls.Add(this.常规标签);
            this.标签控件.Controls.Add(this.过滤标签);
            this.标签控件.ItemSize = new System.Drawing.Size(80, 20);
            this.标签控件.Location = new System.Drawing.Point(8, 8);
            this.标签控件.Name = "标签控件";
            this.标签控件.SelectedIndex = 0;
            this.标签控件.Size = new System.Drawing.Size(456, 304);
            this.标签控件.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.标签控件.TabIndex = 7;
            // 
            // 常规标签
            // 
            this.常规标签.Controls.Add(this.txtPath);
            this.常规标签.Controls.Add(this.lblPath);
            this.常规标签.Location = new System.Drawing.Point(4, 24);
            this.常规标签.Name = "常规标签";
            this.常规标签.Padding = new System.Windows.Forms.Padding(3);
            this.常规标签.Size = new System.Drawing.Size(448, 276);
            this.常规标签.TabIndex = 0;
            this.常规标签.Text = "常规";
            this.常规标签.UseVisualStyleBackColor = true;
            // 
            // 过滤标签
            // 
            this.过滤标签.Controls.Add(this.chkTotalNonDec);
            this.过滤标签.Controls.Add(this.chkTotalIsZero);
            this.过滤标签.Controls.Add(this.chkTotalIsNull);
            this.过滤标签.Controls.Add(this.chkIdNonInt);
            this.过滤标签.Controls.Add(this.chkIdIsNull);
            this.过滤标签.Location = new System.Drawing.Point(4, 24);
            this.过滤标签.Name = "过滤标签";
            this.过滤标签.Padding = new System.Windows.Forms.Padding(3);
            this.过滤标签.Size = new System.Drawing.Size(448, 276);
            this.过滤标签.TabIndex = 1;
            this.过滤标签.Text = "过滤";
            this.过滤标签.UseVisualStyleBackColor = true;
            // 
            // chkTotalNonDec
            // 
            this.chkTotalNonDec.AutoSize = true;
            this.chkTotalNonDec.Location = new System.Drawing.Point(24, 128);
            this.chkTotalNonDec.Name = "chkTotalNonDec";
            this.chkTotalNonDec.Size = new System.Drawing.Size(192, 16);
            this.chkTotalNonDec.TabIndex = 9;
            this.chkTotalNonDec.Text = "过滤\'净付金额\'非金额类型记录";
            this.chkTotalNonDec.UseVisualStyleBackColor = true;
            // 
            // chkTotalIsZero
            // 
            this.chkTotalIsZero.AutoSize = true;
            this.chkTotalIsZero.Location = new System.Drawing.Point(24, 160);
            this.chkTotalIsZero.Name = "chkTotalIsZero";
            this.chkTotalIsZero.Size = new System.Drawing.Size(168, 16);
            this.chkTotalIsZero.TabIndex = 8;
            this.chkTotalIsZero.Text = "过滤\'净付金额\'等于零记录";
            this.chkTotalIsZero.UseVisualStyleBackColor = true;
            // 
            // chkTotalIsNull
            // 
            this.chkTotalIsNull.AutoSize = true;
            this.chkTotalIsNull.Location = new System.Drawing.Point(24, 96);
            this.chkTotalIsNull.Name = "chkTotalIsNull";
            this.chkTotalIsNull.Size = new System.Drawing.Size(156, 16);
            this.chkTotalIsNull.TabIndex = 7;
            this.chkTotalIsNull.Text = "过滤\'净付金额\'为空记录";
            this.chkTotalIsNull.UseVisualStyleBackColor = true;
            // 
            // chkIdNonInt
            // 
            this.chkIdNonInt.AutoSize = true;
            this.chkIdNonInt.Location = new System.Drawing.Point(24, 64);
            this.chkIdNonInt.Name = "chkIdNonInt";
            this.chkIdNonInt.Size = new System.Drawing.Size(180, 16);
            this.chkIdNonInt.TabIndex = 6;
            this.chkIdNonInt.Text = "过滤\'序号\'为非整数类型记录";
            this.chkIdNonInt.UseVisualStyleBackColor = true;
            // 
            // chkIdIsNull
            // 
            this.chkIdIsNull.AutoSize = true;
            this.chkIdIsNull.Location = new System.Drawing.Point(24, 32);
            this.chkIdIsNull.Name = "chkIdIsNull";
            this.chkIdIsNull.Size = new System.Drawing.Size(132, 16);
            this.chkIdIsNull.TabIndex = 5;
            this.chkIdIsNull.Text = "过滤\'序号\'为空记录";
            this.chkIdIsNull.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(144, 32);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(256, 21);
            this.txtPath.TabIndex = 11;
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(24, 32);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(108, 23);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "工作目录：";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(471, 367);
            this.Controls.Add(this.标签控件);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本地配置";
            this.Load += new System.EventHandler(this.SettingDialog_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingDialog_FormClosing);
            this.标签控件.ResumeLayout(false);
            this.常规标签.ResumeLayout(false);
            this.常规标签.PerformLayout();
            this.过滤标签.ResumeLayout(false);
            this.过滤标签.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl 标签控件;
        private System.Windows.Forms.TabPage 常规标签;
        private System.Windows.Forms.TabPage 过滤标签;
        private System.Windows.Forms.CheckBox chkTotalNonDec;
        private System.Windows.Forms.CheckBox chkTotalIsZero;
        private System.Windows.Forms.CheckBox chkTotalIsNull;
        private System.Windows.Forms.CheckBox chkIdNonInt;
        private System.Windows.Forms.CheckBox chkIdIsNull;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
    }
}