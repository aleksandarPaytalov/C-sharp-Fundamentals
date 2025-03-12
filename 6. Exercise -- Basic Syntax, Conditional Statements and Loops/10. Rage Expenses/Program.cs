using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            decimal expensesSum = 0m;            
            int lostCount = 0;
            int lostCounterDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {                
                if (i % 2 == 0 && i % 3 == 0) 
                {
                    lostCount++;
                    expensesSum += headsetPrice + mousePrice + keyboardPrice;
                    if (lostCount % 2 == 0)
                    {
                        lostCounterDisplay++;
                        expensesSum += displayPrice;
                    }                    
                }
                else if (i % 2 == 0)
                {
                    expensesSum += headsetPrice;
                }
                else if (i % 3 == 0)
                {
                    expensesSum += mousePrice;
                }
            }
            Console.WriteLine($"Rage expenses: {expensesSum:f2} lv.");
        }
    }
}
