int n = int.Parse(Console.ReadLine());

int[] firstArray = new int[n];
int[] secondArray = new int[n];
// 1. int counter = 0;
//4                    
//1 5             1 10 31 20
//9 10            5 9 81 41
//31 81
//41 20


for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    // 1. counter++;

    // 1.
    //for (int j = 0; j < input.Length - 1; j++)
    //{
    //    if (counter % 2 != 0)
    //    {
    //        firstArray[i] = input[j];
    //        secondArray[i] = input[input.Length - 1];
    //    }
    //    else
    //    {
    //        firstArray[i] = input[input.Length - 1];
    //        secondArray[i] = input[j];
    //    }
    //}

    // 2. 

    if (i % 2 == 0) // == 0, защото почваме от нула /нулев/ ред с цикъла
    {
        firstArray[i] = input[0];
        secondArray[i] = input[1];
    }
    else
    {
        firstArray[i] = input[1];
        secondArray[i] = input[0];
    }

}

Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));