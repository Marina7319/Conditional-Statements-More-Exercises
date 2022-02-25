using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrissantemsFlowers = int.Parse(Console.ReadLine());
            int rosesFlowers = int.Parse(Console.ReadLine());
            int tulipsFlowers = int.Parse(Console.ReadLine());
            string seasons = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());
            double hrissantemsSumSpr = hrissantemsFlowers * 2;
            double rosesSumSpr = rosesFlowers * 4.1;
            double tulipsSumSpr = tulipsFlowers * 2.5;
            double hrissantemsAutmWin = hrissantemsFlowers * 3.75;
            double rosesAutumWin = rosesFlowers * 4.5;
            double tulipsAutmWin = tulipsFlowers * 4.15;
            double bouquetSprSum = hrissantemsSumSpr + rosesSumSpr + tulipsSumSpr;
            double bouquetAutWin = hrissantemsAutmWin + rosesAutumWin + tulipsAutmWin;
            double result = 0;
            int flowers = hrissantemsFlowers + rosesFlowers + tulipsFlowers;
            if (holiday == 'Y')
            {
                double HolidayPriceSprSum = bouquetSprSum + bouquetSprSum * 0.15;
                double HolidayPriceAutWin = bouquetAutWin + bouquetAutWin * 0.15;
                switch (seasons)
                {
                    case "Spring":
                        if (tulipsFlowers >= 7)
                        {
                            double discountTulips = HolidayPriceSprSum - HolidayPriceSprSum * 0.05;
                            result = discountTulips;
                        }
                        else
                        {
                            result = HolidayPriceSprSum;
                        }
                        break;
                    case "Summer":
                        result = HolidayPriceSprSum;
                        break;
                    case "Autumn":
                        result = HolidayPriceAutWin;
                        break;
                    case "Winter":
                        if (rosesFlowers >= 10)
                        {
                            double discountRoses = HolidayPriceAutWin - HolidayPriceAutWin * 0.1;
                            result = discountRoses;
                        }
                        else
                        {
                            result = HolidayPriceAutWin;
                        }
                        break;
                }
            } else
            {
                switch (seasons)
                {
                    case "Spring":
                        if (tulipsFlowers >= 7)
                        {
                            double discountTulips = bouquetSprSum - bouquetSprSum * 0.05;
                            result = discountTulips;
                        }
                        else
                        {
                            result = bouquetSprSum;
                        }
                        break;
                    case "Summer":
                        result = bouquetSprSum;
                        break;
                    case "Autumn":
                        result = bouquetAutWin;
                        break;
                    case "Winter":
                        if (rosesFlowers >= 10)
                        {
                            double discountRoses = bouquetAutWin - bouquetAutWin * 0.1;
                            result = discountRoses;
                        }
                        else
                        {
                            result = bouquetAutWin;
                        }
                        break;
                }
            }
            if (flowers >= 20)
            {
                double bouquetPrice = result - result * 0.2;
                result = bouquetPrice;
            }
            double sum = result + 2;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
