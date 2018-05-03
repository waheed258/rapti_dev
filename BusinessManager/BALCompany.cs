using DataManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessManager
{
    public class BALCompany
    {
        private DALCompany _objDALCompany = new DALCompany();
        public int InsUpdCompany(EMCompany objEMCompany)
        {
            return _objDALCompany.InsUpdCompany(objEMCompany);
        }

        public DataSet GetCompany()
        {
            return _objDALCompany.GetCompany();
        }
    }
}
