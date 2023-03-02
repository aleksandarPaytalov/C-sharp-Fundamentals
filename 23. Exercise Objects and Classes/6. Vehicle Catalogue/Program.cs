using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

string input = string.Empty;
List<Catalog> catalog = new List<Catalog>();

while ((input = Console.ReadLine()) != "End")
{
    string[] vehicleInfo = input.Split().ToArray();

    string vehicleType = vehicleInfo[0];
    string model = vehicleInfo[1];
    string color = vehicleInfo[2];
    double horsePower = double.Parse(vehicleInfo[3]);

    Catalog crtVehicle = new Catalog(vehicleType, model, color, horsePower);
    catalog.Add(crtVehicle);    
}

string modelType = string.Empty;
while ((modelType = Console.ReadLine()) != "Close the Catalogue")
{
    string vehicleModel = modelType;
    Console.WriteLine(catalog.Find(x => x.Model == vehicleModel));
   //foreach (var item in catalog.Where(x => x.Model == vehicleModel))
   //{
   //
   //}
}


List<Catalog> cars = catalog.Where(x => x.Type == "car").ToList();
List<Catalog> trucks = catalog.Where(x => x.Type == "truck").ToList();
double carsPower = 0;
double truckPower = 0;

foreach (var vehicle in cars)
{
    carsPower += vehicle.HorsePower;
}
foreach (var vehicle in trucks)
{
    truckPower += vehicle.HorsePower;
}
double averageCarsPower = carsPower / cars.Count;
double averageTruckPower = truckPower / trucks.Count;

if (cars.Count > 0)
{
    Console.WriteLine($"Cars have average horsepower of: {averageCarsPower:F2}.");
}
else 
{
    Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
}
if (trucks.Count > 0)
{
    Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:F2}.");
}
else
{
    Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
}
public class Catalog
{
    public Catalog(string vehicleType, string model, string color, double horsePower)
    {
        this.Type = vehicleType;
        this.Model = model;
        this.Color = color;
        this.HorsePower = horsePower;
    }
    public string Type { get; set; }
   
    public string Model { get; set; }

    public string Color { get; set; }

    public double HorsePower { get; set; }

    public override string ToString()
    {
        return $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" + 
               $"Model: {this.Model}{Environment.NewLine}" +
               $"Color: {this.Color}{Environment.NewLine}" + 
               $"Horsepower: {this.HorsePower}";
    }
}
