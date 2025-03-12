using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    price = people * 8.45;
                }
                else if (groupType == "Business")
                {
                    price = people * 10.90;
                }
                else if (groupType == "Regular")
                {
                    price = people * 15;
                }
            }
            else if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    price = people * 9.80;
                }
                else if (groupType == "Business")
                {
                    price = people * 15.60;
                }
                else if (groupType == "Regular")
                {
                    price = people * 20;
                }
            }
            else if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    price = people * 10.46;
                }
                else if (groupType == "Business")
                {
                    price = people * 16;
                }
                else if (groupType == "Regular")
                {
                    price = people * 22.50;
                }
            }
            if (groupType == "Students" && people >= 30)
                price -= price * 0.15;
            else if (groupType == "Business" && people >= 100)
            {
                if (day == "Friday")
                    price -= 10 * 10.90;
                else if (day == "Saturday")
                    price -= 10 * 15.60;
                else
                    price -= 10 * 16;
            }
            else if (groupType == "Regular" && people >= 10 && people <= 20)
                price -= price * 0.05;

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
