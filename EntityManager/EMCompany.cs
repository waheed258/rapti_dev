using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityManager
{
    public class EMCompany
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhoneNo { get; set; }
        public string CompanyWebSite { get; set; }
        public string CompanyFax { get; set; }
        public int CompanyCountry { get; set; }
        public int CompanyState { get; set; }
        public int CompanyCity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int CompanyCurrency { get; set; }
        public string CompanylogoPath { get; set; }

    }
}
