using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataManager;
using EntityManager;
using System.Data;

namespace BusinessManager
{
   public class BALBranch
   {
       DALBranch objDALBranch = new DALBranch();
       public int InsUpdBranch(EMBranch objBranch)
       {
           return objDALBranch.InsUpdBranch(objBranch);
       }

       public int InsUpdConfiguration(EMBranch objBranch)
       {
           return objDALBranch.InsUpdConfiguration(objBranch);
       }

       public DataSet Branch_GetData(int BranchId)
       {
           return objDALBranch.Get_BranchData(BranchId);
       }
    }
}
