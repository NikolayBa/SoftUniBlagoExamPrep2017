using System;

namespace ExamPrep
{
    class Program
    {
        static void Main()
        {
            int juniorsN = int.Parse(Console.ReadLine());
            int seniorsN = int.Parse(Console.ReadLine());
            string roadType = Console.ReadLine();

            double sum = 0;

            if (roadType == "trail")
            {
                sum = juniorsN * 5.5 + seniorsN * 7;
            }
            else if (roadType == "cross-country")
            {
                sum = juniorsN * 8 + seniorsN * 9.5;

                // discount
                if (juniorsN + seniorsN >= 50)
                {
                    sum = sum * 0.75;
                }
            }
            else if (roadType == "downhill")
            {
                sum = juniorsN * 12.25 + seniorsN * 13.75;
            }
            // road
            else
            {
                sum = juniorsN * 20 + seniorsN * 21.5;
            }

            // expenses
            sum = sum * 0.95;

            Console.WriteLine("{0:F2}", sum);
        }
    }
}