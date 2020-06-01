using System;

/*  ASSIGNMENT 1 - PROG32356 
 *  GROUP P14_1205_11181 2
 *  MEMBERS:    Bhagat, Karoona
 *              Minami, Daniel
 *              Sanchez Moyano, Manuel
 *  Repo:       https://github.com/danielminami/PROG32356_assignment1
 */

namespace PROG32356_assignment1
{
    class Calculator {
        /// <summary>
        /// This method is the entry point into the application
        /// The Calculator App is a basic operations calculator. It receives two real numbers and an operator
        /// to perform one of the basic operations: addition, substraction, multiplication, division and remainder
        /// </summary>       
        static void Main()
        {
            // This loop allows users to execute calculations until they choose to exit the program
            do
            {
                Console.Clear();

                Console.WriteLine("CALCULATOR\n");
                Console.Write("Enter first number: ");
                double number1 = getNumber();

                Console.Write("Enter second number: ");
                double number2 = getNumber();

                Console.Write("Enter one of the following operators (+, -, *, /, %): ");
                string operation = getOperator();

                double result = performOperation(operation, number1, number2);

                Console.WriteLine($"\n{number1} {operation} {number2} = {result}\n");

                Console.WriteLine("Enter \"y\" to make another operation or any to exit.");
            } while (Console.ReadLine() == "y");
        }

        /// <summary>
        /// This receives two numerical values and an string containing the operator. It executes the mathematical
        /// calculation and returns the value.
        /// </summary>
        /// <param name="operationType">Operator</param>
        /// <param name="firstNumber">Left side value</param>
        /// <param name="secondNumber">Right side value</param>
        /// <returns></returns>
        static double performOperation(string operationType, double firstNumber, double secondNumber)
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

        /// <summary>
        /// This method prompts the user for a numerical value and returns it. It implements TryParse to test the 
        /// user entry's conversion to numerical type. In case it fails, prompts the user again. 
        /// </summary>
        /// <returns></returns>
        static double getNumber()
        {
            double number = 0;
            
            while(!double.TryParse(Console.ReadLine(), out number))
            {
                    Console.Write("Please enter a valid number: ");
            }

            return number;
        }

        /// <summary>
        /// This method prompts the user for specific math operators. It returns a valid entry, otherwise,
        /// prompts the user for a new entry.
        /// </summary>
        /// <returns></returns>
        static string getOperator()
        {
            bool validEntry = false;
            string operation = string.Empty;

            do
            {
                operation = Console.ReadLine();

                if (operation.Equals("+") || operation.Equals("-") || operation.Equals("/") || 
                    operation.Equals("*") || operation.Equals("%"))
                {
                    validEntry = true;
                }
                else
                {
                    Console.Write("Please enter a valid operator: ");
                }
            } while (!validEntry);

            return operation;
        }
    }
}
