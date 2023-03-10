using System.Text;

string text = Console.ReadLine();
int powerCount = 0;
bool isValid = false;

StringBuilder sb = new StringBuilder();
foreach (var item in text)
{
    if (char.IsDigit(item) && isValid) //
    {
        powerCount += int.Parse(item.ToString());
    }
    if (powerCount > 0 && item != '>') //
    {
        powerCount--;
        isValid = false;
        continue;
    }
    else if (item == '>' && powerCount > 0) //
    {
        isValid = true;    
    }
    if (isValid)
    {        
        sb.Append('>');
        continue;
    }
    if (item != '>') //
    {
        sb.Append(item);
    }
    else
    {
        sb.Append(item); //
        isValid = true;
    }
}
Console.WriteLine(sb);