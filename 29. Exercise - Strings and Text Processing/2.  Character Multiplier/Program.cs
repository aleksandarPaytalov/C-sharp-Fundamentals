string[] str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
//string strOne = str[0];
//string strTwo = str[1];

SumOfTwoStrings(str[0], str[1]);

static void SumOfTwoStrings(string strOne, string strTwo)
{
    int sum = 0;
    if (strOne.Length >= strTwo.Length)
    {
        for (int i = 0; i < strOne.Length; i++)
        {
            if (strTwo.Length != i && strTwo.Length > i)
            {
                sum += strOne[i] * strTwo[i];
            }
            else
            {
                sum += strOne[i];
            }
        }
    }
    if (strOne.Length < strTwo.Length)
    {
        for (int i = 0; i < strTwo.Length; i++)
        {
            if (strOne.Length != i && strOne.Length > i)
            {
                sum += strOne[i] * strTwo[i];
            }
            else
            {
                sum += strTwo[i];
            }
        }
    }

    Console.WriteLine(sum);
}

