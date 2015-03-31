namespace _32ServoManager
{
    partial class ServoControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpServo = new System.Windows.Forms.GroupBox();
            this.chkTimer = new System.Windows.Forms.CheckBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.txtPW = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.barPW = new System.Windows.Forms.TrackBar();
            this.grpServo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPW)).BeginInit();
            this.SuspendLayout();
            // 
            // grpServo
            // 
            this.grpServo.Controls.Add(this.barPW);
            this.grpServo.Controls.Add(this.chkTimer);
            this.grpServo.Controls.Add(this.chkEnabled);
            this.grpServo.Controls.Add(this.txtPW);
            this.grpServo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpServo.Location = new System.Drawing.Point(0, 0);
            this.grpServo.Name = "grpServo";
            this.grpServo.Size = new System.Drawing.Size(170, 82);
            this.grpServo.TabIndex = 0;
            this.grpServo.TabStop = false;
            this.grpServo.Text = "舵机名称";
            // 
            // chkTimer
            // 
            this.chkTimer.AutoSize = true;
            this.chkTimer.Location = new System.Drawing.Point(120, 24);
            this.chkTimer.Name = "chkTimer";
            this.chkTimer.Size = new System.Drawing.Size(48, 16);
            this.chkTimer.TabIndex = 10;
            this.chkTimer.Text = "定时";
            this.chkTimer.UseVisualStyleBackColor = true;
            this.chkTimer.CheckedChanged += new System.EventHandler(this.chkTimer_CheckedChanged);
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.Location = new System.Drawing.Point(72, 24);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(48, 16);
            this.chkEnabled.TabIndex = 9;
            this.chkEnabled.Text = "使能";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // txtPW
            // 
            this.txtPW.ForeColor = System.Drawing.Color.Blue;
            this.txtPW.Location = new System.Drawing.Point(8, 24);
            this.txtPW.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.txtPW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(56, 21);
            this.txtPW.TabIndex = 8;
            this.txtPW.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtPW.ValueChanged += new System.EventHandler(this.txtPW_ValueChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // barPW
            // 
            this.barPW.Location = new System.Drawing.Point(8, 56);
            this.barPW.Name = "barPW";
            this.barPW.Size = new System.Drawing.Size(152, 45);
            this.barPW.TabIndex = 12;
            this.barPW.ValueChanged += new System.EventHandler(this.barPW_ValueChanged);
            // 
            // ServoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpServo);
            this.Name = "ServoControl";
            this.Size = new System.Drawing.Size(170, 82);
            this.grpServo.ResumeLayout(false);
            this.grpServo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServo;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.NumericUpDown txtPW;
        private System.Windows.Forms.CheckBox chkTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar barPW;

    }
}
