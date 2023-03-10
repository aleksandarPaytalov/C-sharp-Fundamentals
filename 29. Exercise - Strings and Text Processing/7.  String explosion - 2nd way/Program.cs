string text = Console.ReadLine();
int bombPower = 0;


for (int i = 0; i < text.Length; i++)
{

    if (bombPower > 0 && text[i] != '>')
    {
        text = text.Remove(i, 1);
        bombPower--;
        i--;
    }

    else if (text[i] == '>')
    {
        bombPower += int.Parse(text[i + 1].ToString());   
    }
}
Console.WriteLine(text);