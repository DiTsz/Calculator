using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "1) Enter 1st number;\n" +
                "2) Enter 2nd number;\n" +
                "3) Choose the operation (+, -, *, /, %)");
            Console.WriteLine();

            double a = EnterNum();
            double b = EnterNum();

            char symbol = Convert.ToChar(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    Console.WriteLine($"{a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a * b}");
                    break;
                case '/':
                    Console.WriteLine($"{a / b}");
                    break;
                case '%':
                    Console.WriteLine($"{a % b}");
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
            

            double EnterNum()
            {
                double num = Convert.ToDouble(Console.ReadLine());
                return num;
            }
        }
    }
}
