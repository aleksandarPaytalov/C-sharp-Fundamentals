using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCoppy = num;
            int numSum = 1;
            int factorialsSum = 0;

            while (numCoppy > 0)
            {
                int digit = numCoppy % 10;
                numCoppy = numCoppy / 10;

                for (int i = 1; i <= digit; i++)
                {
                    numSum *= i;
                }
                factorialsSum += numSum;
                numSum = 1;
            }
            if (factorialsSum == num)
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }

        }
    }
}
