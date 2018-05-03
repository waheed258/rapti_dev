using EntityManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataManager
{
    public class DALCompany : DataUtility
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
            return ExecuteNonQuery("Company_InsertUpdate", htParams, "@return");
        }

        public DataSet GetCompany()
        {
            return ExecuteDataSet("CompanyMaster_Get");
        }
    }
}
