using System;
using System.Linq;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string product = string.Empty;
            decimal coinsSum = 0m; //m
            while ((input = Console.ReadLine()) != "Start")
            {
                decimal coins = decimal.Parse(input);

                if (coins == 0.1m || coins == 0.2m || coins == 0.5m || coins == 1m || coins == 2m)
                {
                    coinsSum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts")
                {
                    if (coinsSum >= 2.0m)
                    {
                        coinsSum -= 2.0m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (coinsSum >= 0.7m)
                    {
                        coinsSum -= 0.7m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (coinsSum >= 1.5m)
                    {
                        coinsSum -= 1.5m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (coinsSum >= 0.8m)
                    {
                        coinsSum -= 0.8m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (coinsSum >= 1.0m)
                    {
                        coinsSum -= 1.0m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {coinsSum:f2}");
        }
    }
}
