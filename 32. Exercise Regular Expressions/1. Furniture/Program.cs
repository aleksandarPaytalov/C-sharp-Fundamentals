using System.Text.RegularExpressions;

string pattern = @">>(?<name>[A-Za-z]+)<<(?<pricePerUnit>\d+.\d+|\d+)!(?<quantity>\d+)";
Regex regex = new Regex(pattern);

string input = string.Empty;
List<Match> furnitures = new List<Match>();

while ((input = Console.ReadLine()) != "Purchase")
{
    Match result = regex.Match(input);
    bool isvalid = regex.IsMatch(input);

    if (isvalid)
    {
        furnitures.Add(result);
    }
}

decimal totalValue = 0;
Console.WriteLine("Bought furniture:");
foreach (var item in furnitures)
{
    var money = item.Groups["pricePerUnit"].Value;
    var quantity = item.Groups["quantity"].Value;
    Console.WriteLine($"{item.Groups[1]}");
    totalValue += decimal.Parse(money) * int.Parse(quantity);
}
Console.WriteLine($"Total money spend: {totalValue:F2}");