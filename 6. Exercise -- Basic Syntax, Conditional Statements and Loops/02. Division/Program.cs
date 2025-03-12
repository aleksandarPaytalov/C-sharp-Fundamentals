using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int higherDev = 0;

            if (num % 2 == 0)
            {
                higherDev = 2;
            }
            if (num % 3 == 0)
            {
                higherDev = 3;
            }
            if (num % 6 == 0)
             {
                 higherDev = 6;
             }
            if (num % 7 == 0)
             {
                 higherDev = 7;
             }
            if (num % 10 == 0)
             {
                 higherDev = 10;
             }
            if (num % 2 != 0 && num % 3 != 0 && num % 6 != 0 && num % 7 != 0 && num % 10 != 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }
            Console.WriteLine($"The number is divisible by {higherDev}");
        }
    }
}
