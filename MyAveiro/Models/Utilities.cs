using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAveiro.Models
{
    public class Utilities
    {
        public int ID { get; set; }
        public int UtilityID { get; set; }
        public string CompleteName { get; set; }
        public string Acronym { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressNumber { get; set; }
        public string Email { get; set; }
        public string URLSite { get; set; }
        public virtual ICollection<UtilitiesTypes> UtilitiesTypes { get; set; }
    }
}