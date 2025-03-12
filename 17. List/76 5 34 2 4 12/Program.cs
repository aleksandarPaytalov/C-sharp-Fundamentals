class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> products = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string product = Console.ReadLine();
            products.Add(product);
        }
        products.Sort();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i + 1}.{string.Join("", products[i])}");
        }
    
    }
}