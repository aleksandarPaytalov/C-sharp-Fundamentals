using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"([\=|\/])(?<location>[A-Z][A-Za-z]{2,})\1";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);
int travelPoints = 0;
List<String> list = new List<string>();

foreach (Match item in matches)
{
    travelPoints += item.Groups[2].Length;
    list.Add(item.Groups[2].Value);
}
//var result = matches.Select(x => x.Groups[2].Value);

Console.WriteLine($"Destinations: {string.Join(", ", list)}");
Console.WriteLine($"Travel Points: {travelPoints}");