Console.ReadLine()
    .Split()
    .Where(x => x.Length % 2 == 0)
    .ToList()
    .ForEach(Console.WriteLine);

//foreach (var item in words)
//{
//    Console.WriteLine(item);
//}

