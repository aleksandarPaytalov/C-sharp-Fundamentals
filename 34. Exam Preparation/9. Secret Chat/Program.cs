string word = Console.ReadLine();
string input = string.Empty;

while ((input = Console.ReadLine()) != "Reveal")
{
    string[] cmd = input
        .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string cmdType = cmd[0];

    if (cmdType == "InsertSpace")
    {
        int index = int.Parse(cmd[1]);
        word = word.Insert(index, " ");
        Console.WriteLine(word);
    }
    else if (cmdType == "Reverse")
    {
        string substring = cmd[1];
        string reversed = string.Empty;
        if (!word.Contains(substring))
        {
            Console.WriteLine("error");
            continue;
        }
        for (int i = substring.Length - 1; i >= 0 ; i--)
        {
            reversed += substring[i];
        }
        int startIndex = word.IndexOf(substring);
        word = word.Remove(startIndex, substring.Length);
        word = word.Insert(word.Length, reversed); // или може да се изпалзва StringBuilder
        Console.WriteLine(word);
    }
    else if (cmdType == "ChangeAll")
    {
        string substring = cmd[1];
        string replacement = cmd[2];
        word = word.Replace(substring, replacement);
        Console.WriteLine(word);
    }
}
Console.WriteLine($"You have a new text message: {word}");