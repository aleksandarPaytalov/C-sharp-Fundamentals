class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()); //2
        int b = int.Parse(Console.ReadLine()); //5
        int c = int.Parse(Console.ReadLine()); //3

        GetSmallestNumber(a, b, c);
    }

    private static void GetSmallestNumber(int a, int b, int c)
    {
        if (a < b && a <= c)
        {
            Console.WriteLine(a);
        }
        else if (b < a && b <= c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}