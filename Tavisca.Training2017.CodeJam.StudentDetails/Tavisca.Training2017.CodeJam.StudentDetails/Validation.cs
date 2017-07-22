using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    class Validation
    {
       
        public bool CheckMobileNumber(string s)
        {
            return Regex.IsMatch(s, @"^[0-9]{10}",RegexOptions.Singleline); 
        }
        public bool CheckEmail(string s)
        {
            return Regex.IsMatch(s, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.Singleline);
        }
        internal bool checkString(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]*", RegexOptions.Singleline);
        }
        public bool CheckAddress(string s)
        {
            return Regex.IsMatch(s, @"[A-Za-z0-9,]", RegexOptions.Singleline);
        }
      
    }
}
