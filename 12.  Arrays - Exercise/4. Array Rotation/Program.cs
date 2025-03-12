int[] inputArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rotations = int.Parse(Console.ReadLine());

//51 47 32 61 21 => 47 32 61 21 51 => 32 61 21 51 47
//0  1  2  3  4

for (int i = 0; i < rotations; i++)
{
    int lastDigit = inputArray[0];

    for (int j = 0; j < inputArray.Length - 1; j++)
    {
        inputArray[j] = inputArray[j + 1];
    }
    inputArray[inputArray.Length - 1] = lastDigit;
}

Console.WriteLine(string.Join(" ", inputArray));
