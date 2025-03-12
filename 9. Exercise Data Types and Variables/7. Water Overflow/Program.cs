int tankVolume = 255;
int input = int.Parse(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    int waterToPour = int.Parse(Console.ReadLine());
    if (tankVolume < waterToPour)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        tankVolume -= waterToPour;
    }
}
Console.WriteLine(255 - tankVolume);