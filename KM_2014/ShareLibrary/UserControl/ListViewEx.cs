using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class ListViewEx : ListView
    {
        public Color OneColor { get; set; }
        public Color TwoColor { get; set; }

        public ListViewEx()
        {
            InitializeComponent();

            this.SmallImageList = new ImageList() { ImageSize = new Size(1, 32) };

            this.ColumnClick += new ColumnClickEventHandler(ListViewEx_ColumnClick);
            this.DoubleBuffered = true;
            this.FullRowSelect = true;            
            //this.OwnerDraw = true;
            this.View = View.Details;
            //this.ShowItemToolTips = true;

            this.OneColor = SystemColors.Window;
            this.TwoColor = SystemColors.Window;
        }

        void ListViewEx_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSort columnSort = new ColumnSort(e.Column);
            columnSort.bAscending = (this.Sorting == System.Windows.Forms.SortOrder.Ascending);
            if (columnSort.bAscending)
            {
                this.Sorting = SortOrder.Descending;
            }
            else
            {
                this.Sorting = SortOrder.Ascending;
            }
            this.ListViewItemSorter = columnSort;
        }

        //protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        //{
        //    e.DrawBackground();
        //    e.DrawText();
        //    //base.OnDrawColumnHeader(e);
        //}

        //protected override void OnDrawItem(DrawListViewItemEventArgs e)
        //{
        //    if (e.ItemIndex % 2 == 0)
        //        e.Item.BackColor = this.OneColor;
        //    else
        //        e.Item.BackColor = this.TwoColor;
        //    base.OnDrawItem(e);
        //}

        //protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        //{
        //    if (e.ItemIndex % 2 == 0)
        //        e.SubItem.BackColor = this.OneColor;
        //    else
        //        e.SubItem.BackColor = this.TwoColor;
        //    base.OnDrawSubItem(e);
        //}

        //protected override void OnResize(EventArgs e)
        //{
        //    this.Columns[this.Columns.Count - 1].Width = -2;
        //    base.OnResize(e);
        //}

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
