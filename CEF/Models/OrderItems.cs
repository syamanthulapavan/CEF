using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEF.Models
{
    public class OrderItems
    {
        public int ID { get; set; }
        public string OrderID { get; set; }
        public string MedicineID { get; set; }
        public string Unitprice { get; set; }
        public string Descount { get; set; }
        public string Quantity { get; set; }
        public string Totalprice { get; set; }
    }
}
