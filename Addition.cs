using System;

namespace Calculator
{
    public class Addition
    {
        public static void Add()
        {
            int a, b, result;

            Console.WriteLine("Enter first Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            b = Convert.ToInt32(Console.ReadLine());

            result = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, result);
        }
    }
}
