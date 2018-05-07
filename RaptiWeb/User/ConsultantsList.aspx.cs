using BusinessManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ConsultantsList : System.Web.UI.Page
{
    BALConsultant _ObjBALConsultant = new BALConsultant();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ConsultantsList();
        }
    }

    public void ConsultantsList()
    {
        int ConsultantId = 0;
        DataSet ds = _ObjBALConsultant.GetConsultant(ConsultantId);
        GvConsultants.DataSource = ds.Tables[0];
        GvConsultants.DataBind();
    }
    protected void GvCompanyDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string Id = e.CommandArgument.ToString();
        if (e.CommandName == "Edit Consultant Details")
        {
            // int Id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("Consultant.aspx?Id=" + Id);
        }
    }
}