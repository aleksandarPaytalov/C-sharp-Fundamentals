string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

double sum = 0;
foreach (var item in input)
{
    char firstLetter = item[0];
    double number = double.Parse(item.Substring(1, item.Length - 2).ToString());
    char lastLetter = item[item.Length - 1];
    int positionFirstLetter = (int)firstLetter % 32;
    int positionLastLetter = (int)lastLetter % 32;

    if (char.IsUpper(firstLetter))
    {
        sum += number / positionFirstLetter;
    }
    else
    {
        sum += number * positionFirstLetter;
    }
    if (char.IsUpper(lastLetter))
    {
        sum -= positionLastLetter;
    }
    else
    {
        sum += positionLastLetter;
    }
}
Console.WriteLine($"{sum:F2}");