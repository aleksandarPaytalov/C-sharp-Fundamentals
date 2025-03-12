class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
        int wagonCapacity = int.Parse(Console.ReadLine());
        string commandInput = String.Empty;

        while ((commandInput = Console.ReadLine()) != "end")
        {
            string[] currentCommand = commandInput.Split();

            if (currentCommand[0] == "Add")
            {                                                                                                  
                int wagonInput = int.Parse(currentCommand[1]);                                                 
                wagons.Add(wagonInput);                           
            }                                                                                                  
            else                                                                                               
            {                                                                                                  
                int passengers = int.Parse(currentCommand[0]);                                                 
                for (int i = 0; i < wagons.Count; i++)                                                         
                {
                    if (wagons[i] + passengers <= wagonCapacity)
                    {
                        wagons[i] += passengers;
                        break;
                    }                   
                }
            }   
        }
        Console.WriteLine(string.Join(" ", wagons));
    }

}