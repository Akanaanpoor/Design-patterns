using Chain_of_Responsibility.Business.Exceptions;
using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Business.UserHandler
{
    public class NameValidationHandler : UserHandler
    {
        public override void Handle(User user)
        {
            if (user.Name.Length <= 1)
            {
                throw new UserValidationException("Your name is unlikely this short.");
            }
            else
            {
                Console.WriteLine("\r\nName Validate Done !");
            }
            base.Handle(user);
        }
    }
}
