﻿int input = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < input; i++)
{
    char letter = char.Parse(Console.ReadLine());
    sum += letter;
}
Console.WriteLine($"The sum equals: {sum}");