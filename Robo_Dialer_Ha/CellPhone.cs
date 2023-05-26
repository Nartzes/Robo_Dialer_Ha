using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// regex to chop the string ups by patterns to fit it in a number
// using string.format to fill in for phone number format
// return overided version for Cell Phone

namespace Robo_Dialer_Ha
{
    internal class CellPhone : Phone
    {
        public CellPhone(string Number, string Company, string PhoneType) : base(Number, Company, PhoneType)
        {

        }

        public override string Dial()
        {
            PhoneNumber = Regex.Replace(PhoneNumber, "[^0-9]", "");
            string formattedNumber = string.Format("{0:(###) ###-####}", long.Parse(PhoneNumber));
            return $"Dialing {CompanyName} using 1+{formattedNumber}...";
        }
    }
}
