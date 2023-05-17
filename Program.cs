using System;

namespace Calculator
{
    class Program
    {
        static void addition()
        {
            int a, b, result;

            Console.WriteLine("Enter first Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            b = Convert.ToInt32(Console.ReadLine());

            result = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator"); 
            Program.addition();
        }
    }
}