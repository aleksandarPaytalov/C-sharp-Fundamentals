public class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        int quantityInput = int.Parse(Console.ReadLine());

        GetTotalPrice(product, quantityInput);
    }

    static void GetTotalPrice(string product, int quantityInput)
    {
        double totalPrice = 0;

        if (product == "coffee")
        {
            totalPrice = 1.50 * quantityInput;
        }
        else if (product == "water")
        {
            totalPrice = 1.00 * quantityInput;
        }
        else if (product == "coke")
        {
            totalPrice = 1.40 * quantityInput;
        }
        else 
        {
            totalPrice = 2 * quantityInput;
        }
        Console.WriteLine($"{totalPrice:f2}");
    }

}