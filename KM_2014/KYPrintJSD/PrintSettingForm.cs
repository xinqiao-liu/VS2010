using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KM.PrintJSD
{
    public partial class PrintSettingForm : Form
    {
        public PrintSettingForm()
        {
            InitializeComponent();
        }

        private void PrintSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == DialogResult.OK)
                {
                    e.Cancel = true;

                    Properties.Settings.Default.PrintTitle = txtTitle.Text;
                    Properties.Settings.Default.PrintName01 = txtName01.Text;
                    Properties.Settings.Default.PrintName02 = txtName02.Text;
                    Properties.Settings.Default.PrintName03 = txtName03.Text;

                    Properties.Settings.Default.ItemTitle01 = txtItemTitle01.Text;
                    Properties.Settings.Default.ItemTitle02 = txtItemTitle02.Text;
                    Properties.Settings.Default.ItemTitle03 = txtItemTitle03.Text;
                    Properties.Settings.Default.ItemTitle04 = txtItemTitle04.Text;
                    Properties.Settings.Default.ItemTitle05 = txtItemTitle05.Text;
                    Properties.Settings.Default.ItemTitle06 = txtItemTitle06.Text;
                    Properties.Settings.Default.ItemTitle07 = txtItemTitle07.Text;
                    Properties.Settings.Default.ItemTitle08 = txtItemTitle08.Text;
                    Properties.Settings.Default.ItemTitle09 = txtItemTitle09.Text;
                    Properties.Settings.Default.ItemTitle10 = txtItemTitle10.Text;

                    Properties.Settings.Default.Save();

                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintSettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtTitle.Text = Properties.Settings.Default.PrintTitle;
                txtName01.Text = Properties.Settings.Default.PrintName01;
                txtName02.Text = Properties.Settings.Default.PrintName02;
                txtName03.Text = Properties.Settings.Default.PrintName03;

                txtItemTitle01.Text = Properties.Settings.Default.ItemTitle01;
                txtItemTitle02.Text = Properties.Settings.Default.ItemTitle02;
                txtItemTitle03.Text = Properties.Settings.Default.ItemTitle03;
                txtItemTitle04.Text = Properties.Settings.Default.ItemTitle04;
                txtItemTitle05.Text = Properties.Settings.Default.ItemTitle05;
                txtItemTitle06.Text = Properties.Settings.Default.ItemTitle06;
                txtItemTitle07.Text = Properties.Settings.Default.ItemTitle07;
                txtItemTitle08.Text = Properties.Settings.Default.ItemTitle08;
                txtItemTitle09.Text = Properties.Settings.Default.ItemTitle09;
                txtItemTitle10.Text = Properties.Settings.Default.ItemTitle10;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
