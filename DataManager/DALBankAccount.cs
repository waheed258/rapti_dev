using EntityManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataManager
{
  public  class DALBankAccount:DataUtility
    {
      public int InsUpdBankAccount(EMBankAccount objBankAcc)
      {
          Hashtable htparams = new Hashtable
                                            {
                                                {"@BankId",objBankAcc.BankId},
                                                {"@BankKey",objBankAcc.BankKey},
                                                {"@AccountName",objBankAcc.AccountName},
                                                {"@AccountType",objBankAcc.AccountType},
                                                {"@AccountNo",objBankAcc.AccountNo},
                                                {"@BranchCode",objBankAcc.BranchCode},
                                                {"@BranchName",objBankAcc.BranchName},
                                                {"@AccountHolder",objBankAcc.AccountHolder},
                                                {"@Graphic",objBankAcc.Graphic},
                                                {"@OwnerBranch",objBankAcc.OwnerBranch},
                                                {"@QuickGiCode",objBankAcc.QuickGiCode},
                                                {"@QuickGiDepositsBatch",objBankAcc.QuickGiDepositsBatch},
                                                {"@QuickPaymentBatch",objBankAcc.QuickPaymentBatch},
                                                {"@CreatedBy",objBankAcc.CreatedBy},
                                                {"@CompanyId",objBankAcc.CompanyId}
                                              
                                          };

          int IsSuccess = ExecuteNonQuery("BankAccountMaster_InserUpdate", htparams);
          return IsSuccess;
      }
   
  
        public DataSet Get_BankAccountData(int BranchId,int CompanyId,int BankId)
        {
            Hashtable htparams = new Hashtable
                                            {
                                                {"@BranchId",BranchId},
                                                {"@CompanyId",CompanyId},
                                                 {"@BankId",BankId}
                                            };
            return ExecuteDataSet("BankAccountMaster_Get",htparams);
        }

        public int Delete_BankAccountData(int BankId)
        {
            Hashtable htparams = new Hashtable
                                            {                                          
                                                {"@BankId",BankId}
                                            };
            int IsSuccess = ExecuteNonQuery("BankAccountMaster_Delete", htparams);
            return IsSuccess;
        }
  }

     
}
