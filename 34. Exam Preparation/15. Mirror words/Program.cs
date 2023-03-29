using System.Linq;

int n = int.Parse(Console.ReadLine());
Dictionary<string, double> exhibition = 
    new Dictionary<string, double>();

for (int i = 0; i < n; i++)
{
    string[] currentFlower = Console.ReadLine()
        .Split("<->", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string flowerName = currentFlower[0];
    int FlowerRarity = int.Parse(currentFlower[1]);
    exhibition[flowerName] = FlowerRarity;
}

string input = string.Empty;
Dictionary<string, List<double>> rating =
    new Dictionary<string, List<double>>();
while ((input = Console.ReadLine()) != "Exhibition")
{
    string[] cmd = input.Split("[: - ]".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
    string cmdType = cmd[0];
    string plantName = cmd[1];

    if (!exhibition.ContainsKey(plantName))
    {
        Console.WriteLine("error");
        continue;
    }
    if (cmdType == "Rate")
    {
        int PlantRating = int.Parse(cmd[2]);
        if (!rating.ContainsKey(plantName))
        {
            rating.Add(plantName, new List<double>());
        }
        rating[plantName].Add(PlantRating);
    }
    else if (cmdType == "Update")
    {
        double rarity = double.Parse(cmd[2]);
        exhibition[plantName] = rarity;
    }
    else if (cmdType == "Reset")
    {
        rating.Remove(plantName);
    }
}

Dictionary<string, List<double>> allInformationPerFlower = 
    new Dictionary<string, List<double>>();
foreach (var item in exhibition)
{
    string flowerName = item.Key;
    double rarity = item.Value;

    allInformationPerFlower.Add(flowerName, new List<double>());
    allInformationPerFlower[flowerName].Add(rarity);
    if (rating.Keys.Contains(flowerName))
    {
        allInformationPerFlower[flowerName].Add(rating[flowerName].Average());
        continue;
    }
    allInformationPerFlower[flowerName].Add(0);
}

Console.WriteLine("Plants for the exhibition:");
foreach (var item in allInformationPerFlower)
{
    Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:F2}");    
}