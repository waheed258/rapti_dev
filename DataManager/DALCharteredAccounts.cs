using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityManager;
using System.Collections;
using System.Data;

namespace DataManager
{
    public class DALCharteredAccounts : DataUtility
    {

        public int InsUpdChartOfAccounta(EMCharteredAccounts objChartofAcc)
        {
            Hashtable htparams = new Hashtable
                                            {
                                                {"@ChartedAccId",objChartofAcc.ChartedAccId},
                                                {"@ChartedAccName",objChartofAcc.ChartedAccName},
                                                {"@ChartedMasterAccId",objChartofAcc.ChartedMasterAccId},
                                                {"@ChartofAccCode",objChartofAcc.ChartofAccCode},
                                                {"@MainAccCode",objChartofAcc.MainAccCode},
                                                {"@CategoryId",objChartofAcc.CategoryId},
                                                {"@CompanyId",objChartofAcc.CompanyId},
                                                {"@BranchId",objChartofAcc.BranchId},
                                                {"@CreatedBy",objChartofAcc.CreatedBy}
                                          
                                              
                                          };

            int IsSuccess = ExecuteNonQuery("CharteredAccounts_InsertUpdate", htparams);
            return IsSuccess;
        }

        public DataSet Get_ChartofAccData()
        {

            return ExecuteDataSet("CharteredAccounts_Get");
        }
    }
}
