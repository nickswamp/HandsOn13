using System;

namespace HelloWorld;

// main program class
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetGreeting());
    }
    public static string GetGreeting() => "Hello, World!";

    internal static string GetInternalData() => "Secret";
}