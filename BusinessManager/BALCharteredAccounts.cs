using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataManager;
using EntityManager;
using System.Data;

namespace BusinessManager
{
    
   public class BALCharteredAccounts
    {
       DALCharteredAccounts objDALChartofAcc = new DALCharteredAccounts();
       public int InsUpdChartOfAccounta(EMCharteredAccounts objChartofAcc)
       {
           return objDALChartofAcc.InsUpdChartOfAccounta(objChartofAcc);
       }
       public DataSet Get_ChartofAccData()
       {
           return objDALChartofAcc.Get_ChartofAccData();
       }

    }
}
