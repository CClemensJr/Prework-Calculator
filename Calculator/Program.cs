using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for two numbers from the user
            Console.WriteLine("Hello World!");
            Console.WriteLine("Give me a couple numbers:");

            // Assign the numbers to variables
            double firstNumber = Double.Parse(Console.ReadLine());
            double secondNumber = Double.Parse(Console.ReadLine());

            // Perform the calculations and assign the results to a variable
            double sum = Add(firstNumber, secondNumber);

            // Inform the user of the results
            Console.WriteLine($"Congratulations! { firstNumber } + { secondNumber } = { sum }");
        }

        // Add two parameters together and return a solution
        // Double is used in case the user wants to add decimals
        static double Add(double number1, double number2)
        {
            double sum = number1 + number2;

            return sum;
        }
    }
}
