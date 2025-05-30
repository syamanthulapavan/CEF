using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEF.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<Users> ListUsers { get; set; }
        public Users user { get; set; }
        public List<Medicines> ListMedicines { get; set; }
        public Medicines Medicine { get; set; }
        public List<Cart> ListCarts { get; set; }
        public Cart cart { get; set; }
        public List<Orders> ListOrders { get; set; }
        public Orders Orders { get; set; }
        public List<OrderItems> ListOrderItems { get; set; }
        public OrderItems OrderItems { get; set; }
    }
}
