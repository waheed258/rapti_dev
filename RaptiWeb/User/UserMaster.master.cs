using BusinessManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_UserMaster : System.Web.UI.MasterPage
{
    BoUtility _objBOUtiltiy = new BoUtility();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetMenu();
        }
    }

    private void GetMenu()
    {
        string strMenu = string.Empty;
        // int RoleId = Convert.ToInt32(Session["role_id"]);
        int companyId = 1;
        int RoleId = 1;

        DataSet objdsmenu = _objBOUtiltiy.GetMenusByRole(RoleId, companyId);
        if (objdsmenu.Tables[0].Rows.Count > 0)
        {
            strMenu = " <a href='#' class='visible-phone'><i class='fa fa-home'></i> Dashboard</a><ul class='sidebar-menu' id='nav-accordion'>";

            foreach (DataRow mainItem in objdsmenu.Tables[0].Rows)
            {
                if (mainItem["MenuName"].ToString() == "Dashboard")
                {
                    //strMenu += "<li class='sub-menu'> <a href=" + mainItem["Url"].ToString() + "> <i class='icon icon-home'> </i><span>" + mainItem["MenuName"].ToString() + " </span></a>";
                    strMenu += "<li class=' sub-menu'><a href=" + mainItem["Url"].ToString() + "><i class='fa fa-home'></i>" + mainItem["MenuName"].ToString() + "</a>";
                }
                else
                {
                   // strMenu += "<li class='submenu'><a href=''>" + mainItem["MenuIcon"].ToString() + " <i class='fa fa-angle-right pull-right'> </i> <span>" + mainItem["MenuName"].ToString() + "</span></a>";
                    strMenu += "<li class=' submenu'><a href='#'>" + mainItem["MenuIcon"].ToString() + mainItem["MenuName"].ToString() + "</a>";
                }
                DataRow[] lstSubMenu;
                lstSubMenu = objdsmenu.Tables[1].Select("ParentMenuId='" + mainItem["MenuId"] + "'");

                if (lstSubMenu.Length > 0)
                {

                    strMenu += "<ul class='sub'>";
                    foreach (var subMenuItem in lstSubMenu)
                    {

                       // strMenu += "<li ><a href=" + subMenuItem["Url"].ToString() + "><span>" + subMenuItem["MenuName"].ToString() + "</span></a></li>";
                        strMenu += "<li><a href=" + subMenuItem["Url"].ToString() + ">" + subMenuItem["MenuName"].ToString() + "</a></li>";
                    }
                    strMenu += "</ul>";
                }
                strMenu += "</li>";
            }
            strMenu += "</ul>";
        }
        sidebar.InnerHtml = strMenu;
    }
}
//fa fa-angle-right pull-right