using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SampleApp!");
            
            // Changed values to test with different inputs
            int result = Add(7, 8);  // Test different inputs
            Console.WriteLine($"The result is: {result}");

            // New line added to call Multiply function
            Console.WriteLine($"The product is: {Multiply(3, 4)}");
        }

        // A method to add two numbers and return the result.
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Added Multiply method to perform multiplication
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
