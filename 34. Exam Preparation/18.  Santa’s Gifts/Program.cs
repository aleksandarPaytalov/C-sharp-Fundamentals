int n = int.Parse(Console.ReadLine());
List<int> houses = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();
int position = 0;

for (int i = 0; i < n; i++)
{
    string[] cmd = Console.ReadLine().Split().ToArray();
    string cmdType = cmd[0];

    if (cmdType == "Forward")
    {
        int steps = int.Parse(cmd[1]);
        position += steps;
        if (position < 0 || position > houses.Count - 1)
        {
            position -= steps;
            continue;
        }
        else
        {
            houses.RemoveAt(position);
        }
    }
    else if (cmdType == "Back")
    {
        int steps = int.Parse(cmd[1]);
        position -= steps;
        if (position < 0 || position > houses.Count - 1)
        {
            position += steps;
            continue;
        }
        else
        {
            houses.RemoveAt(position);
        }

    }
    else if (cmdType == "Gift")
    {
        int index = int.Parse(cmd[1]);
        int houseNumber = int.Parse(cmd[2]);

        if (index < 0 || index > houses.Count - 1)
        {
            continue;
        }
        else
        {
            houses.Insert(index, houseNumber);
            position = index;
        }
    }
    else if (cmdType == "Swap")
    {
        int firstHouse = int.Parse(cmd[1]);
        int indexSecondHouse = int.Parse(cmd[2]);
        int indexOne = houses.IndexOf(firstHouse);
        int indexTwo = houses.IndexOf(indexSecondHouse);

        if (indexOne >= 0 && indexOne < houses.Count
&& indexTwo >= 0 && indexTwo < houses.Count)
        {
            houses.RemoveAt(indexTwo);
            houses.RemoveAt(indexOne);
            houses.Insert(indexOne, indexSecondHouse);
            houses.Insert(indexTwo, firstHouse);
        }
    }
}
Console.WriteLine($"Position: {position}");
Console.WriteLine($"{string.Join(", ", houses)}");