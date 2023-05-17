using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Model
{
    public class User
    {
        public string Name { get; }
        public string SocialSecurityNumber { get; }
        public DateTimeOffset DateOfBirth { get; }
        public RegionInfo CitizenshipRegion { get; }

        // This will get the age right.. most of the time!
        public int Age => (int)((DateTimeOffset.UtcNow - DateOfBirth.UtcDateTime).TotalDays / 365.2425);

        public User(string name,
            string socialSecurityNumber,
            RegionInfo citizenshipRegion,
            DateTimeOffset dateOfBirth)
        {
            Name = name;
            SocialSecurityNumber = socialSecurityNumber;
            DateOfBirth = dateOfBirth;
            CitizenshipRegion = citizenshipRegion;
        }
    }
}
