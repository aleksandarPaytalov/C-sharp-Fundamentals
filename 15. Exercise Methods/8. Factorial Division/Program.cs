class Program
{
    static void Main()
    {
        double firstNumber = int.Parse(Console.ReadLine());
        double secondNumber = int.Parse(Console.ReadLine());

        //factorial of 5 ---> 5*4 => 20*3 => 60*2 => 120
        //factorial of 2 ---> 2*1 => 2

        double result = GetResultFromDevidedFactorials(firstNumber, secondNumber);
        Console.WriteLine($"{result:f2}");    
    }
    static double GetResultFromDevidedFactorials(double firstNumber, double secondNumber)
    {
        double firstNumberFactorial = 1;
        double secondNumberFactorial = 1;

        while (firstNumber != 1)
        {
            firstNumberFactorial *= firstNumber;
            firstNumber--;        
        }
        while (secondNumber != 1)
        {
            secondNumberFactorial *= secondNumber;
            secondNumber--;        
        }

        return firstNumberFactorial / secondNumberFactorial;
    }
}