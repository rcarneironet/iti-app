using Iti.AppDemo.Core.Commands;

namespace Iti.AppDemo.Domain.Contexts.Commands.PasswordCommands.Output
{
    public class CreatePasswordCommandResult : ICommandResult
    {
        public CreatePasswordCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
