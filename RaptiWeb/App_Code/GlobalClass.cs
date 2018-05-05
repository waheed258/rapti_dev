using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using BusinessManager;
using System.Data;

/// <summary>
/// Summary description for GlobalClass
/// </summary>
public class GlobalClass
{
	public GlobalClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static void getRoles(DropDownList ddl_Roles)
    {
        BoUtility _objBoUtility = new BoUtility();
        ddl_Roles.Items.Clear();
        DataSet ds = _objBoUtility.GetRolesList(0, 0);
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
}