using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class NumericUpDownEx : NumericUpDown
    {
        public bool AutoSelectNextControl { get; set; }
        public bool EnterSelectAll { get; set; }
        public bool MustNonZero { get; set; }
        public Color ZeroBackColor { get; set; }
        public Color ZeroForeColor { get; set; }
        public Color NonZeroBackColor { get; set; }
        public Color NonZeroForeColor { get; set; }

        private void EnterEvent()
        {
            if (this.EnterSelectAll) this.Select(0, 12);
        }

        public NumericUpDownEx()
        {
            InitializeComponent();

            this.AutoSelectNextControl = true;
            this.EnterSelectAll = true;
            this.MustNonZero = true;
            this.ZeroBackColor = this.BackColor;
            this.ZeroForeColor = this.ForeColor;
            this.NonZeroBackColor = this.BackColor;
            this.NonZeroForeColor = this.ForeColor;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.EnterEvent();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            this.EnterEvent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text.Trim().Length == 0)
                Text = "0";
            base.OnTextChanged(e);
        }
    }
}
