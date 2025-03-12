class Program
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());

        int a = first;
        int b = second;
        Console.WriteLine(a);
        Console.WriteLine(b);

        char currentDigit = To.char(first + 1);
    }
   
}