public class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            PrintLine(i);
        }
        for (int i = input - 1; i >= 1; i--)
        {
            PrintLine(i);
        }
    }
    static void PrintLine(int end)
    {
        for (int j = 1; j <= end; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}
