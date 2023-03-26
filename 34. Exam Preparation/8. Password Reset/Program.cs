using System.Security.Cryptography.X509Certificates;
using System.Text;

string word = Console.ReadLine();
string input = string.Empty;
StringBuilder str = new StringBuilder();

while ((input = Console.ReadLine()) != "Done")
{
    string[] cmd = input.Split().ToArray();
    string cmdType = cmd[0];

    if (cmdType == "TakeOdd")
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (i % 2 != 0)
            {
                str.Append(word[i]);
            }
        }
        word = str.ToString();
        Console.WriteLine(word);
    }
    else if (cmdType == "Cut")
    {
        int index = int.Parse(cmd[1]);
        int length = int.Parse(cmd[2]);
        word = word.Remove(index, length);
        Console.WriteLine(word);
    }
    else if (cmdType == "Substitute")
    {
        string substring = cmd[1];
        string newSubstring = cmd[2];

        if (!word.Contains(substring))
        {
            Console.WriteLine("Nothing to replace!");
            continue;
        }
        word = word.Replace(substring, newSubstring);
        Console.WriteLine(word);    
    }
}
Console.WriteLine($"Your password is: {word}");