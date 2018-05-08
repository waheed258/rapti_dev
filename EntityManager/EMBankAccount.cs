using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityManager
{
   public class EMBankAccount
    {
       public int BankId { get; set; }
       public string BankKey { get; set; }
       public string AccountName { get; set; }
       public string AccountType { get; set; }
       public string AccountNo { get; set; }
       public string BranchCode { get; set; }
       public string BranchName { get; set; }
       public string AccountHolder { get; set; }
       public string Graphic { get; set; }
       public int OwnerBranch { get; set; }
       public string QuickGiCode { get; set; }
       public string QuickGiDepositsBatch { get; set; }
       public string QuickPaymentBatch { get; set; }
       public int DeActivate { get; set; }
       public int CompanyId { get; set; }
       public int CreatedBy { get; set; }
    }
}
