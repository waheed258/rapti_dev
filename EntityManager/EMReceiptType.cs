using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityManager
{
    public class EMReceiptType
    {
        public int ReceiptTypeId { get; set; }
        public string ReceiptTypeKey { get; set; }
        public int ReceiptTypeIsActive { get; set; }
        public string ReceiptTypeDescription { get; set; }
        public int DepositListMethod { get; set; }
        public int BankAccount { get; set; }
        public int CreditCardType { get; set; }
        public int SetasDefault { get; set; }
        public int Branch { get; set; }
        public int Company { get; set; }
        public int CreatedBy { get; set; }
    }
}
