using System.Xml.Linq;

class Program
{
    static void Main()
    {
        int commands = int.Parse(Console.ReadLine());
        List<string> listNames = new List<string>();

        for (int i = 0; i < commands; i++)
        {
            List<string> guestCommand = Console.ReadLine().Split().ToList(); // но по добре да се ползва масив, защото е по бърз в паметта, както и дължината му
            // винаги ще е фиксирана, защото го четем от конзолата и няма да го променяме.
            //string[] guestCommandd = Console.ReadLine().Split();

            if (guestCommand[2] != "not")
            {
                bool isValid = listNames.Contains(guestCommand[0]);

                if (isValid)
                {
                    Console.WriteLine($"{guestCommand[0]} is already in the list!");                  
                }
                else
                {
                    listNames.Add(guestCommand[0]);
                }
            }
            else
            {
                bool isValid = listNames.Contains(guestCommand[0]);

                if (isValid)
                {                    
                    listNames.Remove(guestCommand[0]);
                }
                else
                {
                    Console.WriteLine($"{guestCommand[0]} is not in the list!"); 
                }

            }
        }
        Console.WriteLine(string.Join(Environment.NewLine,listNames));
    }

}