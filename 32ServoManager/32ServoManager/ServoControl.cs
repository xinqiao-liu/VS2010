using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _32ServoManager
{
    public enum Direction { INC, DEC };

    public partial class ServoControl : UserControl
    {
        public Direction direction = Direction.INC;

        [CategoryAttribute("ServoText"), DescriptionAttribute("舵机名称")]
        public String ServoText
        {
            get { return this.grpServo.Text; }
            set { this.grpServo.Text = value; }
        }

        [CategoryAttribute("ServoSN"), DescriptionAttribute("舵机编号")]
        public Byte ServoSN { get; set; }

        [CategoryAttribute("ServoPW"), DescriptionAttribute("舵机脉宽")]
        public Byte ServoPW
        {
            get { return Convert.ToByte(this.txtPW.Value); }
            set 
            { 
                this.txtPW.Value = value;
                this.barPW.Value = value;
            }
        }

        [CategoryAttribute("ServoMaxPW"), DescriptionAttribute("舵机最大脉宽")]
        public Byte ServoMaxPW
        {
            get { return Convert.ToByte(this.txtPW.Maximum); }
            set 
            { 
                this.txtPW.Maximum = value;
                this.barPW.Maximum = value;
            }
        }

        [CategoryAttribute("ServoMinPW"), DescriptionAttribute("舵机最小脉宽")]
        public Byte ServoMinPW
        {
            get { return Convert.ToByte(this.txtPW.Minimum); }
            set 
            { 
                this.txtPW.Minimum = value;
                this.barPW.Minimum = value;
            }
        }

        [CategoryAttribute("ServoEnabled"), DescriptionAttribute("舵机使能")]
        public Boolean ServoEnabled
        {
            get { return this.chkEnabled.Checked; }
            set { this.chkEnabled.Checked = value; }
        }

        [CategoryAttribute("ServoTimerInterval"), DescriptionAttribute("舵机定时增减")]
        public Int32 ServoTimerInterval
        {
            get { return this.timer.Interval; }
            set { this.timer.Interval = value; }
        }

        public ServoControl()
        {
            InitializeComponent();
        }

        private void chkTimer_CheckedChanged(object sender, EventArgs e)
        {
            this.timer.Enabled = this.chkTimer.Checked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.direction == Direction.INC && this.txtPW.Value + 1 <= this.txtPW.Maximum)
                this.txtPW.Value++;
            else
                this.direction = Direction.DEC;

            if (this.direction == Direction.DEC && this.txtPW.Value - 1 >= this.txtPW.Minimum)
                this.txtPW.Value--;
            else
                this.direction = Direction.INC;
        }

        private void txtPW_ValueChanged(object sender, EventArgs e)
        {
            this.barPW.Value = Convert.ToInt32(this.txtPW.Value);
        }

        private void barPW_ValueChanged(object sender, EventArgs e)
        {
            this.txtPW.Value = this.barPW.Value;
        }
    }
}
