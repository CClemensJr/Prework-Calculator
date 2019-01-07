using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface with the user
            UserInterface();

            // Keep the Console open until the user decides to close it
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadLine();
        }


        /**
         *  INPUT HANDLERS
         **/
        static void UserInterface()
        {
            // Create a heading
            int consoleWidth = Console.WindowWidth;
            string heading = "Welcome to the Calculator. You got to keep it calculated!";

            for (int j = 0; j < 5; j++)
            {
                if (j == 0 || j == 4)
                {
                    for (int i = 0; i < consoleWidth; i++)
                    {
                        Console.Write("*");
                    }
                }
                else if (j == 2)
                {
                    Console.Write(String.Format("{0," + ((consoleWidth / 2) + (heading.Length / 2) + "}"), heading));
                }
                else
                {
                    Console.WriteLine();
                }
            }

            WhichFunction();
        }


        static void WhichFunction()
        {
            Console.WriteLine("Would you like to [A]dd, [S]ubtract, [M]ultiply, or [D]ivide?");
            string function = Console.ReadLine().ToUpper();

            Console.WriteLine("Now give me a couple numbers:");
            // Assign the numbers to variables
            // Double is used in case the user wants to add decimals
            double firstNumber = Double.Parse(Console.ReadLine());
            double secondNumber = Double.Parse(Console.ReadLine());

            switch (function)
            {
                case "A":
                    double sum = Add(firstNumber, secondNumber);

                    Console.WriteLine($"ADDITION: { firstNumber } + { secondNumber } = { sum }");

                    break;

                case "S":
                    double difference = Subtract(firstNumber, secondNumber);

                    Console.WriteLine($"SUBTRACTION: { firstNumber } - { secondNumber } = { difference }");

                    break;

                case "M":
                    double product = Multiply(firstNumber, secondNumber);

                    Console.WriteLine($"MULTIPLICATION: { firstNumber } x { secondNumber } = { product }");

                    break;

                case "D":
                    double quotient = Divide(firstNumber, secondNumber);

                    Console.WriteLine($"DIVISION: { firstNumber } / { secondNumber } = { quotient }");

                    break;

                default:
                    Console.WriteLine("Please enter A for Add, S for Subtract, M for Multiply, or D for Divide.");

                    break;
            }
        }

        /**
         *  CALCULATIONS 
         **/
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

        // Divide one paramter by the other
        static double Divide(double number1, double number2)
        {
            double quotient = number1 / number2;

            return quotient;
        }

    }
}
