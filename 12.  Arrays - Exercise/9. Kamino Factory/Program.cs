int dnaLength = int.Parse(Console.ReadLine());
string input = string.Empty;

int[] currentArray = new int[dnaLength];
int subsequenceLengthOfOnes = 0;
int leftMostStartingIndex = 0;
int elementSum = 0;
int dnaNumber = 0;

int counter = 0;

while ((input = Console.ReadLine()) != "Clone them!")
{
    counter++; 

    int[] array = input 
    .Split("!", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    int length = 0;  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 1)
        {
            length++;           
        }
        else if (length > 0)
        {
            break;
        }
    }

    int currentSum = array.Sum();
    int currentStartingIndex = Array.IndexOf(array, 1);
    if (length > subsequenceLengthOfOnes || length == subsequenceLengthOfOnes && leftMostStartingIndex > currentStartingIndex 
        || length == subsequenceLengthOfOnes && leftMostStartingIndex == currentStartingIndex && currentSum > elementSum)
    {        
        subsequenceLengthOfOnes = length;        
        currentArray = array;
        leftMostStartingIndex = currentStartingIndex;
        elementSum = currentSum;
        dnaNumber = counter;
    }    
}
Console.WriteLine($"Best DNA sample {dnaNumber} with sum: {elementSum}.");
Console.WriteLine(string.Join(" ", currentArray));

