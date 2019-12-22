using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 2");

            Console.Write("R = ");

            double R = double.Parse(Console.ReadLine());

            Console.WriteLine($"S = {S(R)}");

            Console.ReadKey();
        }
        public static double S(double r)

        {

            return 2 * Math.Pow(r, 2);
        }
    }
}
