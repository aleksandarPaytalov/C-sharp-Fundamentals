
using System.Reflection;

string input = Console.ReadLine();
Catalog catalog = new Catalog();

while (input != "end")
{
    string[] vehicle = input.Split("/");
    string type = vehicle[0];
    string brand = vehicle[1];
    string model = vehicle[2];

    if (type == "Car")
    {
        int horsePower = int.Parse(vehicle[3]);

        Car car = new Car
        {
            Brand = brand,
            Model = model,
            HorsePower = horsePower
        };
        catalog.Car.Add(car);
    }
    else
    { 
        int weight = int.Parse(vehicle[3]);

        Truck truck = new Truck
        {
            Brand = brand,
            Model = model,
            Weight = weight
        };
        catalog.Truck.Add(truck);
    }

    input = Console.ReadLine();
}

Console.WriteLine("Cars:");
foreach (var car in catalog.Car.OrderBy(x => x.Brand))
{    
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
}

Console.WriteLine("Trucks:");
foreach (var truck in catalog.Truck.OrderBy(x => x.Brand))
{    
    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
}

class Catalog
{
    public Catalog()
    {
        Car = new List<Car>();
        Truck = new List<Truck>();
    }

    public List<Car> Car { get; set; }
    public List<Truck> Truck { get; set; }
}
class Car
{ 
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}
class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}