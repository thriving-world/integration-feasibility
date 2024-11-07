using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SampleApp!");
            
            int result = Add(5, 10);
            Console.WriteLine($"The result is: {result}");
        }

        // A method to add two numbers and return the result.
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
