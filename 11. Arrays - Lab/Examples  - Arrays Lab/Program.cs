//1. Дългия вариант на int[] name = Console.ReadLine().Split().Select(int.Parse).ToArray();

string name = "10, 20,    30,   40,     50";
string[] array = name.Split(", ",StringSplitOptions.RemoveEmptyEntries);

int[] numbers = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    numbers[i] = int.Parse(array[i]);
    Console.WriteLine(numbers[i]);
}
