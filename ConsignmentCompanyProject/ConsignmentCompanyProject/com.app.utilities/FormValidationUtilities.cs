using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions
    ;

namespace ConsignmentCompanyProject.com.app.utilities
{
    class FormValidationUtilities
    {
        //To validate maxfields in text fields
        public bool fieldsMaxLength(string str, int length)
        {
            if (str.Length < length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //To validate maxfields in text fields
        public bool nullCheck(string str)
        {
            if (str == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ////To validate email text fields

        public bool emailCheck(string str)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (Regex.IsMatch(str, pattern))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //To validate mobilenumber format in text fields

        public bool mobileCheck(string str)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(str, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //To validate the fields contains only text

        public bool stringCheck(string str)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(str, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool numberCheck(string str)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(str, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
