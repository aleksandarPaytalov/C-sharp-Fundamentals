using System.Net.Http.Headers;
using System.Security;

int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

//for (int i = 0; i < numbers.Length; i++)
//{
//    //numbers[i] = int.Parse(Console.ReadLine()); 
//    int number = int.Parse(Console.ReadLine());
//    numbers[i] = number;
//}
//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.Write($"{numbers[i]} "); // Console.Write(numbers[i] + " ");
//}
//int[] reverseNumbers = numbers.Reverse().ToArray();

//for (int i = 0; i <= reverseNumbers.Length; i++)
//{
//    Console.Write(reverseNumbers[i] + " ");
//}


//10. 20. 30. 40. 50//  =>   //50. 40. 30. 20. 10//    
for (int i = 0; i < numbers.Length; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    numbers[i] = currentNumber;
}
;
for (int i = 0; i < numbers.Length / 2; i++)
{
    int firstNumber = numbers[i];
    int lastNumber = numbers[numbers.Length - 1 - i];

    numbers[i] = lastNumber;
    numbers[numbers.Length - 1 - i] = firstNumber;    
}

for (int i = 0; i <= numbers.Length - 1; i++)
{
    Console.Write(numbers[i] + " ");
}
