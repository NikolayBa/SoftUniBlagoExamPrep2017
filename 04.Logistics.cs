using System;

namespace ExamPrep
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int busLoad = 0;
            int truckLoad = 0;
            int trainLoad = 0;

            int priceBus = 200;
            int priceTruck = 175;
            int priceTrain = 120;

            for (int i = 0; i < n; i++)
            {
                int currentLoad = int.Parse(Console.ReadLine());

                if (currentLoad <= 3)
                {
                    busLoad += currentLoad;
                }
                else if (currentLoad >= 4 && currentLoad <= 11)
                {
                    truckLoad += currentLoad;
                }
                else
                {
                    trainLoad += currentLoad;
                }
            }

            double totalLoad = busLoad + truckLoad + trainLoad;
            double average = (priceBus * busLoad + priceTruck * truckLoad + priceTrain * trainLoad) / totalLoad;

            Console.WriteLine("{0:F2}", average);
            Console.WriteLine("{0:F2}%", busLoad / totalLoad * 100);
            Console.WriteLine("{0:F2}%", truckLoad / totalLoad * 100);
            Console.WriteLine("{0:F2}%", trainLoad / totalLoad * 100);
        }
    }
}