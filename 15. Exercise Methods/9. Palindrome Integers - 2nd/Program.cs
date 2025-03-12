using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "END")
        {
            string reverseInput = ReverseInput(input);

            if (input == reverseInput)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
    static string ReverseInput(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}