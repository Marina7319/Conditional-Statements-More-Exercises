using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();
            int total = juniors + seniors;
            double result = 0;
            double crossCountryTaxJuniors = 8 - 8 * 0.25;
            double crossCountryTaxSeniors = 9.5 - 9.5 * 0.25;
            //изчисляване таксата за велосипедистите 
            if (trace == "trail")
            {
                double taxJuniors= juniors * 5.50;
                double taxSeniors = seniors * 7;
                result = taxJuniors + taxSeniors;
            }
            if (trace == "cross-country")
            {
                double taxJuniors = juniors * 8;
                double taxSeniors = seniors * 9.50;
                result = taxJuniors + taxSeniors;
            }
            if (trace == "downhill")
            {
                double taxJuniors = juniors * 12.25;
                double taxSeniors = seniors * 13.75;
                result = taxJuniors + taxSeniors;
            }
            if (trace == "road")
            {
                double taxJuniors = juniors * 20;
                double taxSeniors = seniors * 21.50;
                result = taxJuniors + taxSeniors;
            }
            //повече участници в cross -country  
            if(trace == "cross-country" && total >= 50)
            {                
                double taxJuniors = juniors * crossCountryTaxJuniors;
                double taxSeniors = seniors * crossCountryTaxSeniors;
                result = taxJuniors + taxSeniors;
            }
            double spendMoney = result - result * 0.05;
            //отпечатване на резултата
            Console.WriteLine($"{spendMoney:f2}");
        }
    }
}
