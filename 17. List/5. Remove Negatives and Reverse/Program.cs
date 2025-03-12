class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

        //1.
        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    if (numbers[i] < 0)
        //    {
        //        numbers.Remove(numbers[i]);
        //        i--;
        //    }
        //}

        //2.
        //List<int> result = new List<int>();
        //
        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    if (numbers[i] > 0)
        //    {
        //        result.Add(numbers[i]);
        //    }
        //}

        numbers.RemoveAll(x => x < 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else 
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }       
    }
}