using Iti.AppDemo.Application.Handlers;
using Iti.AppDemo.Core.Commands;
using Iti.AppDemo.Domain.Contexts.Commands.PasswordCommands;
using Iti.AppDemo.Domain.Contexts.Commands.PasswordCommands.Output;
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
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ICommandResult Post([FromBody]CreatePasswordCommand command)
        {
            var result = (CreatePasswordCommandResult)_handler.Handle(command);
            return result;
        }
    }
}