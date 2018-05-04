using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using EntityManager;
using DataManager;
using BusinessManager;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

public partial class Admin_BranchList : System.Web.UI.Page
{

    EMBranch objEMBranch = new EMBranch();
    BALBranch objBALBranch = new BALBranch();
   // BOUtiltiy _BOUtility = new BOUtiltiy();

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["ps"] = 10;
            BindBranchList();

        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Branch.aspx", false);
    }
    protected void gvBranchList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            var ToolTipString = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "BranchIsActive"));

            foreach (TableCell cell in e.Row.Cells)
            {
                if (ToolTipString == "0")
                {
                    // cell.BackColor = Color.Red;
                    cell.ForeColor = Color.Red;
                }
            }
        }
    }
    protected void gvBranchList_Sorting(object sender, GridViewSortEventArgs e)
    {
        try
        {
            ViewState["se"] = e.SortExpression;
            if (ViewState["so"] == null)
                ViewState["so"] = "ASC";
            if (ViewState["so"].ToString() == "ASC")
                ViewState["so"] = "DESC";
            else
                ViewState["so"] = "ASC";
            BindBranchList();
        }
        catch (Exception ex)
        {
            //    lblMsg.Text = _BOUtility.ShowMessage("danger", "Danger", ex.Message);
            //    ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void gvBranchList_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvBranchList.PageIndex = e.NewPageIndex;
        //  BindAirSupplierList();
        SearchItemFromList(txtSearch.Text.Trim());
    }
    protected void imgsearch_Click(object sender, ImageClickEventArgs e)
    {
        SearchItemFromList(txtSearch.Text.Trim());
    }
    protected void DropPage_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["ps"] = DropPage.SelectedItem.ToString().Trim();
        //  BindAirSupplierList();
        SearchItemFromList(txtSearch.Text.Trim());
    }
    protected void gvBranchList_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
        string BranchId = commandArgs[0];
        string ConfigId = commandArgs[1];


        if (e.CommandName == "Edit Branch")
        {

            Response.Redirect("Branch.aspx?BranchId= " + Convert.ToInt32(BranchId) + "&ConfigId=" + Convert.ToInt32(ConfigId), true);
        }
        else if (e.CommandName == "Delete Branch")
        {

            DeleteBranch(Convert.ToInt32(BranchId), Convert.ToInt32(ConfigId));
            BindBranchList();
        }
    }
    
    #endregion

    #region PrivateMethods
    private void BindBranchList()
    {

        try
        {
            gvBranchList.PageSize = int.Parse(ViewState["ps"].ToString());
            int BranchId = 0;
            DataSet ds = objBALBranch.Branch_GetData(BranchId);
            Session["dt"] = ds.Tables[0];
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gvBranchList.DataSource = ds.Tables[0];

                string sortDirection = "ASC", sortExpression;
                if (ViewState["so"] != null)
                {
                    sortDirection = ViewState["so"].ToString();
                }
                if (ViewState["se"] != null)
                {
                    sortExpression = ViewState["se"].ToString();
                    ds.Tables[0].DefaultView.Sort = sortExpression + " " + sortDirection;
                }

                gvBranchList.DataBind();
            }

            else
            {
                gvBranchList.DataSource = null;
                gvBranchList.DataBind();
            }
        }

        catch (Exception ex)
        {
            //lblMsg.Text = _BOUtility.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }
    }
    private void DeleteBranch(int BranchId, int ConfigurationId)
    {
        try
        {
            int Result = objBALBranch.DeleteBranchandConfiguration(BranchId, ConfigurationId);
        }
        catch (Exception ex)
        {

            //lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }
    }
    void SearchItemFromList(string SearchText)
    {
        try
        {
            if (Session["dt"] != null)
            {
                DataTable dt = (DataTable)Session["dt"];
                DataRow[] dr = dt.Select(
                    "SupAccountCode='" + SearchText +
                    "' OR SupplierName LIKE '%" + SearchText +
                     "%' OR ComDesc LIKE '%" + SearchText +
                    "%' OR Telephone LIKE '%" + SearchText +
                    "%' OR Email LIKE '%" + SearchText +
                    "%' OR QuickAccount LIKE '%" + SearchText +
                    "%' OR PaymentName LIKE '%" + SearchText + "%'");

                if (dr.Count() > 0)
                {
                    gvBranchList.PageSize = int.Parse(ViewState["ps"].ToString());
                    gvBranchList.DataSource = dr.CopyToDataTable();
                    gvBranchList.DataBind();

                }
                else
                {
                    gvBranchList.DataBind();
                    Label lblEmptyMessage = gvBranchList.Controls[0].Controls[0].FindControl("lblEmptyMessage") as Label;
                    lblEmptyMessage.Text = "Currently there are no records in" + "  '" + SearchText + "'";
                }
            }
        }
        catch (Exception ex)
        {
            //lblMsg.Text = _BOUtility.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }
    } 

    #endregion
}