using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParstebWhatsapp
{
    public class Tools
    {
        public static string GlobalizePhoneNumber(string countryCode, string phoneNumber)
        {
            string result = phoneNumber;
            if (string.IsNullOrEmpty(countryCode) || string.IsNullOrEmpty(phoneNumber))
                return result;

            int startIndex;

            if (phoneNumber.StartsWith("0"))
                startIndex = 1;
            else
                startIndex = 0;

            if (phoneNumber.StartsWith("+"))
                result = phoneNumber;
            else
                result = countryCode + phoneNumber.Substring(startIndex);

            return result;
        }
    }
}
