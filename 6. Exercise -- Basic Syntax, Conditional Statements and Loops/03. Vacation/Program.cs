using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = people * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = people * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = people * 10.46;
                }
                if (people >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = people * 10.90;
                    if (people >= 100)
                    {
                        totalPrice -= 10 * 10.90;
                    }
                }
                else if (day == "Saturday")
                {
                    totalPrice = people * 15.60;
                    if (people >= 100)
                    {
                        totalPrice -= 10 * 15.60;
                    }
                }
                else if (day == "Sunday")
                {
                    totalPrice = people * 16;
                    if(people >= 100)
                    {
                        totalPrice -= 10 * 16;
                    }
                }                
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = people * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = people * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = people * 22.50;
                }
                if (people >= 10 && people <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
