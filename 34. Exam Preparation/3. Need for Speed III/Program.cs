int n = int.Parse(Console.ReadLine());

Dictionary<string, string> cars = 
    new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string carType = input[0];
    string mileage = input[1];
    string fuel = input[2];
    cars.Add(carType, $"{mileage}:{fuel}");
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "Stop")
{
    string[] cmdType = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
    string cmd1 = cmdType[0];
    string carName = cmdType[1];
    string[] currentCarinfo = cars[carName].Split(":");
    double mileage = double.Parse(currentCarinfo[0]);
    double fuel = double.Parse(currentCarinfo[1]);

    if (cmd1 == "Drive")
    {
        double distanceToDrive = double.Parse(cmdType[2]);
        double fuelNeeded = double.Parse(cmdType[3]);

        if (fuelNeeded > fuel)
        {
            Console.WriteLine("Not enough fuel to make that ride");
            continue;
        }

        mileage += distanceToDrive;
        fuel -= fuelNeeded;
        cars[carName] = $"{mileage}:{fuel}";
        Console.WriteLine($"{carName} driven for {distanceToDrive} kilometers. {fuelNeeded} liters of fuel consumed.");

        if (mileage > 100000)
        {
            Console.WriteLine($"Time to sell the {carName}!");
            cars.Remove(carName);
        }
    }
    else if (cmd1 == "Refuel")
    {
        double fuelToRefill = double.Parse(cmdType[2]);
        if (fuel + fuelToRefill > 75)
        {
            Console.WriteLine($"{carName} refueled with {75 - fuel} liters");
            fuel = 75;
        }
        else
        {
            fuel += fuelToRefill;
            Console.WriteLine($"{carName} refueled with {fuelToRefill} liters");
        }
        cars[carName] = $"{mileage}:{fuel}";
    }
    else if (cmd1 == "Revert")
    {
        double km = double.Parse(cmdType[2]);
        mileage -= km;
        Console.WriteLine($"{carName} mileage decreased by {km} kilometers");
        if (mileage < 10000)
        {
            mileage = 10000;
        }
        cars[carName] = $"{mileage}:{fuel}";
    }
}
foreach (var item in cars)
{
    string[] currentCarinfo = cars[item.Key].Split(":");
    double mileage = double.Parse(currentCarinfo[0]);
    double fuel = double.Parse(currentCarinfo[1]);
    Console.WriteLine($"{item.Key} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
}