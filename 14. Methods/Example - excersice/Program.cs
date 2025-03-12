public class Program // трябва да се създаде/направи в dot.Net =.6
{
    // 1. 
    //static void Main()  // трябва да се създаде/направи в dot.Net =.6
    //{
    //    PrintNumber(start: 10, end: 50);
    //    PrintNumber(start: 90);       
    //}
    //static void PrintNumber(int start = 1, int end = 100)
    //{
    //    for (int i = start; i <= end; i++)
    //    {
    //        Console.Write(i + " ");
    //    }
    //    Console.WriteLine();
    //}

    //.2
    //static void Main()
    //{
    //    int[] number = { 10 };
    //    IncrementNumber(number);        
    //}
    //
    //static void IncrementNumber(int[] number)
    //{
    //    number[0] += 10;
    //    Console.WriteLine(number[0]);
    //}

    //.3
    //static void Main()
    //{
    //    int number = 10;
    //    IncrementNumber(number);
    //    Console.WriteLine(number);
    //}
    //
    //static void IncrementNumber(int number)
    //{
    //    number += 10;
    //    
    //}

    //4.
    //static void Main()
    //{
    //    int[] numbers = { 10 };
    //    int[] refferedNumbers = numbers;
    //
    //
    //    int a = 10;
    //    int b = a;
    //
    //    b = 256;
    //    refferedNumbers[0] = 256;
    //    
    //    Console.WriteLine(a);
    //    Console.WriteLine(numbers[0]);
    //}

    //5.
    static void Main()
    {
        Test2();
        Test();
    }
    static int Test2()
    {
        Console.WriteLine("12");

        return 0;

        Console.WriteLine("13");
    }
    static void Test()
    {
        Console.WriteLine("12");

        return;

        Console.WriteLine("13");
    }

    

}

