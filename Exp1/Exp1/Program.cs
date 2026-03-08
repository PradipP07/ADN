using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Enter Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double add = num1 + num2;
            double sub = num1 - num2;
            double mul = num1 * num2;
            double div = num2 / num2;

            Console.WriteLine("Addition is: " + add);
            Console.WriteLine("Subtraction is: " + sub);
            Console.WriteLine("Multiplication is: "+ mul);
            Console.WriteLine("Division is: "+ div);
        }
    }
}
