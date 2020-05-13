using Iti.AppDemo.Application.Handlers;
using Iti.AppDemo.Domain.Contexts.Commands.PasswordCommands;
using Iti.AppDemo.Tests.Fakes;
using NUnit.Framework;

namespace Iti.AppDemo.Tests.UnitTesting.Handlers
{
    public class PasswordHandlerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PasswordHandlerTest_RegisterPassword_ReturnsTrue()
        {
            var command = new CreatePasswordCommand();
            command.Password = "@Trustno1";

            var handler = new PasswordHandler(new FakePasswordValidationService());
            var result = handler.Handle(command);

            Assert.AreEqual(true, handler.IsValid);
        }

        [Test]
        public void PasswordHandlerTest_RegisterPassword_ReturnsFalse()
        {
            var command = new CreatePasswordCommand();
            command.Password = "";

            var handler = new PasswordHandler(new FakePasswordValidationService());
            var result = handler.Handle(command);

            Assert.AreEqual(false, handler.IsValid);
        }
    }
}
