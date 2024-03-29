﻿Dictionary<string, int> resources = new Dictionary<string, int>();

while (true)
{
    string resource = Console.ReadLine();
    if (resource == "stop")
    {
        break;
    }
    int quantity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(resource))
    {
        resources.Add(resource, quantity);
    }
    else
    {
        resources[resource] += quantity;
    }
}

foreach (var resource in resources)
{
    Console.WriteLine($"{resource.Key} -> {resource.Value}");
}