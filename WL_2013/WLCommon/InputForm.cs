using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon
{
    public partial class InputForm : Form
    {
        public int InputMaxLength { set { this.cboList.MaxLength = value; } }
        public string InputCaption { set { this.lblInput.Text = value; } }
        public string InputValue { get { return this.cboList.Text; } set { this.cboList.Text = value; } }
        public ComboBox List { get { return this.cboList; } set { this.cboList = value; } }
        public bool MustContain { private get; set; }
        public bool MustInput { private get; set; }

        public bool CheckVisible { set { this.chkInputCheck.Visible = value; } }
        public string CheckCaption { set { this.chkInputCheck.Text = value; } }
        public bool CheckValue { set { this.chkInputCheck.Checked = value; } get { return this.chkInputCheck.Checked; } }

        public bool ConfirmState { set; private get; }
        public String ConfirmCaption { set; private get; }
        public String ConfirmString { set; private get; }

        public void Add(string str)
        {
            this.List.Items.Add(str);
        }

        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;
                    if (MustInput && this.cboList.Text == string.Empty) throw new IndexOutOfRangeException("未选择输入数据！");
                    if(MustContain && !this.cboList.Items.Contains(this.cboList.Text)) throw new ApplicationException("列表中不包含输入数据！");
                    if (ConfirmState && MessageBox.Show(string.Format(ConfirmString, this.cboList.Text), ConfirmCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void InputForm_Shown(object sender, EventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
