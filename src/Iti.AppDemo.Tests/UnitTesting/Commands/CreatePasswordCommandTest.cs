using Iti.AppDemo.Domain.Contexts.Commands.PasswordCommands;
using NUnit.Framework;

namespace Iti.AppDemo.Tests.uni
{
    public class CreatePasswordCommandTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatePasswordCommand_IsValid_ReturnsTrue()
        {
            var command = new CreatePasswordCommand();
            command.Password = @"Trustn01";

            Assert.AreEqual(true, command.Valid());
        }
        [Test]
        public void CreatePasswordCommand_IsValid_ReturnsFalse()
        {
            var command = new CreatePasswordCommand()
            {
                Password = string.Empty
            };

            Assert.AreEqual(false, command.Valid());
        }

        [Test]
        public void CreatePasswordCommand_IsValid_ReturnsTrue_With_Password_Rules()
        {
            var command = new CreatePasswordCommand()
            {
                Password = string.Empty
            };

            Assert.AreEqual(false, command.Valid());
        }

    }
}