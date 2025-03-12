class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

        List<int> specialNumber = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();  

        int theSpecial = specialNumber[0];
        int power = specialNumber[1];

        while (numbers.Contains(theSpecial))
        {
            for (int i = 0; i < power; i++)
            {
                
                int indexOfSpecialNumber = numbers.IndexOf(theSpecial);
                if (indexOfSpecialNumber - 1 < 0)
                {
                    break;
                }
                else 
                    numbers.RemoveAt(indexOfSpecialNumber - 1);
            }
            for (int i = 0; i < power; i++)
            {
                int indexOfSpecialNumber = numbers.IndexOf(theSpecial);
                if (indexOfSpecialNumber + 1 > numbers.Count - 1)
                {
                    break;
                }
                else
                numbers.RemoveAt(indexOfSpecialNumber + 1);
            }
            numbers.Remove(theSpecial);
        }
        
        int sum = numbers.Sum();
        Console.WriteLine(sum);

    }

}