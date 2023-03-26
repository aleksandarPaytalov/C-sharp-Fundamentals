using System.Numerics;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string emojiPattern = @"(\:{2}|\*{2})(?<emojiName>[A-Z][a-z]{2,})\1";
string numbersPattern = @"\d";

Regex emojiRegex = new Regex(emojiPattern);
Regex numbersRegex = new Regex(numbersPattern);

MatchCollection emojies = emojiRegex.Matches(input);
MatchCollection numbers = numbersRegex.Matches(input);

long coolTresh = 1;
foreach (Match number in numbers)
{
    coolTresh *= int.Parse(number.Value);    ;
}
Console.WriteLine($"Cool threshold: {coolTresh}");
Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");

foreach (Match emoji in emojies)
{
	int coolness = 0;

	var currEmoji = emoji.Groups["emojiName"].Value;
    for (int i = 0; i < currEmoji.Length; i++)
	{
		coolness += currEmoji[i];
	}

	if (coolness >= coolTresh)
	{
		Console.WriteLine(emoji);
	}
}
