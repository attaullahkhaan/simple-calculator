using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tSimple Calculator\n");
            Console.WriteLine("My first Project in C# May, 2018\n");

            Console.WriteLine("----------------------------------------------\n");


            decimal number1, number2, result;
            string arithmeticOperator;

            Console.Write("Enter first Number : ");
            number1 = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter your Arithmetic operator [ + , - , * , / ]\n");
            Console.Write("Enter your Arithmetic operator : ");
            arithmeticOperator = Console.ReadLine();

            Console.Write("Enter second Number : ");
            number2 = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n----------------------------------------------\n");

            if (arithmeticOperator == "+")
            {
                result = number1 + number2;
                Console.WriteLine("Addition of two number is : {0}", result);
            }
            else if (arithmeticOperator == "-")
            {
                result = number1 - number2;
                Console.WriteLine("Subtraction of two number is : {0}", result);
            }
            else if (arithmeticOperator == "*")
            {
                result = number1 * number2;
                Console.WriteLine("Multiplication of two number is : {0}", result);
            }
            else if (arithmeticOperator == "/")
            {
                result = number1 / number2;
                Console.WriteLine("Division of two number is : {0}", result);
            }
            else
            {
                Console.WriteLine("Arithmetic Operator is not Valid");
            }
            Console.ReadKey();
        }
    }
}

