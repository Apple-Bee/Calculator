using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            char operation = '\0';
            bool validInput = false;

            // Prompt the user for valid input numbers and operation
            do
            {
                try
                {
                    Console.WriteLine("Enter the first number:");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the second number:");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the operation (+, -, *, /):");
                    operation = Convert.ToChar(Console.ReadLine());

                    // Check if the operation is valid
                    if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number out of range. Please enter a smaller number.");
                }
            } while (!validInput);

            double result = 0;

            try
            {
                // Perform calculation based on the operation
                switch (operation)
                {
                    case '+':
                        result = Calc.Add(num1, num2);
                        break;
                    case '-':
                        result = Calc.Subtract(num1, num2);
                        break;
                    case '*':
                        result = Calc.Multiply(num1, num2);
                        break;
                    case '/':
                        result = Calc.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        return;
                }

                // Output the result
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Ask user if they want to continue
            Console.WriteLine("Do you want to continue? (Y/N)");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'Y' || choice == 'y')
            {
                Main(args); // Recursive call to restart the program
            }
        }
    }
}

