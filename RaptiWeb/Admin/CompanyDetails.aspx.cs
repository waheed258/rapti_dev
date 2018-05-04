using BusinessManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_CompanyDetails : System.Web.UI.Page
{
    BALCompany ObjCompay = new BALCompany();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CompanyDetails(1);
        }


    }


    public void CompanyDetails(int CompanyId)
    {


        DataSet ds = ObjCompay.GetCompany(CompanyId);

        GvCompanyDetails.DataSource = ds.Tables[0];
        GvCompanyDetails.DataBind();
    }
    protected void GvCompanyDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string Id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit Currency Details")
        {
            // int Id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("Company.aspx?Id=" +Id);
        }
       
    }
}