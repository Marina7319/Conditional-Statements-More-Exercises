using System;

namespace _06._TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double result = 0.0;
            if (kilometers <= 5000)
            {
                if (text == "Spring" || text == "Autumn")
                {
                    double sum = kilometers * 0.75 * 4;
                    double taxes = sum * 0.1;
                    result = sum - taxes;
                }
                if (text == "Summer")
                {
                    double sum = kilometers * 0.9 * 4;
                    double taxes = sum * 0.1;
                    result = sum - taxes;
                }
                if (text == "Winter")
                {
                    double sum = kilometers * 1.05 * 4;
                    double taxes = sum * 0.1;
                    result = sum - taxes;
                }
            }
            if (5000 < kilometers && kilometers <= 10000)
            {
                if (text == "Spring" || text == "Autumn")
                {
                    double sum = kilometers * 0.95 * 4;
                    double taxes = sum * 0.1;
                    result = sum - taxes;
                }
                if (text == "Summer")
                {
                    double sum = kilometers * 1.1 * 4;
                    double taxes = sum * 0.1;
                    result = sum - taxes;
                }
                if (text == "Winter")
                {
                    double sum = kilometers * 1.25 * 4;
                    double taxes = sum * 0.1;
                    result = sum - taxes;
                }
            }
            if (10000 < kilometers && kilometers <= 20000)
            {
                double sum = kilometers * 1.45 * 4;
                double taxes = sum * 0.1;
                result = sum - taxes;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
