int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int numbersSum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        numbersSum += numbers[i];
    }
}
Console.WriteLine(numbersSum);