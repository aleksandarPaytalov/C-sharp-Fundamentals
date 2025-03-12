public class Program
{
    static void Main()
    { 
    string input = Console.ReadLine();

        if (input == "string")
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string max = GetMax(a, b);
            Console.WriteLine(max);
        }
        else if (input == "int")
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int maxValue = GetMax(a, b);
            Console.WriteLine(maxValue);
        }
        else if (input == "char")
        {   
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            
            char maxValue = GetMax(a, b);
            Console.WriteLine(maxValue);

        }
            

    }

    private static char GetMax(char a, char b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }
    private static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }          
    private static string GetMax(string a, string b)
    {
        int result = a.CompareTo(b);

        if (result > 0)
        {
            return a;
        }
        return b;
    }
}