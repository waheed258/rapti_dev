using BusinessManager;
using DataManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ReceiptType : System.Web.UI.Page
{
    EMReceiptType _ObjEMReceiptType = new EMReceiptType();
    DALReceiptType _objDALReceiptType = new DALReceiptType();
    BALReceiptType _ObjBALReceiptType = new BALReceiptType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                string getId = Convert.ToString(Request.QueryString["Id"]);
                int Id = Convert.ToInt32(getId);
                ReceiptType(Id);

            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ReceiptTypeInsertUpdate();
    }
    /// <summary>
    /// Receipt Type Insert
    /// </summary>
    private void ReceiptTypeInsertUpdate()
    {

        try
        {
            _ObjEMReceiptType.ReceiptTypeId = Convert.ToInt32(hf_ReceiptTypeid.Value);
            _ObjEMReceiptType.ReceiptTypeKey = txtReceiptTypeKey.Text;
            _ObjEMReceiptType.ReceiptTypeIsActive = Convert.ToInt32(ChkIsActive.Checked);
            _ObjEMReceiptType.ReceiptTypeDescription = txtDescription.Text;
            _ObjEMReceiptType.DepositListMethod = Convert.ToInt32(DDLDepListMethod.SelectedValue);
            _ObjEMReceiptType.BankAccount = Convert.ToInt32(DDLBankAccounts.SelectedValue);
            _ObjEMReceiptType.CreditCardType = Convert.ToInt32(DDLCreditCardType.SelectedValue);
            _ObjEMReceiptType.SetasDefault = Convert.ToInt32(ChkDefault.Checked);
            _ObjEMReceiptType.Branch = 1;
            _ObjEMReceiptType.Company = 1;
            _ObjEMReceiptType.CreatedBy = 1;

            int Result = _objDALReceiptType.InsertUpdateReceiptType(_ObjEMReceiptType);

            if (Result > 0)
            {
                // lblMsg.Text = _BOUtility.ShowMessage("success", "Success", "Air Suppliers Created Successfully.");
                Response.Redirect("ReceiptTypeList.aspx", false);
            }
            else
            {
                // lblMsg.Text = _BOUtility.ShowMessage("info", "Info", "Airsuppliers was not created please try again");
            }
        }
        catch (Exception)
        {

            throw;
        }


    }


    public void ReceiptType(int ReceiptTypeId)
    {
        try
        {
            _ObjEMReceiptType.ReceiptTypeId = ReceiptTypeId;
            DataSet ds = _ObjBALReceiptType.GetReceiptType(ReceiptTypeId);
            if (ds.Tables[0].Rows.Count > 0)
            {

                hf_ReceiptTypeid.Value = ds.Tables[0].Rows[0]["ReceiptTypeId"].ToString();
                ChkIsActive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["ReceiptTypeIsActive"]);
                txtReceiptTypeKey.Text = ds.Tables[0].Rows[0]["ReceiptTypeKey"].ToString();
                txtDescription.Text = ds.Tables[0].Rows[0]["ReceiptTypeDescription"].ToString();
                DDLDepListMethod.SelectedIndex = DDLDepListMethod.Items.IndexOf(DDLDepListMethod.Items.FindByValue(ds.Tables[0].Rows[0]["DepositListMethod"].ToString()));
                DDLBankAccounts.SelectedIndex = DDLBankAccounts.Items.IndexOf(DDLBankAccounts.Items.FindByValue(ds.Tables[0].Rows[0]["BankAccount"].ToString()));
                DDLCreditCardType.SelectedIndex = DDLCreditCardType.Items.IndexOf(DDLCreditCardType.Items.FindByValue(ds.Tables[0].Rows[0]["CreditCardType"].ToString()));
                ChkDefault.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["SetasDefault"]);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

}