int wagonsNumber = int.Parse(Console.ReadLine());

int[] passengers = new int[wagonsNumber];

int totalPeopleInTrain = 0;

for (int i = 0; i < passengers.Length; i++)
{
    int people = int.Parse(Console.ReadLine());
    passengers[i] = people;
    totalPeopleInTrain += people;
}
//foreach (var passengersInCurrentWagon in passengers)
//{
//    Console.Write(passengersInCurrentWagon + " ");
//}
//
//Console.WriteLine();
//Console.WriteLine(totalPeopleInTrain);

Console.WriteLine(string.Join(" ", passengers));
Console.WriteLine(totalPeopleInTrain);