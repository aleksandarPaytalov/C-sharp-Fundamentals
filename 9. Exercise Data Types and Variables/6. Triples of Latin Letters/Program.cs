int input = int.Parse(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    char firstChar = (char)('a' + i);
    for (int m = 0; m < input; m++)
    {
        char secondNum = (char)('a' + m);
        for (int n = 0; n < input; n++)
        {
            char thirdChar = (char)('a' + n);
            Console.WriteLine($"{firstChar}{secondNum}{thirdChar}");
        }
    }
}