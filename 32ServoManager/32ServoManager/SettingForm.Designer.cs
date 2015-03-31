namespace _32ServoManager
{
    partial class SettingForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabServo = new System.Windows.Forms.TabPage();
            this.numServoDefaultPW = new System.Windows.Forms.NumericUpDown();
            this.lblServoDefaultPW = new System.Windows.Forms.Label();
            this.numServoMaxPW = new System.Windows.Forms.NumericUpDown();
            this.lblServoMaxPW = new System.Windows.Forms.Label();
            this.numServoMinPW = new System.Windows.Forms.NumericUpDown();
            this.lblServoMinPW = new System.Windows.Forms.Label();
            this.numServoTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.lblServoTimerInterval = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabServo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServoDefaultPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoMaxPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoMinPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoTimerInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(240, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(344, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabServo);
            this.tabControl1.ItemSize = new System.Drawing.Size(96, 20);
            this.tabControl1.Location = new System.Drawing.Point(16, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 224);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabServo
            // 
            this.tabServo.Controls.Add(this.numServoTimerInterval);
            this.tabServo.Controls.Add(this.lblServoTimerInterval);
            this.tabServo.Controls.Add(this.numServoMinPW);
            this.tabServo.Controls.Add(this.lblServoMinPW);
            this.tabServo.Controls.Add(this.numServoMaxPW);
            this.tabServo.Controls.Add(this.lblServoMaxPW);
            this.tabServo.Controls.Add(this.numServoDefaultPW);
            this.tabServo.Controls.Add(this.lblServoDefaultPW);
            this.tabServo.Location = new System.Drawing.Point(4, 24);
            this.tabServo.Name = "tabServo";
            this.tabServo.Padding = new System.Windows.Forms.Padding(3);
            this.tabServo.Size = new System.Drawing.Size(416, 196);
            this.tabServo.TabIndex = 0;
            this.tabServo.Text = "舵机";
            this.tabServo.UseVisualStyleBackColor = true;
            // 
            // numServoDefaultPW
            // 
            this.numServoDefaultPW.ForeColor = System.Drawing.Color.Blue;
            this.numServoDefaultPW.Location = new System.Drawing.Point(144, 24);
            this.numServoDefaultPW.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numServoDefaultPW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServoDefaultPW.Name = "numServoDefaultPW";
            this.numServoDefaultPW.Size = new System.Drawing.Size(105, 21);
            this.numServoDefaultPW.TabIndex = 1;
            this.numServoDefaultPW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblServoDefaultPW
            // 
            this.lblServoDefaultPW.ForeColor = System.Drawing.Color.Gray;
            this.lblServoDefaultPW.Location = new System.Drawing.Point(40, 24);
            this.lblServoDefaultPW.Name = "lblServoDefaultPW";
            this.lblServoDefaultPW.Size = new System.Drawing.Size(104, 24);
            this.lblServoDefaultPW.TabIndex = 0;
            this.lblServoDefaultPW.Text = "缺省脉宽：";
            this.lblServoDefaultPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numServoMaxPW
            // 
            this.numServoMaxPW.ForeColor = System.Drawing.Color.Blue;
            this.numServoMaxPW.Location = new System.Drawing.Point(144, 64);
            this.numServoMaxPW.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numServoMaxPW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServoMaxPW.Name = "numServoMaxPW";
            this.numServoMaxPW.Size = new System.Drawing.Size(105, 21);
            this.numServoMaxPW.TabIndex = 3;
            this.numServoMaxPW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblServoMaxPW
            // 
            this.lblServoMaxPW.ForeColor = System.Drawing.Color.Gray;
            this.lblServoMaxPW.Location = new System.Drawing.Point(40, 64);
            this.lblServoMaxPW.Name = "lblServoMaxPW";
            this.lblServoMaxPW.Size = new System.Drawing.Size(104, 24);
            this.lblServoMaxPW.TabIndex = 2;
            this.lblServoMaxPW.Text = "最大脉宽：";
            this.lblServoMaxPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numServoMinPW
            // 
            this.numServoMinPW.ForeColor = System.Drawing.Color.Blue;
            this.numServoMinPW.Location = new System.Drawing.Point(144, 104);
            this.numServoMinPW.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numServoMinPW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServoMinPW.Name = "numServoMinPW";
            this.numServoMinPW.Size = new System.Drawing.Size(105, 21);
            this.numServoMinPW.TabIndex = 5;
            this.numServoMinPW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblServoMinPW
            // 
            this.lblServoMinPW.ForeColor = System.Drawing.Color.Gray;
            this.lblServoMinPW.Location = new System.Drawing.Point(40, 104);
            this.lblServoMinPW.Name = "lblServoMinPW";
            this.lblServoMinPW.Size = new System.Drawing.Size(104, 24);
            this.lblServoMinPW.TabIndex = 4;
            this.lblServoMinPW.Text = "最小脉宽：";
            this.lblServoMinPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numServoTimerInterval
            // 
            this.numServoTimerInterval.ForeColor = System.Drawing.Color.Blue;
            this.numServoTimerInterval.Location = new System.Drawing.Point(144, 152);
            this.numServoTimerInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numServoTimerInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numServoTimerInterval.Name = "numServoTimerInterval";
            this.numServoTimerInterval.Size = new System.Drawing.Size(105, 21);
            this.numServoTimerInterval.TabIndex = 7;
            this.numServoTimerInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblServoTimerInterval
            // 
            this.lblServoTimerInterval.ForeColor = System.Drawing.Color.Gray;
            this.lblServoTimerInterval.Location = new System.Drawing.Point(40, 152);
            this.lblServoTimerInterval.Name = "lblServoTimerInterval";
            this.lblServoTimerInterval.Size = new System.Drawing.Size(104, 24);
            this.lblServoTimerInterval.TabIndex = 6;
            this.lblServoTimerInterval.Text = "定时器间隔：";
            this.lblServoTimerInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(457, 298);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选项";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabServo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numServoDefaultPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoMaxPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoMinPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoTimerInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabServo;
        private System.Windows.Forms.NumericUpDown numServoDefaultPW;
        private System.Windows.Forms.Label lblServoDefaultPW;
        private System.Windows.Forms.NumericUpDown numServoMinPW;
        private System.Windows.Forms.Label lblServoMinPW;
        private System.Windows.Forms.NumericUpDown numServoMaxPW;
        private System.Windows.Forms.Label lblServoMaxPW;
        private System.Windows.Forms.NumericUpDown numServoTimerInterval;
        private System.Windows.Forms.Label lblServoTimerInterval;
    }
}