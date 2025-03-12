using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        bool lengthIsValid = CheckThePasswordLength(password);
        bool isAlphanumeric = IsPasswordAlphanumeric(password);
        bool hasTwoDigits = HasTwoDigits(password);

        if (!lengthIsValid)
        {
            Console.WriteLine("Password must be between 6 and 10 characters"); 
        }
        if (!isAlphanumeric)
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }
        if (!hasTwoDigits)
        {
            Console.WriteLine("Password must have at least 2 digits");
        }
        if (lengthIsValid && isAlphanumeric && hasTwoDigits)
        {
            Console.WriteLine("Password is valid");        
        }
    }

    static bool CheckThePasswordLength(string password)
    {
        bool isValid = password.Length >= 6 && password.Length <= 10;

        return isValid;
    }
    static bool IsPasswordAlphanumeric(string password)
    {
        bool isValid;
        foreach (char item in password)
        {
            if (!char.IsLetterOrDigit(item))
            {
                return false;
            }
        }
        return true;
    }
    static bool HasTwoDigits(string password)
    {
        int counter = 0;
        foreach (var item in password)
        {
            if (char.IsDigit(item))
            {
                counter++;
            }
        }
        return counter >= 2;
    }
}