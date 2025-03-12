int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int longestSequenceStartIndex = 0;
int longestSequenceLength = 0;


for (int i = 1; i < array.Length; i++) // последния индекс не го проверяваме, защото ще е само един, ако не е равен на предходната комбинация от числа
{
    int currentSequenceStartIndex = i - 1;
    int currentSequenceLength = 1;

    // проверяваме дали първото число на позиция 0 е равно на второто число на позиция 1.
    // слагаме и проверка за дължината на масива, за да сме сигурни, че няма да ни даде грешка, че сме я надвишили
    while (i < array.Length && array[i - 1] == array[i]) 
    {
        currentSequenceLength++;
        i++;    
    }
    if (currentSequenceLength > longestSequenceLength)
    {
        longestSequenceStartIndex = currentSequenceStartIndex;
        longestSequenceLength = currentSequenceLength;            
    }
}
for (int i = longestSequenceStartIndex; i < longestSequenceStartIndex + longestSequenceLength; i++)
{
    Console.Write($"{array[i]} ");
}