char firstChar = char.Parse(Console.ReadLine());
char secondChar = char.Parse(Console.ReadLine());
string randomString = Console.ReadLine();

int sum = 0;
foreach (var letter in randomString)
{
    if (firstChar > secondChar)
    {
        if (letter > secondChar && letter < firstChar)
        {
            sum += letter;
        }
    }
    else
    {
        if (letter > firstChar && letter < secondChar)
        {
            sum += letter;
        }
    }
}
Console.WriteLine(sum);