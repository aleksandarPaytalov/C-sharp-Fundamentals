int yield = int.Parse(Console.ReadLine());
int storage = 0;
int dayCount = 0;

while (yield >= 100)
{
    dayCount++;
    storage += yield;
    storage -= 26;
    yield -= 10;  
}
if (dayCount > 0) // може и ако storage >= 100, защото ако не е означава, че добивът в началото е под 100, от което следва, че няба въобще да се добива => storage ще е празен = 0
{
    storage -= 26;
}


Console.WriteLine(dayCount);
Console.WriteLine(storage);