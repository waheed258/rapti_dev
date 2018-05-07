using EntityManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataManager
{
    public class DALMainAccounts : DataUtility
    {
        public int InsertMainAccount(EMMainAccounts objMainAccounts)
        {
            Hashtable htParams = new Hashtable{
                                        {"@MainAccountId",objMainAccounts.MainAccountId},
                                        {"@MainAccountCode",objMainAccounts.MainAccountCode},
                                        {"@MainAccountName",objMainAccounts.MainAccountName},
                                        {"@Department",objMainAccounts.Department},
                                        {"@Branch",objMainAccounts.Branch},
                                        {"@AccountType",objMainAccounts.AccountType},
                                        {"@Category",objMainAccounts.Category},
                                        {"@Company",objMainAccounts.Company},
                                        {"@CreatedBy",objMainAccounts.CreatedBy},
           };
            int IsSuccess = ExecuteNonQuery("MainAccounts_InsertUpdate", htParams, "@return");
            return IsSuccess;
        }


        public DataSet MainAccountsList(int MainAccId)
        {
            Hashtable htparams = new Hashtable{
                {"@AccId",MainAccId}
            };

            return ExecuteDataSet("MainAccounts_List",htparams);
        }
    }
}
