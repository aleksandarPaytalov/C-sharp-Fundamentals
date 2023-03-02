using System.Collections.Generic;

string input = string.Empty;
List<Person> people = new List<Person>();

while ((input = Console.ReadLine()) != "End")
{
    string[] crtPerson = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string personName = crtPerson[0];
    string personIdNumber = crtPerson[1];
    int age = int.Parse(crtPerson[2]);

    Person person = new Person(personName, personIdNumber, age);
    if (!ExistID(people, personIdNumber))
    {
        people.Add(person);
    }
    else // To Do: //If you get a person whose ID you have already received before,
         //update the name and age for that ID with that of the new person.
    {

    }
}

foreach (Person person in people.OrderBy(x=>x.Age))
{
    Console.WriteLine(person);
}

static bool ExistID(List<Person>people, string personIdNumber)
{
    return people.Any(x => x.ID == personIdNumber);
}

public class Person
{
    public Person(string name, string idNumber, int age)
    {
        this.Name = name;
        this.ID = idNumber;
        this.Age = age;    
    }
    public string Name { get; set; }

    public string ID { get; set; }

    public int Age { get; set; }
    public override string ToString()
    {
        return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
    }
}

