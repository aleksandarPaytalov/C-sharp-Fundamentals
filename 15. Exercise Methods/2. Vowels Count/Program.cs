class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        int vowelsSum = GetSumOfVowels(input);
        Console.WriteLine(vowelsSum);
    }

    private static int GetSumOfVowels(string input)
    {
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char currentLetter = Char.ToLower(input[i]);
            switch (currentLetter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    sum++;
                    break;
            }
        }
        return sum;
    }
}
