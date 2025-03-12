using System.Globalization;
using System.Net.Security;

public class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Print(input);
        
    }
    static void Print(int inputNumber)
    {
        if (inputNumber < 0)
        {
            Console.WriteLine($"The number {inputNumber} is negative.");
        }
        else if (inputNumber == 0)
        {
            Console.WriteLine($"The number {inputNumber} is zero. ");
        }
        else
        {
            Console.WriteLine($"The number {inputNumber} is positive.");
        }
    }
    
}