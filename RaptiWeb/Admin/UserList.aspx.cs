using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessManager;
using DataManager;
using System.Data;
using System.Drawing;
public partial class Admin_UserList : System.Web.UI.Page
{
    BoUtility _objBoutility = new BoUtility();
    BALGlobal objbalglobal = new BALGlobal();
    BALUser objBALuser = new BALUser();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindUserData();
        }

    }

    private void BindUserData()
    {
        try
        {

            DataSet ds = _objBoutility.GetUserList(0, 0, 0);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gvUserList.DataSource = ds;
                gvUserList.DataBind();
                gvUserList.Columns[3].Visible = false;
            }
            else
            {

                gvUserList.DataSource = null;
                gvUserList.DataBind();
            }
        }
        catch (Exception ex)
        {
             lblMsg.Text = objbalglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        
        }
    }
    protected void gvUserList_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
        string UserId = commandArgs[0];



        if (e.CommandName == "Edit User")
        {

            Response.Redirect("User.aspx?UserId= " + Convert.ToInt32(UserId) , true);
        }
        else if (e.CommandName == "Delete User")
        {

            DeleteUser(Convert.ToInt32(UserId));
            BindUserData();
        }
    }
    private void DeleteUser(int UserId)
    {
        try
        {
            int Result = objBALuser.DeleteUser(UserId);
        }
        catch (Exception ex)
        {

            lblMsg.Text = objbalglobal.ShowMessage("danger", "Danger", ex.Message);
            DALGlobal.SendExcepToDB(ex);
        }
    }


    protected void gvUserList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            var ToolTipString = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "IsActive"));

            foreach (TableCell cell in e.Row.Cells)
            {
                if (ToolTipString == "0")
                {
                    // cell.BackColor = Color.Red;
                    cell.ForeColor = Color.Red;
                }
            }
        }
    }
}