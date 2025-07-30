using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Part02_Q02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        // Implement The Method:
        public bool AuthenticateUser(string UserName, string Password)
        {
            if (UserName == "Mansour" && Password == "0502535573") return true;
            if (UserName == "Sara" && Password == "0502535573xcv") return true;
            else return false;

        }

        public bool AuthorizeUser(string UserName, string Role)
        {
            if (UserName == "Mansour" && Role == ".NET") return true;
            if (UserName == "Sara" && Role == "NodeJs") return true;
            else return false;
        }
    }
}
