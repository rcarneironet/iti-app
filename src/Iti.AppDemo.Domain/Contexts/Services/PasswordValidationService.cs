using Iti.AppDemo.Core.Implementations;

namespace Iti.AppDemo.Domain.Contexts.Services
{
    public class PasswordValidationService : IPasswordValidationService
    {
        public bool IsValid(string password)
        {
            var passwordRegex = new PasswordRegex();
            return passwordRegex.IsValid(password);
        }
    }
}
