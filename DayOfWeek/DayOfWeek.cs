using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split('-')
                .Select(a => int.Parse(a))
                .ToArray();

            DateTime dayOfWeek = new DateTime(input[2], input[1], input[0]);

            Console.WriteLine(dayOfWeek.DayOfWeek);

        }
    }
}
