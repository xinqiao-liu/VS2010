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
    public partial class TextBoxEx : TextBox
    {
        public bool AutoSelectNextControl { get; set; }
        public bool EnterSelectAll { get; set; }
        public bool MustNonEmpty { get; set; }
        public Color EmptyBackColor { get; set; }
        public Color EmptyForeColor { get; set; }
        public Color NonEmptyBackColor { get; set; }
        public Color NonEmptyForeColor { get; set; }

        private void EnterEvent()
        {
            if (this.EnterSelectAll) this.SelectAll();
        }

        public TextBoxEx()
        {
            InitializeComponent();

            this.AutoSelectNextControl = true;
            this.EnterSelectAll = true;
            this.MustNonEmpty = true;
            this.EmptyBackColor = this.BackColor;
            this.EmptyForeColor = this.ForeColor;
            this.NonEmptyBackColor = this.BackColor;
            this.NonEmptyForeColor = this.ForeColor;
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
    }
}
