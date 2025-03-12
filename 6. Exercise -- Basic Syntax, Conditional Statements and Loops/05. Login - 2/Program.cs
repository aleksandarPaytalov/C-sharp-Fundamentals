using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string expectedPassword = new string(username.Reverse().ToArray());
            int failAttempts = 0;

            while (true)
            {
                string password = Console.ReadLine();
                if (expectedPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                else
                {
                    failAttempts++;

                    if (failAttempts > 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}
