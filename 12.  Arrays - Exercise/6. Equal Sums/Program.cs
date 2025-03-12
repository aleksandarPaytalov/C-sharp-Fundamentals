int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

// 1 2 3 3

bool equal = false;

for (int i = 0; i < array.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    for (int j = 0; j < i; j++)
    {
        leftSum += array[j];
    }
    for (int h = i + 1; h < array.Length; h++)
    {
        rightSum += array[h];
    }
    if (leftSum == rightSum)
    {
        Console.WriteLine(i);
        equal = false;
        break;
    }
    else
    {
        equal = true;
    }
}
if (equal)
{
    Console.WriteLine("no");
}