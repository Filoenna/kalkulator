using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Type first number: ");
            string x = Console.ReadLine();
            Console.WriteLine("Type second number: ");
            string y = Console.ReadLine();
            double xd = double.Parse(x);
            double yd = double.Parse(y);
            Console.Write("x + y = ");
            Console.WriteLine(xd + yd);
            Console.Write("x - y = ");
            Console.WriteLine(xd - yd);
            Console.Write("x * y = ");
            Console.WriteLine(xd * yd);
            Console.Write("x / y = ");
            Console.WriteLine(xd / yd);
            Console.Write("x % y = ");
            Console.WriteLine(xd % yd);
            Console.Write("y % x = ");
            Console.WriteLine(yd % xd);

            Console.ReadLine();
        }
    }
}
