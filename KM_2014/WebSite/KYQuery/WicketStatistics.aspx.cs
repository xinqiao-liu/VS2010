using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WicketStatistics : System.Web.UI.Page
{
    KYServiceReference.KYServiceClient kyQuery = new KYServiceReference.KYServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            cboSelectKYZ.DataSource = kyQuery.GetKyzList();
            cboSelectKYZ.DataBind();
        }
    }
    protected void cboSelectKYZ_PreRender(object sender, EventArgs e)
    {
        //using (KYServiceReference.KYServiceClient kyService = new KYServiceReference.KYServiceClient())
        //{
        //    foreach (string i in kyService.GetKyzList()) this.cboSelectKYZ.Items.Add(i);
        //}
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = kyQuery.GetWicketStatistics(
           this.cboSelectKYZ.SelectedValue,
           DateTime.Parse(this.txtFromDate.Text),
           DateTime.Parse(this.txtToDate.Text), 
           System.Data.SqlClient.SortOrder.Descending);
       GridView1.DataBind();
    }
}