using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAveiro.Models
{
    public class Utilities
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public string Address { get; set; }        
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string URLSite { get; set; }
       
        public virtual UtilitiesTypes UtilitiesTypes { get; set; }
        public virtual RestTypes RestTypes { get; set; }

        public virtual FoodTypes FoodTypes { get; set; }

        public virtual FunTypes FunTypes { get; set; }

        public virtual EventTypes EventTypes { get; set; }


    }
}