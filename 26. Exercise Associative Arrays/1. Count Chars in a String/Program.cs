string input = Console.ReadLine();

Dictionary<char, int> letters = new Dictionary<char, int>();
for (int i = 0; i < input.Length; i++) //text
{
    char currentLetter = input[i];
    if (currentLetter != ' ')
    {
        if (!letters.ContainsKey(currentLetter))
        {
            letters.Add(currentLetter, 0);
        }
        letters[currentLetter]++;
    }
}
foreach (var letter in letters)
{
    Console.WriteLine($"{letter.Key} -> {letter.Value}");
}

