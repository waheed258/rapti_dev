using DataManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessManager
{
    public class BALMainAccounts
    {
        private DALMainAccounts _objDALMainAccount = new DALMainAccounts();
        public int InsertMainAaccounts(EMMainAccounts objEMMainAccount)
        {
            return _objDALMainAccount.InsertMainAccount(objEMMainAccount);
        }
        public DataSet MainAccountsList()
        {
            return _objDALMainAccount.MainAccountsList();
        }
    }
}
