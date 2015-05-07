using System;
using System.Collections.Generic;
using System.Text;

namespace KM.Common
{
    public class PrintSetting
    {
        private String m_Printer;
        private Decimal m_PageWidth;
        private Decimal m_PageHeight;
        private Decimal m_MarginTop;
        private Decimal m_MarginBottom;
        private Decimal m_MarginLeft;
        private Decimal m_MarginRight;
        private bool m_PrintDLF;

        public String Printer
        {
            get { return m_Printer; }
            set { m_Printer = value; }
        }
        
        public Decimal PageWidth
        {
            get { return m_PageWidth; }
            set { m_PageWidth = value; }
        }
        
        public Decimal PageHeight
        {
            get { return m_PageHeight; }
            set { m_PageHeight = value; }
        }
        
        public Decimal MarginTop
        {
            get { return m_MarginTop; }
            set { m_MarginTop = value; }
        }
        
        public Decimal MarginBottom
        {
            get { return m_MarginBottom; }
            set { m_MarginBottom = value; }
        }
        
        public Decimal MarginLeft
        {
            get { return m_MarginLeft; }
            set { m_MarginLeft = value; }
        }

        public Decimal MarginRight
        {
            get { return m_MarginRight; }
            set { m_MarginRight = value; }
        }

        public bool PrintDLF
        {
            get { return m_PrintDLF; }
            set { m_PrintDLF = value; }
        }

        public PrintSetting()
            : this(String.Empty, 0, 0, 0, 0, 0, 0, false)
        {
        }

        public PrintSetting(
            String printer, 
            decimal pageWidth, 
            decimal pageHeight, 
            decimal marginTop, 
            decimal marginBottom, 
            decimal marginLeft, 
            decimal marginRight,
            bool printDLF)
        {
            this.Printer = printer;
            this.PageWidth = pageWidth;
            this.PageHeight = pageHeight;
            this.MarginTop = marginTop;
            this.MarginBottom = marginBottom;
            this.MarginLeft = marginLeft;
            this.MarginRight = marginRight;
            this.m_PrintDLF = printDLF;
        }
    }
}
