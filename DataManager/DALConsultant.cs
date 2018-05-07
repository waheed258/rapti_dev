using EntityManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataManager
{
    public class DALConsultant : DataUtility
    {
        public int InsertUpdateConsultant(EMConsultant objConsultant)
        {
            Hashtable htParams = new Hashtable{
                                        {"@ConsultantId",objConsultant.ConsultantId},
                                        {"@ConsultantIsActive",objConsultant.ConsultantIsActive},
                                        {"@ConsultantKey",objConsultant.ConsultantKey},
                                        {"@ConsultantName",objConsultant.ConsultantName},
                                        {"@ConsultantGroup",objConsultant.ConsultantGroup},
                                        {"@Division",objConsultant.Division},
                                        {"@Email",objConsultant.Email},
                                        {"@TelephoneNo",objConsultant.TelephoneNo},
                                        {"@CellNo",objConsultant.CellNo},
                                        {"@FaxNo",objConsultant.FaxNo},
                                        {"@ClientType",objConsultant.ClientType},
                                        {"@Company",objConsultant.Company},
                                        {"@Branch",objConsultant.Branch},
                                        {"@CreatedBy",objConsultant.CreatedBy},
                                         
           };
            int IsSuccess = ExecuteNonQuery("Consultant_InsertUpdate", htParams, "@return");
            return IsSuccess;
        }

        public DataSet Get_ConsultantData(int ConsultantId)
        {
            Hashtable htParams = new Hashtable{
                                        {"@ConsultantId",ConsultantId},
            };
            return ExecuteDataSet("Consultant_GetData", htParams);
        }

    }
}
