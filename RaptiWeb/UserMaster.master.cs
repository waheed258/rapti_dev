using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessManager;

public partial class User_UserMaster : System.Web.UI.MasterPage
{

    BoUtility _objBOUtiltiy = new BoUtility();
    protected void Page_Load(object sender, EventArgs e)
    {
       if(!IsPostBack)
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
            strMenu = "<ul class='nav' ui-nav>";

            foreach (DataRow mainItem in objdsmenu.Tables[0].Rows)
            {
                if (mainItem["MenuName"].ToString() == "Dashboard")
                {
                    strMenu += "<li class='active'> <a href=" + mainItem["Url"].ToString() + "> <i class='fa fa-home'> </i><span>" + mainItem["MenuName"].ToString()+ " </span></a>";
                     
                }
                else
                {
                    strMenu += "<li><a href='#'>" + mainItem["MenuIcon"].ToString() +"<span>" + mainItem["MenuName"].ToString() + "</span></a>";
                }
                DataRow[] lstSubMenu;
                lstSubMenu = objdsmenu.Tables[1].Select("ParentMenuId='" + mainItem["MenuId"] + "'");

                if (lstSubMenu.Length > 0)
                {

                    strMenu += "<ul class='nav nav-sub'>";
                    foreach (var subMenuItem in lstSubMenu)
                    {
                       
                        strMenu += "<li class='nav-sub-header'><a href=" + subMenuItem["Url"].ToString() + "><span>" + subMenuItem["MenuName"].ToString() + "</span></a></li>";
                    }
                    strMenu += "</ul>";
                }
                strMenu += "</li>";
            }
            strMenu += "</ul>";
        }
        aside.InnerHtml = strMenu;
    }
}
