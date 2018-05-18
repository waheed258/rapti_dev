﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessManager;

public partial class Admin_PaymentTypesList : System.Web.UI.Page
{
    BAPaymentTypes objBAPaymentTypes = new BAPaymentTypes();
    BOUtiltiy _objBOUtiltiy = new BOUtiltiy();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            ViewState["ps"] = 10;
            BindPaymentTypesDetails();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentTypes.aspx");
    }
    protected void DropPage_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["ps"] = DropPage.SelectedItem.ToString().Trim();
        SearchItemFromList(txtSearch.Text.Trim());
       // BindPaymentTypesDetails();
    }
    protected void gvPaymentTypesList_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {


            string PayId = e.CommandArgument.ToString();
            if (e.CommandName == "Edit PaymentTypes Details")
            {

                Response.Redirect("PaymentTypes.aspx?PaymentId=" + PayId);
            }
            else if (e.CommandName == "Delete PaymentTypes Details")
            {
                DeletePaymentTypeDetails(Convert.ToInt32(PayId));
                BindPaymentTypesDetails();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void gvPaymentTypesList_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvPaymentTypesList.PageIndex = e.NewPageIndex;
        SearchItemFromList(txtSearch.Text.Trim());
        //BindPaymentTypesDetails();
    }

    #region PrivateMethods
    private void BindPaymentTypesDetails()
    {
        try
        {

            gvPaymentTypesList.PageSize = int.Parse(ViewState["ps"].ToString());
            int PaymentId = 0;
            DataSet ds = new DataSet();
            ds = objBAPaymentTypes.GetPaymentTypes(PaymentId);
            Session["dt"] = ds.Tables[0];
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gvPaymentTypesList.DataSource = ds.Tables[0];
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
                gvPaymentTypesList.DataBind();
            }
            else
            {
                gvPaymentTypesList.DataSource = null;
                gvPaymentTypesList.DataBind();
                Label lblEmptyMessage = gvPaymentTypesList.Controls[0].Controls[0].FindControl("lblEmptyMessage") as Label;
                lblEmptyMessage.Text = "Currently there are no records in System";
            }
        }
        catch(Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }



    private void DeletePaymentTypeDetails(int PaymentId)
    {
        try
        {
            int Result = objBAPaymentTypes.DeletePaymentTypes(PaymentId);
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    #endregion PrivateMethods

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
                    "PaymentCode='" + SearchText +
                    "' OR PaymentName LIKE '%" + SearchText +
                    "%' OR Paymentdesc LIKE '%" + SearchText + "%'");

                if (dr.Count() > 0)
                {
                    gvPaymentTypesList.PageSize = int.Parse(ViewState["ps"].ToString());
                    gvPaymentTypesList.DataSource = dr.CopyToDataTable();
                    gvPaymentTypesList.DataBind();
                }
                else
                {
                    gvPaymentTypesList.DataSource = null;
                    gvPaymentTypesList.DataBind();

                    Label lblEmptyMessage = gvPaymentTypesList.Controls[0].Controls[0].FindControl("lblEmptyMessage") as Label;
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
    protected void gvPaymentTypesList_Sorting(object sender, GridViewSortEventArgs e)
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
            BindPaymentTypesDetails();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
}