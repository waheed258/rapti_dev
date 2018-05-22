using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityManager
{
    public class EMBranch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchLogo { get; set; }
        public string BranchLogoPath { get; set; }
        public string BranchPhoneNo { get; set; }
        public string BranchAlternativeNo { get; set; }
        public string BranchEmail { get; set; }
        public string BranchPhysicalAddress { get; set; }
        public string BranchPostalAddress { get; set; }
        public int BranchCountry { get; set; }
        public int BranchState { get; set; }
        public int BranchCity { get; set; }
        public int AddressFlag { get; set; }
        public string BranchCoRegNo { get; set; }
        public string BranchIATARegNo { get; set; }
        public string BranchVatRegNo { get; set; }
        public string BranchDoCex { get; set; }
        public int BranchMemberOfAsata { get; set; }
        public int CompanyId { get; set; }
        public int BranchCurrency { get; set; }
        public int BranchIsActive { get; set; }
        public string BranchCode { get; set; }
        public int CreatedBy { get; set; }

        ///    Configuration Table

        public int ConfigurationId { get; set; }
        public decimal VatPercentage { get; set; }
        public int InvStartNo { get; set; }
        public int CreditNoteStartNo { get; set; }
        public int ZeroCommForSuppliers { get; set; }
        public int ConvertProInvToInv { get; set; }
        public int ServiceFeeMerge { get; set; }
        public int IsSerFeeAddToAirportTax { get; set; }
        public int IsSerFeeMergePaymentMatch { get; set; }
        public string PreFixDebtors { get; set; }
        public string PreFixCorporates { get; set; }
        public string PreFixLiesures { get; set; }
        public string RoundingDecimal { get; set; }
        public string SupplierMainAcNo { get; set; }
        public string SupplMainAccountName { get; set; }
        public string ClientMainAccountName { get; set; }
        public string ClientMainAcNo { get; set; }
        public int ClientAcountType { get; set; }
        public int SupplAcountType { get; set; }

        //ClientType Master

        public int ClientTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class EMClientTypeMaster
    {
        public int ClientTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int CreatedBy { get; set; }
    }
}
