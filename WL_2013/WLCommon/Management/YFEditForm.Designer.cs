namespace WLCommon.Management
{
    partial class YFEditForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBW = new System.Windows.Forms.Label();
            this.lblBF = new System.Windows.Forms.Label();
            this.numBW = new System.Windows.Forms.NumericUpDown();
            this.numBF = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.Label();
            this.lblL2 = new System.Windows.Forms.Label();
            this.numEM = new System.Windows.Forms.NumericUpDown();
            this.lblL1 = new System.Windows.Forms.Label();
            this.lblL0 = new System.Windows.Forms.Label();
            this.numSM = new System.Windows.Forms.NumericUpDown();
            this.lblExcessHint = new System.Windows.Forms.Label();
            this.lblFactor = new System.Windows.Forms.Label();
            this.lblExcess = new System.Windows.Forms.Label();
            this.lblWeightHint = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.numFactor = new System.Windows.Forms.NumericUpDown();
            this.numExcess = new System.Windows.Forms.NumericUpDown();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(328, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.label3);
            this.tabPage.Controls.Add(this.lblBW);
            this.tabPage.Controls.Add(this.lblBF);
            this.tabPage.Controls.Add(this.numBW);
            this.tabPage.Controls.Add(this.numBF);
            this.tabPage.Controls.Add(this.txtName);
            this.tabPage.Controls.Add(this.lblL2);
            this.tabPage.Controls.Add(this.numEM);
            this.tabPage.Controls.Add(this.lblL1);
            this.tabPage.Controls.Add(this.lblL0);
            this.tabPage.Controls.Add(this.numSM);
            this.tabPage.Controls.Add(this.lblExcessHint);
            this.tabPage.Controls.Add(this.lblFactor);
            this.tabPage.Controls.Add(this.lblExcess);
            this.tabPage.Controls.Add(this.lblWeightHint);
            this.tabPage.Controls.Add(this.lblWeight);
            this.tabPage.Controls.Add(this.numFactor);
            this.tabPage.Controls.Add(this.numExcess);
            this.tabPage.Controls.Add(this.numWeight);
            this.tabPage.Controls.Add(this.lblName);
            this.tabPage.Location = new System.Drawing.Point(4, 24);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(480, 284);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "常规";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "（每件）";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBW
            // 
            this.lblBW.ForeColor = System.Drawing.Color.Gray;
            this.lblBW.Location = new System.Drawing.Point(16, 144);
            this.lblBW.Name = "lblBW";
            this.lblBW.Size = new System.Drawing.Size(116, 23);
            this.lblBW.TabIndex = 10;
            this.lblBW.Text = "按重量计费：";
            this.lblBW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBF
            // 
            this.lblBF.ForeColor = System.Drawing.Color.Gray;
            this.lblBF.Location = new System.Drawing.Point(16, 104);
            this.lblBF.Name = "lblBF";
            this.lblBF.Size = new System.Drawing.Size(116, 23);
            this.lblBF.TabIndex = 7;
            this.lblBF.Text = "按文件计费：";
            this.lblBF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBW
            // 
            this.numBW.DecimalPlaces = 2;
            this.numBW.Location = new System.Drawing.Point(136, 144);
            this.numBW.Name = "numBW";
            this.numBW.Size = new System.Drawing.Size(112, 21);
            this.numBW.TabIndex = 11;
            this.numBW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numBF
            // 
            this.numBF.DecimalPlaces = 2;
            this.numBF.Location = new System.Drawing.Point(136, 104);
            this.numBF.Name = "numBF";
            this.numBF.Size = new System.Drawing.Size(112, 21);
            this.numBF.TabIndex = 8;
            this.numBF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(136, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 24);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblL2
            // 
            this.lblL2.Location = new System.Drawing.Point(400, 64);
            this.lblL2.Name = "lblL2";
            this.lblL2.Size = new System.Drawing.Size(56, 23);
            this.lblL2.TabIndex = 6;
            this.lblL2.Text = "公里";
            this.lblL2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEM
            // 
            this.numEM.Location = new System.Drawing.Point(280, 64);
            this.numEM.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numEM.Name = "numEM";
            this.numEM.ReadOnly = true;
            this.numEM.Size = new System.Drawing.Size(112, 21);
            this.numEM.TabIndex = 5;
            this.numEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblL1
            // 
            this.lblL1.Location = new System.Drawing.Point(248, 64);
            this.lblL1.Name = "lblL1";
            this.lblL1.Size = new System.Drawing.Size(24, 23);
            this.lblL1.TabIndex = 4;
            this.lblL1.Text = "至";
            this.lblL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblL0
            // 
            this.lblL0.ForeColor = System.Drawing.Color.Gray;
            this.lblL0.Location = new System.Drawing.Point(16, 64);
            this.lblL0.Name = "lblL0";
            this.lblL0.Size = new System.Drawing.Size(116, 23);
            this.lblL0.TabIndex = 2;
            this.lblL0.Text = "标准里程范围：";
            this.lblL0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numSM
            // 
            this.numSM.Location = new System.Drawing.Point(136, 64);
            this.numSM.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numSM.Name = "numSM";
            this.numSM.ReadOnly = true;
            this.numSM.Size = new System.Drawing.Size(112, 21);
            this.numSM.TabIndex = 3;
            this.numSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblExcessHint
            // 
            this.lblExcessHint.Location = new System.Drawing.Point(248, 208);
            this.lblExcessHint.Name = "lblExcessHint";
            this.lblExcessHint.Size = new System.Drawing.Size(72, 23);
            this.lblExcessHint.TabIndex = 17;
            this.lblExcessHint.Text = "（每公斤）";
            this.lblExcessHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFactor
            // 
            this.lblFactor.ForeColor = System.Drawing.Color.Gray;
            this.lblFactor.Location = new System.Drawing.Point(16, 240);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(116, 23);
            this.lblFactor.TabIndex = 18;
            this.lblFactor.Text = "体积折算系数：";
            this.lblFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExcess
            // 
            this.lblExcess.ForeColor = System.Drawing.Color.Gray;
            this.lblExcess.Location = new System.Drawing.Point(16, 208);
            this.lblExcess.Name = "lblExcess";
            this.lblExcess.Size = new System.Drawing.Size(116, 23);
            this.lblExcess.TabIndex = 15;
            this.lblExcess.Text = "续重金额：";
            this.lblExcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWeightHint
            // 
            this.lblWeightHint.Location = new System.Drawing.Point(248, 176);
            this.lblWeightHint.Name = "lblWeightHint";
            this.lblWeightHint.Size = new System.Drawing.Size(72, 23);
            this.lblWeightHint.TabIndex = 14;
            this.lblWeightHint.Text = "（公斤）";
            this.lblWeightHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeight
            // 
            this.lblWeight.ForeColor = System.Drawing.Color.Gray;
            this.lblWeight.Location = new System.Drawing.Point(16, 176);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(116, 23);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "起步重量：";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numFactor
            // 
            this.numFactor.DecimalPlaces = 2;
            this.numFactor.Location = new System.Drawing.Point(136, 240);
            this.numFactor.Name = "numFactor";
            this.numFactor.Size = new System.Drawing.Size(112, 21);
            this.numFactor.TabIndex = 19;
            this.numFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numExcess
            // 
            this.numExcess.DecimalPlaces = 2;
            this.numExcess.Location = new System.Drawing.Point(136, 208);
            this.numExcess.Name = "numExcess";
            this.numExcess.Size = new System.Drawing.Size(112, 21);
            this.numExcess.TabIndex = 16;
            this.numExcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(136, 176);
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(112, 21);
            this.numWeight.TabIndex = 13;
            this.numWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(32, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "运费标准名称：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(488, 312);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // YFEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 377);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YFEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YFEditForm_FormClosing);
            this.Shown += new System.EventHandler(this.YFEditForm_Shown);
            this.tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblExcessHint;
        private System.Windows.Forms.Label lblFactor;
        private System.Windows.Forms.Label lblExcess;
        private System.Windows.Forms.Label lblWeightHint;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown numFactor;
        private System.Windows.Forms.NumericUpDown numExcess;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label lblL2;
        private System.Windows.Forms.NumericUpDown numEM;
        private System.Windows.Forms.Label lblL1;
        private System.Windows.Forms.Label lblL0;
        private System.Windows.Forms.NumericUpDown numSM;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label lblBW;
        private System.Windows.Forms.Label lblBF;
        private System.Windows.Forms.NumericUpDown numBW;
        private System.Windows.Forms.NumericUpDown numBF;
        private System.Windows.Forms.Label label3;
    }
}