using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_PrintInvoiceSummary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.LoadData();
        }
    }

    private void LoadData()
    {
        int nStatus = 0;
        InvoiceDetails obj = new InvoiceDetails();
        DataTable dtb = new DataTable();

        dtb = obj.ReportbyDateChart("1", nStatus);
        int nT1 = dtb.Rows.Count;
        lblT1.Text = nT1.ToString();

        dtb = obj.ReportbyDateChart("2", nStatus);
        int nT2 = dtb.Rows.Count;
        lblT2.Text = nT2.ToString();

        dtb = obj.ReportbyDateChart("3", nStatus);
        int nT3 = dtb.Rows.Count;
        lblT3.Text = nT3.ToString();

        dtb = obj.ReportbyDateChart("4", nStatus);
        int nT4 = dtb.Rows.Count;
        lblT4.Text = nT4.ToString();

        dtb = obj.ReportbyDateChart("5", nStatus);
        int nT5 = dtb.Rows.Count;
        lblT5.Text = nT5.ToString();

        dtb = obj.ReportbyDateChart("6", nStatus);
        int nT6 = dtb.Rows.Count;
        lblT6.Text = nT6.ToString();

        dtb = obj.ReportbyDateChart("7", nStatus);
        int nT7 = dtb.Rows.Count;
        lblT7.Text = nT7.ToString();
    }
}