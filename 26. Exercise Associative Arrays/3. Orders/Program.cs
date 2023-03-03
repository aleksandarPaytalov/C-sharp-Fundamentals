using System.Diagnostics.Metrics;

string input = string.Empty;

Dictionary<string, List<decimal>> products = 
    new Dictionary<string, List<decimal>>();
while ((input = Console.ReadLine()) != "buy")
{
    string[] product = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string productName = product[0];
    decimal productPrice = decimal.Parse(product[1]);
    decimal quantity = int.Parse(product[2]);

    List<decimal> priceAndQuantity = new List<decimal>();
    if (!products.ContainsKey(productName))
    {        
        priceAndQuantity.Add(productPrice);
        priceAndQuantity.Add(quantity);
        products.Add(productName, priceAndQuantity);
    }
    else
    {        
        products[productName][0] = productPrice;
        products[productName][1] += quantity;
    }   
}
foreach (var product in products)
{
    decimal totalPrice = product.Value[0] * product.Value[1];
    Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
}