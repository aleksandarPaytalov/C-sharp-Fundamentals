using System.Runtime.InteropServices;

public class Program
{
    static void Main()
    {
        string command = Console.ReadLine();       
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
    
        if (command == "add")
        {
            add(num1, num2);
        }
        else if (command == "multiply")
        {
            multiply(num1, num2);
        }
        else if (command == "subtract")
        {            
            subtract(num1, num2);
        }
        else if (command == "divide")
        {
            divide(num1, num2);
        }

    }
    static void add(double numberOne, double numberTwo)
    {        
        Console.WriteLine(numberOne + numberTwo);
    }
    static void multiply(double numberOne, double numberTwo)
    {
        Console.WriteLine(numberOne * numberTwo);
    }
    static void subtract(double numberOne, double numberTwo)
    {
        Console.WriteLine(numberOne - numberTwo);
    }
    static void divide(double numberOne, double numberTwo)
    {
        Console.WriteLine(numberOne / numberTwo);
    }
}

