class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());
        
        double result = NumberOnPower(number, power);
        Console.WriteLine(result);            
    }

    static double NumberOnPower(double number, double power)
    {
        double result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
}