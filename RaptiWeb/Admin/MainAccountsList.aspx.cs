using BusinessManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MainAccountsList : System.Web.UI.Page
{
    BALMainAccounts ObjBALMainAccounts = new BALMainAccounts();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MainAccountsList();
        }
    }
    public void MainAccountsList()
    {

        int mainAccId = 0;
        DataSet ds = ObjBALMainAccounts.MainAccountsList(mainAccId);
        GvMainAccounts.DataSource = ds.Tables[0];
        GvMainAccounts.DataBind();
    }
}