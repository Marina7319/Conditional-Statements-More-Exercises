using System;

namespace _08._Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());//borders
            double y1 = double.Parse(Console.ReadLine());//borders
            double x2 = double.Parse(Console.ReadLine());//borders
            double y2 = double.Parse(Console.ReadLine());//borders
            double x = double.Parse(Console.ReadLine());//x 
            double y = double.Parse(Console.ReadLine());//y
            //bool xxx = (x == x1 || x == x2) && (y >= y1 && y <= y2);
           // bool yyy = (y == y1 || y == y2) && (x >= x1 && x <= x2);
            if (x == x1 || x == x2)
            { if (y >= y1 && y <= y2)
                {
                    Console.WriteLine("Border");
                }
            }
            if (y == y1 || y == y2)
            {
                if (x >= x1 && x <= x2)
                {
                    Console.WriteLine("Border");
                }
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
