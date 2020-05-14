using Iti.AppDemo.Core.Abstractions;
using System.Linq;
using System.Text.RegularExpressions;

namespace Iti.AppDemo.Core.Implementations
{

    /*
    (           # Start of group
    (?=.*\d)    # must contain at least one digit
    (?=.*[A-Z]) # must contain at least one uppercase character
    (?=.*\W)    # must contain at least one special symbol
    .           # match anything with previous condition checking
    {8,8}       # length at least 8 characters and also maximum of 8
    )       
    */

    public class PasswordRegex : IPasswordRegex
    {
        public bool IsValid(string password)
        {
            var isPasswordOk = Regex.Match(password, @"((?=.*\d)(?=.*[A-Z])(?=.*\W).{9,})").Success;
            int repeatedChars = password.Length - password.ToCharArray().Distinct().Count();

            return (isPasswordOk && repeatedChars == 0);
        }
    }
}
