using BusinessManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Admin_Company : System.Web.UI.Page
{
    EMCompany _ObjEmCompany = new EMCompany();
    BALCompany _ObjBalCompany = new BALCompany();
    BOUtiltiy _objBoutility = new BOUtiltiy();
    public string FileLogo = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Company(1);
        }
    }



    private void BindCountries()
    {
        try
        {
            DDLProvince.Items.Clear();
            DDLCity.Items.Clear();

            DataSet ds = _objBoutility.getCountries();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLCountry.DataSource = ds.Tables[0];
                DDLCountry.DataTextField = "Name";
                DDLCountry.DataValueField = "Id";
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
            labelError.Text = _objBoutility.ShowMessage("danger", "error", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
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
                DDLCurrency.DataTextField = "code";
                DDLCurrency.DataValueField = "id";
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
            labelError.Text = _objBoutility.ShowMessage("danger", "error", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    private void BindState()
    {
        try
        {

            DDLProvince.Enabled = true;
            rfvDDLProvince.Enabled = true;
            DDLProvince.Items.Clear();
            DDLCity.Items.Clear();
            DataSet ds = new DataSet();
            int country_id = Convert.ToInt32(DDLCountry.SelectedValue.ToString());
            ds = _objBoutility.get_State_Country(country_id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLProvince.DataSource = ds.Tables[0];
                DDLProvince.DataTextField = "Name";
                DDLProvince.DataValueField = "Id";
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
            labelError.Text = _objBoutility.ShowMessage("danger", "error", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    private void BindCity()
    {
        try
        {
            DDLCity.Enabled = true;
            rfvDDLCity.Enabled = true;

            DDLCity.Items.Clear();
            DataSet ds = new DataSet();
            int state_id = Convert.ToInt32(DDLProvince.SelectedValue.ToString());
            ds = _objBoutility.get_City_State(state_id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLCity.DataSource = ds.Tables[0];
                DDLCity.DataTextField = "Name";
                DDLCity.DataValueField = "Id";
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
            labelError.Text = _objBoutility.ShowMessage("danger", "error", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    protected void DDLCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindState();
    }
    protected void DDLProvince_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCity();
    }
    private string GetFile(FileUpload FUName)
    {
        string fileName = string.Empty;
        if (FUName.HasFile)
        {
            string strPath = System.IO.Path.GetExtension(FUName.PostedFile.FileName);
            string date = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            fileName = date + strPath;
            FUName.SaveAs(Server.MapPath("~/Logos/" + fileName));
            lblLogo.Text = CompanyLogoUpload.FileName;
        }
        return fileName;
    }

    private void InsertCompanyDetails()
    {
        try
        {

            _ObjEmCompany.CompanyId = Convert.ToInt32(hf_CompanyId.Value);
            _ObjEmCompany.CompanyName = txtCompanyName.Text;
            _ObjEmCompany.CompanyEmail = txtEmailId.Text;
            _ObjEmCompany.CompanyPhoneNo = txtPhoneNo.Text;
            _ObjEmCompany.CompanyWebSite = txtWebSite.Text;
            _ObjEmCompany.CompanyFax = txtFaxNo.Text;
            _ObjEmCompany.CompanyCountry = Convert.ToInt32(DDLCountry.SelectedValue);
            _ObjEmCompany.CompanyState = Convert.ToInt32(DDLProvince.SelectedValue);
            _ObjEmCompany.CompanyCity = Convert.ToInt32(DDLCity.SelectedValue);
            _ObjEmCompany.CompanyCurrency = Convert.ToInt32(DDLCurrency.SelectedValue);
            _ObjEmCompany.CreatedBy = 1;

            string filepath = string.Empty;
            if (hfImageLogo.Value != "")
            {
                if (CompanyLogoUpload.HasFile)
                    lblLogo.Text = CompanyLogoUpload.FileName;
                else
                    filepath = hfImageLogo.Value.ToString();
            }
            else
                filepath = GetFile(CompanyLogoUpload);

            _ObjEmCompany.CompanyLogo = lblLogo.Text;
            _ObjEmCompany.CompanylogoPath = filepath;

            //}

            int Result = _ObjBalCompany.InsUpdCompany(_ObjEmCompany);

            if (Result > 0)
            {
                // lblMsg.Text = _BOUtility.ShowMessage("success", "Success", "Air Suppliers Created Successfully.");
                ClearControl();
                Response.Redirect("CompanyDetails.aspx", false);
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
    protected void Company_Submit_Click(object sender, EventArgs e)
    {
        try
        {
            InsertCompanyDetails();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Company(int CompanyId)
    {
        try
        {
            _ObjEmCompany.CompanyId = CompanyId;
            DataSet ds = _ObjBalCompany.GetCompany(CompanyId);
            if (ds.Tables[0].Rows.Count > 0)
            {

                hf_CompanyId.Value = ds.Tables[0].Rows[0]["CompanyId"].ToString();
                txtCompanyName.Text = ds.Tables[0].Rows[0]["CompanyName"].ToString();


                lblLogo.Text = ds.Tables[0].Rows[0]["CompanyLogo"].ToString();
                hfImageLogo.Value = ds.Tables[0].Rows[0]["CompanylogoPath"].ToString();
                FileLogo = ds.Tables[0].Rows[0]["CompanylogoPath"].ToString();
                logoview.Attributes["href"] = "../Logos/" + FileLogo;

                //CompanyLogoUpload.HasFile = ds.Tables[0].Rows[0]["CompanyLogo"].ToString();
                txtEmailId.Text = ds.Tables[0].Rows[0]["CompanyEmail"].ToString();
                txtPhoneNo.Text = ds.Tables[0].Rows[0]["CompanyPhoneNo"].ToString();
                txtWebSite.Text = ds.Tables[0].Rows[0]["CompanyWebSite"].ToString();
                txtFaxNo.Text = ds.Tables[0].Rows[0]["CompanyFax"].ToString();
                BindCountries();
                DDLCountry.SelectedIndex = DDLCountry.Items.IndexOf(DDLCountry.Items.FindByValue(ds.Tables[0].Rows[0]["CompanyCountry"].ToString()));
                BindState();
                DDLProvince.SelectedIndex = DDLProvince.Items.IndexOf(DDLProvince.Items.FindByValue(ds.Tables[0].Rows[0]["CompanyState"].ToString()));
                BindCity();
                DDLCity.SelectedIndex = DDLCity.Items.IndexOf(DDLCity.Items.FindByValue(ds.Tables[0].Rows[0]["CompanyCity"].ToString()));
                BindCurrency();
                DDLCurrency.SelectedIndex = DDLCurrency.Items.IndexOf(DDLCurrency.Items.FindByValue(ds.Tables[0].Rows[0]["CompanyCurrency"].ToString()));

            }
            else
            {

            }


        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        ClearControl();
    }
    private void ClearControl()
    {

        hf_CompanyId.Value = "0";
        txtCompanyName.Text = "";
        txtEmailId.Text = "";
        txtPhoneNo.Text = "";
        txtWebSite.Text = "";
        txtFaxNo.Text = "";
        DDLCountry.SelectedValue = "-1";
        DDLProvince.SelectedValue = "-1";
        DDLCity.SelectedValue = "-1";
        DDLCurrency.SelectedValue = "-1";
    }
}