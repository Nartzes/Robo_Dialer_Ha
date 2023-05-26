using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Shoves eveything in as string
// given protected string current string of array
// return message

namespace Robo_Dialer_Ha
{
    class Phone
    {

        protected string PhoneNumber;
        protected string CompanyName;
        protected string PhoneNumberType;

        public Phone(string Number, string Company, string PhoneType)
        {
            this.PhoneNumber = Number;
            this.CompanyName = Company;
            this.PhoneNumberType = PhoneType;
        }

        public virtual string Dial()
        {
            return $"Dialing {CompanyName} using {PhoneNumber}";
        }
    }
}
