using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityManager
{
  public class EMCharteredAccounts
    {
      public int ChartedAccId { get; set; }
      public string ChartedAccName { get; set; }
      public int ChartedMasterAccId { get; set; }
      public string ChartofAccCode { get; set; }
      public string MainAccCode { get; set; }
      public int CategoryId { get; set; }
      public int CompanyId { get; set; }
      public int BranchId { get; set; }
      public int CreatedBy { get; set; }
    }
}
