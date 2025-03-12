using System.Security.Cryptography.X509Certificates;

//const string left = "left";
//const string right = "right";
int fieldSize = int.Parse(Console.ReadLine());
int[] positions = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
int[] ladybugsOnField = new int[fieldSize];
string command = string.Empty;
   

foreach (var position in positions)
{
    if (position >= 0 && position < fieldSize)
        {
        ladybugsOnField[position] = 1;
        }
}


while ((command = Console.ReadLine()) != "end")
{
    string[] commandArray = command.Split(); 

    int position = int.Parse(commandArray[0]);
    string direction = (commandArray[1]);
    int flightLength = int.Parse(commandArray[2]);

    if (position < 0 || position >= fieldSize || ladybugsOnField[position] == 0) 
    {
        continue;
    }

    if (direction == "left")
    {
        flightLength *= -1;
    }
    bool hasLanded = false;
    ladybugsOnField[position] = 0;

    do
    {
        position += flightLength;
        if (position < 0 || position >= fieldSize)
        { 
            break;
        }
        if (ladybugsOnField[position] == 0)
        {
            hasLanded = true;
            ladybugsOnField[position] = 1;
        }
    } while (!hasLanded);
}
Console.WriteLine(string.Join(" ", ladybugsOnField));
