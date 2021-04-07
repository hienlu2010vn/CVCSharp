using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinForms
{
    class Validate
    {
        public bool CheckPhone(string phone)
        {
            bool check = true;
            try
            {
                if (phone.Length < 10)
                {
                    check = false;
                }
                else
                {
                    int alo = int.Parse(phone);
                    if (alo < 0)
                    {
                        check = false;
                    }
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }
        public bool checkInt(string num)
        {
            bool check = true;
            try
            {
                int alo = int.Parse(num);
                if (alo <= 0)
                {
                    check = false;
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }

        public bool checkFloat(string num)
        {
            bool check = true;
            try
            {
                float alo = float.Parse(num);
                if (alo <= 0)
                {
                    check = false;
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }

        public bool checkString(string stri, int num)
        {
            bool check = true;
            if (stri.Trim().Length > num)
            {
                check = false;
            }
            return check;
        }

        public bool checkEmail(string stri)
        {
            bool check = true;
            if (!Regex.IsMatch(stri, "[a-z][a-zA-Z0-9_.]{5,32}@[a-z0-9]{2,}(.[a-z0-9]{2,4}){1,2}"))
            {
                check = false;
            }
            return check;
        }
        public bool checkID(string stri)
        {
            bool check = true;
            if (!Regex.IsMatch(stri, "(?i)^(?=.*[a-z])[a-z0-9]{1,10}$"))
            {
                check = false;
            }
            return check;
        }
    }
}
