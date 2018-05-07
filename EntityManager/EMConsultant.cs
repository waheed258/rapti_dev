using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityManager
{
    public class EMConsultant
    {
        public int ConsultantId { get; set; }
        public string ConsultantKey { get; set; }
        public int ConsultantIsActive { get; set; }
        public string ConsultantName { get; set; }
        public int ConsultantGroup { get; set; }
        public int Division { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public string CellNo { get; set; }
        public string FaxNo { get; set; }
        public int ClientType { get; set; }
        public int Company { get; set; }
        public int Branch { get; set; }
        public int CreatedBy { get; set; }
    }
}
