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
    }
}
