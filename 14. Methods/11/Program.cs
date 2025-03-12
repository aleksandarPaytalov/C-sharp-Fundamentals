class Program
{
    static void Main()
    {
        double num1 = int.Parse(Console.ReadLine());
        string operatorInput = Console.ReadLine();
        double num2 = int.Parse(Console.ReadLine());

        double operation = OperationNum1AndNum2(num1, operatorInput, num2);
        Console.WriteLine(operation);
    }

    private static double OperationNum1AndNum2(double num1,string operatorInput, double num2)
    {
        double result = 0;
       switch (operatorInput)
       {
           case "/":
               result = num1 / num2;
               break;
           case "*":
               result = num1 * num2;
               break;
           case "+":
               result = num1 + num2;
               break;
           case "-":
               result = num1 - num2;
               break;        
       }
        return result;
    }
}
