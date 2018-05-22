using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityManager;
using System.Data;
using DataManager;

namespace BusinessManager
{
    public class BABranch
    {
        DABranch objDABranch = new DABranch();
        public int InsUpdBranch(EMBranch objBranch)
        {
            return objDABranch.InsUpdBranch(objBranch);
        }

        public int InsUpdConfiguration(EMBranch objBranch)
        {
            return objDABranch.InsUpdConfiguration(objBranch);
        }

        public int InsUpdClientTypeMaster(EMBranch objBranch)
        {
            return objDABranch.InsUpdClientTypeMaster(objBranch);
        }
        public DataSet Branch_GetData(int BranchId)
        {
            return objDABranch.Get_BranchData(BranchId);
        }

        public int DeleteBranchandConfiguration(int BranchId, int ConfigurationId)
        {
            return objDABranch.DeleteBranchandConfiguration(BranchId, ConfigurationId);
        }
        public int InsUpdClientTypeMaster(EMClientTypeMaster objClient)
        {
            return objDABranch.InsUpdClientTypeMaster(objClient);
        }

    }
}
