using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityManager
{
    public class EMMainAccounts
    {
        public int MainAccountId { get; set; }
        public string MainAccountCode { get; set; }
        public string MainAccountName { get; set; }
        public int Department { get; set; }
        public int Branch { get; set; }
        public int AccountType { get; set; }
        public int Category { get; set; }
        public int Company { get; set; }
        public int CreatedBy { get; set; }
    }
}
