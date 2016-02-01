using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAveiro.Models
{
    public class ImagesRepository
    {
        public int ID { get; set; }
        public string URLImage { get; set; }
        public virtual Utilities Utilities { get; set; }
    }
}