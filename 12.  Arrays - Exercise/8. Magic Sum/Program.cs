int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (number == array[i] + array[j])
        {
            Console.WriteLine($"{array[i]} {array[j]}");
        }
    }
}
