using System.Linq;
using System.Text.RegularExpressions;

string pattern = @"\b(?<day>\d{2})([-|\.|/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

Regex regex = new Regex(pattern);
string input = Console.ReadLine();

MatchCollection result = regex.Matches(input);

foreach (Match item in result)
{
    //string day = item.Groups["day"].Value;
    //string month = item.Groups["month"].Value;
    //string year = item.Groups["year"].Value;

    var match = item.Groups;

    Console.WriteLine($"Day: {match["day"]}, Month: {match["month"]}, Year: {match["year"]}");
}

