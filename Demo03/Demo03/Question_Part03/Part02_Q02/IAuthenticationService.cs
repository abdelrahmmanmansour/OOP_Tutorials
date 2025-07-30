using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Part02_Q02
{
    internal interface IAuthenticationService
    {
        // Signature Of Method:
        bool AuthenticateUser(string UserName, string Password);
        bool AuthorizeUser(string UserName, string Role);
    }
}
