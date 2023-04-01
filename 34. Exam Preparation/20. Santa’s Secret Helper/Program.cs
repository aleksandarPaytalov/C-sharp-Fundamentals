using System.Text;
using System.Text.RegularExpressions;

int key = int.Parse(Console.ReadLine());
string input = string.Empty;
string pattern = @"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]+\!(?<behavior>G|N)\!";
Regex regex = new Regex(pattern);

List<string> names = new List<string>();
while ((input = Console.ReadLine()) != "end")
{
    StringBuilder str = new StringBuilder();

    foreach (var item in input)
    {
        int newCharKey = item - key;
        str.Append(((char)newCharKey));
    }

    Match match = regex.Match(str.ToString());
    var behaviorType = match.Groups["behavior"].ToString();
    if (behaviorType == "G")
    {
        names.Add(match.Groups["name"].ToString());
    }    
}
Console.WriteLine(string.Join(Environment.NewLine, names));