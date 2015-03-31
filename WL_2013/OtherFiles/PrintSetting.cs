using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;

namespace WLClient
{
    public static class PrintSetting
    {
        public static readonly string XMLPATH = "PrintSetting.xml";

        private static DataTable m_SettingTable;
        public static DataTable SettingTable
        {
          get { return m_SettingTable; }
          set { m_SettingTable = value; }
        }

        static PrintSetting()
        {
            m_SettingTable = new DataTable();

            SettingTable.Columns.Clear();
            SettingTable.Columns.Add("name", typeof(string));
            SettingTable.Columns.Add("x", typeof(int));
            SettingTable.Columns.Add("y", typeof(int));
            SettingTable.Columns.Add("font", typeof(string));
            SettingTable.Columns.Add("fontsize", typeof(string));
            SettingTable.Columns.Add("fontmode", typeof(string));
            SettingTable.Columns.Add("print", typeof(string));

            Read(XMLPATH);
        }

        public static void Read(string xmlPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            SettingTable.Rows.Clear();
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {                
                SettingTable.Rows.Add(node.Attributes["name"].Value,
                    node.Attributes["x"].Value,
                    node.Attributes["y"].Value,
                    node.Attributes["font"].Value,
                    node.Attributes["fontsize"].Value,
                    node.Attributes["fontmode"].Value,
                    node.Attributes["print"].Value);
            }
        }

        public static void Write(string xmlPath)
        {

            XmlTextWriter xml = new XmlTextWriter(xmlPath, null);
            xml.WriteStartElement("fieldnames");

            foreach (DataRow row in SettingTable.Rows)
            {
                xml.WriteStartElement("field");

                xml.WriteStartAttribute("name");
                xml.WriteString(row[0].ToString());
                xml.WriteEndAttribute();

                xml.WriteStartAttribute("x");
                xml.WriteString(row[1].ToString());
                xml.WriteEndAttribute();

                xml.WriteStartAttribute("y");
                xml.WriteString(row[2].ToString());
                xml.WriteEndAttribute();

                xml.WriteStartAttribute("font");
                xml.WriteString(row[3].ToString());
                xml.WriteEndAttribute();

                xml.WriteStartAttribute("fontsize");
                xml.WriteString(row[4].ToString());
                xml.WriteEndAttribute();

                xml.WriteStartAttribute("fontmode");
                xml.WriteString(row[5].ToString());
                xml.WriteEndAttribute();

                xml.WriteStartAttribute("print");
                xml.WriteString(row[6].ToString());
                xml.WriteEndAttribute();

                xml.WriteEndElement();
            }

            xml.WriteEndElement();
            xml.Close();
        }        
    }
}
