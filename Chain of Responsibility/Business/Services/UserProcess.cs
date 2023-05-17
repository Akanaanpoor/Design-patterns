using Chain_of_Responsibility.Business.Exceptions;
using Chain_of_Responsibility.Business.UserHandler;
using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Business.Services
{
    public class UserProcess
    {
        public bool Register(User user)
        {
            try
            {
                var handler = new SocialSecurityNumberValidateHandler();

                handler.SetNext(new AgeValidationHandler())
                    .SetNext(new NameValidationHandler())
                    .SetNext(new CitizenshipRegionValidationHandler());

                handler.Handle(user);
            }
            catch (UserValidationException ex)
            {
                return false;
            }
            return true;
        }
    }
}
