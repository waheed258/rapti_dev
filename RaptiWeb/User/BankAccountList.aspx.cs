using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessManager;
using System.Data;
using DataManager;
using System.Drawing;


public partial class User_BankAccountList : System.Web.UI.Page
{
    BALBankAccount objBALBankAccount = new BALBankAccount();
    BALGlobal objBALglobal = new BALGlobal();
    int branchId = 3;
    int companyId = 1;

    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindBankAccounts(branchId, companyId);
        }
    }
    protected void gvBankAccountList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            var ToolTipString = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "DeActivate"));

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
    protected void gvBankAccountList_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        try
        {
            string BankId = e.CommandArgument.ToString();

            if (e.CommandName == "Edit Bank")
            {

                Response.Redirect("BankAccount.aspx?BankId= " + Convert.ToInt32(BankId), true);
            }
            else if (e.CommandName == "Delete Bank")
            {

                DeleteBranch(Convert.ToInt32(BankId));
                BindBankAccounts(branchId, companyId);
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    } 

    #endregion

    #region PrivateMethods
    private void DeleteBranch(int BankId)
    {
        try
        {
            int Result = objBALBankAccount.Delete_BankAccountData(BankId);
        }
        catch (Exception ex)
        {

            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }
    private void BindBankAccounts(int branchId, int companyId)
    {
        try
        {
            int BankId = 0;
            DataSet ds = objBALBankAccount.Get_BankAccountData(branchId, companyId, BankId);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gvBankAccountList.DataSource = ds.Tables[0];
                gvBankAccountList.DataBind();
                gvBankAccountList.Columns[4].Visible = false;
            }

            else
            {
                gvBankAccountList.DataSource = null;
                gvBankAccountList.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }

    }
    
    #endregion

}