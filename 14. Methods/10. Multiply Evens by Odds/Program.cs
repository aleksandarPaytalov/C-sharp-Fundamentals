public class Program
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int evenSum = 0;
        int oddSum = 0;

        while (number > 0)
        {
            int currentDigit = 0;
            int currentNumber = number;
            currentDigit = currentNumber % 10;           
            number = number / 10;

            if (currentDigit % 2 == 0)
            {
                evenSum = GetSumOfEvenDigits(evenSum, currentDigit);
            }
            else
            {
                oddSum = GetSumOfEvenDigits(oddSum, currentDigit);
            }
        }
        int result = GetMultipleOfEvenAndOdds(oddSum, evenSum);
        Console.WriteLine(result);
    }

    static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
    {
        int multiplication = oddSum * evenSum;
        return multiplication;
    }
    static int GetSumOfEvenDigits(int evenSum, int currentDigit)
    {
        evenSum += currentDigit;
        return evenSum;
    }
    static int GetSumOfOddDigits(int oddSum, int currentDigit)
    {
        oddSum += currentDigit;
        return oddSum;

    }

}