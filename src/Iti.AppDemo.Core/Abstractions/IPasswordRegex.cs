namespace Iti.AppDemo.Core.Abstractions
{
    public interface IPasswordRegex
    {
        bool IsValid(string password);
    }
}
