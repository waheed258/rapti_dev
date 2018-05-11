using EntityManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataManager
{
    public class DACashBook : DataUtility
    {
        public int InsUpdCashBook(EMCashBook objEMCash)
        {
            Hashtable htparams = new Hashtable{
                                            {"@CashBookId",objEMCash.CashBookId},
                                            {"@CashBookKey",objEMCash.CashBookKey},
                                            {"@CashDescription",objEMCash.CashDescription},
                                            {"@Deactivate",objEMCash.Deactivate},
                                            {"@DefaultAction",objEMCash.DefaultAction},
                                            {"@GICode",objEMCash.GICode},
                                            {"@ReferenceFormat",objEMCash.ReferenceFormat},
                                            {"@VatCodes",objEMCash.VatCodes},
                                            {"@CreatedBy",objEMCash.CreatedBy},
                                             {"@CompanyId",objEMCash.CompanyId},
                                            {"@BranchId",objEMCash.BranchId},
            };
            return ExecuteNonQuery("CashBookTypes_InsertUpdate", htparams);
        }

        public DataSet GetCashBook(int CashBookId)
        {
            Hashtable htparams = new Hashtable{
                                            {"@CashBookId",CashBookId},
            };
            return ExecuteDataSet("CashBookTypes_Get", htparams);
        }

        public int DeleteCashBook(int CashBookId)
        {
            Hashtable htparams = new Hashtable{
                                            {"@CashBookId",CashBookId},
            };
            return ExecuteNonQuery("CashBookTypes_Delete", htparams);
        }
    }
}
