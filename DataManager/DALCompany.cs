using EntityManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class DALCompany : DataUtilities
    {
        public int InsUpdCompany(EMCompany objCompany)
        {
            Hashtable htParams = new Hashtable{
                                        {"@CompanyId",objCompany.CompanyId},
                                        {"@CompanyName",objCompany.CompanyName},
                                        {"@CompanyLogo",objCompany.CompanyLogo},
                                        {"@CompanyEmail",objCompany.CompanyEmail},
                                        {"@CompanyPhoneNo",objCompany.CompanyPhoneNo},
                                        {"@CompanyWebSite",objCompany.CompanyWebSite},
                                        {"@CompanyFax",objCompany.CompanyFax},
                                        {"@CompanyCountry",objCompany.CompanyCountry},
                                        {"@CompanyState",objCompany.CompanyState},
                                        {"@CompanyCity",objCompany.CompanyCity},
                                        {"@CompanyCurrency",objCompany.CompanyCurrency},
                                        {"@CreatedBy",objCompany.CreatedBy},
                                        {"@CompanylogoPath",objCompany.CompanylogoPath},
                                        
           };
            int IsSuccess = ExecuteNonQuery("Company_InsertUpdate", htParams, "@return");
            return IsSuccess;
        }

        public DataSet GetCompany(int CompanyId)
        {
            Hashtable htParams = new Hashtable{
                                        {"@CompanyId",CompanyId},
            };
            return ExecuteDataSet("CompanyMaster_Get", htParams);
        }

    }
}
