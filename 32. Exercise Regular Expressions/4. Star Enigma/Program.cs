using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:\d+[^\@\-\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\!\:\>]*?\-\>\d+";
Regex regex = new Regex(pattern);

List<Match> attackedPlaneds = new List<Match>();
List<Match> destroyedPlaneds = new List<Match>();
for (int i = 0; i < n; i++)
{
    string encryptedMessage = Console.ReadLine();
    StringBuilder decryptedMessage = new StringBuilder();
    int counter = 0;
	foreach (var item in encryptedMessage)
	{
        if (item == 's' || item == 't' || item == 'a' || item == 'r'
            || item == 'S' || item == 'T' || item == 'A' || item == 'R')
        {
            counter++;        
        }
    }
    foreach (var item in encryptedMessage)
    {
        int currentLetter = item - counter;
        char letter = (char)currentLetter;
        decryptedMessage.Append(letter);        
    }

    Match match = regex.Match(decryptedMessage.ToString());
    if (match.Success)
    {
        if (match.Groups["attackType"].ToString() == "A")
        {
            attackedPlaneds.Add(match);
        }
        else
        {
            destroyedPlaneds.Add(match);
        }        
    }
}
Console.WriteLine($"Attacked planets: {attackedPlaneds.Count}");
foreach (var item in attackedPlaneds.OrderBy(x => x.Groups[1].Value))
{
    Console.WriteLine($"-> {item.Groups["planet"]}");
}
Console.WriteLine($"Destroyed planets: {destroyedPlaneds.Count}");
foreach (var item in destroyedPlaneds.OrderBy(x => x.Groups[1].Value))
{
    Console.WriteLine($"-> {item.Groups["planet"]}");
}