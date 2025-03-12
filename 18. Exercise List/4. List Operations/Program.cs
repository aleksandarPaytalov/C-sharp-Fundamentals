class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] currentCommand = command.Split();
            string commandType = currentCommand[0];

            if (commandType == "Add")
            {
                numbers.Add(int.Parse(currentCommand[1]));
            }
            else if (commandType == "Insert")
            {
                if (int.Parse(currentCommand[2]) >= numbers.Count || int.Parse(currentCommand[2]) < 0)
                {
                    Console.WriteLine("Invalid index");
                    continue;
                }
                numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
            }
            else if (commandType == "Remove")
            {
                if (int.Parse(currentCommand[1]) >= numbers.Count || int.Parse(currentCommand[1]) < 0)
                {
                    Console.WriteLine("Invalid index");
                    continue;
                }
                numbers.RemoveAt(int.Parse(currentCommand[1]));
            }
            else if (commandType == "Shift" && currentCommand[1] == "left")
            {
                int iterations = int.Parse(currentCommand[2]);
                for (int i = 0; i < iterations; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else if (commandType == "Shift" && currentCommand[1] == "right")
            {
                int iterations = int.Parse(currentCommand[2]);
                for (int i = 0; i < iterations; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}