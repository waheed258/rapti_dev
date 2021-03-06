﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataManager
{
    public class DALogin : DataUtilities
    {
        public DataSet UserAuthentication(string UserName, string Password)
        {
            Hashtable htParams = new Hashtable
                                     {
                                         {"@LoginId",UserName},
                                         {"@Password",Password},
                                     };
            return ExecuteDataSet("UserMaster_Authentication", htParams);
        }
    }
}
