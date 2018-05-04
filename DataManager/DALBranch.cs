using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityManager;
using System.Collections;
using System.Data;

namespace DataManager
{
   public class DALBranch:DataUtility
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
                                                {"@SupplierMainAcNo",objBranch.SupplierMainAcNo},
                                                {"@ClientMainAcNo",objBranch.ClientMainAcNo},
                                                {"@BranchId",objBranch.BranchId},
                                            
                                                {"@CreatedBy",objBranch.CreatedBy},
                                               
                                               
                                              
                                          };

           int IsSuccess = ExecuteNonQuery("Configuration_InsertUpdate", htparams);
           return IsSuccess;
       }

       public DataSet Get_BranchData(int BranchId)
       {
           Hashtable htparams = new Hashtable
                                            {
                                                {"@BranchId",BranchId},
                                            };
           return ExecuteDataSet("Branch_GetData",htparams);
       }

       public int DeleteBranchandConfiguration(int BranchId,int ConfigurationId)
       {
           Hashtable htparams = new Hashtable
           {
             {"@BranchId",BranchId},
             {"@ConfigurationId",ConfigurationId}
           };

           return ExecuteNonQuery("BranchandConfiguration_Delete", htparams);

       }

    }
}
