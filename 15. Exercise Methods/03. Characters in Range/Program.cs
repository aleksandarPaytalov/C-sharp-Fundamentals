class Program
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());

        PrintCharsBetween(first, second);
    
    }

    private static void PrintCharsBetween(char first, char second)
    {
        int firstDigit = first;
        int secondDigit = second;

        if (firstDigit < secondDigit)
        {
            for (int i = firstDigit + 1; i < secondDigit; i++)
            {
                char currentLetter = Convert.ToChar(i);
                Console.Write(currentLetter + " ");
            }
        }
        else
        {
            for (int i = secondDigit + 1; i < firstDigit; i++)
            {
                char currentLetter = Convert.ToChar(i);
                Console.Write(currentLetter + " ");
            }
        }
    }
}