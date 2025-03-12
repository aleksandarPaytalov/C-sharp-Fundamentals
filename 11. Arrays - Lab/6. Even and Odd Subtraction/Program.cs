using System.Security;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int oddSum = 0;
int evenSum = 0;

//1.
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        evenSum += numbers[i];
//    }
//    else
//    {
//        oddSum += numbers[i];
//    }
//
//}

//2.

foreach (int currentNumber in numbers)
{
    if (currentNumber % 2 == 0)
    {
        evenSum += currentNumber;
    }
    else
    {
        oddSum += currentNumber;
    }
}

Console.WriteLine(evenSum - oddSum);