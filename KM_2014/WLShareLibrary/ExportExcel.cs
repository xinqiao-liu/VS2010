using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;

namespace WLCommon
{
    public static class ExportExcel
    {
        public static void ExportAccount(string excelFile, ListView list)
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("账单");

            worksheet.Cells[1, 0] = new Cell("结账代码");
            worksheet.Cells[1, 1] = new Cell("车辆总数");
            worksheet.Cells[1, 2] = new Cell("运单总数");
            worksheet.Cells[1, 3] = new Cell("运单总额");
            worksheet.Cells[1, 4] = new Cell("结账金额");

            for (int i = 0; i < list.Items.Count; i++)
            {
                WLDataModelLayer.ZDHZB item = list.Items[i].Tag as WLDataModelLayer.ZDHZB;
                if (item is WLDataModelLayer.ZDHZB)
                {
                    worksheet.Cells[2 + i, 0] = new Cell(item.Code);
                    worksheet.Cells[2 + i, 1] = new Cell(item.Cars);
                    worksheet.Cells[2 + i, 2] = new Cell(item.Count);
                    worksheet.Cells[2 + i, 3] = new Cell(item.Total);
                    worksheet.Cells[2 + i, 4] = new Cell(item.Money);
                }
                else
                    throw new NullReferenceException("账单项数据为空，终止导出！");
            }

            //可以下列方法设置额外的信息
            //worksheet.AddPicture; worksheet.ExtractPicture;worksheet.Cells.ColumnWidth

            workbook.Worksheets.Add(worksheet);
            workbook.Save(excelFile);
        }

        public static void ExportDetail(string excelFile, ListView list)
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("明细");

            worksheet.Cells[1, 0] = new Cell("结账代码");
            worksheet.Cells[1, 1] = new Cell("车牌号");
            worksheet.Cells[1, 2] = new Cell("运单数");
            worksheet.Cells[1, 3] = new Cell("运单额");
            worksheet.Cells[1, 4] = new Cell("结账比率");
            worksheet.Cells[1, 5] = new Cell("结账金额");

            for (int i = 0; i < list.Items.Count; i++)
            {
                WLDataModelLayer.ZDMXB item = list.Items[i].Tag as WLDataModelLayer.ZDMXB;
                if (item is WLDataModelLayer.ZDMXB)
                {
                    worksheet.Cells[2 + i, 0] = new Cell(item.Code);
                    worksheet.Cells[2 + i, 1] = new Cell(item.CPH);
                    worksheet.Cells[2 + i, 2] = new Cell(item.Count);
                    worksheet.Cells[2 + i, 3] = new Cell(item.Total);
                    worksheet.Cells[2 + i, 4] = new Cell(item.Ratio);
                    worksheet.Cells[2 + i, 5] = new Cell(item.Money);
                }
                else
                    throw new NullReferenceException("明细项数据为空，终止导出！");
            }

            //可以下列方法设置额外的信息
            //worksheet.AddPicture; worksheet.ExtractPicture;worksheet.Cells.ColumnWidth

            workbook.Worksheets.Add(worksheet);
            workbook.Save(excelFile);
        }

        public static void ExportAllDetail(string excelFile)
        {
        }
    }
}
