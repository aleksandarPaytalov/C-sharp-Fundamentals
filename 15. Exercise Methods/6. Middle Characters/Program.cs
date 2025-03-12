class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string result = GetMiddleChar(input); //someText    //aString
        Console.WriteLine(result);
    }
    // 1.
    //static string GetMiddleChar(string input)
    //{
    //    string lettersToPrint = string.Empty;
    //    char currentDiggit = ' ';
    //    if (input.Length % 2 != 0)
    //    {
    //        currentDiggit = input[input.Length / 2];
    //        lettersToPrint += currentDiggit;
    //    }
    //    else if (input.Length % 2 == 0)
    //    {
    //        currentDiggit = input[(input.Length - 1) / 2];
    //        lettersToPrint += currentDiggit;
    //        currentDiggit = ' ';
    //        currentDiggit = input[(input.Length + 1) / 2];
    //        lettersToPrint += currentDiggit;            
    //    }
    //    return lettersToPrint;
    //}
    // 2.
    static string GetMiddleChar(string input)
    {
        string lettersToPrint = string.Empty;
        if (input.Length % 2 != 0)
        {
            lettersToPrint = input[input.Length / 2].ToString();
        }
        else if (input.Length % 2 == 0)
        {
            lettersToPrint = input[(input.Length - 1) / 2].ToString() + input[(input.Length + 1) / 2];
        }
        return lettersToPrint;
    }
}