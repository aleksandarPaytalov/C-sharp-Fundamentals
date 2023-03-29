using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> compositionInfo = 
    new Dictionary<string, List<string>>();
for (int i = 0; i < n; i++)
{
    string[] info = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string pieceCurrentComposition = info[0];
    string composerCurrentComposition = info[1];
    string keyCurrentComposition = info[2];

    compositionInfo.Add(pieceCurrentComposition, new List<string>());
    compositionInfo[pieceCurrentComposition].Add(composerCurrentComposition);
    compositionInfo[pieceCurrentComposition].Add(keyCurrentComposition);
}

string input = string.Empty;
while ((input = Console.ReadLine()) != "Stop")
{
    string[] cmd = input.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string cmdType = cmd[0];
    string piece = cmd[1];

    if (cmdType == "Add")
    {
        string composer = cmd[2];
        string key = cmd[3];
        if (compositionInfo.Keys.Contains(piece))
        {
            Console.WriteLine($"{piece} is already in the collection!");
            continue;
        }
        else
        {
            compositionInfo.Add(piece, new List<string>());
            compositionInfo[piece].Add(composer);
            compositionInfo[piece].Add(key);
            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
    }
    else if (cmdType == "Remove")
    {
        if (compositionInfo.Keys.Contains(piece))
        {
            compositionInfo.Remove(piece);
            Console.WriteLine($"Successfully removed {piece}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
    else if (cmdType == "ChangeKey")
    {
        string newKey = cmd[2];
        if (compositionInfo.Keys.Contains(piece))
        {
            compositionInfo[piece].RemoveAt(1);
            compositionInfo[piece].Add(newKey);
            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
}
foreach (var item in compositionInfo)
{
    Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
}