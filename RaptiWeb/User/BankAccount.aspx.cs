using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityManager;
using BusinessManager;
using System.Data;
using DataManager;

public partial class User_BankAccount : System.Web.UI.Page
{

    EMBankAccount objEMBankAccount = new EMBankAccount();
    BALBankAccount objBALBankAccount = new BALBankAccount();
    BALBranch objBALBranch = new BALBranch();
    BALGlobal objBALglobal = new BALGlobal();

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindBranches();
            int BranchId = 1;
            int CompanyId = 1;
            if (!string.IsNullOrEmpty(Request.QueryString["BankId"]))
            {

                string bankId = "0";

                if (Request.QueryString["BankId"] == null)
                {
                    bankId = "0";

                }
                else
                {
                    bankId = Request.QueryString["BankId"].ToString();

                }

                Submit_BankAccount.Text = "Update";
                GetBankAccountDetails(BranchId,CompanyId,bankId);
            }
        }
    }

    protected void Cancel_BankAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("BankAccountList.aspx", false);
    }
    protected void Submit_BankAccount_Click(object sender, EventArgs e)
    {
        InsertUpdateBankAccount();
    }
    protected void Reset_BankAccount_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
    
    #endregion

    #region PrivateMethods
    private void InsertUpdateBankAccount()
    {
        try
        {
            objEMBankAccount.BankId = Convert.ToInt32(hf_BankAccountId.Value);
            objEMBankAccount.BankKey = txtBankKey.Text;
            objEMBankAccount.AccountName = txtAccName.Text;
            objEMBankAccount.AccountType = txtBankAccType.Text;
            objEMBankAccount.AccountNo = txtBankAccNo.Text;
            objEMBankAccount.BranchCode = txtBranchCode.Text;
            objEMBankAccount.BranchName = txtBranchName.Text;
            objEMBankAccount.DeActivate = Convert.ToInt32(chkIsactive.Checked);
            objEMBankAccount.AccountHolder = txtbankAccHolder.Text;
            objEMBankAccount.Graphic = txtGraphic.Text;
            objEMBankAccount.OwnerBranch = Convert.ToInt32(DDLOwnerBranch.SelectedItem.Value);
            objEMBankAccount.QuickGiCode = txtQuickGiCode.Text;
            objEMBankAccount.QuickGiDepositsBatch = txtQuickGiDepBatch.Text;
            objEMBankAccount.QuickPaymentBatch = txtQuickGiPayBatch.Text;
            objEMBankAccount.CreatedBy = 1;
            objEMBankAccount.CompanyId = 1;
            int Result = objBALBankAccount.InsUpdBankAccount(objEMBankAccount);

            if (Result > 0)
            {
                Response.Redirect("BankAccountList.aspx", false);
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }

    }

    private void GetBankAccountDetails(int branchId, int companyId, string BankId)
    {
        try
        {
            DataSet ds = objBALBankAccount.Get_BankAccountData(branchId, companyId, Convert.ToInt32(BankId));

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                hf_BankAccountId.Value = ds.Tables[0].Rows[0]["BankId"].ToString();
                txtBankKey.Text = ds.Tables[0].Rows[0]["BankKey"].ToString();
                txtAccName.Text = ds.Tables[0].Rows[0]["AccountName"].ToString();
                txtBankAccType.Text = ds.Tables[0].Rows[0]["AccountType"].ToString();
                txtBankAccNo.Text = ds.Tables[0].Rows[0]["AccountNo"].ToString();
                txtBranchCode.Text = ds.Tables[0].Rows[0]["BranchCode"].ToString();
                txtBranchName.Text = ds.Tables[0].Rows[0]["BranchName"].ToString();
                txtbankAccHolder.Text = ds.Tables[0].Rows[0]["AccountHolder"].ToString();
                txtGraphic.Text = ds.Tables[0].Rows[0]["Graphic"].ToString();
                DDLOwnerBranch.SelectedIndex = DDLOwnerBranch.Items.IndexOf(DDLOwnerBranch.Items.FindByValue(ds.Tables[0].Rows[0]["OwnerBranch"].ToString()));
                txtQuickGiCode.Text = ds.Tables[0].Rows[0]["QuickGiCode"].ToString();
                txtQuickGiDepBatch.Text = ds.Tables[0].Rows[0]["QuickGiDepositsBatch"].ToString();
                txtQuickGiPayBatch.Text = ds.Tables[0].Rows[0]["QuickPaymentBatch"].ToString();
                chkIsactive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["DeActivate"]);


            }
        }
        catch (Exception ex)
        {
           lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }

    }
    private void BindBranches()
    {
        try
        {

            int BranchId = 0;
            DataSet ds = objBALBranch.Branch_GetData(BranchId);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLOwnerBranch.DataSource = ds.Tables[0];
                DDLOwnerBranch.DataTextField = "BranchName";
                DDLOwnerBranch.DataValueField = "BranchId";
                DDLOwnerBranch.DataBind();
                DDLOwnerBranch.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
            else
            {
                DDLOwnerBranch.DataSource = null;
                DDLOwnerBranch.DataBind();
                DDLOwnerBranch.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }

    private void clearcontrols()
    {
        txtBankKey.Text = "";
        txtBankAccType.Text = "";
        txtAccName.Text = "";
        txtBankAccNo.Text = "";
        txtBranchCode.Text = "";
        txtBranchName.Text = "";
        txtbankAccHolder.Text = "";
        txtGraphic.Text = "";
        DDLOwnerBranch.SelectedIndex = 0;
        txtQuickGiCode.Text = "";
        txtQuickGiDepBatch.Text = "";
        txtQuickGiPayBatch.Text = "";
    } 
    #endregion
}