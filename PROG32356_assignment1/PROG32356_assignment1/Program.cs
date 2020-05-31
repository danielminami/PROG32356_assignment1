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


            //double number1 = getNumber("first");
            //char operation = getOperation();
            //double number2 = getNumber("second");

            ////TODO: I guess we now just need to find the right condition and then print the result.

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


        //static char getOperation() {
        //    char operation = '\0';
        //    bool validEntry = false;
        //    do {
        //        try {
        //            Console.Write("Please enter the operation\na - addition\ns - substraction\n" +
        //                "d - division \nm - multiplication\nr - remainder\n");
        //            operation = char.Parse(Console.ReadLine());
        //            if (operation == 'a' || operation == 's' || operation == 'd' || operation == 'm' || operation == 'r' ) {
        //                validEntry = true;
        //            } else {
        //                printErrorMessage();
        //            }
        //        } catch (Exception ex) {
        //            printErrorMessage();
        //        }
        //    } while (!validEntry);
        //    return operation;
        //}

        //static void printErrorMessage() {
        //    Console.WriteLine("Error: this character seems not to be what we expect. Please enter it again.");
        //}

        //static double addition(double a, double b) {
        //    return a + b;
        //}

        //static double substraction(double a, double b) {
        //    return a - b;
        //}

        //static double division(double a, double b) {
        //    return a / b;
        //}

        //static double multiplication(double a, double b) {
        //    return a * b;
        //}

        //static double remainder(double a, double b) {
        //    return a % b;
        //}

        //static void printGoodByeMessage() {
        //    Console.WriteLine("Thanks for using the calculator app. Press 'ENTER' to close.");
        //    Console.ReadLine();
        //}

        //static void printWelcomeMessage() {
        //    Console.WriteLine("Welcome to the Calulator APP.");
        //    Console.WriteLine("Instructions: this calculator app handles the four basic operations for two numbers.\n" +
        //        "First, enter a number. Then, enter the operation. Last, enter the second number.");
        //    Console.WriteLine("\n\n***************************************************\n\n");
        //}


    }
}
