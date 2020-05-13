namespace Iti.AppDemo.Domain.Contexts.Services
{
    public interface IPasswordValidationService
    {
        bool IsValid(string password);
    }
}