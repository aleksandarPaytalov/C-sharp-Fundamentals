using System.Numerics;

int snowballNum = int.Parse(Console.ReadLine());
BigInteger bestSnowball = 0;
int currentsnowballSnow = 0;
int currentSnowballTime = 0;
int currentSnowballQuality = 0;
BigInteger snowballValue = 0;

for (int i = 1; i <= snowballNum; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());
    if (snowballTime != 0)
    {
        snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

        if (snowballValue >= bestSnowball)
        {
            bestSnowball = snowballValue;
            currentsnowballSnow = snowballSnow;
            currentSnowballTime = snowballTime;
            currentSnowballQuality = snowballQuality;
        }
    }   
   
   
}
Console.WriteLine($"{currentsnowballSnow} : {currentSnowballTime} = {bestSnowball} ({currentSnowballQuality})");