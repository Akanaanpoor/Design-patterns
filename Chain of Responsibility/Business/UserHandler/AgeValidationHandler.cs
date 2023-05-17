using Chain_of_Responsibility.Business.Exceptions;
using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Business.UserHandler
{
    public class AgeValidationHandler : UserHandler
    {
        public override void Handle(User user)
        {
            if (user.Age < 18)
            {
                throw new UserValidationException("You have to be 18 years or older");
            }
            else
            {
                Console.WriteLine("\r\nAge Validate Done !");
            }
            base.Handle(user);
        }
    }
}
