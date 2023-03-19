using System.Text.RegularExpressions;

string pattern = @">>(?<name>[A-Za-z]+)<<(?<pricePerUnit>\d+.\d+|\d+)!(?<quantity>\d+)";
Regex regex = new Regex(pattern);

string input = string.Empty;
List<string> furnitures = new List<string>();
decimal totalValue = 0;
while ((input = Console.ReadLine()) != "Purchase")
{
    Match result = regex.Match(input);
    if (result.Success)
    {
        string furnitureName = result.Groups["name"].Value;
        decimal pricePerUnit = decimal.Parse(result.Groups["pricePerUnit"].Value);
        int quantity = int.Parse(result.Groups["quantity"].Value);

        furnitures.Add(furnitureName);
        totalValue += pricePerUnit * quantity;
    }
}

Console.WriteLine("Bought furniture:");
foreach (var item in furnitures)
{    
    Console.WriteLine(item);
}
Console.WriteLine($"Total money spend: {totalValue:F2}");