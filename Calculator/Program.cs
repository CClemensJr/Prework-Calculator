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
            // Double is used in case the user wants to add decimals
            double firstNumber = Double.Parse(Console.ReadLine());
            double secondNumber = Double.Parse(Console.ReadLine());

            // Perform the calculations and assign the results to a variable
            double sum = Add(firstNumber, secondNumber);
            double difference = Subtract(firstNumber, secondNumber);
            double product = Multiply(firstNumber, secondNumber);
            double quotient = Divide(firstNumber, secondNumber);

            // Inform the user of the results
            Console.WriteLine($"ADDITION: { firstNumber } + { secondNumber } = { sum }");
            Console.WriteLine($"SUBTRACTION: { firstNumber } - { secondNumber } = { difference }");
            Console.WriteLine($"MULTIPLICATION: { firstNumber } x { secondNumber } = { product }");
            Console.WriteLine($"DIVISION: { firstNumber } / { secondNumber } = { quotient }");


            // Keep the Console open until the user decides to close it
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadLine();
        }

        // Add two parameters together and return a solution
        static double Add(double number1, double number2)
        {
            double sum = number1 + number2;

            return sum;
        }

        // Subtract one parameter from the other and return a solution
        static double Subtract(double number1, double number2)
        {
            double difference = number1 - number2;

            return difference;
        }

        // Multiply two parameters together and return a solution
        static double Multiply(double number1, double number2)
        {
            double product = number1 * number2;

            return product;
        }

        static double Divide(double number1, double number2)
        {
            double quotient = number1 / number2;

            return quotient;
        }

    }
}
