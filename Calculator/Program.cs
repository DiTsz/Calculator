using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Do you want to calculate:\n" +
                "1) Calculate numbers;\n" +
                "2) Factorial of the number;\n");
            Console.Write("Your choice: ");
 
            uint answer = Convert.ToUInt32(Console.ReadLine());
            switch (answer)
            {
                case 1: Calculate();
                    break;
                case 2: Factorial(); 
                    break;
                default:
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
               "2) Choose the operation (+, -, *, /, %)\n" +
               "3) Enter 2nd number;" +
               "* You can enter \"qqq\" to exit the calculaton at any step.\n");

                double firstValue = 0;
                bool isFirstValueSet = false;

                while (true)
                {
                    if (!isFirstValueSet)
                    {
                        string firstInput = Console.ReadLine();

                        if (firstInput.ToLower() == "qqq")
                            break;

                        try
                        {
                            firstValue = double.Parse(firstInput);
                            isFirstValueSet = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                    else
                    {
                        string operatorInput = Console.ReadLine();

                        if (operatorInput.ToLower() == "qqq")
                            break;

                        if (operatorInput != "+" && operatorInput != "-" && operatorInput != "*" && operatorInput != "/" && operatorInput != "%")
                        {
                            Console.WriteLine("Error: Invalid operator.");
                            continue;
                        }

                        string secondInput = Console.ReadLine();

                        if (secondInput.ToLower() == "qqq")
                            break;

                        try
                        {
                            double secondValue = double.Parse(secondInput);
                            double result = 0;

                            switch (operatorInput)
                            {
                                case "+":
                                    result = firstValue + secondValue;
                                    break;
                                case "-":
                                    result = firstValue - secondValue;
                                    break;
                                case "*":
                                    result = firstValue * secondValue;
                                    break;
                                case "/":
                                    if (secondValue != 0)
                                        result = firstValue / secondValue;
                                    else
                                        Console.WriteLine("Error: Division by zero is not allowed.");
                                    break;
                                case "%": 
                                    result = firstValue % secondValue;
                                    break;
                                default:
                                    break;
                            }

                            Console.WriteLine("= " + result);
                            firstValue = result;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }

                    // Console.WriteLine();
                }
            }
        }
    }
}
