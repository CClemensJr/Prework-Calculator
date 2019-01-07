using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Add two parameters together and return a solution
        // Double is used in case the user wants to add decimals
        static double Add(double num1, double num2)
        {
            double product = num1 + num2;

            return product;
        }
    }
}
