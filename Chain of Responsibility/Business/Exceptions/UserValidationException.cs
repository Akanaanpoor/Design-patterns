using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Business.Exceptions
{
    public class UserValidationException : Exception
    {
        public UserValidationException(string message) : base(message)
        {

        }
    }
}
