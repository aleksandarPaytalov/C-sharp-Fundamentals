using System.Linq;


//1. 
//string[] input = Console.ReadLine().Split(" ").Reverse().ToArray();
//
//for (int i = 0; i < input.Length; i++)
//{
//    Console.Write(input[i] + " ");
//}
//
////2.
//string[] items = Console.ReadLine().Split().ToArray();
//for (int i = 0; i < items.Length / 2; i++)
//{
//    string oldElement = items[i];
//    items[i] = items[items.Length - 1 - i];
//    items[items.Length - 1 - i] = oldElement;
//}

//3.

string[] input = Console.ReadLine().Split();

// Note: same as string[] input = Console.ReadLine().Split();
//string input = Console.ReadLine();
//string[] array = input.Split();

for (int i = input.Length - 1; i >= 0; i--)
{
    Console.Write(input[i] + " ");
}

//Console.WriteLine(string.Join(" ", items));
