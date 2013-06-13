using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Shopping : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            this.loadData();
        }
    }
    private void loadData()
    {
        if (Session["giohang"] != null)
        {
            DataTable dt = (DataTable)Session["giohang"];
            rptCart.DataSource = dt;
            rptCart.DataBind();

            if (dt != null && dt.Rows.Count != 0)
            {
                float total = float.Parse(dt.Compute("sum(Total)", "").ToString());
                lblTotal.Text = string.Format("${0:#,#.00}", total);
            }
            else
                lblTotal.Text = "0";

        }
        else
        {
            lblTotal.Text = "0";
        }
    }

    protected void lbtCheckOut_Click(object sender, EventArgs e)
    {
        try
        {
            string sUserName = Session["Username"].ToString();
            if (sUserName != null)
            {
                Response.Redirect("~/CheckOut.aspx");
            }
            else
            {
                lblWarning.Visible = true;
                lnkLogin.Visible = true;
            }
        }
        catch(Exception ex)
        {

            lblWarning.Visible = true;
            lnkLogin.Visible = true;
            
        }
       
    }
    protected void rptCart_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType != ListItemType.Header) && (e.Item.ItemType != ListItemType.Footer))
        {
            HyperLink lnkName = (HyperLink)e.Item.FindControl("lnkName");
            Image img = (Image)e.Item.FindControl("img");
            HyperLink lnkimg = (HyperLink)e.Item.FindControl("lnkimg");
            TextBox txtQuantity = (TextBox)e.Item.FindControl("txtQuantity");
            Label lblPrice = (Label)e.Item.FindControl("lblPrice");
            Label lblID = (Label)e.Item.FindControl("lblID");
            LinkButton lbtRemove = (LinkButton)e.Item.FindControl("lbtRemove");
            LinkButton lbtUpdate = (LinkButton)e.Item.FindControl("lbtUpdate");


            int nID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ID"));
            string sProductName = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Name"));
            string sPrice = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Price"));
            string sImage = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "Image"));
            int nNumber = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Number"));

            string sUrl= "~/ProductDetail.aspx?nid=" + nID;

            lblID.Text = nID.ToString();
            lnkName.Text = sProductName;
            img.ImageUrl = "~/images/products/" + sImage;
            lblPrice.Text =" $ " + sPrice;
            txtQuantity.Text = nNumber.ToString();

            lnkName.NavigateUrl = sUrl;
            lnkimg.NavigateUrl = sUrl;

            lbtRemove.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ID"));
            lbtUpdate.CommandArgument = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "ID"));
        }
    }
    protected void rptCart_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string strCommand = e.CommandName;
        int nID = Convert.ToInt32(e.CommandArgument);
        DataTable dt = (DataTable)Session["giohang"];

        switch (strCommand)
        {
            case "Remove":
                    for (int i = 0; i < rptCart.Items.Count; i++)
                    {
                        Label lblID = rptCart.Items[i].FindControl("lblID") as Label;
                        if (lblID.Text == nID.ToString())
                        {
                            DataRow dr = dt.Rows[i];
                            if (dr != null)
                                dr.Delete();
                        }            
                    }
                    this.loadData();
                break;

            case "Update":
                for (int i = 0; i < rptCart.Items.Count; i++)
                {
                    try
                    {

                        int sl = int.Parse("0" + (rptCart.Items[i].FindControl("txtQuantity") as TextBox).Text);
                        if (sl > 0)
                        {
                            dt.Rows[i]["Number"] = sl;
                        }
                        else
                        {
                            ClientMessageBox.Show("Number must be greater than 0 !", this);
                        }
                    }
                    catch
                    {
                        ClientMessageBox.Show("Quantity false !", this);
                    }
                }

                loadData();
                break;
        }
    }
}