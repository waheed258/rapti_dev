using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessManager;
using DataManager;
using EntityManager;

using System.Data;
public partial class Admin_Branch : System.Web.UI.Page
{
    BoUtility _objBoutility = new BoUtility();
    EMBranch _objEMBranch = new EMBranch();
    DALBranch _objDALBranch = new DALBranch();
    BALBranch _objBALBranch = new BALBranch();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCountries();
            BindCurrency();
            DefaultSeletedItems();
            BindVatType();

            if (!string.IsNullOrEmpty(Request.QueryString["BranchId"]))
            {
                var qs = "0";
                if (Request.QueryString["ConsultantId"] == null)
                {
                    qs = "0";
                }
                int BranchId = Convert.ToInt32(qs);

                Submit_Branch.Text = "Update";
                GetBranchDetails(BranchId);
            }
        }
      
    }

    private void GetBranchDetails(int BranchId)
    {
        try
        {
            _objEMBranch.BranchId = BranchId;
            DataSet ds = _objBALBranch.Branch_GetData(BranchId);
            if (ds.Tables[0].Rows.Count > 0)
            {
                hf_BranchId.Value = ds.Tables[0].Rows[0]["BranchId"].ToString();
                txtBranchName.Text = ds.Tables[0].Rows[0]["BranchName"].ToString();

                txtPhoneno.Text = ds.Tables[0].Rows[0]["BranchPhoneNo"].ToString();
                txtAlternativeNo.Text = ds.Tables[0].Rows[0]["BranchAlternativeNo"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["BranchEmail"].ToString();
                txtPhysicalAddress.Text = ds.Tables[0].Rows[0]["BranchPhysicalAddress"].ToString();
                txtPostalAddress.Text = ds.Tables[0].Rows[0]["BranchPostalAddress"].ToString();


                DDLCountry.SelectedIndex = DDLCountry.Items.IndexOf(DDLCountry.Items.FindByValue(ds.Tables[0].Rows[0]["BranchCountry"].ToString()));
                DDLProvince.SelectedIndex = DDLProvince.Items.IndexOf(DDLProvince.Items.FindByValue(ds.Tables[0].Rows[0]["BranchState"].ToString()));
                DDLProvince.SelectedIndex = DDLProvince.Items.IndexOf(DDLProvince.Items.FindByValue(ds.Tables[0].Rows[0]["BranchCity"].ToString()));

                txtCoRegNo.Text = ds.Tables[0].Rows[0]["BranchCoRegNo"].ToString();
                txtIATARegNo.Text = ds.Tables[0].Rows[0]["BranchIATARegNo"].ToString();
                txtVatRegNo.Text = ds.Tables[0].Rows[0]["BranchVatRegNo"].ToString();
                txtDoCex.Text = ds.Tables[0].Rows[0]["BranchDoCex"].ToString();

                txtBranchCode.Text = ds.Tables[0].Rows[0]["BranchCode"].ToString();
                DDLCurrency.SelectedIndex = DDLCurrency.Items.IndexOf(DDLCurrency.Items.FindByValue(ds.Tables[0].Rows[0]["BranchCurrency"].ToString()));

                chkMemberOfAsata.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["BranchMemberOfAsata"]);       
                chkIsactive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["BranchIsActive"]);
        
            }
        }
        catch (Exception ex)
        {

            //lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }

    }
    protected void chkcheckphysicaladdress_CheckedChanged(object sender, EventArgs e)
    {
        if(chkcheckphysicaladdress.Checked == true)
        {
            txtPostalAddress.Text = txtPhysicalAddress.Text;
        }
        else
        {
            txtPostalAddress.Text = "";
        }
    }
    protected void txtPhysicalAddress_TextChanged(object sender, EventArgs e)
    {
        chkcheckphysicaladdress.Checked = false;
        txtPostalAddress.Text = "";
    }
    protected void chkServiceFeeMerge_CheckedChanged(object sender, EventArgs e)
    {
        if(chkServiceFeeMerge.Checked == true)
        {
            chkIsSerFeeAddToAirportTax.Checked = true;
            chkIsSerFeeMergePaymentMatch.Checked = true;
        }
        else
        {
            chkIsSerFeeAddToAirportTax.Checked = false;
            chkIsSerFeeMergePaymentMatch.Checked = false;
        }
        chkServiceFeeMerge.Focus();
    }
    protected void Submit_Branch_Click(object sender, EventArgs e)
    {

        InsertUpdateBranch();
    }
    protected void Cancel_Branch_Click(object sender, EventArgs e)
    {
        Response.Redirect("BranchList.aspx", false);
    }
    protected void Reset_Branch_Click(object sender, EventArgs e)
    {

    }

    private void InsertUpdateBranch()
    {
        _objEMBranch.BranchId = Convert.ToInt32(hf_BranchId.Value);
        _objEMBranch.BranchName = txtBranchName.Text;
       // _objEMBranch.BranchLogo = txtbranch.Text;
        _objEMBranch.BranchPhoneNo = txtPhoneno.Text;
        _objEMBranch.BranchAlternativeNo = txtAlternativeNo.Text;
        _objEMBranch.BranchEmail = txtEmail.Text;
        _objEMBranch.BranchPhysicalAddress =txtPhysicalAddress.Text;
        _objEMBranch.BranchPostalAddress = txtPostalAddress.Text;
        _objEMBranch.BranchCountry = Convert.ToInt32(DDLCountry.SelectedValue);
        _objEMBranch.BranchState = Convert.ToInt32(DDLProvince.SelectedValue);
        _objEMBranch.BranchCity = Convert.ToInt32(DDLCity.SelectedValue);

        _objEMBranch.BranchCoRegNo = txtCoRegNo.Text;
        _objEMBranch.BranchIATARegNo = txtIATARegNo.Text;
        _objEMBranch.BranchVatRegNo = txtVatRegNo.Text;
        _objEMBranch.BranchDoCex = txtDoCex.Text;
        _objEMBranch.BranchMemberOfAsata = Convert.ToInt32(chkMemberOfAsata.Checked);
        _objEMBranch.CompanyId = 1;
        _objEMBranch.BranchCurrency = Convert.ToInt32(DDLCurrency.SelectedValue);
        _objEMBranch.BranchIsActive = Convert.ToInt32(chkIsactive.Checked);
        _objEMBranch.CreatedBy = 1;
        _objEMBranch.BranchCode = txtBranchCode.Text;

        int Result = _objDALBranch.InsUpdBranch(_objEMBranch);



        if (Result > 0)
        {
            
            _objEMBranch.VatPercentage = Convert.ToDecimal(txtVatPercentage.Text);
            _objEMBranch.InvStartNo = Convert.ToInt32(txtInvStartNo.Text);
            _objEMBranch.CreditNoteStartNo = Convert.ToInt32(txtCreditNoteStartNo.Text);
            _objEMBranch.ZeroCommForSuppliers = Convert.ToInt32(chkZeroCommForSuppliers.Checked);
            _objEMBranch.ConvertProInvToInv = Convert.ToInt32(chkConvertProInvToInv.Checked);
            _objEMBranch.ServiceFeeMerge = Convert.ToInt32(chkServiceFeeMerge.Checked);
            _objEMBranch.IsSerFeeAddToAirportTax = Convert.ToInt32(chkIsSerFeeAddToAirportTax.Checked);

            _objEMBranch.IsSerFeeMergePaymentMatch = Convert.ToInt32(chkIsSerFeeMergePaymentMatch.Checked);
            _objEMBranch.PreFixDebtors = txtPreFixDebtors.Text;
            _objEMBranch.PreFixCorporates = txtPreFixCorporates.Text;
            _objEMBranch.PreFixLiesures = txtPreFixLiesures.Text;
            _objEMBranch.RoundingDecimal = txtRoundingDecimal.Text;

            _objEMBranch.SupplierMainAcNo = txtSupplierMainAcNo.Text;
            _objEMBranch.ClientMainAcNo = txtClientMainAcNo.Text;
            _objEMBranch.BranchId = Convert.ToInt32(Result.ToString());
            _objEMBranch.CreatedBy = 1;
           int configResult=  _objDALBranch.InsUpdConfiguration(_objEMBranch);
          if (configResult > 0)
          {

          }

        }
    }

    private void BindVatType()
    {
        try
        {
            
            DataSet ds = _objBoutility.GetVatData();
            ViewState["txtVatPercentage"] = ds.Tables[0];

            if (ViewState["txtVatPercentage"].ToString() != null)
            {
                DataTable dt = (DataTable)ViewState["txtVatPercentage"];
                //string vatRate = Convert.ToString(_doUtilities.getVatByType(Convert.ToInt32(ddlType.SelectedValue)));
                string vatRate = (dt.AsEnumerable()
                    .Where(p => p["VatDescription"].ToString() == "Standard Output")
                    .Select(p => p["VatRate"].ToString())).FirstOrDefault();

                txtVatPercentage.Text = vatRate;
            }

            else
            {
                txtVatPercentage.Text = "";

            }
        }
        catch (Exception ex)
        {
            //lblMsg.Text = _BOUtility.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }
    }
    private void BindCountries()
    {
        try
        {
            DDLProvince.Items.Clear();
            DDLCity.Items.Clear();
            DataSet ds = _objBoutility.GetCountries();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLCountry.DataSource = ds.Tables[0];
                DDLCountry.DataTextField = "CountryName";
                DDLCountry.DataValueField = "CountryId";
                DDLCountry.DataBind();
                DDLCountry.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
            else
            {
                DDLCountry.DataSource = null;
                DDLCountry.DataBind();
                DDLCountry.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
        }
        catch (Exception ex)
        {
            //lblMsg.Text = _BOUtility.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }
  }

    private void BindCurrency()
    {
        try
        {

            DataSet ds = _objBoutility.GetCurrency();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLCurrency.DataSource = ds.Tables[0];
                DDLCurrency.DataTextField = "CurrencyCode";
                DDLCurrency.DataValueField = "CurrencyId";
                DDLCurrency.DataBind();
                DDLCurrency.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
            else
            {
                DDLCurrency.DataSource = null;
                DDLCurrency.DataBind();
                DDLCurrency.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
        }
        catch (Exception ex)
        {
            //lblMsg.Text = _BOUtility.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }
    }
    private void BindState()
    {
        try
        {
            DDLProvince.Items.Clear();
            DDLCity.Items.Clear();
            DataSet ds = new DataSet();
            int country_id = Convert.ToInt32(DDLCountry.SelectedValue.ToString());
            ds = _objBoutility.GetState(country_id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLProvince.DataSource = ds.Tables[0];
                DDLProvince.DataTextField = "StateName";
                DDLProvince.DataValueField = "StateId";
                DDLProvince.DataBind();
                DDLProvince.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
            else
            {
                DDLProvince.DataSource = null;
                DDLProvince.DataBind();
                DDLProvince.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
        }
        catch (Exception ex)
        {
            //lblMsg.Text = _BOUtility.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void BindCity()
    {
        try
        {
            DDLCity.Items.Clear();
            DataSet ds = new DataSet();
            int state_id = Convert.ToInt32(DDLProvince.SelectedValue.ToString());
            ds = _objBoutility.GetCities(state_id);         
            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLCity.DataSource = ds.Tables[0];
                DDLCity.DataTextField = "CityName";
                DDLCity.DataValueField = "CityId";
                DDLCity.DataBind();
                DDLCity.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
            else
            {
                DDLCity.DataSource = null;
                DDLCity.DataBind();
                DDLCity.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
        }
        catch (Exception ex)
        {
            //lblMsg.Text = _BOUtility.ShowMessage("danger", "Danger", ex.Message);
            //ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void DefaultSeletedItems()
    {
        chkIsactive.Checked = true;
        chkMemberOfAsata.Checked = true;
        chkZeroCommForSuppliers.Checked = true;
        chkConvertProInvToInv.Checked = true;
        chkServiceFeeMerge.Checked = true;
        chkIsSerFeeMergePaymentMatch.Checked = true;
        chkIsSerFeeAddToAirportTax.Checked = true;
    }
    protected void DDLCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindState();
    }
    protected void DDLProvince_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCity();
    }
}