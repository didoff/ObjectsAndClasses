using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] orderedWords = Console.ReadLine().Split(' ');

            Random rdm = new Random();

            for (int i = 0; i < orderedWords.Length; i++)
            {

                // LOOK PLEASE. HOW TO EXCHANGE!

                int exchPos = rdm.Next(orderedWords.Length);
                string changer = orderedWords[i];
                orderedWords[i] = orderedWords[exchPos];
                orderedWords[exchPos] = changer;
            }

            foreach (var item in orderedWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
