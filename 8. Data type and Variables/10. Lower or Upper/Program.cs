char input = char.Parse(Console.ReadLine());

if (char.IsUpper(input))
{
    Console.WriteLine("upper-case");
}
else
{
    Console.WriteLine("lower-case");
}

// or with ascii table if (input >= 97 && input <= 122)