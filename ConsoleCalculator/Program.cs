/************************************************************************
 * Practical Math Basic in C#
 * author: Soediro
 ************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Simple Console Calculator");
            Console.WriteLine("\n");
            // enter the first value
            Console.WriteLine("enter a first value");
            string firstValueAsAText = Console.ReadLine();
            double firstValue = Convert.ToDouble(firstValueAsAText);

            Console.WriteLine("enter an operand (e.g: +,-,/ or *)");
            string operandAsAText = Console.ReadLine();
            char anOperand = Convert.ToChar(operandAsAText);

            Console.WriteLine("enter a second value");
            string secondValueAsAText = Console.ReadLine();
            double secondValue = Convert.ToDouble(secondValueAsAText);

            if (anOperand == '+')
            {
                double sum = firstValue + secondValue;
                Console.WriteLine("the result is: " + sum);
            }
            else if(anOperand == '-')
            {
                double sub = firstValue - secondValue;
                Console.WriteLine("the result is: " + sub);
            }
            else if (anOperand == '*')
            {
                double mul = firstValue * secondValue;
                Console.WriteLine("the result is: " + mul);
            }
            else if (anOperand == '/')
            {
                double div = firstValue / secondValue;
                Console.WriteLine("the result is: " + div);
            }
            else
            {
                Console.WriteLine("wrong operand");
            }
            Console.ReadKey();
        }
    }
}
