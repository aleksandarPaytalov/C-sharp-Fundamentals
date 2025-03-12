using System.Dynamic;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        int oddsum = GetSum(number, true);
        int evenSum = GetSum(number, false);

        Console.WriteLine(oddsum * evenSum);


        static int GetSum(string numbers, bool isValid)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsDigit(numbers[i]))
                {
                    int currentdigit = int.Parse(numbers[i].ToString());

                    if (currentdigit % 2 == 0 && isValid)
                    {
                        sum += currentdigit;
                    }
                    else if (currentdigit % 2 != 0 && !isValid)
                    {
                        sum += currentdigit;
                    }
                }
            }
            return sum;
        }
    }
}