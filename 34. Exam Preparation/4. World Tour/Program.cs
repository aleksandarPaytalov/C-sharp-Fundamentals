using System.Text;

string destinations = Console.ReadLine();

string input = string.Empty;
while ((input = Console.ReadLine()) != "Travel")
{
    string[] cmd = input.Split(":", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string cmdType = cmd[0];

    if (cmdType == "Add Stop")
    {
        int index = int.Parse(cmd[1]);
        string stop = cmd[2];

        if (index >= 0 && index < destinations.Length)
        {
            destinations = destinations.Insert(index, stop);
        }
        Console.WriteLine(destinations);
    }
    else if (cmdType == "Remove Stop")
    {
        int startIndex = int.Parse(cmd[1]);
        int endIndex = int.Parse(cmd[2]);

        if (startIndex >= 0 && startIndex < destinations.Length
            && endIndex >= 0 && endIndex < destinations.Length)
        {            
            destinations = destinations.Remove(startIndex, endIndex - startIndex + 1);
        }
        Console.WriteLine(destinations);
    }
    else if (cmdType == "Switch")
    {
        string oldStop = cmd[1];
        string newStop = cmd[2];
        destinations = destinations.Replace(oldStop, newStop);

        Console.WriteLine(destinations);
    }
}
Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
