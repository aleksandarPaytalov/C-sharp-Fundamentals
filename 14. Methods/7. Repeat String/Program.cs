using System.Diagnostics;

public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int repeatCount = int.Parse(Console.ReadLine());

        string results = GetNewString(input, repeatCount);
        Console.WriteLine(results);
    }
    
    static string GetNewString(string input, int count)
    {
        string result = string.Empty;

        for (int i = 0; i < count; i++)
        {
            result += input;
        }
        return result;
    }

}






