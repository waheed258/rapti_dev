using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityManager;
namespace DataManager
{
    public class DABranch:DataUtilities
    {
        public int InsUpdBranch(EMBranch objBranch)
        {
            Hashtable htparams = new Hashtable
                                            {
                                                {"@BranchId",objBranch.BranchId},
                                                {"@BranchName",objBranch.BranchName},
                                                {"@BranchLogo",objBranch.BranchLogo},
                                                 {"@BranchlogoPath",objBranch.BranchLogoPath},
                                                {"@BranchPhoneNo",objBranch.BranchPhoneNo},
                                                {"@BranchAlternativeNo",objBranch.BranchAlternativeNo},
                                                {"@BranchEmail",objBranch.BranchEmail},
                                                {"@BranchPhysicalAddress",objBranch.BranchPhysicalAddress},
                                                {"@BranchPostalAddress",objBranch.BranchPostalAddress},
                                                {"@AddressFlag",objBranch.AddressFlag},
                                                {"@BranchCountry",objBranch.BranchCountry},
                                                {"@BranchState",objBranch.BranchState},
                                                {"@BranchCity",objBranch.BranchCity},
                                                {"@BranchCoRegNo",objBranch.BranchCoRegNo},
                                                {"@BranchIATARegNo",objBranch.BranchIATARegNo},
                                                {"@BranchVatRegNo",objBranch.BranchVatRegNo},
                                                {"@BranchDoCex",objBranch.BranchDoCex},
                                                {"@BranchMemberOfAsata",objBranch.BranchMemberOfAsata},
                                                {"@SupplierMainAcNo",objBranch.SupplierMainAcNo},
                                                {"@SupplMainAccountName",objBranch.SupplMainAccountName},
                                                {"@SupplAcountType",objBranch.SupplAcountType},
                                                {"@ClientMainAcNo",objBranch.ClientMainAcNo},
                                                {"@ClientMainAccountName",objBranch.ClientMainAccountName},
                                                {"@ClientAcountType",objBranch.ClientAcountType},
                                                {"@CompanyId",objBranch.CompanyId},
                                                {"@CreatedBy",objBranch.CreatedBy},
                                                {"@BranchCurrency",objBranch.BranchCurrency},
                                                {"@BranchIsActive",objBranch.BranchIsActive},
                                                {"@BranchCode",objBranch.BranchCode},
                                               
                                              
                                          };

            int IsSuccess = ExecuteNonQuery("Branch_InsertUpdate", htparams, "@return");
            return IsSuccess;
        }

        public int InsUpdConfiguration(EMBranch objBranch)
        {
            Hashtable htparams = new Hashtable
                                            {
                                                {"@ConfigurationId",objBranch.ConfigurationId},
                                                {"@VatPercentage",objBranch.VatPercentage},
                                                {"@InvStartNo",objBranch.InvStartNo},
                                                {"@CreditNoteStartNo",objBranch.CreditNoteStartNo},
                                                {"@ZeroCommForSuppliers",objBranch.ZeroCommForSuppliers},
                                                {"@ConvertProInvToInv",objBranch.ConvertProInvToInv},
                                                {"@ServiceFeeMerge",objBranch.ServiceFeeMerge},
                                                {"@IsSerFeeAddToAirportTax",objBranch.IsSerFeeAddToAirportTax},
                                                {"@IsSerFeeMergePaymentMatch",objBranch.IsSerFeeMergePaymentMatch},
                                                {"@PreFixDebtors",objBranch.PreFixDebtors},
                                                {"@PreFixCorporates",objBranch.PreFixCorporates},
                                                {"@PreFixLiesures",objBranch.PreFixLiesures},
                                                {"@RoundingDecimal",objBranch.RoundingDecimal},
                                            
                                                {"@BranchId",objBranch.BranchId},
                                            
                                                {"@CreatedBy",objBranch.CreatedBy},
                                               
                                               
                                              
                                          };

            int IsSuccess = ExecuteNonQuery("Configuration_InsertUpdate", htparams);
            return IsSuccess;
        }

        public int InsUpdClientTypeMaster(EMBranch objBranch)
        {
            Hashtable htparams = new Hashtable
                                            {
                                                {"@ClientTypeId",objBranch.ClientTypeId},
                                                {"@Name",objBranch.Name},
                                                {"@Code",objBranch.Code},
                                                {"@BranchId",objBranch.BranchId},
                                                  {"@CompanyId",objBranch.CompanyId},
                                                {"@CreatedBy",objBranch.CreatedBy},
                                            };
            return ExecuteNonQuery("ClienttypeMaster_InsertUpdate", htparams);
        }
        public DataSet Get_BranchData(int BranchId)
        {
            Hashtable htparams = new Hashtable
                                            {
                                                {"@BranchId",BranchId},
                                            };
            return ExecuteDataSet("Branch_Get", htparams);
        }

        public int DeleteBranchandConfiguration(int BranchId, int ConfigurationId)
        {
            Hashtable htparams = new Hashtable
           {
             {"@BranchId",BranchId},
             {"@ConfigurationId",ConfigurationId}
           };

            return ExecuteNonQuery("BranchandConfiguration_Delete", htparams);

        }

        public int InsUpdClientTypeMaster(EMClientTypeMaster objClient)
        {
            Hashtable htparams = new Hashtable
                                            {
                                                {"@ClientTypeId",objClient.ClientTypeId},
                                                {"@Name",objClient.Name},
                                                {"@Code",objClient.Code},
                                                 {"@CompanyId",objClient.CompanyId},
                                                {"@BranchId",objClient.BranchId},
                                                {"@CreatedBy",objClient.CreatedBy},
                                               
                                            };
            int IsSuccess = ExecuteNonQuery("ClienttypeMaster_InsertUpdate", htparams);
            return IsSuccess;
        }


    }
}
