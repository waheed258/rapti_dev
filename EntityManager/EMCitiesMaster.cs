using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityManager
{

    public class EMCitiesMaster
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int state_id { get; set; }
        public string CityKey { get; set; }
        public int CreatedBy { get; set; }
    }
}
