List<string> participants = 
    new List<string>(Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries));
List<string> songs = 
    new List<string>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries));

bool isValid = true;
Dictionary<string, List<string>> singersAward =
    new Dictionary<string, List<string>>();
string input = string.Empty;
while((input = Console.ReadLine()) != "dawn")
{
    string[] singer = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string singerName = singer[0];
    string songName = singer[1];
    string award = singer[2];

    if (participants.Contains(singerName) && songs.Contains(songName))
    {
        isValid = false;
        if (!singersAward.ContainsKey(singerName))
        {
            singersAward.Add(singerName, new List<string>());
        }
        
        if (singersAward[singerName].Contains(award))
        {
            continue;
        }
        singersAward[singerName].Add(award);    
    }
}

if (isValid)
{
    Console.WriteLine("No awards");
}
foreach (var item in singersAward.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
{
    var awardsOrdered = item.Value.OrderBy(x => x);

    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");   
    foreach (var reward in awardsOrdered)
    {
        Console.WriteLine($"--{reward}");
    }
}

