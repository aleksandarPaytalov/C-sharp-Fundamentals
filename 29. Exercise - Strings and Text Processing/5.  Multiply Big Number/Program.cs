using System.Text;

string number = Console.ReadLine();
int singleNumber = int.Parse(Console.ReadLine());

StringBuilder sb = new StringBuilder();
int leftOver = 0;
bool isValid = true;
if (singleNumber == 0 || number == "0")
{
    isValid = false;
}

if (isValid)
{
    for (int i = number.Length - 1; i >= 0; i--)
    {
        char currentDigit = number[i];
        int multiplication = (int.Parse(currentDigit.ToString())) * singleNumber + leftOver;
        int digitToAdd = multiplication % 10;
        leftOver = multiplication / 10;

        sb.Insert(0, digitToAdd);
    }

    if (leftOver > 0)
    {
        sb.Insert(0, leftOver);
    }

    Console.WriteLine(sb);
}
else
{
    Console.WriteLine(0);
}
