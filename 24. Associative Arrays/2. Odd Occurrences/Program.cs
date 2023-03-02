string[] words = Console.ReadLine()
    .Split()
    .ToArray();

Dictionary<string, int> wordsCounter = new Dictionary<string, int>();

for (int i = 0; i < words.Length; i++)
{
    string wordToLowerCase = words[i].ToLower();

    if (wordsCounter.ContainsKey(wordToLowerCase))
    {
        wordsCounter[wordToLowerCase]++;
    }
    else
    {
        wordsCounter.Add(wordToLowerCase, 1);    
    }
}

foreach (var word in wordsCounter)
{
    if (word.Value % 2 != 0)
    {
        Console.Write($"{word.Key} ");
    }
}