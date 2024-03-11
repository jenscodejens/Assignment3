using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_ErrorHandling
{
    internal class LoginCredentialInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered invalid login credentials.";
        }

        public override string ToString() => string.Format("{0,-30} {1}", "LoginCredentialInputError:", UEMessage());

    }
}
