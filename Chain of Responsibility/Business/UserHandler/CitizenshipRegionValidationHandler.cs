using Chain_of_Responsibility.Business.Exceptions;
using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Business.UserHandler
{
    public class CitizenshipRegionValidationHandler : UserHandler
    {
        public override void Handle(User user)
        {
            if (user.CitizenshipRegion.TwoLetterISORegionName == "NO")
            {
                throw new UserValidationException("We currently do not support Norwegians");
            }
            else
            {
                Console.WriteLine("\r\nCitizenship Done !\r\n");
            }

            base.Handle(user);
        }
    }
}
