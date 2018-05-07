using EntityManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataManager
{
   public class DALUser:DataUtility
    {
        public int InsUpdUser(EMUser objuser)
        {
            Hashtable htparams = new Hashtable
                                            {
                                                {"@UserId",objuser.UserId},
                                                {"@UserName",objuser.UserName},
                                                {"@UserEmail",objuser.UserEmail},
                                                {"@UserPhoneNo",objuser.UserPhoneNo},
                                                {"@UserRole",objuser.UserRole},
                                                {"@IsActive",objuser.IsActive},
                                                {"@CompanyId",objuser.CompanyId},
                                                {"@BranchId",objuser.BranchId},
                                                {"@CreatedBy",objuser.CreatedBy}
                                          
                                              
                                          };

            int IsSuccess = ExecuteNonQuery("UserMaster_InserUpdate", htparams);
            return IsSuccess;
        }

        public int DeleteUser(int Userid)
        {
            Hashtable htparams = new Hashtable{
                {"@userId",Userid}
            };
            return ExecuteNonQuery("User_delete", htparams);
        }

    }
}
