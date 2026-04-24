// <copyright file="ProgramTests.cs" company="StudentProject">
// Copyright (c) StudentProject. All rights reserved.
// </copyright>

namespace HelloWorld.Tests
{
    using Xunit;

    /// <summary>
    /// Test class for the main Program.
    /// </summary>
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
