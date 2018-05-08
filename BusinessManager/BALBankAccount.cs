using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataManager;
using EntityManager;
using System.Data;

namespace BusinessManager
{
   public class BALBankAccount
    {
       DALBankAccount objDALBankAcc = new DALBankAccount();
       public int InsUpdBankAccount(EMBankAccount objEMBankAcc)
        {
            return objDALBankAcc.InsUpdBankAccount(objEMBankAcc);
        }

       public DataSet Get_BankAccountData(int BranchId, int CompanyId,int BankId)
       {
           return objDALBankAcc.Get_BankAccountData(BranchId, CompanyId, BankId);
       }

       public int Delete_BankAccountData(int BankId)
       {
           return objDALBankAcc.Delete_BankAccountData(BankId);
       }
    }
}
