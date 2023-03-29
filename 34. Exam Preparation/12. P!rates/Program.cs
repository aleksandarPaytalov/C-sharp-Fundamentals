string input = string.Empty;
string text = string.Empty;
int count = 0;

Dictionary<string, string> cities = 
    new Dictionary<string, string>();
while((input = Console.ReadLine()) != "Sail")
{
    string[] cityInfo = input.Split("||").ToArray();
    string city = cityInfo[0];
    int population = int.Parse(cityInfo[1]);
    int gold = int.Parse(cityInfo[2]);

    if (!cities.Keys.Contains(city))
    {
        count++;
        cities.Add(city, $"{population}:{gold}");
    }
    else
    {
        string[] populationAndGold = cities[city].Split(":").ToArray();
        int currentCityPopulation = int.Parse(populationAndGold[0]);
        int goldInCurrentCity = int.Parse(populationAndGold[1]);

        currentCityPopulation += population;
        goldInCurrentCity += gold;
        cities[city] = $"{currentCityPopulation}:{goldInCurrentCity}";
    }    
}

while ((text = Console.ReadLine()) != "End")
{
    string[] cmd = text.Split("=>").ToArray();
    string cmd1 = cmd[0];
    string city = cmd[1];
    
    string[] populationAndGold = cities[city].Split(":").ToArray();
    int currentCityPopulation = int.Parse(populationAndGold[0]);
    int goldInCurrentCity = int.Parse(populationAndGold[1]);

    if (cmd1 == "Plunder")
    {
        int people = int.Parse(cmd[2]);
        int gold = int.Parse(cmd[3]);
        Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");
        currentCityPopulation -= people;
        goldInCurrentCity -= gold;
        cities[city] = $"{currentCityPopulation}:{goldInCurrentCity}";

        if (currentCityPopulation == 0 || goldInCurrentCity == 0)
        {
            Console.WriteLine($"{city} has been wiped off the map!");
            cities.Remove(city);
            count--;
        }
    }
    else if (cmd1 == "Prosper")
    {
        int gold = int.Parse(cmd[2]);

        if (gold < 0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
            continue;
        }
        else
        {
            goldInCurrentCity += gold;
            cities[city] = $"{currentCityPopulation}:{goldInCurrentCity}";
            Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {goldInCurrentCity} gold.");
        }
    }
}

if (count != 0)
{
    Console.WriteLine($"Ahoy, Captain! There are {count} wealthy settlements to go to:");
    foreach (var town in cities)
    {
        string[] populationAndGold = cities[town.Key].Split(":").ToArray();
        int people = int.Parse(populationAndGold[0]);
        int gold = int.Parse(populationAndGold[1]);

        Console.WriteLine($"{town.Key} -> Population: {people} citizens, Gold: {gold} kg");
    }
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}