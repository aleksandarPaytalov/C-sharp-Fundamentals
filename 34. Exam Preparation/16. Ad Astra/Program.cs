using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"([\#\|])(?<name>[A-Za-z\s]+)\1(?<expdate>\d{2}\/\d{2}\/\d{2})\1(?<calories>[0-9]{1,5})\1";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(text);

int totalCalories = 0;
foreach (Match item in matches)
{
    totalCalories += int.Parse(item.Groups["calories"].Value);
}
int totaldays = totalCalories / 2000;
Console.WriteLine($"You have food to last you for: {totaldays} days!");

foreach (Match item in matches)
{
    Console.WriteLine($"Item: {item.Groups["name"].Value}, Best before: {item.Groups["expdate"].Value}, Nutrition: {item.Groups["calories"].Value}");
}