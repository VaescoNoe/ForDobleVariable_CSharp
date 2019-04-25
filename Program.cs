using System;

namespace Procesos
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int  i = 0, j = 10;  i <=  j;  i++ , j--)
            {
                Console.WriteLine($"i={i}");
                Console.WriteLine($"j={j}");
            }

            for (; ; )
            {
                Console.WriteLine("infinito");
            }

        }
    }
}
