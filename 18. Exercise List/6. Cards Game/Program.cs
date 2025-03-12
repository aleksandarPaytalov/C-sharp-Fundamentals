class Program
{ 
static void Main()
    {
        List<int> firstDeck = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> secondDeck = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        //20 30 40 50
        //10 20 30 40

        while (firstDeck.Count != 0 && secondDeck.Count != 0)
        {        
            if (firstDeck[0] > secondDeck[0])
            {
                firstDeck.Add(firstDeck[0]);
                firstDeck.Add(secondDeck[0]);
                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);
            }
            else if (firstDeck[0] < secondDeck[0])
            {
                secondDeck.Add(secondDeck[0]);
                secondDeck.Add(firstDeck[0]);
                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);
            }
            else if (firstDeck[0] == secondDeck[0])
            {
                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);                
            }
        }
        int sum = 0;
        if (firstDeck.Count > secondDeck.Count)
        {
            sum = firstDeck.Sum();
            Console.WriteLine($"First player wins! Sum: {sum}");
        }
        else
        {
            sum = secondDeck.Sum();
            Console.WriteLine($"Second player wins! Sum: {sum}");
        }
        
    }


}