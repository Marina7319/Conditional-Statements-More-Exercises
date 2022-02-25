using System;

namespace _10._Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i =1; i > 0; i++) {  
                double num = double.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    double multiplyByTwo = num * 2;
                    Console.WriteLine($"Result: {multiplyByTwo:f2}");
                }
                else
                {
                    Console.WriteLine("Negative number!");
                    break;
                }
            }
        }
    }   
}
