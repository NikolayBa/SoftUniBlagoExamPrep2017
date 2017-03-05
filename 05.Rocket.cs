using System;

namespace ExamPrep
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;

            // top 
            for (int i = 0; i < n; i++)
            {
                int spaces = 2 * i;
                int dots = width - spaces - 2;

                Console.WriteLine("{0}/{1}\\{0}", new string('.', dots / 2), new string(' ', spaces));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n *2));

            // middle 
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2 - 2));
            }

            // bottom 
            for (int i = 0; i < n / 2; i++)
            {
                int stars = n * 2 - 2 + 2 * i;
                int dots = width - stars - 2;

                Console.WriteLine("{0}/{1}\\{0}", new string('.', dots / 2), new string('*', stars));
            }
        }
    }
}