using System.Net.Http.Headers;

int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

// 14 24 3 19 15 17
// 1 4 3 2

for (int i = 0; i < array.Length; i++)
{
    bool topNumber = true;

    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] <= array[j])
        {
            topNumber = false;
            break;
        }
    }
    if (topNumber)
    {
        Console.Write($"{array[i]} ");
    }
}

