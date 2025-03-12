class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();
       
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandArguments = command.Split();
            string cmdType = commandArguments[0];

            if (cmdType == "exchange")
            {
                int index = int.Parse(commandArguments[1]);

                if (index < 0 || index > arr.Length)
                {
                    Console.WriteLine("Invalid index");
                    continue;
                }
                arr = GetExchangedArray(arr, index);
            }
            else if (cmdType == "max")
            {
                string oddOrEven = commandArguments[1];
                int currentMaxIndex = IndexOfMAxEvenOrOdd(arr, oddOrEven);
                if (currentMaxIndex < 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(currentMaxIndex);
                }
            }
            else if (cmdType == "min")
            {
                string oddOrEven = commandArguments[1];
                int currentMinIndex = IndexOfMinEvenOrOdd(arr, oddOrEven);
                if (currentMinIndex < 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(currentMinIndex);
                }
            }
            else if (cmdType == "first")
            {
                int count = int.Parse(commandArguments[1]);
                string oddOrEven = commandArguments[2];

                if (count > arr.Length)
                {
                    Console.WriteLine("Invalid count");
                    continue;
                }

                int[] firstEllArray = FirstEvenOrOddElements(arr, count, oddOrEven);
                PrintResizedArray(firstEllArray);
            }
            else if (cmdType == "last")
            {
                int count = int.Parse(commandArguments[1]);
                string oddOrEven = commandArguments[2];

                if (count > arr.Length)
                {
                    Console.WriteLine("Invalid count");
                    continue;
                }

                int[] firstEllArray = LastEvenOrOddElements(arr, count, oddOrEven);
                PrintResizedArray(firstEllArray);
            }
        }
        Console.WriteLine(string.Join(", ", arr));
    }
     
    static int[] GetExchangedArray(int[] arr, int index)
    {
        int[] exchangedArray = new int[arr.Length];
        int indexExchangedArray = 0;

        for (int i = index + 1; i < arr.Length; i++)
        {
            exchangedArray[indexExchangedArray] = arr[i];
            indexExchangedArray++;
        }
        for (int i = 0; i <= index; i++)
        {
            exchangedArray[indexExchangedArray++] = arr[i];
        }
        return exchangedArray;
    }
    static int IndexOfMAxEvenOrOdd(int[] arr, string oddOrEven)
    {
        int currentMaxIndex = -1;
        int maxNumber = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            int currentMaxNumber = arr[i];
            if (oddOrEven == "even" && currentMaxNumber % 2 == 0)
            {
                if (currentMaxNumber >= maxNumber) // за да може да вземе индекса на числото най в дясно, ако числата са равни. 
                {
                    maxNumber = currentMaxNumber;
                    currentMaxIndex = i;
                }
            }
            else if (oddOrEven == "odd" && currentMaxNumber % 2 != 0)
            {
                if (currentMaxNumber >= maxNumber)
                {
                    maxNumber = currentMaxNumber;
                    currentMaxIndex = i;
                }
            }
        }

        return currentMaxIndex;
    }
    static int IndexOfMinEvenOrOdd(int[] arr, string oddOrEven)
    {
        int currentMinIndex = -1;
        int minNumber = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            int currentMinNumber = arr[i];
            if (oddOrEven == "even" && currentMinNumber % 2 == 0)
            {
                if (currentMinNumber <= minNumber) // за да може да вземе индекса на числото най в дясно, ако числата са равни. 
                {
                    minNumber = currentMinNumber;
                    currentMinIndex = i;
                }
            }
            else if (oddOrEven == "odd" && currentMinNumber % 2 != 0)
            {
                if (currentMinNumber <= minNumber)
                {
                    minNumber = currentMinNumber;
                    currentMinIndex = i;
                }
            }
        }
        return currentMinIndex;
    }
    static int[] FirstEvenOrOddElements(int[] arr, int count, string oddOrEven)
    {
        int[] arrayOfEll = new int[count];
        int ellIndexCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (ellIndexCount >= count)
            {
                break;
            }
            int currNumber = arr[i];
            if (oddOrEven == "even" && currNumber % 2 == 0)
            { 
                arrayOfEll[ellIndexCount++] = currNumber;
            }
            else if (oddOrEven == "odd" && currNumber % 2 != 0)
            {
                arrayOfEll[ellIndexCount++] = currNumber;
            }
        }
        arrayOfEll = ArrayResizeFirst(arrayOfEll, ellIndexCount);
        return arrayOfEll;
    
    }
    static int[] LastEvenOrOddElements(int[] arr, int count, string oddOrEven)
    {
        int[] arrayOfEll = new int[count];
        int ellIndexCount = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (ellIndexCount >= count)
            {
                break;
            }
            int currNumber = arr[i];
            if (oddOrEven == "even" && currNumber % 2 == 0)
            {
                arrayOfEll[ellIndexCount++] = currNumber;
            }
            else if (oddOrEven == "odd" && currNumber % 2 != 0)
            {
                arrayOfEll[ellIndexCount++] = currNumber;
            }
        }
        arrayOfEll = ArrayResizeFirst(arrayOfEll, ellIndexCount);
        arrayOfEll = ReverseArray(arrayOfEll);
        return arrayOfEll;
    }
    static int[] ArrayResizeFirst(int[] resizedArray, int ellIndexCount)
    {
        int[] currResizedArray = new int[ellIndexCount];
        for (int i = 0; i < ellIndexCount; i++)
        {
            currResizedArray[i] = resizedArray[i];
        }
        return currResizedArray;
    }
    private static void PrintResizedArray(int[] firstEllArray)
    {
        Console.WriteLine($"[{string.Join(", ", firstEllArray)}]");
    }
    static int[] ReverseArray(int[] arrayOfEll)
    {
        int[] reversedArray = new int[arrayOfEll.Length];
        for (int i = 0; i < arrayOfEll.Length; i++)
        {
            reversedArray[i] = arrayOfEll[arrayOfEll.Length - 1 - i];
        }
        return reversedArray;
    }
}