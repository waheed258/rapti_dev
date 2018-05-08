using EntityManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataManager
{
    public class DALReceiptType : DataUtility
    {
        public int InsertUpdateReceiptType(EMReceiptType objReceiptType)
        {
            Hashtable htParams = new Hashtable{
                                        {"@ReceiptTypeId",objReceiptType.ReceiptTypeId},
                                        {"@ReceiptTypeKey",objReceiptType.ReceiptTypeKey},
                                        {"@ReceiptTypeIsActive",objReceiptType.ReceiptTypeIsActive},
                                        {"@ReceiptTypeDescription",objReceiptType.ReceiptTypeDescription},
                                        {"@DepositListMethod",objReceiptType.DepositListMethod},
                                        {"@BankAccount",objReceiptType.BankAccount},
                                        {"@CreditCardType",objReceiptType.CreditCardType},
                                        {"@SetasDefault",objReceiptType.SetasDefault},
                                        {"@Branch",objReceiptType.Branch},
                                        {"@Company",objReceiptType.Company},
                                        {"@CreatedBy",objReceiptType.CreatedBy},
                                         
           };
            int IsSuccess = ExecuteNonQuery("ReceiptType_InsertUpdate", htParams, "@return");
            return IsSuccess;
        }

        public DataSet Get_ReceiptData(int ReceiptTypeId)
        {
            Hashtable htParams = new Hashtable{
                                        {"@ReceiptTypeId",ReceiptTypeId},
            };
            return ExecuteDataSet("ReceiptType_GetData", htParams);
        }

        public int DeleteReceiptTypeData(int ReceiptTypeId)
        {
            Hashtable htparams = new Hashtable
                                        {
                                             {"@ReceiptTypeId",ReceiptTypeId}
                                        };
            return ExecuteNonQuery("Delete_ReceiptType", htparams);
        }

    }
}
