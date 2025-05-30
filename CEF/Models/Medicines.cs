using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEF.Models
{
    public class Medicines
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Unitprice { get; set; }
        public string Descount { get; set; }
        public string Quantity { get; set; }
        public string Imageurl { get; set; }
        public string Status { get; set; }
        public string Expdate { get; set; }
    }
}
