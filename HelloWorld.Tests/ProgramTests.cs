
namespace HelloWorld.Tests
{
    using Xunit;

    public class ProgramTests
    {
        [Fact]
        public void GetGreeting_ReturnsHelloWorld()
        {
            // Arrange & Act
            var result = Program.GetGreeting();

            // Assert
            Assert.Equal("Hello, World!", result);
        }
    }
}
