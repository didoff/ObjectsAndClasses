using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigFactorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger fact = 1;

            for (int i = number; i > 1; i--)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
