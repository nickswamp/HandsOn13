namespace HelloWorld;

using System;

/// <summary>
/// The main program class for the HelloWorld application.
/// </summary>
public static class Program
{
    /// <summary>
    /// The entry point of the application.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    public static void Main(string[] args)
    {
        Console.WriteLine(GetGreeting());
    }

    /// <summary>
    /// Generates a standard greeting message.
    /// </summary>
    /// <returns>A string containing the greeting.</returns>
    public static string GetGreeting() => "Hello, World!";

    // Notice this internal method does not have XML comments
    internal static string GetInternalData() => "Secret";
}
