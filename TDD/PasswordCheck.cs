using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDD
{
    public static class PasswordCheck
    {
        //APIs for checking Password
        public static int PasswordStrength(string pwd)
        {
            //If No Password
            if (string.IsNullOrEmpty(pwd))
                return 0;

            int strength = 0;

            // +1 for small password  
            if(pwd.Length>4&&pwd.Length<7)
                strength += 1;

            // +2 for medium password
            if (pwd.Length > 7 && pwd.Length < 11)
                strength += 2;

            return strength;
        }

        //API for checking Password Regex
        public static string PasswordRegexCheck(string pwd)
        {
            string result = "";
            if (Regex.Match(pwd,
                "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\{\\}\\[\\]\\:\\'\\;\\\"\\/\\?\\.\\>\\,\\<\\~\\`\\-\\\\_\\=\\+\\|]").Success)
                result= "Valid";
            return result;
        }

        //API for checking Password with Number 
        public static string PasswordNumberCheck(string pwd)
        {
            string result = "";
            if (Regex.Match(pwd, "[0-9]").Success)
                result = "Valid";
            return result;
        }

        //API for checking complex password
        public static string ComplexPasswordCheck(string pwd)
        {
            string result = "";
            Regex regex1 = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]){6,20}$");
            Regex regex2 = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*?[#?!@$%^&*-]){6,20}$");
            Regex regex3 = new Regex("^(?=.*[0-9])(?=.*[A-Z])(?=.*?[#?!@$%^&*-]){6,20}$");
            Regex regex4 = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*?[#?!@$%^&*-]){6,20}$");
            Regex regex5 = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*?[#?!@$%^&*-]){6,20}$");

            Match match1 = regex1.Match(pwd);
            Match match2 = regex2.Match(pwd);
            Match match3 = regex3.Match(pwd);
            Match match4 = regex4.Match(pwd);
            Match match5 = regex5.Match(pwd);

            if (match1.Success || match2.Success || match3.Success ||
                match4.Success || match5.Success)
                result = "Valid";
            return result;
        }
    }
}
