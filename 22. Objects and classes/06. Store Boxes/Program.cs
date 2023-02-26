using System.Security;

string input = Console.ReadLine();
List<Box> boxes = new List<Box>();

while (input != "end")
{
    string[] currentItem = input.Split();
    int serialNumber = int.Parse(currentItem[0]);
    string itemName = currentItem[1];
    int quantity = int.Parse(currentItem[2]);
    decimal pricePerItem = decimal.Parse(currentItem[3]);

    Item item = new Item
    {
        Name = itemName,
        Price = pricePerItem
    };
    Box box = new Box
    {
        SerialNumber = serialNumber,
        Item = item,
        Quantity = quantity,
        PricePerBox = quantity * pricePerItem
    };
    boxes.Add(box);
    
    input = Console.ReadLine();
}
foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
    Console.WriteLine($"-- ${box.PricePerBox:F2}");   
}
class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Box
{
    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }

    public decimal PricePerBox { get; set; }
}