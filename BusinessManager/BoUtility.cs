using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataManager;
using System.Data;

namespace BusinessManager
{
   
   public class BoUtility
    {
       DoUtility _objDOUtility = new DoUtility();


        #region Dynamic Menus
        // added by Anitha on 25/04/2018

      //Menus
       public DataSet GetMenusByRole(int RoleId, int CompanyId)
        {
            return _objDOUtility.GetMenusByRole(RoleId, CompanyId);
        }

        #endregion

       #region Country,State,City
       public DataSet GetCountries()
       {
           return _objDOUtility.GetCountries();
       }
       public DataSet GetState(int StateId)
       {
           return _objDOUtility.GetState(StateId);
       }

       public DataSet GetCities(int Id)
       {
           return _objDOUtility.GetCities(Id);
       }

       public DataSet GetCurrency()
       {
           return _objDOUtility.GetCurrency();
       }
       public DataSet GetVatData()
       {
           return _objDOUtility.GetVatData();
       }

       #endregion

       #region UserList
       // added by Anitha on 05/02/2018

       //check in again
       public DataSet GetUserList(int userId, int CompanyId, int BranchId)
       {
           return _objDOUtility.GetUserList(userId, CompanyId, BranchId);
       }

       #endregion


       #region RolesList
       // added by Anitha on 05/02/2018

       //check in again
       public DataSet GetRolesList(int CompanyId, int BranchId)
       {
           return _objDOUtility.GetRolesList(CompanyId, BranchId);
       }

       #endregion


       #region MenusList,Menus Update
       // added by Anitha on 02/05/2018

       //check in again
       public DataSet GetMenusList(int RoleId)
       {
           return _objDOUtility.GetMenusList(RoleId);
       }

       //added by anitha on 04/05/2018
       public int MenusAccessUpdate(int RoleId, int IsAccessId, int MenuId, int MenuAccessId)
       {
           return _objDOUtility.MenuAccessUpdate(RoleId, IsAccessId, MenuId, MenuAccessId);
       }
       #endregion
       //added by anitha on 5/5/2018
       #region Assign Role to user
       public int ManageUserRole(int UserId, int RoleId)
       {
           return _objDOUtility.ManageUserRole(UserId, RoleId);
       }
       #endregion

       #region CheckAccCodes Exit or Not
       public DataSet CheckAccCode_ExistorNot(string AccountCode, string type)
       {
           return _objDOUtility.CheckAccCode_ExistorNot(AccountCode, type);
       } 
       #endregion

       #region User Login Check
       //added by anitha on 10/5/2018
       public DataSet User_Login(string UserName, string Password)
       {
           return _objDOUtility.User_Login(UserName, Password);
       }
       #endregion

    }
}
