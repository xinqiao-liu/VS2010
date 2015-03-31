using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Common
{
    internal class ColumnSort : IComparer
    {
        private int columnNum = 0;
        public bool bAscending = true;

        public ColumnSort(int column_to_sort)
        {
            columnNum = column_to_sort;
        }
        public int Compare(object a, object b)
        {
            System.Windows.Forms.ListViewItem listItemA = (System.Windows.Forms.ListViewItem)a;
            System.Windows.Forms.ListViewItem listItemB = (System.Windows.Forms.ListViewItem)b;
            if (listItemA.SubItems[columnNum] == null || listItemA.SubItems[columnNum].ToString() == string.Empty)
            {
                return -1;
            }
            if (listItemB.SubItems[columnNum] == null || listItemB.SubItems[columnNum].ToString() == string.Empty)
            {
                return -1;
            }
            if (bAscending)
            {
                return String.Compare(listItemA.SubItems[columnNum].ToString(), listItemB.SubItems[columnNum].ToString());
            }
            else
            {
                return -1 * String.Compare(listItemA.SubItems[columnNum].ToString(), listItemB.SubItems[columnNum].ToString());
            }
        }
    }
}
