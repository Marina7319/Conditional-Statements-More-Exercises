using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int participants = int.Parse(Console.ReadLine());
            double result = 0;
            double sum = 0;
            //определяне броя на членовете 
            if (participants >= 1 && participants <= 4)
            {
                result = budget - budget * 0.75;//1000-750=250
            }
            if (participants >= 5 && participants <= 9)
            {
                result = budget - budget * 0.6;
            }
            if (participants >= 10 && participants <= 24)
            {
                result = budget - budget * 0.5;
            }
            if (participants >= 25 && participants <= 49)
            {
                result = budget - budget * 0.4;
            }
            if (participants >= 50)
            {
                result = budget - budget * 0.25;
            }
            if (category == "VIP") {
                 sum = participants * 499.99;
            }
            if (category == "Normal") {
                 sum = participants * 249.99;
            }
            
            if(result > sum)
            {
                double total = result - sum;
                Console.WriteLine($"Yes! You have {total:f2} leva left.");
            } 
            else
            {
                double moneyNeed = sum - result;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
        }
    }
}
