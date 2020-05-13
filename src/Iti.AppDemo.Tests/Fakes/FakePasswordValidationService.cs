using Iti.AppDemo.Domain.Contexts.Services;

namespace Iti.AppDemo.Tests.Fakes
{
    public class FakePasswordValidationService : IPasswordValidationService
    {
        public bool IsValid(string password)
        {
            return string.IsNullOrEmpty(password) ? false : true;
        }
    }
}
