class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        PalindromeCheck(input);   
    }
    static void PalindromeCheck (string input)
    {
        while (input != "END")
        {
            int number = int.Parse(input);
            bool isValid = false;

            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length - i; i++)
                {
                    if (input[i] == input[input.Length - 1 - i])
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
            }
            if (input.Length % 2 == 1 && input.Length > 1)
            {
                for (int i = 0; i < input.Length - 1 - i; i++)    
                {
                    if (input[i] == input[input.Length - 1])
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
            }
            else if (input.Length == 1)
            {
                isValid = true;
            }

            if (isValid)
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }
            input = Console.ReadLine();
        }
    }
}