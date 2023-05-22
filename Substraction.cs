using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Substraction
    {
        public static void Substract()
        {
            int a, b, result;

            Console.WriteLine("Enter first Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            b = Convert.ToInt32(Console.ReadLine());

            result = a - b;

            Console.WriteLine("{0} - {1} = {2}", a, b, result);
        }
    }
}
