using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WicketBCQuery : System.Web.UI.Page
{
    KYServiceReference.KYServiceClient kyQuery = new KYServiceReference.KYServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.cboSelectKYZ.DataSource = kyQuery.GetKyzList();
            this.cboSelectKYZ.DataBind();
        }
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = kyQuery.GetWicketBCQuery(this.cboSelectKYZ.SelectedValue, DateTime.Parse(this.txtDate.Text), this.txtBC.Text, rdoCurrent.Checked);
        GridView1.DataBind();              
    }
}