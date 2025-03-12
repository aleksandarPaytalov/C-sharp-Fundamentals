class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

        string command = string.Empty;

        while ((command = Console.ReadLine()) != "end")
        {
            string[] givenCommand = command.Split();

            //List<string> newGivenCommand = command.Split().ToList();

            if (givenCommand[0] == "Delete")
            {
                int givenNumber = int.Parse(givenCommand[1]);
                input.RemoveAll(x => x == givenNumber);
            }
            else if (givenCommand[0] == "Insert")
            {
                int givenNumber = int.Parse(givenCommand[1]);
                int index = int.Parse(givenCommand[2]);
                input.Insert(index, givenNumber);
            }
        }
        Console.WriteLine(String.Join(" ", input));
    }
}