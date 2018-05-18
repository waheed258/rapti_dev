using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessManager;
using System.Data;

public partial class Admin_MenuRoleAssign : System.Web.UI.Page
{
    BOUtiltiy _objBoutility = new BOUtiltiy();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (ddlRoles.Items.Count <= 1)
            {
                getRoles(ddlRoles);
            }
            LoadConsultants();
        }
    }
    protected void ddlRoles_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindRoles(Convert.ToInt32(ddlRoles.SelectedValue.ToString()));

        if (ddlRoles.SelectedIndex > 0)
        {
            ddlConsultants.Enabled = true;
            btnAssign.Enabled = true;
        }
        else
        {
            ddlConsultants.Enabled = false;
            btnAssign.Enabled = false;
        }
    }
    protected void btnAssign_Click(object sender, EventArgs e)
    {
        if (ddlRoles.SelectedIndex > 0 && ddlConsultants.SelectedIndex > 0)
        {
            int IsSuccess = _objBoutility.ManageUserRole(Convert.ToInt32(ddlConsultants.SelectedValue.ToString()),
                                                        Convert.ToInt32(ddlRoles.SelectedValue.ToString()));
            if (IsSuccess > 0)
                lblMsg.Text = "Successfully assigned selected role to User !!";
            else
                lblMsg.Text = "Unable to assign role to User!!";
        }
    }
    protected void gvRAL_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditRecord")
        {

        }
    }
    protected void gvRAL_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label inLblUrl = (Label)e.Row.FindControl("lblUrl");
            if (inLblUrl.Text == "#" || inLblUrl.Text.ToUpper() == "INDEX.ASPX")
            {
                e.Row.BackColor = System.Drawing.Color.FromArgb(184, 203, 237);
                e.Row.Font.Bold = true;
            }
            else
            {
                //e.Row.BackColor = System.Drawing.Color.FromArgb(218, 223, 232);
                e.Row.Font.Bold = false;
            }
        }
    }
    protected void gvRAL_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvRAL.EditIndex = e.NewEditIndex;
        BindRoles(Convert.ToInt32(ddlRoles.SelectedValue.ToString()));
    }
    protected void gvRAL_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvRAL.PageIndex = e.NewPageIndex;
        BindRoles(Convert.ToInt32(ddlRoles.SelectedValue.ToString()));
    }
    protected void gvRAL_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //Entity_Evidences evid_ojb = new Entity_Evidences();
        GridViewRow row = (GridViewRow)gvRAL.Rows[e.RowIndex];
        Label hfAccessId = (Label)row.FindControl("hfMenuAccessId");
        Label hfMenuId = (Label)row.FindControl("hfMenuId");
        DropDownList ddlAccess = (DropDownList)row.FindControl("ddlMenuAccess");

        int tmpRoleId = Convert.ToInt32(ddlRoles.SelectedValue.ToString());
        if (hfAccessId.Text == "" || hfAccessId.Text == null)
            hfAccessId.Text = "0";
        int tmpMenuAccessId = Convert.ToInt32(hfAccessId.Text.ToString());
        int tmpMenuId = Convert.ToInt32(hfMenuId.Text.ToString());
        int tmpIsAccess = Convert.ToInt32(ddlAccess.SelectedValue.ToString());

        int IsSuccess = _objBoutility.MenusAccessUpdate(tmpRoleId, tmpIsAccess, tmpMenuId, tmpMenuAccessId);
        if (IsSuccess > 0)
            lblMsg.Text = "Updated Successfully !!";
        else
            lblMsg.Text = "Description was Not Updated Successfully !!";

        gvRAL.EditIndex = -1;
        BindRoles(Convert.ToInt32(ddlRoles.SelectedValue.ToString()));
    }
    protected void gvRAL_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvRAL.EditIndex = -1;
        BindRoles(Convert.ToInt32(ddlRoles.SelectedValue.ToString()));
    }
    #region Common Methods
    private void BindRoles(int RoleId)
    {
        DataSet ds = _objBoutility.GetMenusList(RoleId);
        //lblMsg.Text = null;
        try
        {
            if (RoleId > 0)
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    gvRAL.DataSource = ds.Tables[0];
                    gvRAL.DataBind();
                }
                else
                {
                    gvRAL.DataSource = null;
                    gvRAL.DataBind();
                }
            }
            else
            {
                gvRAL.DataSource = null;
                gvRAL.DataBind();
            }
        }
        catch
        {

        }
    }

    public void LoadConsultants()
    {
        DataSet ds = _objBoutility.GetUserList(0, 1, 1);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddlConsultants.Items.Clear();
            ddlConsultants.Items.Add(new ListItem("-User-", "-1"));
            ddlConsultants.DataSource = ds.Tables[0];
            ddlConsultants.DataTextField = "UserFirstName";
            ddlConsultants.DataValueField = "UserLoginId";
            ddlConsultants.DataBind();
        }
    }

    public static void getRoles(DropDownList ddl_Roles)
    {
        BOUtiltiy _objBoUtility = new BOUtiltiy();
        ddl_Roles.Items.Clear();
        DataSet ds = _objBoUtility.GetRolesList(1, 1);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddl_Roles.Items.Clear();
            ddl_Roles.Items.Add(new ListItem("-Role-", "-1"));
            ddl_Roles.DataSource = ds.Tables[0];
            ddl_Roles.DataTextField = "RoleName";
            ddl_Roles.DataValueField = "RoleId";
            ddl_Roles.DataBind();
        }



    }
    #endregion
}