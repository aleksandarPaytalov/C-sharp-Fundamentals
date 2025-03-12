int input = int.Parse(Console.ReadLine());
decimal sum = 0m;

for (int i = 1; i <= input; i++)
{
    decimal number = decimal.Parse(Console.ReadLine());
    sum += number;
}
Console.WriteLine(sum);