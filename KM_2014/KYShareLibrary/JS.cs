using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace KM.Common
{
    public sealed class JS
    {
        public static void InsertLog(SqlConnection conn, String mm, String cc)
        {
            try
            {
                KM.Data.CZJL.Insert(conn, new KM.Data.CZJL() { XM = Runtime.Name, SJ = DateTime.Now, CC = mm, JS = "对" + cc + "次车进行打印单据操作" });
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入操作日志发生异常（" + ex.Message + "）");
            }            
        }

        public static void Delete(SqlConnection conn, DateTime rq, String cc)
        {
            try
            {
                KM.Data.JSD jsItem = KM.Data.JSD.Read(conn, rq, cc);
                if (jsItem != null)
                {
                    using (SqlTransaction trn = conn.BeginTransaction())
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.Transaction = trn;
                            try
                            {
                                KM.Data.JSD.Delete(cmd, rq, cc);
                                KM.Data.JSDMXB.Delete(cmd, rq, cc);
                                KM.Data.JSDPJ.Disable(cmd, jsItem.JSDBH, rq, cc);

                                trn.Commit();
                            }
                            catch (Exception ex)
                            {
                                trn.Rollback();
                                throw ex;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除结算数据发生异常（" + ex.Message + "）");
            }
        }

        public static void Insert(SqlConnection conn, List<KM.Data.JSDMXB> mxlist, String bh, KM.Data.BCK bcItem, KM.Data.CLK clItem, bool balanceAccountDLF, bool BSY_JP)
        {
            try
            {
                using (SqlTransaction trn = conn.BeginTransaction())
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trn;
                        try
                        {
                            KM.Data.JSD.Insert(cmd, CreateJSD(bh, bcItem, clItem, KM.Data.CPCollect.Read(cmd, bcItem.RQ, bcItem.CC), balanceAccountDLF));
                            KM.Data.JSDPJ.Insert(cmd, CreateJSDPJ(bh, bcItem.RQ, bcItem.CC));
                            KM.Data.JSDMXB.Insert(cmd, mxlist);

                            if (!BSY_JP) KM.Data.BCK.SetState(cmd, bcItem.RQ, bcItem.CC, BCState.结算);

                            KM.Data.CZJL.Insert(cmd, new KM.Data.CZJL() { XM = Runtime.Name, SJ = DateTime.Now, CC = "班次结算", JS = "对" + bcItem.CC + "次车进行结算操作" });

                            trn.Commit();
                        }
                        catch (Exception ex)
                        {
                            trn.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("插入结算数据发生异常（" + ex.Message + "）");
            }
        }

        public static KM.Data.JSDPJ CreateJSDPJ(String bh, DateTime rq, String cc)
        {
            try
            {
                KM.Data.JSDPJ pjItem = new KM.Data.JSDPJ();

                pjItem.BH = bh;
                pjItem.RQ = rq;
                pjItem.CC = cc;
                pjItem.BZ = " ";
                pjItem.CZ = Runtime.Name;
                pjItem.SJ = DateTime.Now;

                return pjItem;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("生成结算票据记录异常（" + ex.Message + "）");
            }
        }

        public static KM.Data.JSD CreateJSD(String bh, KM.Data.BCK bcItem, KM.Data.CLK clItem, KM.Data.CPCollect cpItem, bool balanceAccountDLF)
        {
            try
            {
                KM.Data.JSD jsItem = new KM.Data.JSD();

                jsItem.KYZBM = Runtime.Setting.BM;
                jsItem.KYZMC = Runtime.Setting.MC;
                jsItem.JSDBH = bh;
                jsItem.RQ = bcItem.RQ;
                jsItem.CC = bcItem.CC;
                jsItem.ZDZ = bcItem.ZDZ;
                jsItem.FCSJ = bcItem.FCSJ;
                jsItem.CPH = bcItem.CPH;
                jsItem.JSDM = clItem.JSDM;
                jsItem.CSDW = clItem.CSDW;
                jsItem.XM = "";//车辆数据.司机姓名;

                if (cpItem != null)
                {
                    jsItem.JSZS = cpItem.JSZS;
                    jsItem.KPPK = cpItem.KPPK;
                    jsItem.KBXF = cpItem.KBXF;
                    jsItem.RYF = cpItem.KRYF;
                }
                else
                {
                    jsItem.JSZS = 0;
                    jsItem.KPPK = 0;
                    jsItem.KBXF = 0;
                    jsItem.RYF = 0;
                }
                jsItem.PKBL = clItem.BZ7;
                jsItem.KFJF = 0;

                jsItem.XBBS = 0;
                jsItem.XBJS = 0;
                jsItem.XBYF = 0;
                jsItem.XBBL = clItem.BZ8;

                //计算代理费
                if (balanceAccountDLF)
                {
                    jsItem.PKDLF = Decimal.Ceiling(jsItem.KPPK * jsItem.PKBL) / 100;
                    jsItem.JSPK = jsItem.KPPK - jsItem.PKDLF;

                    jsItem.XBDLF = Decimal.Ceiling(jsItem.XBYF * jsItem.XBBL) / 100;
                    jsItem.XBK = jsItem.XBYF - jsItem.XBDLF;
                }
                else
                {
                    jsItem.PKDLF = 0;
                    jsItem.JSPK = jsItem.KPPK;

                    jsItem.XBDLF = 0;
                    jsItem.XBK = jsItem.XBYF;
                }

                jsItem.FKJE = 0;
                jsItem.DBFK = 0;
                jsItem.HJJE = jsItem.JSPK + jsItem.RYF + jsItem.XBK - jsItem.FKJE - jsItem.DBFK;
                jsItem.FCBZ = "";
                jsItem.JSCZ = Runtime.Name;
                jsItem.BXBZ = 0;
                jsItem.FJBZ = 0;
                jsItem.JZBZ = "N";
                jsItem.JZDBH = "";
                jsItem.JZDWMC = "";
                jsItem.JZCZY = "";

                return jsItem;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("生成结算记录异常（" + ex.Message + "）");
            }
        }

        public static void Create(SqlConnection conn, String cc, bool allowNullBalance, bool allowWQDBalance, bool balanceAccountDLF)
        {
            //获取相关数据
            KM.Data.BCK bcItem = KM.Data.BCK.Read(conn, Runtime.QueryDate, cc);
            if (bcItem == null)
                throw new ApplicationException("不能读取指定班次 " + cc + " 数据");

            KM.Data.CLK clItem = KM.Data.CLK.Read(conn, bcItem.CPH);
            if (clItem == null)
                throw new ApplicationException("不能读取指定车辆(" + bcItem.CPH + ")数据");

            //结算前检测
            if (!allowWQDBalance && bcItem.BDSJ == DateTime.MaxValue) throw new ApplicationException("班次 " + cc + " 未签到");
            if (!allowNullBalance && bcItem.SCS == 0) throw new ApplicationException("班次 " + cc + " 零客票");

            if (KM.Data.JSD.Exists(conn, Runtime.QueryDate, cc)) Delete(conn, Runtime.QueryDate, cc);

            //创建结算单编号并插入结算记录
            String bh = KM.Data.JSD.CreateBH(conn, Runtime.Setting.PJWS);
            if (bh != string.Empty)
                Insert(conn, KM.Data.CPB.Reads_JSDMX(conn, bcItem.RQ, bcItem.CC), bh, bcItem, clItem, balanceAccountDLF, false);
            else
                throw new ApplicationException("不能创建结算单编号，终止结算");
        }

        public static void Print(SqlConnection conn, PrintSetting printSetting, String cc, int count)
        {
            if (PrinterSettings.InstalledPrinters.Count <= 0) throw new ApplicationException("系统未安装打印机");
            if (printSetting.Printer == String.Empty)throw new ApplicationException("系统未指定结算打印机");

            using (SimpleBalancePrint simpleBalancePrint = new SimpleBalancePrint())
            {
                for (int i = 0, j = 0; i < count; j++)
                {
                    try
                    {
                        switch (i)
                        {
                            case 0:
                                simpleBalancePrint.Run(conn, printSetting, Runtime.QueryDate, cc, "经营者");
                                break;
                            case 1:
                                simpleBalancePrint.Run(conn, printSetting, Runtime.QueryDate, cc, "站内结算");
                                break;
                            default:
                                simpleBalancePrint.Run(conn, printSetting, Runtime.QueryDate, cc, "");
                                break;
                        }
                        i++;
                    }
                    catch
                    {}

                    if (j > 99) break;
                }
                KM.Data.JSD.AddPrintCount(conn, Runtime.QueryDate, cc);
            }                
        }

        public static void RefreshJS(SqlConnection conn, ListView list, String jpk)
        {
           List<KM.Data.JSD> jsList;
            if (jpk == "全部")
                jsList = KM.Data.JSD.Reads(conn, Runtime.QueryDate);
            else
                jsList = KM.Data.JSD.Reads_JPK(conn, Runtime.QueryDate, jpk);

            list.Items.Clear();
            foreach (KM.Data.JSD jsItem in jsList)
            {
                list.Items.Add(new ListViewItem(new String[] { jsItem.CC, jsItem.ZDZ, jsItem.FCSJ, jsItem.CPH, jsItem.CSDW, jsItem.JSDM, jsItem.JSCZ, jsItem.JSZS.ToString() }));
            }
        }

        public static void ResumeJS(SqlConnection conn, String cc)
        {
            if (KM.Data.BCK.SetState(conn, Runtime.QueryDate, cc, BCState.售检))
                Delete(conn, Runtime.QueryDate, cc);
            else
                throw new ApplicationException("设置班次为售检状态失败");
        }
    }
}
