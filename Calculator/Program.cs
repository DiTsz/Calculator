using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Do you want to calculate:\n" +
                "1) 2 numbers;\n" +
                "2) Factorial of the number;\n" +
                "Choose 1 or 2");
            Console.WriteLine();
            uint answer = Convert.ToUInt32(Console.ReadLine());
            switch (answer)
            {
                case 1: Calculate();
                    break;
                case 2: Factorial(); 
                    break;

            }
            Console.WriteLine();
  

           void Factorial()
            {
                Console.Write("Enter the number (0+): ");
                uint num = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine(FactorialCalc(num));

                uint FactorialCalc(uint n)
                {
                    if (n == 1 || n == 0) return n;
                    return n * FactorialCalc(n-1);
                }
            }

            void Calculate() 
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
}
