using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderNum = int.Parse(Console.ReadLine());
            decimal total = 0;            

            for (int i = 1; i <= orderNum; i++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulNum = int.Parse(Console.ReadLine());
                decimal order = (days * capsulNum) * capsulePrice;
                total += order;
                Console.WriteLine($"The price for the coffee is: ${order:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
