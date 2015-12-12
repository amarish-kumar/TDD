using System.Text.RegularExpressions;

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

    }
}
