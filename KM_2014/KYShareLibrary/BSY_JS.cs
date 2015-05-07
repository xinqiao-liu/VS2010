using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace KM.Common
{
    public static class BSY_JS
    {
        public static void Create(SqlConnection oneConn, SqlConnection twoConn, String cc, bool allowNullBalance, bool allowWQDBalance, bool balanceAccountDLF)
        {
            //获取本售异班次数据
            KM.Data.BCK bcItem = KM.Data.BCK.Read(twoConn, Runtime.QueryDate, cc);
            if (bcItem == null)
                throw new ApplicationException("不能读取指定班次 " + cc + " 数据");

            //获取本售异车辆数据
            KM.Data.CLK clItem = KM.Data.CLK.Read(twoConn, bcItem.CPH);
            if (clItem == null)
                throw new ApplicationException("不能读取指定车辆(" + bcItem.CPH + ")数据");

            //结算前检测是否签到、空结算
            //if (!allowWQDBalance && bcItem.BDSJ == DateTime.MaxValue) throw new ApplicationException("班次 " + cc + " 未签到");
            //if (!allowNullBalance && bcItem.SCS == 0) throw new ApplicationException("班次 " + cc + " 零客票");

            if (KM.Data.JSD.Exists(oneConn, Runtime.QueryDate, cc)) JS.Delete(oneConn, Runtime.QueryDate, cc);

            //创建结算单编号并插入结算记录
            String bh = KM.Data.JSD.CreateBH(oneConn, Runtime.Setting.PJWS);
            if (bh != string.Empty)
                JS.Insert(oneConn, KM.Data.CPB.Reads_JSDMX(twoConn, bcItem.RQ, bcItem.CC), bh, bcItem, clItem, balanceAccountDLF, true);
            else
                throw new ApplicationException("不能创建结算单编号，终止结算");
        }
    }
}
