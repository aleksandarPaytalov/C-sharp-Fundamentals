using System.Security;
using System.Text.RegularExpressions;

List<string> participants = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .ToList();
string pattern = @"[^_|\W]";
Regex regex = new Regex(pattern);

Dictionary<string, int> racers = new Dictionary<string, int>();

string input = string.Empty;
while ((input = Console.ReadLine()) != "end of race")
{
    MatchCollection result = regex.Matches(input);
    string racerName = string.Empty;
    int distance = 0;
    foreach (Match item in result)
    {
        char current = char.Parse(item.ToString());
        if (char.IsDigit(current))
        {
            distance += int.Parse(current.ToString());
        }
        else
        {
            racerName += item;
        }
    }
    if (participants.Contains(racerName))
    {
        if (!racers.Keys.Contains(racerName))
        {
            racers.Add(racerName, distance);
        }
        else
        {
            racers[racerName] += distance;
        }        
    }
    else
    {
        continue;    
    }    
}

racers = racers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

Console.WriteLine($"1st place: {racers.Keys.ElementAt(0)}");
Console.WriteLine($"2nd place: {racers.Keys.ElementAt(1)}");
Console.WriteLine($"3rd place: {racers.Keys.ElementAt(2)}");
