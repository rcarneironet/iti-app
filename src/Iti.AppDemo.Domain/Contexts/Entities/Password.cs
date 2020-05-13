using Iti.AppDemo.Core.Entities;

namespace Iti.AppDemo.Domain.Contexts.Entities
{
    public class Password : Entity
    {
        public string UserPassword { get; private set; }
        public Password(string password)
        {
            UserPassword = password;
        }
    }
}
