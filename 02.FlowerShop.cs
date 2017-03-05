using System;

namespace ExamPrep
{
    class Program
    {
        static void Main()
        {

            int magnolii = int.Parse(Console.ReadLine());
            int ziumbiuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double profitNoTax = 3.25 * magnolii + 4 * ziumbiuli + 3.5 * rozi + 8 * kaktusi;
            double profit = 0.95 * profitNoTax;

            double difference = profit - giftPrice;

            if(difference >= 0)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(difference));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(-difference));
            }



        }
    }
}