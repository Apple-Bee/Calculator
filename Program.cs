using System;
using System.ComponentModel.Design;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /):");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = Add(num1, num2);
                        break;
                    case '-':
                        result = Subtract(num1, num2);
                        break;
                    case '*':
                        result = Multiply(num1, num2);
                        break;
                    case '/':
                        result = Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine($"Result: {result}");

                Console.WriteLine("Do you want to continue? (Y/N)");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice != 'Y' && choice != 'y')
                {
                    break;
                }
            }
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            if (num1 != 0 && num2 !=0)
                
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return double.NaN; // Return NaN (Not a Number) for division by zero
            }
        }
    }
}


