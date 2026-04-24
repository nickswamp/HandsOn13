namespace HelloWorld
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetGreeting());
        }

        public static string GetGreeting() => "Hello, World!";
        
        // Notice this internal method does not have XML comments
        internal static string GetInternalData() => "Secret";
    }
}
