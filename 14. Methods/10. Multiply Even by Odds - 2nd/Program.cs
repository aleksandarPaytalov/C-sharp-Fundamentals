public class Program
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int evenSum = GetSumOfEvenDigits(number);
        int oddSum = GetSumOfOddDigits(number);        

        Console.WriteLine(evenSum * oddSum);
    }
    static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int currentDigit = number % 10;
            number /= 10;
            if (currentDigit % 2 == 0)
            {
                sum += currentDigit;
            }
        }
        return sum;
    }
    static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int currentDigit = number % 10;
            number /= 10;
            if (currentDigit % 2 != 0)
            {
                sum += currentDigit;
            }
        }
        return sum;
    }

}
