using DataManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessManager
{
    public class BACashBook
    {
        DACashBook objDACash = new DACashBook();
        public int InsUpdCashBook(EMCashBook objEMCash)
        {
            return objDACash.InsUpdCashBook(objEMCash);
        }

        public DataSet GetCashBook(int CashBookId)
        {
            return objDACash.GetCashBook(CashBookId);
        }

        public int DeleteCashBook(int CashBookId)
        {
            return objDACash.DeleteCashBook(CashBookId);
        }
    }
}
