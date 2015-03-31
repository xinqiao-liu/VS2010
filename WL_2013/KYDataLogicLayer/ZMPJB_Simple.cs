using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace KYDataLogicLayer
{
    public static class ZMPJB_Simple
    {
        public static void Refresh(ComboBox list, DateTime date, string zddm)
        {
            list.Items.Clear();
            foreach (KYDataModelLayer.ZMPJB_Simple i in KYDataAccessLayer.ZMPJB_Simple.Reads(Runtime.B_CreateCommand(), zddm + "%", ""))
            {
                //确定站点代码是否存在可用班次
                if (KYDataAccessLayer.BCK.ExistByZDDM(Runtime.B_CreateCommand(), date, i.Code)) list.Items.Add(i);
            }

            if (list.Items.Count > 0) list.SelectedIndex = 0;
        }

        //public static List<KYDataModelLayer.ZMPJB_Simple> Reads(string zddm, string bdnm)
        //{
        //    return KYDataAccessLayer.ZMPJB_Simple.Reads(Runtime.B_CreateCommand(), zddm, bdnm);
        //}
    }
}
