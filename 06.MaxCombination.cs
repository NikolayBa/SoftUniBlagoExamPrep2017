using System;

namespace ExamPrep
{
    class Program
    {
        static void Main()
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int count = 0;

            int maxCombinations = int.Parse(Console.ReadLine());

            for (int i = beginning; i <= end; i++)
            {
                for (int j = beginning; j <= end; j++)
                {
                    count++;
                    if (count <= maxCombinations)
                    {
                        Console.Write("<{0}-{1}>", i, j);
                    }
                    else
                    {
                        //exit out of the two loops
                        i = end + 1;
                        break;
                    }
                }
            }
           

        }
    }
}