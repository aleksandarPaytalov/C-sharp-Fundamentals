using System.Text;
using System.Text.RegularExpressions;

string words = Console.ReadLine();
string pattern = @"([\@|\#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(words);

if (matches.Count == 0)
{
    Console.WriteLine("No word pairs found!");
    Console.WriteLine("No mirror words!");
}
else
{
    Console.WriteLine($"{matches.Count} word pairs found!");
    List<string> mirrorWords = new List<string>();    
    foreach (Match item in matches)
    {
        var firstWord = item.Groups["firstWord"].Value;
        var secondWord = item.Groups["secondWord"].Value;
        StringBuilder str = new StringBuilder();
        for (int i = firstWord.Length - 1; i >= 0; i--)
        {
            str.Append(firstWord[i]);
        }
        if (str.ToString() == secondWord)
        {
            mirrorWords.Add($"{firstWord} <=> {secondWord}");
        }
    }
    if (mirrorWords.Count == 0)
    {
        Console.WriteLine("No mirror words!");
    }
    else
    {
        Console.WriteLine("The mirror words are:");
        Console.WriteLine(string.Join(", ", mirrorWords));
    }    
}

