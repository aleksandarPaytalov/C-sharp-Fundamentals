class Program
{
    static void Main()
    {
        List<int> listOne = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> listTwo = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> result = new List<int>();

        int minValue = Math.Min(listOne.Count, listTwo.Count);

        for (int i = 0; i < minValue; i++)
        {
            result.Add(listOne[i]);
            result.Add(listTwo[i]);
        }
        if (listOne.Count > listTwo.Count)
        {
            for (int i = minValue; i < listOne.Count; i++)
            {
                result.Add(listOne[i]);
            }
        }
        else if (listTwo.Count > listOne.Count)
        {
            for (int i = minValue; i < listTwo.Count; i++)
            {
                result.Add(listTwo[i]);
            }        
        }

        Console.WriteLine(string.Join(" ", result));
        //1. 
        //if (listOne.Count >= listTwo.Count)
        //{
        //    for (int i = 0; i < listTwo.Count; i++)
        //    {
        //        result.Add(listOne[i]);
        //        result.Add(listTwo[i]);
        //    }
        //    for (int i = 0; i < listOne.Count - listTwo.Count; i++)
        //    {
        //        result.Add(listOne[listTwo.Count + i]);
        //    }
        //}
        //else
        //{
        //    for (int i = 0; i < listOne.Count; i++)
        //    {
        //        result.Add(listOne[i]);
        //        result.Add(listTwo[i]);
        //    }
        //    for (int i = 0; i < listTwo.Count - listOne.Count; i++)
        //    {
        //        result.Add(listTwo[listOne.Count + i]);
        //    }
        //}
        // Console.WriteLine(string.Join(" ", result));
    }

}