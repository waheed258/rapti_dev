using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityManager;
using BusinessManager;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
public partial class Admin_BranchList : System.Web.UI.Page
{
    EMBranch objEMBranch = new EMBranch();
    BABranch objBABranch = new BABranch();
    BOUtiltiy _objBOUtiltiy = new BOUtiltiy();

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["ps"] = 10;
            BindBranchDetails();
        }
    }
    protected void gvBranchDetailsList_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvBranchDetailsList.PageIndex = e.NewPageIndex;
        SearchItemFromList(txtSearch.Text.Trim());
        //BindBranchDetails();
    }
    protected void gvBranchDetailsList_RowCommand(object sender, GridViewCommandEventArgs e)
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

            deleteBranchDetails(Convert.ToInt32(BranchId), Convert.ToInt32(ConfigId));
            BindBranchDetails();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Branch.aspx");
    }
    protected void DropPage_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["ps"] = DropPage.SelectedItem.ToString().Trim();
        SearchItemFromList(txtSearch.Text.Trim());
        //  BindBranchDetails();
    }
    protected void gvBranchDetailsList_Sorting(object sender, GridViewSortEventArgs e)
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
            BindBranchDetails();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void imgsearch_Click(object sender, ImageClickEventArgs e)
    {
        SearchItemFromList(txtSearch.Text.Trim());
    }

    protected void gvBranchDetailsList_RowDataBound(object sender, GridViewRowEventArgs e)
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
    
    #endregion

      #region PrivateMethods
     private void BindBranchDetails()
    {
        try
        {
            gvBranchDetailsList.PageSize = int.Parse(ViewState["ps"].ToString());
            int branchid = 0;
            DataSet ds = objBABranch.Branch_GetData(branchid);
            Session["dt"] = ds.Tables[0];
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gvBranchDetailsList.DataSource = ds;
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
                gvBranchDetailsList.DataBind();
            }
            else
            {
                gvBranchDetailsList.DataSource = null;
                gvBranchDetailsList.DataBind();

                Label lblEmptyMessage = gvBranchDetailsList.Controls[0].Controls[0].FindControl("lblEmptyMessage") as Label;
                lblEmptyMessage.Text = "Currently there are no records in System";
            }



        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
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
                    "BranchCode='" + SearchText +
                    "' OR BranchName LIKE '%" + SearchText +
                    "%' OR TelephoneNumber LIKE '%" + SearchText +
                    "%' OR FaxNumber LIKE '%" + SearchText +
                    "%' OR EmailAddress LIKE '%" + SearchText + "%'");

                if (dr.Count() > 0)
                {
                    gvBranchDetailsList.PageSize = int.Parse(ViewState["ps"].ToString());
                    gvBranchDetailsList.DataSource = dr.CopyToDataTable();
                    gvBranchDetailsList.DataBind();
                }
                else
                {
                    gvBranchDetailsList.DataSource = null;
                    gvBranchDetailsList.DataBind();

                    Label lblEmptyMessage = gvBranchDetailsList.Controls[0].Controls[0].FindControl("lblEmptyMessage") as Label;
                    lblEmptyMessage.Text = "Currently there are no records in" + "  '" + SearchText + "'";
                }
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    private void deleteBranchDetails(int BranchId, int ConfigurationId)
    {
        try
        {
            int Result = objBABranch.DeleteBranchandConfiguration(BranchId, ConfigurationId);
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

       #endregion
}