using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if(budget <= 100)
            {
                Console.WriteLine("Economy class");
                if(season == "Summer")
                {
                    double price = budget - budget * 0.65;
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
                if(season == "Winter")
                {
                    double price = budget - budget * 0.35;
                    Console.WriteLine($"Jeep - {price:f2}");
                }
            }
            if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    double price = budget - budget * 0.55;
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
                if (season == "Winter")
                {
                    double price = budget - budget * 0.2;
                    Console.WriteLine($"Jeep - {price:f2}");
                }
            }
            if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                double price = budget - budget * 0.1;
                Console.WriteLine($"Jeep - {price:f2}");               
            }           
        }
    }
}
