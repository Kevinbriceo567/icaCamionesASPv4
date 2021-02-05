using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace icaCamionesASPv4.Models
{
    public class Membership
    {
        public int Id {get;set;}
        public string NOM_USU { get; set; }
        public string PER_USU { get; set; }
        public string PWD_USU { get; set; }
        public string NIC_USU { get; set; }
    }
}