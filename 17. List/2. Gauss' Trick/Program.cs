class Program
{
    static void Main()
    {
        //1. 
        //1 2 3 4 5	 --> 6 2 3 4  ---> 6 6 3 
        //6 6 3
        //List<int> numbers = Console.ReadLine()
        //    .Split()
        //    .Select(int.Parse)
        //    .ToList();
        //
        //for (int i = 0; i < numbers.Count - 1; i++)
        //{
        //    numbers[i] += numbers[numbers.Count - 1];
        //    numbers.RemoveAt(numbers.Count - 1);            
        //}
        //Console.WriteLine(string.Join(" ", numbers));

        //2. 

        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> result = new List<int>();
        for (int i = 0; i < numbers.Count / 2; i++)
        {
            int sum = numbers[i] + numbers[numbers.Count - 1 - i];
            result.Add(sum);

        }
        if (numbers.Count % 2 != 0)
        {
            result.Add(numbers[numbers.Count / 2]);
        
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
