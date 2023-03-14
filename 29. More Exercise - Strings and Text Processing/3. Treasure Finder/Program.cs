using System.Text;

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
string input = Console.ReadLine();

while (input != "find")
{
    StringBuilder sb = new StringBuilder();
    StringBuilder type = new StringBuilder();
    StringBuilder coordinates = new StringBuilder();
    int i = 0;
    foreach (var letter in input)
    {
        if (i > numbers.Length - 1)
        {
            i = 0;
        }
        int curent = letter - numbers[i];
        char newLeter = (char)curent;
        sb.Append(newLeter);
        i++;
    }  
    
    int startIndex = sb.ToString().IndexOf('&');
    int endIndex = sb.ToString().LastIndexOf('&');
    int startIndexCoordinates = sb.ToString().IndexOf('<');
    for (int j = startIndex + 1; j < endIndex; j++)
    {
        type.Append(sb[j]);
    }
    for (int m = startIndexCoordinates + 1; m < sb.Length - 1; m++)
    {
        coordinates.Append(sb[m]);
    }

    Console.WriteLine($"Found {type} at {coordinates}");
    input = Console.ReadLine();
}