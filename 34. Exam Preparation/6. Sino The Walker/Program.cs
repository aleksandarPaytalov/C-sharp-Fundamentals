int[] timeSinoLeft = Console.ReadLine()
.Split(":")
.Select(int.Parse)
.ToArray();
int steps = int.Parse(Console.ReadLine());
int timeForOneStep = int.Parse(Console.ReadLine());

int hours = timeSinoLeft[0];
int minutes = timeSinoLeft[1];
int seconds = timeSinoLeft[2];

int totalsec = hours * 3600 + minutes * 60 + seconds + steps * timeForOneStep;
int newSec = totalsec % 60;
totalsec /= 60;
int newMin = totalsec % 60;
totalsec /= 60;
int newHour = totalsec % 60;

if (newHour > 24)
{
    newHour %= 24;
}
Console.WriteLine($"Time Arrival: {newHour:d2}:{newMin:d2}:{newSec:d2}");   

