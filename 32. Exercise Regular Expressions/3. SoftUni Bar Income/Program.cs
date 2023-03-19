using System.Diagnostics;
using System.Text.RegularExpressions;

string pattern = @"^[^\|\$\%\.]*?\%(?<customerName>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$[^\|\$\%\.]*?$";
Regex regex = new Regex(pattern);

double totalIncome = 0;
string input = string.Empty;
while ((input = Console.ReadLine()) != "end of shift")
{
    Match match = regex.Match(input);
    if (match.Success)
    {
        double income = int.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["price"].Value);
        totalIncome += income;
        Console.WriteLine($"{match.Groups["customerName"]}: {match.Groups["product"]} - {income:f2}");    
    }
}
Console.WriteLine($"Total income: {totalIncome:f2}");