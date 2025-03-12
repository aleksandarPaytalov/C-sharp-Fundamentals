int number = int.Parse(Console.ReadLine()); //245678

int sum = 0;
while (number > 0)
{
    int currentNumber = number;
    currentNumber %= 10; // or currentNumber = number % 10; това работи само еко int currentNumber = number; е в while цикъла, ако го изкараме отвън тогава трябва да запишем currentNumber = number % 10
    sum += currentNumber;
    number /= 10;
}
Console.WriteLine(sum);