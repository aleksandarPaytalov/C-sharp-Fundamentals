using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
Regex regex = new Regex(pattern);

string input = Console.ReadLine();

MatchCollection result = regex.Matches(input);

//Console.Write(string.Join(" ", result));

foreach (Match item in result)
{
    Console.Write(item + " ");
}
