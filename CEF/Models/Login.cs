using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEF.Models
{
    public class Login
    {
       public string UserID { get; set; }
       public string UserName { get; set; }
       public string Email { get; set; }
       public string Password { get; set; }
       public string CPassword { get; set; }
    }
}
