using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityManager
{

    public class EMCountries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryKey { get; set; }       
        public int CreatedBy { get; set; }
    }
}
