using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataManager
{
    public class DoUtility : DataUtility
    {
        #region DynamicMenuData
        // added by Anitha on 25/04/2018
        public DataSet GetMenusByRole(int RoleId, int CompanyId)
        {
            Hashtable htParams = new Hashtable
                                     {
                                          
                                         {"@inRoleId",RoleId},
                                         {"@inCompanyId",CompanyId},
                                         // {"@BranchId",BranchId}
                                     };
            return ExecuteDataSet("menuaccess_by_role", htParams);
        }
        #endregion

        #region Country,State,City,Currency,Vat Type
        public DataSet GetCountries()
        {
            return ExecuteDataSet("CountriesMaster_Get");
        }

        public DataSet GetState(int StateId)
        {
            Hashtable htparams = new Hashtable
           {
             {"@countryId",StateId}
           };

            return ExecuteDataSet("StatesMaster_Get", htparams);

        }
        public DataSet GetCities(int Id)
        {
            Hashtable htparams = new Hashtable{
                                            {"@StateId",Id},
            };
            return ExecuteDataSet("CitiesMaster_Get", htparams);
        }
        public DataSet GetCurrency()
        {
            return ExecuteDataSet("CurrencyMaster_Get");
        }

        public DataSet GetVatData()
        {
            return ExecuteDataSet("Vat_GetData");
        }

        #endregion

        #region UserList
        // added by Anitha on 02/05/2018
        public DataSet GetUserList(int UserId, int CompanyId, int BranchId)
        {
            Hashtable htParams = new Hashtable
                                            {
                                                {"inUserId",UserId},
                                                {"@inCompanyId",CompanyId},
                                                 {"@inBranchId",BranchId}
                                                 
                                            };
            return ExecuteDataSet("UserMaster_Get", htParams);
        }
        #endregion

        #region RolesList
        // added by Anitha on 02/05/2018
        public DataSet GetRolesList(int CompanyId, int BranchId)
        {
            Hashtable htParams = new Hashtable
                                            {
                                               
                                                {"@inCompanyId",CompanyId},
                                                 {"@inBranchId",BranchId}
                                                 
                                            };
            return ExecuteDataSet("RolesMaster_Get", htParams);
        }
        #endregion

        #region MenusList and Update Menus As per Role
        // added by Anitha on 02/05/2018
        public DataSet GetMenusList(int RoleId)
        {
            Hashtable htParams = new Hashtable
                                            {
                                               
                                                {"@inRoleId",RoleId}
                                                
                                                 
                                            };
            return ExecuteDataSet("MenuAccess_Get", htParams);
        }
        public int MenuAccessUpdate(int RoleId, int isAccessId, int MenuId, int MenuAccessId)
        {
            Hashtable htParams = new Hashtable
                                            {
                                               
                                                 {"@inRoleId",RoleId},
                                                 {"@inIsAccessId",isAccessId},
                                                 {"@inMenuId",MenuId},
                                                 {"@inMenuAccessId",MenuAccessId}
                                                
                                                 
                                            };
            return ExecuteNonQuery("MenuAccess_Update", htParams);
        }
        #endregion

        #region Assign Role to user
        //added by anitha on 05/05/2018
        public int ManageUserRole(int UserId, int RoleId)
        {
            Hashtable htParams = new Hashtable
                                     {
                                         {"@UserId",UserId},
                                         {"@RoleId",RoleId},
                                          
                                     };
            return ExecuteNonQuery("UserMaster_Assign_Role", htParams);
        }
        #endregion

        #region CheckAccCodes Exit or Not
        //added by mounika on 07/05/2018
        public DataSet CheckAccCode_ExistorNot(string AccountCode, string type)
        {
            Hashtable htparams = new Hashtable
           {
             {"@AccountCode",AccountCode},
              {"@Type",type}
           };

            return ExecuteDataSet("AccCode_ExistorNot", htparams);

        }
        
        #endregion

    }
}
