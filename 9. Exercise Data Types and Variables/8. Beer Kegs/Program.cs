int input = int.Parse(Console.ReadLine());
string biggestKeg = string.Empty;
double currentKeg = double.MinValue;

for (int i = 0; i < input; i++)
{
    string keg = Console.ReadLine();
    float radius = float.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    double volum = (Math.PI * radius ^ 2 height);

    if (volum > currentKeg)
    {
        currentKeg = volum;
        biggestKeg = keg;
    }

}
Console.WriteLine(biggestKeg);