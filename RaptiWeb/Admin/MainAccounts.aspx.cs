using BusinessManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MainAccounts : System.Web.UI.Page
{
    EMMainAccounts _ObjEmMainAccount = new EMMainAccounts();
    BALMainAccounts _ObjBALMainAccounts = new BALMainAccounts();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }

    private void InsertMainAccounts()
    {

        _ObjEmMainAccount.MainAccountId = Convert.ToInt32(hf_MainAccountId.Value);
        _ObjEmMainAccount.MainAccountCode = txtMainAccCode.Text;
        _ObjEmMainAccount.MainAccountName = txtMainAccName.Text;
        _ObjEmMainAccount.Department = Convert.ToInt32(DDLMainAccDepartment.SelectedValue);
        _ObjEmMainAccount.Branch = Convert.ToInt32(DDLMainAccBranch.SelectedValue);
        _ObjEmMainAccount.AccountType = Convert.ToInt32(DDLMainAccType.SelectedValue);
        _ObjEmMainAccount.Category = Convert.ToInt32(DDLMainAccCategory.SelectedValue);
        _ObjEmMainAccount.Company = 1;
        _ObjEmMainAccount.CreatedBy = 1;


        int Result = _ObjBALMainAccounts.InsertMainAaccounts(_ObjEmMainAccount);
        //int Result = _ObjBalCompany.InsUpdCompany(_ObjEmCompany);

        if (Result > 0)
        {
            // lblMsg.Text = _BOUtility.ShowMessage("success", "Success", "Air Suppliers Created Successfully.");
            Response.Redirect("MainAccount.aspx", false);
        }
        else
        {

            // lblMsg.Text = _BOUtility.ShowMessage("info", "Info", "Airsuppliers was not created please try again");
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        InsertMainAccounts();
    }
}