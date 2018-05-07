using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityManager
{
   public class EMUser
    {
       public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNo { get; set; }
        public int UserRole { get; set; }
        public int IsActive { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int CreatedBy { get; set; }
    }
}
