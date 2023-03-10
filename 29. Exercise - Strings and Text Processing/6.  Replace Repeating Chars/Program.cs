string str = Console.ReadLine();

char previousChar = str[0];
Console.Write(previousChar);
for (int i = 1; i < str.Length; i++)
{
    char currentChar = str[i];
    if (currentChar != previousChar)
    {
        previousChar = currentChar;
        Console.Write(previousChar);        
    }
}
