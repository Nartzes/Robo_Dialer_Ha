using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Per request a constructor was made and strings were pass in... Confuse why you want <3

namespace Robo_Dialer_Ha
{
    class HomePhone : Phone
    {
        public HomePhone(string Number, string Company, string PhoneType) : base(Number, Company, PhoneType)
        {

        }
    }
}
