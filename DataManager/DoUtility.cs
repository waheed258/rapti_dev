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


    }
}
