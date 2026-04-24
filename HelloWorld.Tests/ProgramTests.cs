using Xunit;

namespace HelloWorld.Tests;

public class ProgramTests
{
    [Fact]
    public void GetGreeting_ReturnsHelloWorld()
    {
        var result = Program.GetGreeting();

        Assert.Equal("Hello, World!", result);
    }
}

