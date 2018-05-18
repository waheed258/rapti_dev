﻿using System;
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
    public class DOUtility : DataUtilities
    {
        public DataSet GetMenus(string RoleId, int CompanyId)
        {
            Hashtable htParams = new Hashtable
                                     {
                                          
                                         {"@id_role",RoleId},
                                         {"@CompanyId",CompanyId}
                                     };
            return ExecuteDataSet("get_menu_byrole", htParams);
        }

        public DataSet BindGenVATPer()
        {

            return ExecuteDataSet("Vat_GetData");
        }
        public DataSet BindPaymentType(int paymentId)
        {
            Hashtable htParams = new Hashtable
                                     {
                                          
                                         {"@PaymentId",paymentId},
                                        
                                     };
            return ExecuteDataSet("PaymentTypes_Get", htParams);
        }
        public DataSet BindCreditCardType()
        {

            return ExecuteDataSet("CreditCardTypeMaster_GetData");
        }

        public DataSet GetErrorList()
        {
            return ExecuteDataSet("ErrorsList");

        }
        public DataSet get_Type()
        {
            return ExecuteDataSet("[Type_Get]");
        }

        public DataSet getVatByType()
        {

            return ExecuteDataSet("get_VatRateByType");
        }


        //Divya 
        public DataSet getStates()
        {
            return ExecuteDataSet("StatesMaster_Get");
        }

        public DataSet getCities()
        {
            return ExecuteDataSet("CitiesMaster_Get");
        }

        public DataSet getStatus()
        {
            return ExecuteDataSet("StatusMaster_Get");
        }
        public DataSet get_City_State(int state_id)
        {
            Hashtable htparams = new Hashtable
                                   {
                                       {"@state_id",state_id}
                                   };
            return ExecuteDataSet("Get_City_State", htparams);
        }
        public DataSet getGraphics()
        {
            return ExecuteDataSet("GraphicsMaster_Get");
        }

        public DataSet GetNotepadType()
        {
            return ExecuteDataSet("Notepads_GetData");
        }
        public DataSet GetConsultant(int consultantid)
        {
            Hashtable htparams = new Hashtable
                                   {
                                       {"@ConsultantId",consultantid}
                                   };
            return ExecuteDataSet("Consultant_Get", htparams);
        }
        public DataSet GetBookingSource()
        {

            return ExecuteDataSet("BookingSource_Get");
        }
        public DataSet GetBookingDestination()
        {

            return ExecuteDataSet("BookingDestination_Get");
        }
        public DataSet GetServiceTypeByType(string Type)
        {

            Hashtable htparams = new Hashtable
                                   {
                                       {"@Type",Type}
                                   };
            return ExecuteDataSet("ServiceType_GetDataByType", htparams);
        }
        public DataSet GetClienttype()
        {
            return ExecuteDataSet("ClienttypeMaster_Get");
        }


        public DataSet InvoiceDdlBinding(int clientTypeId)
        {

            Hashtable htparams = new Hashtable
                                   {
                                       {"@ClientTypeId",clientTypeId}
                                   };

            return ExecuteDataSet("Invoice_ddlBinding", htparams);
        }


        //public DataSet GetGroup()
        //{
        //    return ExecuteDataSet("GroupMaster_Get");
        //}
        public DataSet GetDivisions()
        {

            return ExecuteDataSet("DivisionsMaster_Get");
        }

        public DataSet get_City_Country(int Id)
        {
            Hashtable htparams = new Hashtable
                                   {
                                       {"@Id",Id}
                                   };
            return ExecuteDataSet("Get_City_Country", htparams);
        }

        public DataSet BindAirServiceTypes()
        {
            return ExecuteDataSet("ServiceType_GetAirData");
        }

        public DataSet BindLandServiceTypes()
        {
            return ExecuteDataSet("ServiceType_GetLandData");
        }

        public DataSet GetConsultants()
        {
            return ExecuteDataSet("Consultant_GetData");
        }
        //General receipts Accounts
        public DataSet GetGeneralReceiptAccounts()
        {
            return ExecuteDataSet("GRAccounts_Get");
        }

        public DataSet GetBankNames()
        {
            return ExecuteDataSet("banks_GetData");
        }

        public DataSet GetAccountTypes()
        {
            return ExecuteDataSet("AccountTypes_Get");
        }

        public DataSet GetCommissionTypes()
        {
            return ExecuteDataSet("commisiontypes_GetData");
        }


        //Payment Type

        public DataSet GetAccountTypeOfSuppl()
        {
            return ExecuteDataSet("Get_PaymentUserType");
        }

        public DataSet GetAccNoofClientandSuppl(int AccType,string categoryName)
        {
            Hashtable htparams = new Hashtable
                                   {
                                       {"@CategoryId",AccType},
                                       {"@categoryName",categoryName}
                                   };
            return ExecuteDataSet("Supplier_PaymentUserAccName", htparams);
        }
        public DataSet getCountries()
        {
            return ExecuteDataSet("Countries_GetData");
        }

        public DataSet get_State_Country(int Id)
        {
            Hashtable htparams = new Hashtable
                                   {
                                       {"@Id",Id}
                                   };
            return ExecuteDataSet("Get_State_Country", htparams);
        }

        public DataSet GetSupplierInvoice()
        {
            return ExecuteDataSet("Suppliervatinvoice_GetData");
        }

        public DataSet GetDepListMethods()
        {
            return ExecuteDataSet("DepListMethods_Get");
        }

        public DataSet GetItemLoadingType()
        {
            return ExecuteDataSet("Openitemloadings_GetData");
        }

        public DataSet GetTransactionAction()
        {
            return ExecuteDataSet("TransactionAction_Getdata");
        }
     
        public DataSet GetStatement()
        {
            return ExecuteDataSet("ClientStatementMaster_Get");
        }

        public DataSet GetCreditTerms()
        {
            return ExecuteDataSet("CreditTermMaster_GetData");
        }

        public DataSet GetLimitTerms()
        {
            return ExecuteDataSet("LimitTermsMaster_GetData");
        }

        public DataSet GetDepartment()
        {
            return ExecuteDataSet("DepartmentMaster_GetData");
        }
        public DataSet GetCalCulAir()
        {
            return ExecuteDataSet("CalculAirMaster_GetData");
        }

        public DataSet GetCalCulLand()
        {
            return ExecuteDataSet("CalculLandMaster_GetData");
        }

      
        public DataSet GetImportedTicket()
        {
            return ExecuteDataSet("CCImportTicketMaster_GetData");
        }

        public DataSet GetDirectSettleTrans()
        {
            return ExecuteDataSet("DirSettleTransMaster_GetData");
        }

        public DataSet GetClientActions()
        {
            return ExecuteDataSet("ClientActionsMaster_GetData");
        }

        public DataSet getType()
        {
            return ExecuteDataSet("TypesMaster_Get");
        }

        public DataSet GetGroup(string Type)
        {
            Hashtable htparams = new Hashtable{
                                                 {"@Type",Type}
            };

            return ExecuteDataSet("GroupTypes_GetData", htparams);
        }
        public DataSet GetReceiptTypes( int RecieptId)
        {
            Hashtable htparams = new Hashtable{
                                                 {"@ReceiptId",RecieptId}
            };
            return ExecuteDataSet("ReceiptType_Get",htparams);
        }

        public DataSet GetBankAccounts(int bankId)
        {
            Hashtable htparams = new Hashtable{
                                                 {"@BankAcId",bankId}
            };

            return ExecuteDataSet("BankAccounts_Get", htparams);
        }

        /// <summary>
        /// for Main Account and ChartedAccounts
        /// </summary>
        public DataSet BindDepartments()
        {

            return ExecuteDataSet("DepartmentMaster_GetData");
        }

        public DataSet BindCurrency()
        {

            return ExecuteDataSet("Currency_Get");
        }
        public DataSet BindDefaultCurrency()
        {
            return ExecuteDataSet("Currency_getDefaultCurrency");
        }

        public DataSet GetPaymentTypes(int PaymentId)
        {
            Hashtable htparams = new Hashtable
                                              {
                                                 {"@PaymentId",PaymentId},
                                              };
            return ExecuteDataSet("PaymentTypes_Get", htparams);
        }


        /// <summary>
        /// for Commission percentage
        /// </summary>

        public DataSet GetCommissionPerc(int commId)
        {
            Hashtable htparams = new Hashtable
                                              {
                                                 {"@comId",commId},
                                              };
            return ExecuteDataSet("CommissionTypes_GetComPercentage", htparams);
        }
        public DataSet BindMainAccount()
        {

            return ExecuteDataSet("MainAcount_ListGet");
        }
         public DataSet GetMainAccountType(int MainAccId)
        {
            Hashtable htparams = new Hashtable
                                              {
                                                 {"@mainAcc",MainAccId},
                                              };
            return ExecuteDataSet("[MainAccountType]", htparams);
        }

        

        //Main Accounts Get
        public DataSet GetGroupMaster(int commId)
        {
            Hashtable htparams = new Hashtable
                                              {
                                                 {"@Id",commId},
                                              };
            return ExecuteDataSet("GroupMaster_Get", htparams);
        }



        //Multiple  Language 

        public DataSet GetLanguageDescription(int LangId)
        {
            Hashtable htparams = new Hashtable
                                              {
                                                 {"@LangId",LangId},
                                              };
            return ExecuteDataSet("Get_LanguagesDescription", htparams);
        }

        public DataSet GetLanguages()
        {

            return ExecuteDataSet("Get_Languages");
        }

        // added for unique account code checking in Air ,land,client, main and chart of accounts by anitha
        public DataSet CheckAccCodeExitorNot(string AccountNo, string FormName)
        {
            Hashtable htparams = new Hashtable
                                              {
                                                 {"@Accountno",AccountNo},
                                                  {"@Type",FormName},
                                              };
            return ExecuteDataSet("AccCode_ExistorNot", htparams);
        }
        // added for unique account code checking in Air ,land,client, main and chart of accounts by anitha
        public DataSet CheckKeyCodeExitorNot(string Key, string FormName)
        {
            Hashtable htparams = new Hashtable
                                              {
                                                 {"@Key",Key},
                                                  {"@Type",FormName},
                                              };
            return ExecuteDataSet("KeyCode_ExistorNot", htparams);
        }
        #region DynamicMenuData
        // added by Anitha on 25/04/2018
        public DataSet GetMenusByRole(int RoleId, int CompanyId)
        {
            Hashtable htParams = new Hashtable
                                     {
                                          
                                         {"@inRoleId",RoleId},
                                         {"@inCompanyId",CompanyId},
                                         // {"@BranchId",BranchId}
                                     };
            return ExecuteDataSet("menuaccess_by_role", htParams);
        }
        #endregion
        #region UserList
        // added by Anitha on 02/05/2018
        public DataSet GetUserList(int UserId, int CompanyId, int BranchId)
        {
            Hashtable htParams = new Hashtable
                                            {
                                                {"@inUserId",UserId},
                                                {"@inCompanyId",CompanyId},
                                                 {"@inBranchId",BranchId}
                                                 
                                            };
            return ExecuteDataSet("UserMaster_Get", htParams);
        }
        #endregion

        #region RolesList
        // added by Anitha on 02/05/2018
        public DataSet GetRolesList(int CompanyId, int BranchId)
        {
            Hashtable htParams = new Hashtable
                                            {
                                               
                                                {"@inCompanyId",CompanyId},
                                                 {"@inBranchId",BranchId}
                                                 
                                            };
            return ExecuteDataSet("RolesMaster_Get", htParams);
        }
        #endregion

        #region MenusList and Update Menus As per Role
        // added by Anitha on 02/05/2018
        public DataSet GetMenusList(int RoleId)
        {
            Hashtable htParams = new Hashtable
                                            {
                                               
                                                {"@inRoleId",RoleId}
                                                
                                                 
                                            };
            return ExecuteDataSet("MenuAccess_Get", htParams);
        }
        public int MenuAccessUpdate(int RoleId, int isAccessId, int MenuId, int MenuAccessId)
        {
            Hashtable htParams = new Hashtable
                                            {
                                               
                                                 {"@inRoleId",RoleId},
                                                 {"@inIsAccessId",isAccessId},
                                                 {"@inMenuId",MenuId},
                                                 {"@inMenuAccessId",MenuAccessId}
                                                
                                                 
                                            };
            return ExecuteNonQuery("MenuAccess_Update", htParams);
        }
        #endregion

        #region Assign Role to user
        //added by anitha on 05/05/2018
        public int ManageUserRole(int UserId, int RoleId)
        {
            Hashtable htParams = new Hashtable
                                     {
                                         {"@UserId",UserId},
                                         {"@RoleId",RoleId},
                                          
                                     };
            return ExecuteNonQuery("UserMaster_Assign_Role", htParams);
        }
        #endregion
        #region CheckAccCodes Exit or Not
        //added by mounika on 07/05/2018
        public DataSet CheckAccCode_ExistorNot(string AccountCode, string type)
        {
            Hashtable htparams = new Hashtable
           {
             {"@AccountCode",AccountCode},
              {"@Type",type}
           };

            return ExecuteDataSet("AccCode_ExistorNot", htparams);

        }

        #endregion
        public DataSet GetVatData(int vatid)
        {

            Hashtable htparams = new Hashtable
           {
             {"@VatId",vatid}
           };
            return ExecuteDataSet("Vat_GetData", htparams);
        }
        public DataSet GetCurrency()
        {
            return ExecuteDataSet("Currency_Get");
        }

    }
}
