string word = Console.ReadLine();
string input = string.Empty;

while ((input = Console.ReadLine()) != "Generate")
{
    string[] cmd = input
        .Split(">>>")
        .ToArray();
    string cmdType = cmd[0];

    if (cmdType == "Contains")
    {
        string substing = cmd[1];

        if (!word.Contains(substing))
        {
            Console.WriteLine("Substring not found!");
            continue;
        }
        Console.WriteLine($"{word} contains {substing}");
    }
    else if (cmdType == "Flip")
    {
        string cmd1 = cmd[1];
        int start = int.Parse(cmd[2]);
        int end = int.Parse(cmd[3]);
        string substring = word.Substring(start, end - start);
        if (cmd1 == "Lower")
        {
            substring = substring.ToLower();
            word = word.Remove(start, end - start);
            word = word.Insert(start, substring);
        }
        else 
        {
            substring = substring.ToUpper();
            word = word.Remove(start, end - start);
            word = word.Insert(start, substring);
        }
        Console.WriteLine(word);
    }
    else if (cmdType == "Slice")
    {
        int start = int.Parse(cmd[1]);
        int end = int.Parse(cmd[2]);
        word = word.Remove(start, end - start);
        Console.WriteLine(word);
    }
}
Console.WriteLine($"Your activation key is: {word}");
