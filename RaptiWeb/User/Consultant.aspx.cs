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

public partial class User_Consultant : System.Web.UI.Page
{
    EMConsultant _ObjEMConsultant = new EMConsultant();
    DALConsultant _ObjDALConsultant = new DALConsultant();
    BALConsultant _ObjBALConsultants = new BALConsultant();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            IsActive.Checked = true;

            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                string getId = Convert.ToString(Request.QueryString["Id"]);
                int Id = Convert.ToInt32(getId);
                Company(Id);
            }
        }
    }
    private void InsertUpdateConsultant()
    {
        _ObjEMConsultant.ConsultantId = Convert.ToInt32(hf_ConsultantId.Value);
        _ObjEMConsultant.ConsultantKey = txtConsultantKey.Text;
        _ObjEMConsultant.ConsultantName = txtConsultantName.Text;
        _ObjEMConsultant.ConsultantGroup = Convert.ToInt32(DDLGroup.SelectedValue);
        _ObjEMConsultant.Division = Convert.ToInt32(DDLDivision.SelectedValue);
        _ObjEMConsultant.Email = txtEmail.Text;
        _ObjEMConsultant.TelephoneNo = txtTelephoneNo.Text;
        _ObjEMConsultant.CellNo = txtCellNo.Text;
        _ObjEMConsultant.FaxNo = txtFaxNo.Text;
        _ObjEMConsultant.ClientType = Convert.ToInt32(DDLClientType.SelectedValue);


        int Result = _ObjDALConsultant.InsertUpdateConsultant(_ObjEMConsultant);

        if (Result > 0)
        {
            // lblMsg.Text = _BOUtility.ShowMessage("success", "Success", "Air Suppliers Created Successfully.");
            Response.Redirect("ConsultantsList.aspx", false);
        }
        else
        {
            // lblMsg.Text = _BOUtility.ShowMessage("info", "Info", "Airsuppliers was not created please try again");
        }
    }
    protected void Consultant_Submit_Click(object sender, EventArgs e)
    {
        InsertUpdateConsultant();
    }


    public void Company(int ConsultantId)
    {
        try
        {
            _ObjEMConsultant.ConsultantId = ConsultantId;
            DataSet ds = _ObjBALConsultants.GetConsultant(ConsultantId);
            if (ds.Tables[0].Rows.Count > 0)
            {

                hf_ConsultantId.Value = ds.Tables[0].Rows[0]["ConsultantId"].ToString();
                txtConsultantKey.Text = ds.Tables[0].Rows[0]["ConsultantKey"].ToString();

                txtConsultantName.Text = ds.Tables[0].Rows[0]["ConsultantName"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                txtTelephoneNo.Text = ds.Tables[0].Rows[0]["TelephoneNo"].ToString();
                txtCellNo.Text = ds.Tables[0].Rows[0]["CellNo"].ToString();
                txtFaxNo.Text = ds.Tables[0].Rows[0]["FaxNo"].ToString();
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
}