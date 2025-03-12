int firstChar = int.Parse(Console.ReadLine());
int lastChar = int.Parse(Console.ReadLine());

for (int i = firstChar; i <= lastChar; i++)
{
    char letter = (char)(i);
    Console.Write($"{letter} ");
}