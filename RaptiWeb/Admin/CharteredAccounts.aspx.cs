using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessManager;
using EntityManager;
using System.Data;
using DataManager;
public partial class Admin_CharteredAccounts : System.Web.UI.Page
{
    BALCharteredAccounts objBALChartofAcc = new BALCharteredAccounts();
    EMCharteredAccounts objEMChartofAcc = new EMCharteredAccounts();
    BALMainAccounts objBALMainAccount = new BALMainAccounts();
    BoUtility objBOutility = new BoUtility();
    BALGlobal objBALglobal = new BALGlobal();
   

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDDLMasterAccount();          
        }
        lblcheckacccode.Text = "";
    }
    protected void DDLMasterAcc_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = objBALMainAccount.MainAccountsList(Convert.ToInt32(DDLMasterAcc.SelectedItem.Value));

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtMainAccCode.Text = ds.Tables[0].Rows[0]["MainAccountCode"].ToString();
            }
            else
            {
                txtMainAccCode.Text = "";
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }
    protected void txtChartofAcc_TextChanged(object sender, EventArgs e)
    {
        try
        {
            lblcheckacccode.Text = "";
            DataSet ds = objBOutility.CheckAccCode_ExistorNot(txtMainAccCode.Text+txtChartofAcc.Text, "CharteredAcc");
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblcheckacccode.Text = "Alredy Exist";
                lblcheckacccode.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblcheckacccode.Text = "Available";
                lblcheckacccode.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }
        catch (Exception ex)
        {

            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }
    protected void Submit_ChartofAcc_Click(object sender, EventArgs e)
    {
        InsertUpdateChartofAccount();
    }
    protected void Cancel_ChartofAcc_Click(object sender, EventArgs e)
    {
        Response.Redirect("CharteredAccountsList.aspx",false);
    }
    protected void Reset_ChartofAcc_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
    
    #endregion

    #region PrivateMethods
    private void BindDDLMasterAccount()
    {

        try
        {
            DataSet ds = objBALMainAccount.MainAccountsList(0);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLMasterAcc.DataSource = ds.Tables[0];
                DDLMasterAcc.DataTextField = "MainAccountName";
                DDLMasterAcc.DataValueField = "MainAccountId";
                DDLMasterAcc.DataBind();
                DDLMasterAcc.Items.Insert(0, new ListItem("--Select Main Account--", "0"));
            }
            else
            {
                DDLMasterAcc.DataSource = null;
                DDLMasterAcc.DataBind();
                DDLMasterAcc.Items.Insert(0, new ListItem("--Select Main Account--", "0"));
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }
    private void InsertUpdateChartofAccount()
    {
        try
        {
            objEMChartofAcc.ChartedAccId = Convert.ToInt32(hf_CharteredofaccountId.Value);
            objEMChartofAcc.ChartedAccName = txtchartofaccName.Text;
            objEMChartofAcc.ChartedMasterAccId = Convert.ToInt32(DDLMasterAcc.SelectedItem.Value);
            objEMChartofAcc.ChartofAccCode = txtMainAccCode.Text + txtChartofAcc.Text;
            objEMChartofAcc.MainAccCode = txtMainAccCode.Text;
            objEMChartofAcc.CategoryId = Convert.ToInt32(DDLCategory.SelectedItem.Value);
            objEMChartofAcc.CompanyId = 1;
            objEMChartofAcc.BranchId = 1;
            objEMChartofAcc.CreatedBy = 1;
            int result = objBALChartofAcc.InsUpdChartOfAccounta(objEMChartofAcc);

            if (result > 0)
            {
                Response.Redirect("CharteredAccountsList.aspx",false);
            }
            else
            {

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
        txtchartofaccName.Text = "";
        DDLMasterAcc.SelectedIndex = 0;
        txtMainAccCode.Text = "";
        txtChartofAcc.Text = "";
        DDLCategory.SelectedIndex = 0;
        lblcheckacccode.Text = "";
    }

    #endregion

  
}