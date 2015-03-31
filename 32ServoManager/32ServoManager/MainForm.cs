using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace _32ServoManager
{
    public partial class MainForm : Form
    {
        private Int32 m_ServoCount = 0;
        private Int32 m_ScriptCount = 0;
        private Int32 m_ScriptIndex = 0;
        private String m_FileName = string.Empty;

        public Int32 ServoCount
        {
            get { return m_ServoCount; }
            set 
            { 
                m_ServoCount = value;

                this.miSaveScript.Enabled = (this.FileName != string.Empty || this.ServoCount > 0 || this.ScriptCount > 0);
                this.txtServoCount.Text = value.ToString();

                this.btnAppendServo.Enabled = (value < 32);
                this.btnDeleteServo.Enabled = (value > 0);
                this.btnAllEnabled.Enabled = (value > 0);
                this.btnAllDisable.Enabled = (value > 0);
                this.chkRealtimeTrack.Enabled = (value > 0 && this.btnSendScript.Text == "发送脚本");
                this.btnAppendItem.Enabled = (value > 0);
            }
        }

        public Int32 ScriptCount
        {
            get { return m_ScriptCount; }
            set 
            { 
                m_ScriptCount = value;

                this.miSaveScript.Enabled = (this.FileName != string.Empty || this.ServoCount > 0 || this.ScriptCount > 0);
                this.txtScriptCount.Text = value.ToString();

                this.btnDeleteItem.Enabled = (value > 0 && this.lstScript.SelectedIndex >= 0);
                this.btnEditItem.Enabled = (value > 0 && this.lstScript.SelectedIndex >= 0 
                    && this.lstScript.SelectedItems.Count == 1);
                this.btnInsertItem.Enabled = (value > 0 && this.lstScript.SelectedIndex >= 0);
                this.btnMoveupItem.Enabled = (value > 0 && this.lstScript.SelectedIndex > 0
                    && this.lstScript.SelectedItems.Count == 1);
                this.btnMovedownItem.Enabled = (value > 0 && this.lstScript.SelectedIndex >= 0 && this.lstScript.SelectedIndex < this.lstScript.Items.Count - 1 
                    && this.lstScript.SelectedItems.Count == 1);
                this.btnSendScript.Enabled = (value > 0 && !this.chkRealtimeTrack.Checked);
            }
        }
        
        public Int32 ScriptIndex
        {
            get { return m_ScriptIndex; }
            set { m_ScriptIndex = value; }
        }

        private String FileName
        {
            get { return m_FileName; }
            set
            {
                m_FileName = value;

                this.miSaveScript.Enabled = (this.FileName != string.Empty || this.ServoCount > 0 || this.ScriptCount > 0);
            }
        }

        private System.Windows.Forms.DialogResult NeedToSave(string msg)
        {
            if (this.FileName != string.Empty || this.ServoCount > 0 || this.ScriptCount > 0)
                return MessageBox.Show(msg, "确认", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            else
                return System.Windows.Forms.DialogResult.No;
        }

        private void OpenFile(string filename)
        {
        }

        private void OpenScript()
        {
            if (NeedToSave("是否保存脚本？") == System.Windows.Forms.DialogResult.Yes) this.SaveScript();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.AddExtension = true;
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.DefaultExt = "ssx";
                openFileDialog.Filter = "Servo script files (*.ssx)|*.ssx";
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "打开舵机脚本";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    this.FileName = openFileDialog.FileName;
                else
                    return;
            }
            this.OpenFile(this.FileName);
        }

        private void SaveFile(string filename)
        {
        }

        private void SaveScript()
        {
            if (this.FileName == string.Empty)
            {
                if(this.ServoCount <= 0 && this.ScriptCount <= 0) return;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.DefaultExt = "ssx";
                    saveFileDialog.Filter = "Servo script files (*.ssx)|*.ssx";
                    saveFileDialog.InitialDirectory = Application.StartupPath;
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.Title = "保存舵机脚本";
                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        this.FileName = saveFileDialog.FileName;
                    else
                        return;
                }
            }
            this.SaveFile(this.FileName);  
        }

        private void AppendServo(Int32 value)
        {
            Int32 count = this.flowLayoutPanel.Controls.Count;
            for (int i = count; i < value + count; i++)
            {
                if (this.flowLayoutPanel.Controls.Count > 32)
                {
                    MessageBox.Show("最多只能添加32路舵机！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ServoControl servoControl = new ServoControl();
                servoControl.Name = "servoControl" + i.ToString();
                servoControl.ServoText = "舵机 " + (i + 1).ToString("00");
                servoControl.ServoEnabled = true;
                servoControl.ServoSN = ((byte)(i));
                servoControl.ServoPW = Properties.Settings.Default.ServoDefaultPW;
                servoControl.ServoMaxPW = Properties.Settings.Default.ServoMaxPW;
                servoControl.ServoMinPW = Properties.Settings.Default.ServoMinPW;
                servoControl.ServoTimerInterval = Properties.Settings.Default.ServoTimerInterval;
                servoControl.TabIndex = i;
                this.flowLayoutPanel.Controls.Add(servoControl);
            }
        }

        private void DeleteServo(Int32 value)
        {
            for (int i = 0; i < value; i++)
            {
                if (this.flowLayoutPanel.Controls.Count > 0)
                {
                    this.flowLayoutPanel.Controls.RemoveAt(this.flowLayoutPanel.Controls.Count - 1);
                }
            }
        }

        private ScriptItem GetScriptItem()
        {
            ScriptItem scriptItem = new ScriptItem();
            foreach (ServoControl item in this.flowLayoutPanel.Controls)
            {
                if (item.ServoEnabled) scriptItem.Add(new ServoItem() { SN = item.ServoSN, PW = item.ServoPW });
            }
            return scriptItem;
        }

        public void SendScriptItem(Byte[] bytes)
        {
            this.serialPort.Write(bytes, 0, bytes.Length);
        }

        private void InitPortNames()
        {
            this.cboSendPortName.Items.Clear();
            this.cboSendPortName.Items.AddRange(SerialPort.GetPortNames());
        }

        private void InitSerialPort()
        {
            if (this.cboSendPortName.SelectedIndex < 0)
                throw new ArgumentException("未指定发送端口名称！");
            else
                serialPort.PortName = this.cboSendPortName.Text;

            if (this.cboSendPortBaud.SelectedIndex < 0)
                throw new ArgumentException("未指定发送端口波特率！");
            else
                serialPort.BaudRate = Convert.ToInt32(this.cboSendPortBaud.Text);
        }

        private void OpenSerialPort()
        {
            if (!this.serialPort.IsOpen) this.serialPort.Open();
        }

        private void CloseSerialPort()
        {
            if (this.serialPort.IsOpen) this.serialPort.Close();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //保存发送配置
                Properties.Settings.Default.SendPortName = this.cboSendPortName.Text;
                Properties.Settings.Default.SendPortBaud = this.cboSendPortBaud.Text;
                Properties.Settings.Default.SendInterval = Convert.ToInt32(this.numSendInterval.Value);
                Properties.Settings.Default.SendingLoop = this.chkSendingLoop.Checked;
                //保存窗口状态
                Properties.Settings.Default.WindowState = this.WindowState;
                Properties.Settings.Default.WindowLocation = this.Location;
                Properties.Settings.Default.WindowSize = this.Size;

                Properties.Settings.Default.Save();

                switch(NeedToSave("是否退出并保存脚本？"))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        this.SaveScript();
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { throw new Exception("关闭主窗口错误!\r\n错误信息:" + ex.Message); }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.InitPortNames();
                //恢复发送配置
                this.cboSendPortName.SelectedIndex = this.cboSendPortName.FindStringExact(Properties.Settings.Default.SendPortName);
                this.cboSendPortBaud.SelectedIndex = this.cboSendPortBaud.FindStringExact(Properties.Settings.Default.SendPortBaud);
                this.numSendInterval.Value = Properties.Settings.Default.SendInterval;
                this.chkSendingLoop.Checked = Properties.Settings.Default.SendingLoop;
                //恢复窗口状态
                this.WindowState = Properties.Settings.Default.WindowState;
                this.Location = Properties.Settings.Default.WindowLocation;
                if (!Properties.Settings.Default.WindowSize.IsEmpty)
                    this.Size = Properties.Settings.Default.WindowSize;
            }
            catch (Exception ex) { throw new Exception("显示主窗口错误!\r\n错误信息:" + ex.Message); }
        }

        private void flowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                this.ServoCount = this.flowLayoutPanel.Controls.Count;
            }
            catch (Exception ex) { throw new Exception("添加舵机错误!\r\n错误信息:" + ex.Message); }
        }

        private void flowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            try
            {
                this.ServoCount = this.flowLayoutPanel.Controls.Count;
            }
            catch (Exception ex) { throw new Exception("删除舵机错误!\r\n错误信息:" + ex.Message); }
        }

        private void lstScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ScriptCount = this.lstScript.Items.Count;
            }
            catch (Exception ex) { throw new Exception("脚本选择错误!\r\n错误信息:" + ex.Message); }
        }

        private void cboSendPort_DropDown(object sender, EventArgs e)
        {
            try
            {
                this.InitPortNames();
            }
            catch (Exception ex) { throw new Exception("获取本机串口列表失败!\r\n错误信息:" + ex.Message); }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try { }
            catch (Exception ex) { throw new Exception("串口接收错误!\r\n错误信息:" + ex.Message); }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.timer.Tag) == 0)
                    this.SendScriptItem(this.GetScriptItem().ToArray());
                else
                {
                    this.SendScriptItem(((ScriptItem)this.lstScript.Items[this.ScriptIndex++]).ToArray());

                    if (this.ScriptIndex == this.ScriptCount)
                    {
                        if (this.chkSendingLoop.Checked)
                            this.ScriptIndex = 0;
                        else
                            this.btnSendScript_Click(sender, e);
                    }
                }
            }
            catch (Exception ex) { throw new Exception("实时定时器错误!\r\n错误信息:" + ex.Message); }
        }

        private void chkRealtimeTrack_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkRealtimeTrack.Checked)
                {
                    this.InitSerialPort();
                    this.OpenSerialPort();

                    this.timer.Tag = 0;
                    this.timer.Interval = Convert.ToInt32(this.numSendInterval.Value);                    
                }
                else
                    this.CloseSerialPort();

                this.cboSendPortName.Enabled = !this.chkRealtimeTrack.Checked;
                this.cboSendPortBaud.Enabled = !this.chkRealtimeTrack.Checked;
                this.numSendInterval.Enabled = !this.chkRealtimeTrack.Checked;
                this.timer.Enabled = this.chkRealtimeTrack.Checked;
                this.ScriptCount = this.ScriptCount;
            }
            catch (Exception ex) { throw new Exception("实时控制错误!\r\n错误信息:" + ex.Message); }
        }

        private void miNewScript_Custom_Click(object sender, EventArgs e)
        {
            try
            {
                this.SaveScript();

                Int32 value = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
                if (value == 0)
                {
                    using (ValueForm valueForm = new ValueForm())
                    {
                        valueForm.MinValue = 1;
                        valueForm.MaxValue = 32;
                        valueForm.Value = 8;
                        if (valueForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            value = valueForm.Value;
                        else
                            return;
                    }
                }
                this.flowLayoutPanel.Controls.Clear();
                this.AppendServo(value);
                this.FileName = string.Empty;
            }
            catch (Exception ex) { throw new Exception("新建脚本错误!\r\n错误信息:" + ex.Message); }
        }

        private void miOpenScript_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenScript();
            }
            catch (Exception ex) { throw new Exception("打开脚本错误!\r\n错误信息:" + ex.Message); }
        }

        private void miSaveScript_Click(object sender, EventArgs e)
        {
            try
            {
                this.SaveScript();
            }
            catch (Exception ex) { throw new Exception("保存脚本错误!\r\n错误信息:" + ex.Message); }
        }

        private void miSetting_Click(object sender, EventArgs e)
        {
            try
            {
                using (SettingForm settingForm = new SettingForm())
                {
                    if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
                }
            }
            catch (Exception ex) { throw new Exception("本地设置错误!\r\n错误信息:" + ex.Message); }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAppendServo_Click(object sender, EventArgs e)
        {
            try
            {
                this.AppendServo(1);
            }
            catch (Exception ex) { throw new Exception("添加舵机错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnDeleteServo_Click(object sender, EventArgs e)
        {
            try
            {
                this.DeleteServo(1);
            }
            catch (Exception ex) { throw new Exception("删除舵机错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnAllEnabled_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ServoControl item in this.flowLayoutPanel.Controls)
                {
                    item.ServoEnabled = true;
                }
            }
            catch (Exception ex) { throw new Exception("全部使能错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnAllDisable_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ServoControl item in this.flowLayoutPanel.Controls)
                {
                    item.ServoEnabled = false;
                }
            }
            catch (Exception ex) { throw new Exception("全部禁用错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnAppendItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstScript.Items.Add(this.GetScriptItem());

                this.ScriptCount = this.lstScript.Items.Count;
            }
            catch (Exception ex) { throw new Exception("添加项错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = this.lstScript.SelectedItems.Count - 1; i > -1; i--)
                {
                    this.lstScript.Items.Remove(this.lstScript.SelectedItems[i]);
                }
                this.ScriptCount = this.lstScript.Items.Count;
            }
            catch (Exception ex) { throw new Exception("删除项错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { throw new Exception("编辑项错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnInsertItem_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { throw new Exception("插入项错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnMoveupItem_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 index = this.lstScript.SelectedIndex;
                Object item = this.lstScript.SelectedItem;

                this.lstScript.Items.Remove(this.lstScript.SelectedItem);
                this.lstScript.Items.Insert(index - 1, item);
                this.lstScript.SelectedIndex = index - 1;
            }
            catch (Exception ex) { throw new Exception("上移项错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnMovedownItem_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 index = this.lstScript.SelectedIndex;
                Object item = this.lstScript.SelectedItem;

                this.lstScript.Items.Remove(this.lstScript.SelectedItem);
                this.lstScript.Items.Insert(index + 1, item);
                this.lstScript.SelectedIndex = index + 1;
            }
            catch (Exception ex) { throw new Exception("下移项错误!\r\n错误信息:" + ex.Message); }
        }

        private void btnSendScript_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnSendScript.Text == "发送脚本")
                {
                    this.InitSerialPort();
                    this.OpenSerialPort();

                    this.btnSendScript.Text = "终止发送";
                    this.ScriptIndex = 0;
                    this.timer.Tag = 1;
                    this.timer.Interval = Convert.ToInt32(this.numSendInterval.Value);
                    this.timer.Enabled = true;
                }
                else
                {
                    this.timer.Enabled = false;
                    this.btnSendScript.Text = "发送脚本";

                    this.CloseSerialPort();
                }

                this.lstScript.Enabled = (this.btnSendScript.Text == "发送脚本");
                this.cboSendPortName.Enabled = (this.btnSendScript.Text == "发送脚本");
                this.cboSendPortBaud.Enabled = (this.btnSendScript.Text == "发送脚本");
                this.numSendInterval.Enabled = (this.btnSendScript.Text == "发送脚本");
                this.ServoCount = this.ServoCount;
            }
            catch (Exception ex) { throw new Exception("脚本发送错误!\r\n错误信息:" + ex.Message); }
        }
    }
}
