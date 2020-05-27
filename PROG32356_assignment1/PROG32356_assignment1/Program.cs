using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROG32356_assignment1 {
    class Calculator {

        /// <summary>
        /// This method is the entry point into the application
        /// 
        /// The Calculator App ... WRITE SOME STUFF ABOUT
        /// 
        /// </summary>
        /// <param name="args">This function does not use the arguments</param>
        
        static void Main(string[] args) {
            printWelcomeMessage();
            double number1 = getNumber("first");
            char operation = getOperation();
            double number2 = getNumber("second");

            //TODO: I guess we now just need to find the right condition and then print the result.

            printGoodByeMessage();
        }

        static double getNumber(string message) {
            bool validEntry = false;
            double number = 0;
            do {
                try {
                    Console.Write("Please enter the " + message + " number: ");
                    number = double.Parse(Console.ReadLine());
                    validEntry = true;
                } catch (FormatException ex) {
                    printErrorMessage();
                }
            } while (!validEntry);
            return number;
        }

        static char getOperation() {
            char operation = '\0';
            bool validEntry = false;
            do {
                try {
                    Console.Write("Please enter the operation\na - addition\ns - substraction\n" +
                        "d - division \nm - multiplication\nr - remainder\n");
                    operation = char.Parse(Console.ReadLine());
                    if (operation == 'a' || operation == 's' || operation == 'd' || operation == 'm' || operation == 'r' ) {
                        validEntry = true;
                    } else {
                        printErrorMessage();
                    }
                } catch (Exception ex) {
                    printErrorMessage();
                }
            } while (!validEntry);
            return operation;
        }

        static void printErrorMessage() {
            Console.WriteLine("Error: this character seems not to be what we expect. Please enter it again.");
        }

        static double addition(double a, double b) {
            return a + b;
        }

        static double substraction(double a, double b) {
            return a - b;
        }

        static double division(double a, double b) {
            return a / b;
        }

        static double multiplication(double a, double b) {
            return a * b;
        }

        static double remainder(double a, double b) {
            return a % b;
        }

        static void printGoodByeMessage() {
            Console.WriteLine("Thanks for using the calculator app. Press 'ENTER' to close.");
            Console.ReadLine();
        }

        static void printWelcomeMessage() {
            Console.WriteLine("Welcome to the Calulator APP.");
            Console.WriteLine("Instructions: this calculator app handles the four basic operations for two numbers.\n" +
                "First, enter a number. Then, enter the operation. Last, enter the second number.");
            Console.WriteLine("\n\n***************************************************\n\n");
        }


    }
}
