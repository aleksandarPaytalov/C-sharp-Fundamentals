class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        string command = string.Empty;
        bool changes = false;

        while ((command = Console.ReadLine()) != "end")
        {
            string[] cmd = command.Split();

            if (cmd[0] == "Add")
            {
                int number = int.Parse(cmd[1]);
                numbers.Add(number);
                changes = true;
            }
            else if (cmd[0] == "Remove")
            {
                int number = int.Parse(cmd[1]);
                numbers.Remove(number);
                changes = true;
            }
            else if (cmd[0] == "RemoveAt")
            {
                int number = int.Parse(cmd[1]);
                numbers.RemoveAt(number);
                changes = true;
            }
            else if (cmd[0] == "Insert")
            {
                int number = int.Parse(cmd[1]);
                int index = int.Parse(cmd[2]);
                numbers.Insert(index, number);
                changes = true;
            }
            else if (cmd[0] == "Contains")
            {
                int number = int.Parse(cmd[1]);
                bool isValid = numbers.Contains(number);
                if (isValid)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }

            }
            else if (cmd[0] == "PrintEven")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (cmd[0] == "PrintOdd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (cmd[0] == "GetSum")
            {
                int sum = numbers.Sum(x => x);
                Console.WriteLine(sum);
            }
            else if (cmd[0] == "Filter")
            {
                string condition = cmd[1];
                int number = int.Parse(cmd[2]);
                
                if (condition == ">")
                {
                    foreach (var item in numbers)
                    {
                        if (item > number)
                        {
                            Console.Write(item + " ");
                        }                        
                    }
                    Console.WriteLine();
                }
                else if (condition == ">=")
                {
                    foreach (var item in numbers)
                    {
                        if (item >= number)
                        {
                            Console.Write(item + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (condition == "<")
                {
                    foreach (var item in numbers)
                    {
                        if (item < number)
                        {
                            Console.Write(item + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (condition == "<=")
                {
                    foreach (var item in numbers)
                    {
                        if (item <= number)
                        {
                            Console.Write(item + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        if (changes)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }        
    }
}