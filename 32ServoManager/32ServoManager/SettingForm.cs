using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _32ServoManager
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    Properties.Settings.Default.ServoDefaultPW = Convert.ToByte(this.numServoDefaultPW.Value);
                    Properties.Settings.Default.ServoMaxPW = Convert.ToByte(this.numServoMaxPW.Value);
                    Properties.Settings.Default.ServoMinPW = Convert.ToByte(this.numServoMinPW.Value);
                    Properties.Settings.Default.ServoTimerInterval = Convert.ToInt32(this.numServoTimerInterval.Value);
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex) { throw new Exception("关闭主窗口错误!\r\n错误信息:" + ex.Message); }
        }

        private void SettingForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.numServoDefaultPW.Value = Properties.Settings.Default.ServoDefaultPW;
                this.numServoMaxPW.Value = Properties.Settings.Default.ServoMaxPW;
                this.numServoMinPW.Value = Properties.Settings.Default.ServoMinPW;
                this.numServoTimerInterval.Value = Properties.Settings.Default.ServoTimerInterval;
            }
            catch (Exception ex) { throw new Exception("显示主窗口错误!\r\n错误信息:" + ex.Message); }
        }
    }
}
