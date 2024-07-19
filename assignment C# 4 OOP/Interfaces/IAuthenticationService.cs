using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_C__4_OOP.Interfaces
{
    internal interface IAuthenticationService

    {
        public string User { get; set; }
        public string Pass { get; set; }

        public bool  AuthenticateUser(string UserName, String Password);
       public bool AuthorizeUser(String UserName, String Roles);
    }
}
