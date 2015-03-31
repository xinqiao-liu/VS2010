using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WLCommon
{
    public class PrintBill
    {
        private static PrintDocument m_PrintDocument = new PrintDocument();
        private static int m_OffsetX = 0;
        private static int m_OffsetY = 0;
        private static WLDataModelLayer.WLB m_Item = null;

        public static readonly int DefaultPixelsPerInchX = 180;
        public static readonly int DefaultPixelsPerInchY = 180;
        public static readonly int CurrentPixelsPerInchX = GetPixelsPerInchX();
        public static readonly int CurrentPixelsPerInchY = GetPixelsPerInchY();

        public static PrintDocument PrintDocument
        {
            get { return PrintBill.m_PrintDocument; }
            set { PrintBill.m_PrintDocument = value; }
        }

        public static int OffsetX
        {
            get { return PrintBill.m_OffsetX; }
            set { PrintBill.m_OffsetX = value; }
        }

        public static int OffsetY
        {
            get { return PrintBill.m_OffsetY; }
            set { PrintBill.m_OffsetY = value; }
        }

        public static WLDataModelLayer.WLB Item
        {
            get { return PrintBill.m_Item; }
            set { PrintBill.m_Item = value; }
        }

        //查看是否存在可用打印机
        public static bool Exists()
        {
            return (PrinterSettings.InstalledPrinters.Count > 0);
        }

        //设置打印页面大小
        public static void SetPageSize(string name, int width, int height)
        {
            PrintBill.PrintDocument.DefaultPageSettings.PaperSize = new PaperSize(name, width, height);
        }

        //初始化缺省打印机
        public static void Init(int pageWidth, int pageHeight)
        {
            if (Exists())
                SetPageSize("CustomSize", pageWidth, pageHeight);
            else
                throw new ApplicationException("系统不存在可用打印机！");
        }

        //返回打印机 X.Y 分辨率
        public static int GetPixelsPerInchX()
        {
            if (Exists())
                return PrintBill.PrintDocument.DefaultPageSettings.PrinterResolution.X;
            else
                return 0;
        }

        public static int GetPixelsPerInchY()
        {
            if (Exists())
                return PrintBill.PrintDocument.DefaultPageSettings.PrinterResolution.Y;
            else
                return 0;
        }

        //打印单据
        public static WLDataModelLayer.WLB Print(WLDataModelLayer.WLB item)
        {
            return PrintBill.Print(item, 0, 0);
        }

        public static WLDataModelLayer.WLB Print(WLDataModelLayer.WLB item, int offsetX, int offsetY)
        {
            PrintBill.OffsetX = offsetX;
            PrintBill.OffsetY = offsetY;

            PrintBill.Item = item;

            if (PrintBill.Item != null)
            {
                PrintBill.PrintDocument.DocumentName = string.Format("打印货单 [ 日期：{0}  单号：{1} ]", PrintBill.Item.Date.ToString("yyyy-MM-dd"), PrintBill.Item.SN);
                PrintBill.PrintDocument.Print();
            }

            return item;
        }

        //预览单据
        public static void Preview(WLDataModelLayer.WLB item)
        {
            PrintBill.Preview(item, 0, 0);
        }

        public static void Preview(WLDataModelLayer.WLB item, int offsetX, int offsetY)
        {
            PrintBill.OffsetX = offsetX;
            PrintBill.OffsetY = offsetY;

            PrintBill.Item = item;

            using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
            {
                previewDialog.Document = PrintBill.PrintDocument;
                previewDialog.ShowDialog();
            }
        }

        //静态构造函数
        static PrintBill()
        {
            PrintBill.PrintDocument.PrintController = new StandardPrintController();
            PrintBill.PrintDocument.PrintPage += new PrintPageEventHandler(PrintBill.PrintDocument_PrintPage);
        }

        //打印事件
        private static void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            foreach (WLDataModelLayer.PrintFormat item in WLDataLogicLayer.PrintFormat.Array)
            {
                if (!item.Enable) continue;

                switch (item.Code)
                {
                    case "date":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.Date.ToString("yyyy      MM    dd"), item);
                        break;
                    case "sn":
                        break;
                    case "uid":
                        break;
                    case "username":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.Username, item);
                        break;
                    case "cdt":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.CDT.ToString("yyyy-MM-dd hh:mm:ss"), item);
                        break;
                    case "sk_type":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.SK_Type.ToString(), item);
                        break;
                    case "yd_type":
                        break;
                    case "zt_type":
                        break;
                    case "fh_code":
                        break;
                    case "fh_name":
                        break;
                    case "fh_cityname":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.FH_CityName, item);
                        break;
                    case "jh_code":
                        break;
                    case "jh_name":
                        break;
                    case "cz_rq":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.CZ_RQ.ToString("yyyy-MM-dd"), item);
                        break;
                    case "cz_bc":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.CZ_BC, item);
                        break;
                    case "cz_dz":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.CZ_DZ, item);
                        break;
                    case "cz_sj":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.CZ_SJ, item);
                        break;
                    case "cz_cph":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.CZ_CPH, item);
                        break;
                    case "cz_lc":
                        break;
                    case "cz_yx":
                        break;
                    case "hw_mc":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.HW_MC, item);
                        break;
                    case "hw_lx":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.HW_LX, item);
                        break;
                    case "hw_js":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.HW_JS.ToString(), item);
                        break;
                    case "hw_bj":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.HW_BJ.ToString("N2"), item);
                        break;
                    case "fhr_name":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.FHR_Name, item);
                        break;
                    case "fhr_mobile":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.FHR_Mobile, item);
                        break;
                    case "fhr_remark":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.FHR_Remark, item);
                        break;
                    case "jhr_name":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.JHR_Name, item);
                        break;
                    case "jhr_mobile":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.JHR_Mobile, item);
                        break;
                    case "bxd_sn":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.BXD_SN, item);
                        break;
                    case "jfzl":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.JFZL.ToString("N1"), item);
                        break;
                    case "jftj":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.JFTJ.ToString("N1"), item);
                        break;
                    case "tyf":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.TYF.ToString("N2"), item);
                        break;
                    case "bzf":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.BZF.ToString("N2"), item);
                        break;
                    case "bxf":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.BXF.ToString("N2"), item);
                        break;
                    case "total":
                        PrintBill.PrintItem(e.Graphics, PrintBill.Item.Total.ToString("N2"), item);
                        break;
                    case "money":
                        break;
                    case "total_upper":
                        PrintBill.PrintItem(e.Graphics, Common.Money.ToUppercase(PrintBill.Item.Total), item);
                        break;
                }
            }
        }

        private static void PrintItem(Graphics g, String value, WLDataModelLayer.PrintFormat item)
        {
            Font font;
            switch (item.FontMode)
            {
                case "粗体":
                    font = new Font(item.FontName, item.FontSize, FontStyle.Bold);
                    break;
                case "斜体":
                    font = new Font(item.FontName, item.FontSize, FontStyle.Italic);
                    break;
                case "粗斜体":
                    font = new Font(item.FontName, item.FontSize, FontStyle.Bold | FontStyle.Italic);
                    break;
                default:
                    font = new Font(item.FontName, item.FontSize, FontStyle.Regular);
                    break;
            }

            //int X = Convert.ToInt32(item.X) / PrintBill.DefaultPixelsPerInchX * PrintBill.CurrentPixelsPerInchX + PrintBill.OffsetX;
            //int Y = Convert.ToInt32(item.Y) / PrintBill.DefaultPixelsPerInchY * PrintBill.CurrentPixelsPerInchY + PrintBill.OffsetY;
            int X = Convert.ToInt32(item.X) + PrintBill.OffsetX;
            int Y = Convert.ToInt32(item.Y) + PrintBill.OffsetY;

            g.DrawString(value, font, new SolidBrush(Color.Black), new PointF(X, Y));
        }
    }
}
