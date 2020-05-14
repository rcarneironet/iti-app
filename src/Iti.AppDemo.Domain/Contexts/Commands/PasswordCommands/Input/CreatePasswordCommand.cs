using FluentValidator;
using FluentValidator.Validation;
using Iti.AppDemo.Core.Commands;

namespace Iti.AppDemo.Domain.Contexts.Commands.PasswordCommands
{
    public class CreatePasswordCommand : Notifiable, ICommand
    {
        public string Password { get; set; }
        public bool Valid()
        {
            AddNotifications(new ValidationContract()
                .HasMinLen(Password, 1, "Password", "A senha deve conter ao menos um caracter.")
            );
            return IsValid;
        }
    }
}
