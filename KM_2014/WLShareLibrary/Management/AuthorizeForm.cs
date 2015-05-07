using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WLCommon.Management
{
    public partial class AuthorizeForm : Form
    {
        public static DialogResult InitAndShowDialog()
        {
            using (AuthorizeForm authorizeForm = new AuthorizeForm())
            {
                return authorizeForm.ShowDialog();
            }
        }

        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void AuthorizeForm_Shown(object sender, EventArgs e)
        {
            try
            {
                WLDataLogicLayer.Authorize.Refresh(this.list);
                this.btnAppend.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (this.list.SelectedItems.Count > 0) this.btnCustom_Click(sender, e);
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnDelete.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnCustom.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnImport.Enabled = (this.list.SelectedItems.Count > 0);
            this.btnExport.Enabled = (this.list.SelectedItems.Count > 0 && this.list.SelectedItems[0].SubItems[4].Text == "已授权");
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                using (AuthorizetAppendForm authorizetAppendForm = new AuthorizetAppendForm())
                {
                    if (authorizetAppendForm.ShowDialog() == DialogResult.OK)
                    {
                        if (WLDataLogicLayer.Authorize.Insert(authorizetAppendForm.AuthorizeRecord))
                        {
                            ListViewItem item = new ListViewItem(authorizetAppendForm.AuthorizeRecord.Code);
                            item.Tag = authorizetAppendForm.AuthorizeRecord;
                            item.SubItems.Add(authorizetAppendForm.AuthorizeRecord.Name);
                            item.SubItems.Add(authorizetAppendForm.AuthorizeRecord.CityCode);
                            item.SubItems.Add(authorizetAppendForm.AuthorizeRecord.CityName);
                            item.SubItems.Add(authorizetAppendForm.AuthorizeRecord.Content.IsNull ? "未授权" : "已授权");
                            this.list.Items.Add(item);
                        }
                    }
                }
                this.list.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    string code = this.list.SelectedItems[0].Text;
                    string msg = string.Format("是否删除代码为 {0} 的网点授权记录？", code);
                    if (MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (WLDataLogicLayer.Authorize.Delete(code)) this.list.SelectedItems[0].Remove();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    using (AuthorizeCustomForm authorizeCustomForm = new AuthorizeCustomForm())
                    {
                        authorizeCustomForm.AuthorizeRecord = new WLDataModelLayer.Authorize(
                           this.list.SelectedItems[0].Text,
                           this.list.SelectedItems[0].SubItems[1].Text,
                           this.list.SelectedItems[0].SubItems[2].Text,
                           this.list.SelectedItems[0].SubItems[3].Text,
                           System.Data.SqlTypes.SqlBinary.Null);
                            
                        if (authorizeCustomForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (WLDataLogicLayer.Authorize.SetContent(authorizeCustomForm.AuthorizeRecord.Code, authorizeCustomForm.AuthorizeRecord.Content))
                            {
                                this.list.SelectedItems[0].Tag = authorizeCustomForm.AuthorizeRecord;                                
                            }
                            this.list.SelectedItems[0].SubItems[4].Text = authorizeCustomForm.AuthorizeRecord.Content.IsNull ? "未授权" : "已授权";
                            this.list_SelectedIndexChanged(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    WLDataModelLayer.Authorize authorizeRecord = new WLDataModelLayer.Authorize(
                           this.list.SelectedItems[0].Text,
                           this.list.SelectedItems[0].SubItems[1].Text,
                           this.list.SelectedItems[0].SubItems[2].Text,
                           this.list.SelectedItems[0].SubItems[3].Text,
                           System.Data.SqlTypes.SqlBinary.Null);

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.AddExtension = true;
                        openFileDialog.CheckFileExists = true;
                        openFileDialog.CheckPathExists = true;
                        openFileDialog.DefaultExt = ".auth";
                        openFileDialog.Filter = "网点授权文件|*.auth";
                        openFileDialog.FilterIndex = 0;
                        openFileDialog.InitialDirectory = Application.StartupPath;
                        openFileDialog.Title = "导入网点授权信息";

                        if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            System.Data.SqlTypes.SqlBinary importContent = WLDataModelLayer.Authorize.Import(openFileDialog.FileName);
                            if (!importContent.IsNull)
                            {
                                authorizeRecord.Content = importContent;
                                if (WLDataLogicLayer.Authorize.SetContent(authorizeRecord.Code, authorizeRecord.Content))
                                {

                                    this.list.SelectedItems[0].Tag = authorizeRecord;
                                    this.list.SelectedItems[0].SubItems[4].Text = authorizeRecord.Content.IsNull ? "未授权" : "已授权";
                                    this.list_SelectedIndexChanged(sender, e);
                                }
                                else throw new ApplicationException("设置授权失败，终止导入！");

                            }
                            else throw new ApplicationException("授权信息无效，终止导入！");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list.SelectedItems.Count > 0)
                {
                    WLDataModelLayer.Authorize item = this.list.SelectedItems[0].Tag as WLDataModelLayer.Authorize;

                    if (item.Content.IsNull) throw new ApplicationException("网点未授权，终止导出！");

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.AddExtension = true;
                        saveFileDialog.DefaultExt = ".auth";
                        saveFileDialog.FileName = string.Format("{0}_{1}.auth", item.Code, item.Name);
                        saveFileDialog.Filter = "网点授权文件|*.auth";
                        saveFileDialog.FilterIndex = 0;
                        saveFileDialog.InitialDirectory = Application.StartupPath;
                        saveFileDialog.OverwritePrompt = true;
                        saveFileDialog.Title = "导出网点授权信息";

                        if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            WLDataModelLayer.Authorize.Export(saveFileDialog.FileName, item.Content);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
