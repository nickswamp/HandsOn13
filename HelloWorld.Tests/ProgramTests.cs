namespace HelloWorld.Tests
{
    using Xunit;
    
    public class ProgramTests
    {
        /// <summary>
        /// Verifies that the GetGreeting method returns the expected output.
        /// </summary>
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
