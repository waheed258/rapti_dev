using DataManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessManager
{
   public class BALConsultant
    {
        private DALConsultant _ObjDALConsultant = new DALConsultant();

        public int InsertUpdateConsultant(EMConsultant objEMConsultant)
        {
            return _ObjDALConsultant.InsertUpdateConsultant(objEMConsultant);
        }
      
        public DataSet GetConsultant(int ConsultantId)
        {
            return _ObjDALConsultant.Get_ConsultantData(ConsultantId);
        }
    }
}
