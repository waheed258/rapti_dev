using DataManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessManager
{
   public class BALReceiptType
    {
        private DALReceiptType _ObjDALReceiptType = new DALReceiptType();

        public int InsertUpdateReceiptType(EMReceiptType objEMReceipt)
        {
            return _ObjDALReceiptType.InsertUpdateReceiptType(objEMReceipt);
        }
        public DataSet GetReceiptType(int ReceiptId)
        {
            return _ObjDALReceiptType.Get_ReceiptData(ReceiptId);
        }
        public int DeleteReceiptType(int ReceiptId)
        {
            return _ObjDALReceiptType.DeleteReceiptTypeData(ReceiptId);
        }

        //DeleteReceiptType
    }
}
