using System;

namespace PROG32356_assignment1
{
    class Calculator {
        /// <summary>
        /// This method is the entry point into the application
        /// The Calculator App ... WRITE SOME STUFF ABOUT
        /// </summary>       
        static void Main()
        {
            //printGoodByeMessage();

            //Allow user to make operations recursively
            do
            {
                Console.Clear();

                Console.WriteLine("CALCULATOR\n");

                Console.Write("Enter first number: ");
                double number1 = GetNumber();

                Console.Write("Enter second number: ");
                double number2 = GetNumber();

                string operation = GetOperator();

                double result = PerformOperation(operation, number1, number2);

                Console.WriteLine($"\n{number1} {operation} {number2} = {result}\n");

                Console.WriteLine("Enter \"y\" to make another operation or any to exit.");
            } while (Console.ReadLine() == "y");
        }

        static double PerformOperation(string operationType, double firstNumber, double secondNumber)
        {
            double result = 0;

            switch (operationType)
            {

                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    break;
            }

            return result;
        }

        static double GetNumber()
        {
            //bool validEntry = true;
            double number =0;
            
            while(!double.TryParse(Console.ReadLine(), out number))
            {
                    Console.WriteLine("Enter a valid number.");
            }

            return number;
        }

        static string GetOperator()
        {
            bool invalidEntry = true;
            string operation = string.Empty;

            Console.WriteLine("Enter one of the following operators (+, -, *, /, %): ");
            do
            {
                operation = Console.ReadLine();

                if (operation.Equals("+") || operation.Equals("+")
                    || operation.Equals("/") || operation.Equals("*")
                     || operation.Equals("%"))
                {

                    invalidEntry = false;
                }
                else
                {
                    Console.WriteLine("Invalid operator");
                }
            } while (invalidEntry);

            return operation;
        }
    }
}
