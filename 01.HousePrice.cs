using System;

namespace ExamPrep
{
    class Program
    {
        static void Main()
        {

            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double pricePerSqM = double.Parse(Console.ReadLine());

            double bathroom = 0.5 * smallestRoom;
            double secondRoom = 1.1 * smallestRoom;
            double thirdRoom = 1.1 * secondRoom;

            double totalAreaNoCorrdor = smallestRoom + secondRoom + thirdRoom + bathroom + kitchen;
            double totalArea = 1.05 * totalAreaNoCorrdor;

            double price = totalArea * pricePerSqM;

            Console.WriteLine("{0:F2}", price);

        }
    }
}