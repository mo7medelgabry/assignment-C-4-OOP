using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_C__4_OOP.Interfaces
{
    internal class BasicAuthenticationService : IAuthenticationService
    {   public string User {  get; set; }   
        public string Pass { get; set; }    
         

        public bool AuthenticateUser(string UserName, string Password)
        {  if(UserName == User  && Password == Pass )
            {
                return true;

            } else { return false; }


        }

        public bool AuthorizeUser(string UserName, string Roles)
        {
            if (UserName == "admin" && Roles == "Administrator")
            {
                return true;
            }

            return false;
        }
    }

    
}
