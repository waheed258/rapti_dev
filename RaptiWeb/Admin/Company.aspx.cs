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
    BoUtility _BOUtility = new BoUtility();
    public string FileLogo = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Company();
            BindCountry();
            BindCurrency();
            DesableFields();
        }
    }

    private void DesableFields()
    {
        DDLProvince.Enabled = false;
        DDLCity.Enabled = false;
    }
    public void BindCountry()
    {
        try
        {

            DataSet ds = _BOUtility.GetCountries();
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
    public void Get_State_Country()
    {
        try
        {
            DataSet ds = new DataSet();
            int Country_Id = Convert.ToInt32(DDLCountry.SelectedValue.ToString());
            ds = _BOUtility.GetState(Country_Id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLProvince.DataSource = ds.Tables[0];
                DDLProvince.Enabled = true;
                DDLProvince.DataTextField = "StateName";
                DDLProvince.DataValueField = "StateId";
                DDLProvince.DataBind();
                DDLProvince.Items.Insert(0, new ListItem("--Select Country--", "0"));

            }
            else
            {
                DDLProvince.DataSource = null;
                DDLProvince.DataBind();
                DDLProvince.Items.Insert(0, new ListItem("--Select Country--", "0"));

            }
        }
        catch (Exception ex)
        {
            //ExceptionLogging.SendExcepToDB(ex);
        }
    }
    public void Get_City_State()
    {
        try
        {
            DataSet ds = new DataSet();
            int State_Id = Convert.ToInt32(DDLProvince.SelectedValue.ToString());
            ds = _BOUtility.GetCities(State_Id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLCity.DataSource = ds.Tables[0];
                DDLCity.Enabled = true;
                DDLCity.DataTextField = "CityName";
                DDLCity.DataValueField = "CityId";
                DDLCity.DataBind();
                DDLCity.Items.Insert(0, new ListItem("-- Select City --", "0"));

            }
            else
            {
                DDLCity.DataSource = null;
                DDLCity.DataBind();
                DDLCity.Items.Insert(0, new ListItem("-- Select City--", "0"));

            }
        }
        catch (Exception ex)
        {
            // ExceptionLogging.SendExcepToDB(ex);

        }
    }


    public void Company()
    {
        try
        {
            DataSet ds = _ObjBalCompany.GetCompany();
            if (ds.Tables[0].Rows.Count > 0)
            {
                Submit_Company.Text = "Update";
                hf_CompanyId.Value = ds.Tables[0].Rows[0]["CompanyId"].ToString();
                txtCompanyName.Text = ds.Tables[0].Rows[0]["CompanyName"].ToString();

                lblLogo.Text = ds.Tables[0].Rows[0]["CompanyLogo"].ToString();
                hfImageLogo.Value = ds.Tables[0].Rows[0]["CompanylogoPath"].ToString();
                FileLogo = ds.Tables[0].Rows[0]["CompanylogoPath"].ToString();
                logoview.Attributes["href"] = "../Admin/ClientsLogo/" + FileLogo;

                //CompanyLogoUpload.HasFile = ds.Tables[0].Rows[0]["CompanyLogo"].ToString();
                txtEmailId.Text = ds.Tables[0].Rows[0]["CompanyEmail"].ToString();
                txtPhoneNo.Text = ds.Tables[0].Rows[0]["CompanyPhoneNo"].ToString();
                txtWebSite.Text = ds.Tables[0].Rows[0]["CompanyWebSite"].ToString();
                txtFaxNo.Text = ds.Tables[0].Rows[0]["CompanyFax"].ToString();
                BindCountry();
                DDLCountry.SelectedIndex = DDLCountry.Items.IndexOf(DDLCountry.Items.FindByValue(ds.Tables[0].Rows[0]["CompanyCountry"].ToString()));
                Get_State_Country();
                DDLProvince.SelectedIndex = DDLProvince.Items.IndexOf(DDLProvince.Items.FindByValue(ds.Tables[0].Rows[0]["CompanyState"].ToString()));
                Get_City_State();
                DDLCity.SelectedIndex = DDLCity.Items.IndexOf(DDLCity.Items.FindByValue(ds.Tables[0].Rows[0]["CompanyCity"].ToString()));
                BindCurrency();
                DDLCurrency.SelectedIndex = DDLCurrency.Items.IndexOf(DDLCurrency.Items.FindByValue(ds.Tables[0].Rows[0]["CompanyCurrency"].ToString()));

            }
            else
            {
                Submit_Company.Text = "Submit";
                ClearControl();
                BindCountry();
                BindCurrency();
                DesableFields();
            }


        }
        catch (Exception)
        {

            throw;
        }
    }
    public void BindCurrency()
    {
        try
        {

            DataSet ds = _BOUtility.GetCurrency();
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
    protected void DDLCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        Get_State_Country();
    }
    protected void DDLProvince_SelectedIndexChanged(object sender, EventArgs e)
    {
        Get_City_State();
    }
    protected void Submit_Company_Click(object sender, EventArgs e)
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
    private string GetFile(FileUpload FUName)
    {
        string fileName = string.Empty;
        if (FUName.HasFile)
        {
            string strPath = System.IO.Path.GetExtension(FUName.PostedFile.FileName);
            string date = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            fileName = date + strPath;
            FUName.SaveAs(Server.MapPath("~/Admin/CompanyLogos/" + fileName));
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
    protected void Cancel_Company_Click(object sender, EventArgs e)
    {
        Response.Redirect("CompanyDetails.aspx");
    }
    protected void Reset_Company_Click(object sender, EventArgs e)
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
        DDLCountry.SelectedValue = "0";
        DDLProvince.SelectedValue = "0";
        DDLCity.SelectedValue = "0";
        DDLCurrency.SelectedValue = "0";
    }

}