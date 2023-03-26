using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalBoxes = 0;

        for (int i = 0; i < n; i++)
        {
            int flour = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            int cocoa = int.Parse(Console.ReadLine());

            int flourCups = flour / 140;
            int sugarSpoons = sugar / 20;
            int cocoaSpoons = cocoa / 10;
            int minValue = Math.Min(Math.Min(flourCups, sugarSpoons), cocoa);

            if (flourCups <= 0 || sugarSpoons <= 0 || cocoaSpoons <= 0)
            {
                Console.WriteLine("Ingredients are not enough for a box of cookies.");
            }
            else
            {
                int totalCookiesPerBake = ((140 + 10 + 20) * minValue) / 25;
                int totalBoxesCurrentBake = totalCookiesPerBake / 5;
                totalBoxes += totalBoxesCurrentBake;
                Console.WriteLine($"Boxes of cookies: {totalBoxesCurrentBake}");
            }
        }
        Console.WriteLine($"Total boxes: {totalBoxes}");
    }
}