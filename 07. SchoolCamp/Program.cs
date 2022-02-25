using System;

namespace _07._SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int kidsInSchool = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sports = "";
            double result = 0.0;
            double price = 0.0;
            switch(group) 
            {
                case "girls":
                    if (season == "Winter")
                    {
                        sports = "Gymnastics";
                    }
                    if (season == "Spring")
                    {

                        sports = "Athletics";

                    }
                    if (season == "Summer")
                    {
                        sports = "Volleyball";
                    }
                    break;
                case "boys":
                    if (season == "Winter")
                    {
                        sports = "Judo";
                    }
                    if (season == "Spring")
                    {

                        sports = "Tennis";

                    }
                    if (season == "Summer")
                    {
                        sports = "Football";
                    }
                    break;
                case "mixed":
                    if (season == "Winter")
                    {
                        sports = "Ski";
                    }
                    if (season == "Spring")
                    {

                        sports = "Cycling";

                    }
                    if (season == "Summer")
                    {
                        sports = "Swimming";
                    }
                    break;
            }
            switch (group)
            {
                case "boys":
                case "girls":
                    if (season == "Winter")
                    {
                        double sumWinter = nights * 9.6 * kidsInSchool;
                        result = sumWinter;
                    }
                    if (season == "Spring")
                    {
                        double sumSpring = nights * 7.2 * kidsInSchool;
                        result = sumSpring; ;

                    }
                    if (season == "Summer")
                    {
                        double sumSummer = nights * 15 * kidsInSchool;
                        result = sumSummer;
                    }
                    break;
                case "mixed":               
                    if (season == "Winter")
                    {
                        double sumWinter = nights * 10 * kidsInSchool;
                        result = sumWinter;
                    }
                    if (season == "Spring")
                    {
                        double sumSpring = nights * 9.50* kidsInSchool;
                        result = sumSpring;
                    }
                    if (season == "Summer")
                    {
                        double sumSummer = nights * 15* kidsInSchool;
                        result = sumSummer;
                    }
                    break;
            }
            if (kidsInSchool >= 50)
            {
                double sum = result -  0.5 * result;
                price = sum;             
            }
            if (kidsInSchool >= 20 && kidsInSchool < 50)
            {
                double sum = result - result * 0.15;
                price = sum;
            }
            if (kidsInSchool <= 10  && kidsInSchool < 20)
            {
                double sum = result - result * 0.05;
                price = sum;               
            }
            if (kidsInSchool < 10)
            {             
                price = result;
            }
            Console.WriteLine($"{sports} {price:f2} lv.");
        }
    }
}
