using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataManager;
using System.Data;

namespace BusinessManager
{
   
   public class BoUtility
    {
       DoUtility _objDOUtility = new DoUtility();


        #region Dynamic Menus
        // added by Anitha on 25/04/2018

      //Menus
       public DataSet GetMenusByRole(int RoleId, int CompanyId)
        {
            return _objDOUtility.GetMenusByRole(RoleId, CompanyId);
        }

        #endregion

       #region Country,State,City
       public DataSet GetCountries()
       {
           return _objDOUtility.GetCountries();
       }
       public DataSet GetState(int StateId)
       {
           return _objDOUtility.GetState(StateId);
       }

       public DataSet GetCities(int Id)
       {
           return _objDOUtility.GetCities(Id);
       }

       public DataSet GetCurrency()
       {
           return _objDOUtility.GetCurrency();
       } 

       #endregion

    }
}
