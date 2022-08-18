using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomness
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random(); // or else Random rand = new Random();

            Console.WriteLine(rand.Next());

            Console.WriteLine(rand.Next(26)); // Lower than 26

            Console.WriteLine(rand.Next(47,72)); // Between 47 and 72

            double val = (rand.NextDouble() * (100));

            Console.WriteLine(val);

            for (int j = 0; j < 6; j++)
                Console.Write(" {0,7} ", rand.Next());

            Console.ReadKey();
        }
    }
}
