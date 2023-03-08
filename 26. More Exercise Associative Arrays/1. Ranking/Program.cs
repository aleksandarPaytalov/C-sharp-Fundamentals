string firstInput = string.Empty;

Dictionary<string, string> contests = 
    new Dictionary<string, string>();
while ((firstInput = Console.ReadLine()) != "end of contests")
{
    string[] command = firstInput
        .Split(":", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string contestName = command[0];
    string password = command[1];

    contests[contestName] = password;        
}

string secondInput = string.Empty;

SortedDictionary<string, Dictionary<string, int>> ussers = 
    new SortedDictionary<string, Dictionary<string, int>>(); // тук Key ще е Името на юзъра (userNAme, contestName,points)
while ((secondInput = Console.ReadLine()) != "end of submissions")
{
    string[] command = secondInput
        .Split("=>", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string contestName = command[0];
    string password = command[1];
    string userName = command[2];
    int points = int.Parse(command[3]);

    if (contests.ContainsKey(contestName) && contests[contestName].Contains(password))
    {
        if (!ussers.ContainsKey(userName))
        {
            Dictionary<string, int> currentUser = new Dictionary<string, int>();
            ussers[userName] = currentUser;
            ussers[userName].Add(contestName, points);
        }
        if (ussers[userName].ContainsKey(contestName)) 
        {
            if (ussers[userName][contestName] < points)
            {
                ussers[userName][contestName] = points;
            }
        }
        else
        {
            ussers[userName].Add(contestName, points);
        }
    }
}

int usserWithMaxPoints = int.MinValue;
foreach (var user in ussers)
{
    int currentTotalPoints = user.Value.Values.Sum();
    if (currentTotalPoints > usserWithMaxPoints)
    {
        usserWithMaxPoints = currentTotalPoints;
    }
}
foreach (var user in ussers)
{
    if (user.Value.Values.Sum() == usserWithMaxPoints)
    {
        Console.WriteLine($"Best candidate is {user.Key} with total {usserWithMaxPoints} points.");
    }    
}
Console.WriteLine("Ranking: ");
foreach (var student in ussers)
{
    Console.WriteLine($"{student.Key}");
    Console.WriteLine($"{string.Join(Environment.NewLine, student.Value.OrderByDescending(x => x.Value).Select(a => $"#  {a.Key} -> {a.Value}"))}");    
}