class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        GetTheMatric(input);
    
    }

    static void GetTheMatric(int input)
    {
        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                Console.Write(input + " ");
            }
            Console.WriteLine();
        }
    }
}