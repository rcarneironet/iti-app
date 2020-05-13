using FluentValidator;
using Iti.AppDemo.Core.Commands;
using Iti.AppDemo.Core.Implementations;
using Iti.AppDemo.Domain.Contexts.Commands.PasswordCommands;
using Iti.AppDemo.Domain.Contexts.Services;

namespace Iti.AppDemo.Application.Handlers
{
    public class PasswordHandler :
        Notifiable,
        ICommandHandler<CreatePasswordCommand>
    {
        private readonly IPasswordValidationService _passwordValidationService;
        public PasswordHandler(IPasswordValidationService passwordValidationService)
        {
            _passwordValidationService = passwordValidationService;
        }
        public ICommandResult Handle(CreatePasswordCommand command)
        {
            if (!_passwordValidationService.IsValid(command.Password))
            {
                AddNotification("Password", "As regras de criação de senhas não estão válidas.");
            }

            if (Invalid)
            {
                return new CommandResult(false, 
                    "Senha criada com sucesso", 
                    Notifications);
            }

            return new CommandResult(true, "Senha criada com sucesso", string.Empty);
        }
    }
}
