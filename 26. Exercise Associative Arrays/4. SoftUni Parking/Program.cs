int n = int.Parse(Console.ReadLine());

Dictionary<string, string> users = new Dictionary<string, string>();
for (int i = 0; i < n; i++)
{
    string[] cmdArg = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string cmd = cmdArg[0];
    string userName = cmdArg[1];

    if (cmd == "register")
    {
        string licensePlate = cmdArg[2];
        if (!users.ContainsKey(userName))
        {
            users.Add(userName, licensePlate);
            Console.WriteLine($"{userName} registered {licensePlate} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {users[userName]}");
        }
    }
    else
    {
        if (!users.ContainsKey(userName))
        {
            Console.WriteLine($"ERROR: user {userName} not found");
        }
        else
        {
            Console.WriteLine($"{userName} unregistered successfully");
            users.Remove(userName);
        }    
    }
}
foreach (var user in users)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}