class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "end")
        {
            string[] cmd = command.Split();
            int number = int.Parse(cmd[1]);

            if (cmd[0] == "Add")
            {
                numbers.Add(number);
            }
            else if (cmd[0] == "Remove")
            {
                numbers.Remove(number);
            }
            else if (cmd[0] == "RemoveAt")
            {
                numbers.RemoveAt(number);
            }
            else if (cmd[0] == "Insert")
            {
                int index = int.Parse(cmd[2]);
                numbers.Insert(index, number);            
            }
        
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}