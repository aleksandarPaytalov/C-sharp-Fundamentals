class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        FindTopNumbers(input);

    }

    static void FindTopNumbers(int input)
    {
        for (int i = 16; i <= input; i++) // от 16, защото първото число, което ще отговаря на условията винаги ще е 17, затова няма смисъл да проверяваме числата преди това
        {
            int currentDigit = i % 10;
            int number = i / 10;
            if ((currentDigit + number) % 8 == 0 && (currentDigit % 2 == 1 ||number % 2 == 1))
            {
                Console.WriteLine(i);
            }
        }
    }
}