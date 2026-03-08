using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp4
{
    
    internal class Program
    {
        //Delegate
        public delegate int Opr(int a, int b);

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int sub(int x, int y)
        {
            return x - y;
        }

        public delegate void Show();
        public static void Method1()
        {
            Console.WriteLine("Method1 Executed");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 Executed");
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter No.: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No.: ");
            num2 = Convert.ToInt32(Console.ReadLine());

           
            //Lambda Exp
            Func<int, int, int > mul = (a , b) => a * b;
            Func<int, int, int> div = (a, b) => a / b;

            //Objects
            Opr o1 = Add;
            Opr o2 = sub;

            Show o3 = Method1;
            o3 += Method2; // multicast delegate

            Console.WriteLine("Using Delegate:");
            Console.WriteLine("Add is: " + o1(num1, num2));
            Console.WriteLine("Sub is: "+ o2(num1, num2));

            Console.WriteLine("Multi-Cast Delegate:");
            o3();

            Console.WriteLine("Using Lambda:");
            Console.WriteLine("Mul is: " + mul(num1, num2));
            Console.WriteLine("Div is: " + div(num1, num2));

            //Sort list using Lambda
            List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };

            numbers.Sort((a, b) => a.CompareTo(b));
            Console.WriteLine("Sorted List Using Lambda:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
