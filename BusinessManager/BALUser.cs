using DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using EntityManager;

namespace BusinessManager
{
   public class BALUser
    {
       DALUser objDALUser = new DALUser();
        public int InsUpdUser(EMUser objuser)
        {
            return objDALUser.InsUpdUser(objuser);
        }

        public int DeleteUser(int userId)
        {
            return objDALUser.DeleteUser(userId);
        }
    }
}
