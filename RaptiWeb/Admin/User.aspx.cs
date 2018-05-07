using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityManager;
using BusinessManager;
using DataManager;
using System.Data;
public partial class Admin_User : System.Web.UI.Page
{
    EMUser objEMuser = new EMUser();
    BoUtility objBoutility = new BoUtility();
    BALUser objBALuser = new BALUser();
    BALGlobal objBALglobal = new BALGlobal();
    BALBranch objBALBranch = new BALBranch();

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (DDLRole.Items.Count <= 1)
                GlobalClass.getRoles(DDLRole);
            chkIsactive.Checked = true;
            BindBranches();

            if (!string.IsNullOrEmpty(Request.QueryString["UserId"]))
            {

                string userId = "0";

                if (Request.QueryString["UserId"] == null)
                {
                    userId = "0";

                }
                else
                {
                    userId = Request.QueryString["UserId"].ToString();

                }

                Submit_User.Text = "Update";
                GetUserDetails(userId);
            }
        }
    }
    private void GetUserDetails(string userId)
    {
        try
        {

            objEMuser.UserId = Convert.ToInt32(userId);
            DataSet ds = objBoutility.GetUserList(Convert.ToInt32(userId), 0, 0);
            if (ds.Tables[0].Rows.Count > 0)
            {
                hf_UserId.Value = ds.Tables[0].Rows[0]["UserId"].ToString();
                txtUserName.Text = ds.Tables[0].Rows[0]["UserName"].ToString();
                chkIsactive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["IsActive"]);
                txtuserMail.Text = ds.Tables[0].Rows[0]["UserEmail"].ToString();
                txtPhoneNo.Text = ds.Tables[0].Rows[0]["UserPhoneNo"].ToString();
                DDLBranch.SelectedIndex = DDLBranch.Items.IndexOf(DDLBranch.Items.FindByValue(ds.Tables[0].Rows[0]["BranchId"].ToString()));
                DDLRole.SelectedIndex = DDLRole.Items.IndexOf(DDLRole.Items.FindByValue(ds.Tables[0].Rows[0]["UserRole"].ToString()));
            }
        }
        catch (Exception ex)
        {
           lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }


    }
    protected void Submit_User_Click(object sender, EventArgs e)
    {
        InsertUpdateUser();
    }
    protected void Cancel_User_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserList.aspx", false);
    }
    protected void Reset_User_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
    #endregion

    #region PrivateMethods
    private void clearcontrols()
    {
        txtUserName.Text = "";
        txtuserMail.Text = "";
        txtPhoneNo.Text = "";
        DDLRole.SelectedIndex = 0;
        DDLBranch.SelectedIndex = 0;
    }
    private void BindBranches()
    {
        try
        {
            int branchId = 0;
            DataSet ds = objBALBranch.Branch_GetData(branchId);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DDLBranch.DataSource = ds.Tables[0];
                DDLBranch.DataTextField = "BranchName";
                DDLBranch.DataValueField = "BranchId";
                DDLBranch.DataBind();
                DDLBranch.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
            else
            {
                DDLBranch.DataSource = null;
                DDLBranch.DataBind();
                DDLBranch.Items.Insert(0, new ListItem("-- Please Select --", "0"));

            }
        }
        catch (Exception ex)
        {
          lblMsg.Text = objBALglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }
    private void InsertUpdateUser()
    {
        try
        {
            objEMuser.UserId = Convert.ToInt32(hf_UserId.Value);
            objEMuser.UserName = txtUserName.Text;
            objEMuser.UserPhoneNo = txtPhoneNo.Text;
            objEMuser.UserEmail = txtuserMail.Text;
            objEMuser.IsActive=Convert.ToInt32(chkIsactive.Checked);
            objEMuser.UserRole = Convert.ToInt32(DDLRole.SelectedItem.Value);
            objEMuser.BranchId = Convert.ToInt32(DDLBranch.SelectedItem.Value);
            objEMuser.CompanyId = 1;
            objEMuser.CreatedBy = 1;
            int result = objBALuser.InsUpdUser(objEMuser);
            if (result > 0)
            {
                Response.Redirect("UserList.aspx", false);
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