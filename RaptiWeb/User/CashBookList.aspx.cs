using BusinessManager;
using DataManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_CashBookList : System.Web.UI.Page
{
    EMCashBook objEMCash = new EMCashBook();
    BACashBook objBACash = new BACashBook();
    BoUtility _BOUtility = new BoUtility();
    BALGlobal objBALglobal = new BALGlobal();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["ps"] = 10;
            Session["dt"] = null;
            BindCashBook();

        
          
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CashBookType.aspx");
    }
    protected void gvCashBookList_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string cashBookId = e.CommandArgument.ToString();
        if (e.CommandName == "Edit Cash")
        {
            Response.Redirect("CashBookType.aspx?CashBookId=" + HttpUtility.UrlEncode(objBALglobal.Encrypts(cashBookId, true)));

        }
        if (e.CommandName == "Delete Cash")
        {
            DeleteCashBook(Convert.ToInt32(cashBookId));
            BindCashBook();
        }
    }

    private void DeleteCashBook(int CashBookId)
    {
        int Result = objBACash.DeleteCashBook(CashBookId);
    }
    protected void gvCashBookList_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvCashBookList.PageIndex = e.NewPageIndex;
    //    SearchItemFromList(txtSearch.Text.Trim());
        BindCashBook();
    }

    private void BindCashBook()
    {
        try
        {
         //   gvCashBookList.PageSize = int.Parse(ViewState["ps"].ToString());
            int CashBookId = 0;
            DataSet ds = objBACash.GetCashBook(CashBookId);
            Session["dt"] = ds.Tables[0];
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gvCashBookList.DataSource = ds.Tables[0];
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
                gvCashBookList.DataBind();
            }
            else
            {
                gvCashBookList.DataSource = null;
                gvCashBookList.DataBind();

                Label lblEmptyMessage = gvCashBookList.Controls[0].Controls[0].FindControl("lblEmptyMessage") as Label;
                lblEmptyMessage.Text = "Currently there are no records in System";

            }
            gvCashBookList.PageSize = Convert.ToInt32(ddlRecords.SelectedValue);
        }
        catch (Exception ex)
        {
            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }
    protected void ddlRecords_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCashBook();
    }
    protected void gvCashBookList_Sorting(object sender, GridViewSortEventArgs e)
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
            BindCashBook();
        }
        catch (Exception ex)
        {
            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }
    protected void imgsearch_Click(object sender, ImageClickEventArgs e)
    {
        SearchItemFromList(txtSearch.Text.Trim());
    }

    void SearchItemFromList(string SearchText)
    {
        try
        {
            if (Session["dt"] != null)
            {
                DataTable dt = (DataTable)Session["dt"];
                DataRow[] dr = dt.Select(
                    "CashBookKey='" + SearchText +
                    "' OR CashDescription LIKE '%" + SearchText +
                    "%' OR TransName LIKE '%" + SearchText +
                    "%' OR GICode LIKE '%" + SearchText +
                    "%' OR ReferenceFormat LIKE '%" + SearchText +
                    "%' OR VatCodes LIKE '%" + SearchText + "%'");

                if (dr.Count() > 0)
                {
                    gvCashBookList.PageSize = int.Parse(ViewState["ps"].ToString());
                    gvCashBookList.DataSource = dr.CopyToDataTable();
                    gvCashBookList.DataBind();
                }
                else
                {
                    gvCashBookList.DataSource = null;
                    gvCashBookList.DataBind();

                    Label lblEmptyMessage = gvCashBookList.Controls[0].Controls[0].FindControl("lblEmptyMessage") as Label;
                    lblEmptyMessage.Text = "Currently there are no records in" + "  '" + SearchText + "'";
                }
            }
        }
        catch (Exception ex)
        {
           // lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
           // DALGlobal.SendExcepToDB(ex);
        }
    }

    protected void cmdSearch_Click(object sender, ImageClickEventArgs e)
    {
        SearchItemFromList(txtSearch.Text.Trim());
    }

   
    protected void gvCashBookList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            var ToolTipString = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "Deactivate"));

            foreach (TableCell cell in e.Row.Cells)
            {
                if (ToolTipString == "1")
                {
                    // cell.BackColor = Color.Red;
                    cell.ForeColor = Color.Red;
                }
            }
        }
    }
    protected void imgRefresh_Click(object sender, ImageClickEventArgs e)
    {
        BindCashBook();
    }
}