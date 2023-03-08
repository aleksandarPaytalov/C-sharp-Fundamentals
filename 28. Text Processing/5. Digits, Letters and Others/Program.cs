string word = Console.ReadLine();

for (int i = 0; i < word.Length; i++)
{
    char letter = word[i];
    if (char.IsDigit(letter))
    {
        Console.Write(letter);
    }
}
Console.WriteLine();
for (int i = 0; i < word.Length; i++)
{
    char letter = word[i];
    if (char.IsLetter(letter))
    {
        Console.Write(letter);
    }
}
Console.WriteLine();
for (int i = 0; i < word.Length; i++)
{
    char letter = word[i];
    if (!char.IsLetter(letter) && !char.IsDigit(letter))
    {
        Console.Write(letter);
    }
}


