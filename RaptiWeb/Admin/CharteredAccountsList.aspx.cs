using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessManager;
using System.Data;

public partial class Admin_CharteredAccountsList : System.Web.UI.Page
{
    BALCharteredAccounts objBALChartoffAcc = new BALCharteredAccounts();

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindChartofAccList();
        }
    }
    protected void gvChartofAccList_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    } 
    #endregion

    #region PrivateMethods
    private void BindChartofAccList()
    {
        try
        {
            DataSet ds = objBALChartoffAcc.Get_ChartofAccData();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gvChartofAccList.DataSource = ds.Tables[0];
                gvChartofAccList.DataBind();
            }

            else
            {
                gvChartofAccList.DataSource = null;
                gvChartofAccList.DataBind();
            }
        }
        catch (Exception ex)
        {


        }
    }
    
    #endregion

}