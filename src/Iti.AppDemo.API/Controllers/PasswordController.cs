using Iti.AppDemo.Application.Handlers;
using Iti.AppDemo.Core.Commands;
using Iti.AppDemo.Domain.Contexts.Commands.PasswordCommands;
using Microsoft.AspNetCore.Mvc;

namespace Iti.AppDemo.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PasswordController : Controller
    {
        private readonly PasswordHandler _handler;
        public PasswordController(PasswordHandler handler)
        {
            _handler = handler;
        }

        [HttpPost("ValidatePassword")]
        public ICommandResult Post([FromBody]CreatePasswordCommand command)
        {
            return (_handler.Handle(command));
        }
    }
}