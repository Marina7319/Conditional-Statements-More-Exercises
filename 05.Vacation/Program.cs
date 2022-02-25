using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double num = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (num <= 1000)
            {
                switch(season)
                {
                    case "Summer":
                        double sumSum = num - num * 0.35;
                        Console.WriteLine($"Alaska - Camp - {sumSum:f2}");
                        break;
                    case "Winter":
                        double sumWinter = num - num * 0.55;
                        Console.WriteLine($"Morocco - Camp - {sumWinter:f2}");
                        break;
                }
            }
            if (num > 1000 && num <= 3000)
            {
                switch (season)
                {
                    case "Summer":
                        double sumSum = num - num * 0.2;
                        Console.WriteLine($"Alaska - Hut - {sumSum:f2}");
                        break;
                    case "Winter":
                        double sumWinter = num - num * 0.4;
                        Console.WriteLine($"Morocco - Hut - {sumWinter:f2}");
                        break;
                }
            }
            if (num >= 3000)
            {
                switch (season)
                {
                    case "Summer":
                        double sumSum = num - num * 0.1;
                        Console.WriteLine($"Alaska - Hotel - {sumSum:f2}");
                        break;
                    case "Winter":
                        double sumWinter = num - num * 0.1;
                        Console.WriteLine($"Morocco - Hotel - {sumWinter:f2}");
                        break;
                }
            }
        }
    }
}
