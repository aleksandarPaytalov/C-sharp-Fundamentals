using System;

int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

int arraySum = 0;
bool identical = true;

for (int i = 0; i < arrayOne.Length; i++)
{
    if (arrayOne[i] == arrayTwo[i])
    {
        arraySum += arrayOne[i];
    }
    else
    {
        identical = false;
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
    }
}
if (identical)
{
    Console.WriteLine($"Arrays are identical. Sum: {arraySum}");
}