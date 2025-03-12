class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2= int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int result = GetFinalResult(num1, num2, num3);
        Console.WriteLine(result);
    }

    static int GetFinalResult(int num1, int num2, int num3)
    {
        int sum = num1 + num2;
        int finalResult = SubrtactThirdNumber(sum, num3);
        return finalResult;

    }

    static int SubrtactThirdNumber(int sum, int num3)
    {
        int subtract = sum - num3;
        return subtract;
    }
}