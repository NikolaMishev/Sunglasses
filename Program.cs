using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', (2 * n)));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', (2 * n)));
            Console.WriteLine();
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('/', (2 * n - 2)));
                Console.Write(new string('*', 1));

                if (row == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write(new string('*', 1));
                Console.Write(new string('/', (2 * n - 2)));
                Console.Write(new string('*', 1));

                Console.WriteLine();
            }
            Console.Write(new string('*', (2 * n)));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', (2 * n)));
            Console.WriteLine();
        }
    }
}
