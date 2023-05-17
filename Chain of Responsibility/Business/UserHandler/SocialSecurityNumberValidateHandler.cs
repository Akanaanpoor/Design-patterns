using Chain_of_Responsibility.Business.Exceptions;
using Chain_of_Responsibility.Business.Validator;
using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Business.UserHandler
{
    public class SocialSecurityNumberValidateHandler : UserHandler
    {
        private SocialSecurityNumberValidator socialSecurityNumberValidator
            = new SocialSecurityNumberValidator();

        public override void Handle(User request)
        {
            if (!socialSecurityNumberValidator.Validate(request.SocialSecurityNumber,
                request.CitizenshipRegion))
            {
                throw new UserValidationException("Social security number could not be validated");
            }
            else
            {
                Console.WriteLine("\r\nSocial Security Code Validate Done!");
            }
            base.Handle(request);
        }
    }
}
